public class Ali
{
    public static string Name { get; set; }

    public string ColorSkim { get; set; }

    public int  Age { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public void Drive()
    {
        Name="Ali";
        Console.WriteLine("Ali is driving a car");
    }

    public void Eat()
    {
        Console.WriteLine("Ali is eating food");
    }

    public static void Sleep()
    {
        Console.WriteLine("Ali is sleeping");
    }



  
}