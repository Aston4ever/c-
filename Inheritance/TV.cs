namespace Inheritance;

public class TV : ElectricDevices
{
    public TV(string brand, bool isOn): base(brand, isOn)
    {
       
    }

    public void WatchTV()
    {
        if (IsOn == true)
        {
            Console.WriteLine("TV is on");
        }
        else
        {
            Console.WriteLine("TV is off");
        }
    }
}