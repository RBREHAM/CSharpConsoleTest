class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Salaire a l'annee : ");
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);
        if(salaryIsInt)
        {
            ShowSalary(salary);
        }
        else
        {
            Console.WriteLine("Salaire non valide !");
        }
    }

    static void ShowSalary(int salary)
    {
        Console.WriteLine("taxes pourcent");
        bool taxesIsInt = int.TryParse(Console.ReadLine(), out int taxes);

        if (salary > 100000)
        {
            Console.WriteLine("Excusez moi Mr Besos");
        }
        else if (salary > 50000)
        {
            Console.WriteLine("Faires des dons pour reduire ses impots");
        }
        else if (salary < 1500 * 12)
        {
            Console.WriteLine("Tu es alternant, dommage");
        }
        else if (30000 < salary && salary < 40000)
        {
            Console.WriteLine("Viens dev au CESI !");
        }
        else
        {
            Console.WriteLine("Salaire normal...");
        }
    }
}