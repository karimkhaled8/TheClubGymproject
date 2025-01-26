using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClubGymproject.Model
{
    public class classes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Classname { get; set; }

        public string Classtime { get; set; }

        public int trainersID { get; set; }

        public trainers trainers { get; set; }

        public ICollection<members> members { get; set; }

    }
}
