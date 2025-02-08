using System;
public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }

    // Constructor
    public Course(string courseName, int duration)
    {
        this.CourseName = courseName;
        this.Duration = duration;
    }

    // Method to display course information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Course Name: "+CourseName+", Duration: "+Duration+" hours");
    }
}

public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    // Constructor 
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        this.Platform = platform;
        this.IsRecorded = isRecorded;
    }

    // Overriding the DisplayInfo method 
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Platform: "+Platform+", Is Recorded: "+IsRecorded);
    }
}

public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; } 

    // Constructor 
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        this.Fee = fee;
        this.Discount = discount;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Fee: "+Fee+", Discount: "+Discount+"%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of PaidOnlineCourse
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Basic C#", 50, "BridgeLabz", true, 499.99, 10);

        // Displaying course details
        paidCourse.DisplayInfo();
    }
}
