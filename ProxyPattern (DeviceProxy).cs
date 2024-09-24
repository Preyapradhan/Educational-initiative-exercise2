// Proxy for controlling access to devices
public class DeviceProxy : SmartDevice
{
    private SmartDevice _device;

    public DeviceProxy(SmartDevice device) : base(device.Id, device.Type)
    {
        _device = device;
    }

    public override void TurnOn()
    {
        Console.WriteLine("Accessing device through proxy...");
        _device.TurnOn();
    }

    public override void TurnOff()
    {
        Console.WriteLine("Accessing device through proxy...");
        _device.TurnOff();
    }

    public override string GetStatus()
    {
        return _device.GetStatus();
    }
}
