using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIplatformWeb.Models
{
    public class user
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string first_name { get; set; }
       
        public DateTime created_at { get; set; } = DateTime.Now;
    }
}
