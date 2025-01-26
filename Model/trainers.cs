using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClubGymproject.Model
{
    public class trainers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Specialaiztion { get; set; }

        public string Email { get; set; }

        public int phonenumber { get; set; }

        public ICollection<classes> classes { get; set; }= new List<classes>();
    }
}
