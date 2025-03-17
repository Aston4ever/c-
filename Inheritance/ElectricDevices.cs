namespace Inheritance;

public class ElectricDevices
{
    public bool IsOn { get; set; }
    public string Brand { get; set; }

    public ElectricDevices(string brand, bool isOn)
    {
        this.Brand = brand;
        this.IsOn = isOn;
    }

    public void SwitchOn()
    {
        this.IsOn = true;
    }

    public void SwitchOff()
    {
        this.IsOn = false;
    }
    
}