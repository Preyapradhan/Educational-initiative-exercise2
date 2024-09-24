// Main program
public class Program
{
    public static void Main()
    {
        // Create Smart Home Hub
        SmartHomeHub hub = new SmartHomeHub();

        // Create devices using Factory Method
        SmartDevice light1 = DeviceFactory.CreateDevice("light", 1);
        SmartDevice thermostat1 = DeviceFactory.CreateDevice("thermostat", 2, 72);
        SmartDevice door1 = DeviceFactory.CreateDevice("door", 3);

        // Add proxy control
        SmartDevice lightProxy = new DeviceProxy(light1);
        SmartDevice thermostatProxy = new DeviceProxy(thermostat1);
        SmartDevice doorProxy = new DeviceProxy(door1);

        // Add devices to the hub
        hub.AddDevice(lightProxy);
        hub.AddDevice(thermostatProxy);
        hub.AddDevice(doorProxy);

        // Control devices
        hub.TurnOnDevice(1);  // Turn on light
        hub.TurnOnDevice(2);  // Turn on thermostat
        hub.TurnOffDevice(3); // Unlock door

        // Display the status of all devices
        hub.DisplayStatus();

        // Schedule example (could be enhanced with timer logic)
        Console.WriteLine("Scheduled: Light will turn off at 06:00 AM");

        // Automation example
        Console.WriteLine("Automation: Turn off Light if temperature > 75");
        ((Thermostat)thermostat1).SetTemperature(76);  // Trigger automation
        if (((Thermostat)thermostat1).GetStatus().Contains("76"))
        {
            hub.TurnOffDevice(1); // Turn off Light if condition met
        }

        hub.DisplayStatus(); // Updated status
    }
}
