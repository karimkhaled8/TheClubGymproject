using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClubGymproject.Model
{
    public class members
    {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Fname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public string Lname { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string? role { get; set; }

        

        public string? couch { get; set; }
        public int Age { get; set; }   
        public DateTime MembershipStartDate { get; set; }

        public DateTime MembershipEndDate { get; set; }
     
        public ICollection<payment> payments { get; set; }= new List<payment>();

        public ICollection<classes> classes { get; set; }

    }

}
