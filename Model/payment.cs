using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClubGymproject.Model
{
    public class payment
    {
        public int ID { get; set; }
        
        public int Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymentType { get; set; }

        public int membersID { get; set; }

        public members members { get; set; }
    }
}
