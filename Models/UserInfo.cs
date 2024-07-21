using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Alanı Zorunlu")]
        public string? Name { get; set; }//null bir değer geldiğinde required bize bir meseaj verecek

        [Required]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Hatalı Eposta")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public bool? WillAttend { get; set; }
    }
}