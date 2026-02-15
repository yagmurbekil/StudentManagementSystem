using System.Collections.Generic;

public class Course
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Lecturer {get; set;} = string.Empty;
    public int AbsenteeismCount { get; set; }
    public int MaxAbsence { get; set; }

    public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    public ICollection<Topic> Topics { get; set; } = new List<Topic>();
}