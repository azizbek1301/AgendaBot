using System.ComponentModel.DataAnnotations;

namespace ToDoBotAPI.Models
{
    public class TaskToDo
    {
        [Key]
        public int TaskId { get; set; }
        public string Description {  get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
