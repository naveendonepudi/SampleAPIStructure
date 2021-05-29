using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionName.Models
{
    public class Employee
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Identity column increment
        // [Column(Order = 1)] Order if required
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }
        [MaxLength(32)]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(32)]
        public string LastName { get; set; }
    }
}
