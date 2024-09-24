// Factory Method for creating smart devices
public static class DeviceFactory
{
    public static SmartDevice CreateDevice(string type, int id, int? initialTemp = null)
    {
        switch (type.ToLower())
        {
            case "light":
                return new Light(id);
            case "thermostat":
                return new Thermostat(id, initialTemp ?? 70);
            case "door":
                return new Door(id);
            default:
                throw new ArgumentException("Unknown device type");
        }
    }
}
