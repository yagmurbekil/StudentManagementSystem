public class Assignment {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public int CourseId { get; set; } 
}