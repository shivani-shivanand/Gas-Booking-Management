using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    public class OrderDetail
    {
        public int Booking_no { get; set; }
        public DateTime Booking_date { get; set; }
        public DateTime Due_date { get; set; }
        public int Consumer_no { get; set; }
        public string Consumer_Name { get; set; }
        public string Consumer_address { get; set; }
        public int Phone { get; set; }
        public int Dis_no { get; set; }
        public string Cylinder_type { get; set; }
        public int Price { get; set; }
    }
}
