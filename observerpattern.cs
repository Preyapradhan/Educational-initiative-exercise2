// Observer pattern: Interface for device observers
public interface IDeviceObserver
{
    void Update(SmartDevice device);
}

// SmartHomeHub class (Subject)
public class SmartHomeHub
{
    private List<SmartDevice> _devices = new List<SmartDevice>();
    private List<IDeviceObserver> _observers = new List<IDeviceObserver>();

    public void AddDevice(SmartDevice device)
    {
        _devices.Add(device);
        NotifyObservers(device);
    }

    public void RemoveDevice(SmartDevice device)
    {
        _devices.Remove(device);
        NotifyObservers(device);
    }

    public void RegisterObserver(IDeviceObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnregisterObserver(IDeviceObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers(SmartDevice device)
    {
        foreach (var observer in _observers)
        {
            observer.Update(device);
        }
    }

    public void TurnOnDevice(int deviceId)
    {
        var device = _devices.FirstOrDefault(d => d.Id == deviceId);
        device?.TurnOn();
    }

    public void TurnOffDevice(int deviceId)
    {
        var device = _devices.FirstOrDefault(d => d.Id == deviceId);
        device?.TurnOff();
    }

    public void DisplayStatus()
    {
        foreach (var device in _devices)
        {
            Console.WriteLine(device.GetStatus());
        }
    }
}
