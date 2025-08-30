namespace TaskTracker.Models
{
    public class Task
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }

        // Foreign key to User
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
