CREATE PROCEDURE [dbo].CustomerAddSP
	@LPG_id bigint,
	@Consumer_no numeric(4,0),
	@Consumer_Name varchar(20),
	@Consumer_address varchar(20),
	@Phone numeric(10,0),
	@email varchar(20),
	@Dis_no numeric(6,0)
	@No_of_cylinders numeric(1,0),
	@Date_of_connection date
AS
	insert into Consumer(LPG_id,Consumer_no,Consumer_Name,Consumer_address,Phone,email,Dis_no,No_of_cylinders,Date_of_connection) values(@LPG_id,@Consumer_no,@Consumer_Name,@Consumer_address,@Phone,@email,@Dis_no,@No_of_cylinders,@Date_of_connection)
RETURN 0
