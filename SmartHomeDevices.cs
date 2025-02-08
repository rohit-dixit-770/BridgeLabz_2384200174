using System;
// Superclass Device
public class Device
{
    public string DeviceId { get; set; }
    public string Status { get; set; }

    // Constructor 
    public Device(string deviceId, string status)
    {
        this.DeviceId = deviceId;
        this.Status = status;
    }

    // Method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: "+DeviceId+", Status: "+Status);
    }
}

// Subclass Thermostat 
public class Thermostat : Device
{
    public double TemperatureSetting { get; set; }

    // Constructor 
    public Thermostat(string deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        this.TemperatureSetting = temperatureSetting;
    }

    // Overriding the DisplayStatus method 
    public override void DisplayStatus()
    {
        base.DisplayStatus(); 
        Console.WriteLine("Temperature Setting: "+TemperatureSetting);
    }
}

// Main program 
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Thermostat
        Thermostat thermostat = new Thermostat("N12345", "Active", 25.5);

        // Displaying thermostat status
        thermostat.DisplayStatus();
    }
}
