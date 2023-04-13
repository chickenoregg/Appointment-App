using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultingScheduleApp.Models
{
    public class Address : Base
    {
        //properties for the Address 
        public int AddressID { get; set; }
        public string AddressInfo { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
