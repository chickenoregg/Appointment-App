using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultingScheduleApp.Models
{
    //properties for the Client 
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Address Address { get; set; }

        public string ZipCode { get; set; }
        public bool ClientStats { get; set; }
    }
}
