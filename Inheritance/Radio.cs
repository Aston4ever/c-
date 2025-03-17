namespace Inheritance;

public class Radio : ElectricDevices
{
    public Radio(string brand, bool isOn) : base(brand, isOn)
    {
        
    }

    public void ListenToTheRadio()
    {
        if (IsOn == true)
        {
            Console.WriteLine("Radio is on");
        }
        else
        {
            Console.WriteLine("Radio is off");
        }
    }
}