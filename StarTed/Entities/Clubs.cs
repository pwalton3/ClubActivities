using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTed.Entities
{
    [Table("Clubs")]
    public class Clubs
    {
        private string _StartDate;
        [Key]
        public string ClubID { get; set; }

 

    }
}
