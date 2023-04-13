using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultingScheduleApp.Models
{
    public class City : Base
    {
        //properties for the City 
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }

    }
}
