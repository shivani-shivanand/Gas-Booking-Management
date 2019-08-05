CREATE PROCEDURE [dbo].BookingSP
	@Booking_no numeric(5),
	@Cons_no numeric(4),
	@Booking_date date,
	@Cylinder_type varchar(15),
    @Text Nvarchar(1000) OUTPUT
AS
Begin
   If ((Select count(*) from Gas_Booking where Booking_date=@Booking_date) !>10)
     Begin
       If Exists(Select Quantity from Stock_Registry where Quantity > 2 and Cylinder_type=@Cylinder_type)
         Begin
           If Not Exists(Select @Booking_date,DateAdd(month,-1,@Booking_date) as Due From Gas_Booking where Cons_no=@Cons_no and Booking_date Between DateAdd(month,-1,@Booking_date) and @Booking_date)
             Begin
	               Insert into Gas_Booking(Booking_no,Cons_no,Booking_date,Due_date,Status)
		           Select @Booking_no,@Cons_no,@Booking_date,DateAdd(day,5,@Booking_date),'Pending';
		     Begin
		           set @Text = 'Successfully Booked'
		     End
             End
	       Else
	         Begin
	               set @Text = 'Only one booking per month'
	         End
         End
       Else
         Begin
             set @Text = 'Stock Unavailable'
         End
     End
   Else
     Begin
             set @Text ='Only 10 Bookings Per day'
     End
End
RETURN 0