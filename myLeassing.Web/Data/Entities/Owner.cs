using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myLeassing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Document { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="First Name")]
        public string FirsName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Last Name")]
        public string LasName { get; set; }
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        public string Adress { get; set; }
        public string FullName => $"{FirsName} {LasName}";
        public string FullNameWhitDocument => $"{FirsName} {LasName} - {Document}";
    }
}
