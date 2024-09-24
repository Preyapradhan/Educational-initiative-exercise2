// Abstract SmartDevice class (Base class)
public abstract class SmartDevice
{
    public int Id { get; private set; }
    public string Type { get; private set; }
    
    protected SmartDevice(int id, string type)
    {
        Id = id;
        Type = type;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract string GetStatus();
}

// Light class (Concrete device)
public class Light : SmartDevice
{
    private bool _isOn;

    public Light(int id) : base(id, "Light") {}

    public override void TurnOn()
    {
        _isOn = true;
        Console.WriteLine($"Light {Id} is now On.");
    }

    public override void TurnOff()
    {
        _isOn = false;
        Console.WriteLine($"Light {Id} is now Off.");
    }

    public override string GetStatus()
    {
        return $"Light {Id} is " + (_isOn ? "On" : "Off");
    }
}

// Thermostat class (Concrete device)
public class Thermostat : SmartDevice
{
    private int _temperature;

    public Thermostat(int id, int initialTemp) : base(id, "Thermostat")
    {
        _temperature = initialTemp;
    }

    public void SetTemperature(int temp)
    {
        _temperature = temp;
        Console.WriteLine($"Thermostat {Id} is set to {_temperature} degrees.");
    }

    public override void TurnOn()
    {
        Console.WriteLine($"Thermostat {Id} is On.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"Thermostat {Id} is Off.");
    }

    public override string GetStatus()
    {
        return $"Thermostat {Id} is set to {_temperature} degrees.";
    }
}

// Door class (Concrete device)
public class Door : SmartDevice
{
    private bool _isLocked;

    public Door(int id) : base(id, "Door") {}

    public void Lock()
    {
        _isLocked = true;
        Console.WriteLine($"Door {Id} is Locked.");
    }

    public void Unlock()
    {
        _isLocked = false;
        Console.WriteLine($"Door {Id} is Unlocked.");
    }

    public override void TurnOn()
    {
        Console.WriteLine($"Door {Id} is Locked.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"Door {Id} is Unlocked.");
    }

    public override string GetStatus()
    {
        return $"Door {Id} is " + (_isLocked ? "Locked" : "Unlocked");
    }
}
