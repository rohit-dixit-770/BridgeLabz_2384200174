using System;

class Patient
{
    // Static variable 
    public static string hospitalName = "City Hospital";
    private static int totalPatients = 0;
    
    // Readonly variable
    public readonly int patientID;
    
    // Instance variables
    public string name;
    public int age;
    public string ailment;

    // Constructor 
    public Patient(string name, int age, string ailment)
    {
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.patientID = ++totalPatients;
    }

    // Static method to get total patients count
    public static int GetTotalPatients()
    {
        return totalPatients;
    }

    // Method to display patient details
    public void DisplayDetails()
    {
        if (this is Patient) 
        {
            Console.WriteLine($"Hospital: {hospitalName}");
            Console.WriteLine($"Patient ID: {patientID}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"ailment: {ailment}");
        }
    }
	
	public static void Main()
    {
        // Creating patient instances
        Patient patient1 = new Patient("Rohit", 24, "Flu");
        Patient patient2 = new Patient("Ramkumar", 45, "Joint Pain");
        
        // Display details
        patient1.DisplayDetails();
        patient2.DisplayDetails();
        
        // Get total patients count
        Console.WriteLine($"Total Patients Admitted: {Patient.GetTotalPatients()}");
    }
}

