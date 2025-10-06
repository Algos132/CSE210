using System;
using System.Collections.Generic;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetHomeworkList()
    {
        string studentName = GetStudentName();
        return $"Title {_title} by {studentName}";
    
    }
}