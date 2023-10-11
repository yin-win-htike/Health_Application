using System.ComponentModel.DataAnnotations;

namespace HealthApplication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Employee Name")]
        public string Name { get; set; }
        public string Designation { get; set; }

        public string Country { get; set; } 

        public string Vehicle { get; set; }

        public string Language { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }        
        public DateTime? RecordCreatedOn { get; set; } 
    }  
   
    
}

