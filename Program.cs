class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("yearly salary : ");
        string salary = Console.ReadLine();
        Console.WriteLine("taxes per cent : ");
        string taxes = Console.ReadLine();
        Show(float.Parse(salary), float.Parse(taxes));
    }

    static void Show(float salary, float taxes)
    {
        Console.WriteLine("salary : " + salary / 12 + "€");
        Console.WriteLine("after taxes : " + ((salary / 12) - ((taxes / 100) * (salary / 12))) + "€");
    }
}