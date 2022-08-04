using System.ComponentModel.DataAnnotations;

namespace BlazorHW.Data
{
    public class ContactInfo
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
