namespace OOP;

public class Box
{
    private int width;
    private int height;
    //private int depth;
    private int volume;
    /* Старый способ написания сеттеров геттеров
     public void SetWidth(int width)
    {
        this.width = width;
    }

    public int GetWidth()
    {
        return this.width;
    }

    public int GetVolume()
    {
       return this.width * this.height*this.depth;
    }
    */
    
    public int Width { get => width; set => width = value; }

    public int Height //Можно даже не писать поле private int height; так как если пишешь свойство оно не обязательно
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                height = -value;
            }
            height = value;
        }
    }
    public int Depth { get; set; } //дефолтное проперти. Тоже самое что и Height без условия

    public int Volume
    {
        get
        {
            return this.width * this.height * this.Depth;
        }
    }
    public void DIisplayInfo()
    {
        Console.WriteLine($"width: {width}\nheight: {height}\ndepth: {Depth}\n Volume: {width}x{height}x{Depth} = {width * height * Depth}");
    }

    ~Box() //Finalizer or Destructor
    {
        Console.WriteLine("Box object was destroyed");
    }
}