using System;
using System.Collections.Generic;

// Abstract class Patient
abstract class Patient
{
    public int PatientId { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }

    protected string Diagnosis { get; set; }  // Encapsulation
    protected string MedicalHistory { get; set; }

    public Patient(int patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + PatientId + ", Name: " + Name + ", Age: " + Age);
    }
}

// Interface IMedicalRecord
interface IMedicalRecord
{
    void AddRecord(string diagnosis, string history);
    void ViewRecords();
}

// InPatient class
class InPatient : Patient, IMedicalRecord
{
    private int NumberOfDays;
    private double DailyCharge = 500;

    public InPatient(int patientId, string name, int age, int numberOfDays) : base(patientId, name, age)
    {
        NumberOfDays = numberOfDays;
    }

    public override double CalculateBill()
    {
        return NumberOfDays * DailyCharge;
    }

    public void AddRecord(string diagnosis, string history)
    {
        Diagnosis = diagnosis;
        MedicalHistory = history;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis: " + Diagnosis);
        Console.WriteLine("Medical History: " + MedicalHistory);
    }
}

// OutPatient class
class OutPatient : Patient, IMedicalRecord
{
    private double ConsultationFee = 200;

    public OutPatient(int patientId, string name, int age) : base(patientId, name, age) { }

    public override double CalculateBill()
    {
        return ConsultationFee;
    }

    public void AddRecord(string diagnosis, string history)
    {
        Diagnosis = diagnosis;
        MedicalHistory = history;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis: " + Diagnosis);
        Console.WriteLine("Medical History: " + MedicalHistory);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Aman", 45, 5),
            new OutPatient(102, "Rahul", 30)
        };

        foreach (var patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine("Total Bill: " + patient.CalculateBill());
            Console.WriteLine("----------------------");
        }
    }
}
