namespace Application08_TodoDB.Models
{
    public class TaskItem
    {
        public int Id { get; set; }           
        public string TaskDescription { get; set; } = "";
        public bool IsComplete { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}