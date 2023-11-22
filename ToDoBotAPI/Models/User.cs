using System.ComponentModel.DataAnnotations;

namespace ToDoBotAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public long UserId { get; set; }    
        public string UserName { get; set; }
    }
}
