using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Topic
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    [StringLength(30)]
    public string Type { get; set; } // Video, PDF, Quiz, etc.

    public int Duration { get; set; } // in minutes

    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public Course Course { get; set; }
}
