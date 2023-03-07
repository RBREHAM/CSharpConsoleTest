using CSharpConsoleTest.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
         
        User user1 = new User(1, "Raphael", "Breham", 19, 1500, 20);

        Console.WriteLine(user1.Id);
        Console.WriteLine(user1.FirstName);
        Console.WriteLine(user1.LastName);
        Console.WriteLine(user1.Old);
        Console.WriteLine(user1.Salary);
        Console.WriteLine(user1.Tax);

        User user2 = new(2, "0", "0", 0, 0, 0);
        Console.WriteLine("First name : ");
        user2.FirstName = Console.ReadLine();
        Console.WriteLine("Last name : ");
        user2.LastName = Console.ReadLine();
        Console.WriteLine("Age : ");
        user2.Old = int.Parse(Console.ReadLine());
        Console.WriteLine("Yearly salary : ");
        user2.Salary = int.Parse(Console.ReadLine());
        Console.WriteLine("Taxes : ");
        user2.Tax = int.Parse(Console.ReadLine());



        double salary = 0;

        string[] months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };

        try
        {
            salary = user2.Salary;
        }
        catch(FormatException)
        {
            Console.WriteLine("Mauvais format !");
        }
        
        double taxe = user2.Tax;
        Console.WriteLine("Xmas prime : ");
        double.TryParse(Console.ReadLine(), out double Xmasprime);


        foreach (string month in months)
        {
            if (month == "Aout")
            {
                Console.WriteLine("Entreprise fermée pour le mois d'Aout");
            }
            else
            {
                double netSalary = CalculSalary(salary, taxe);
                if (month == "Decembre")
                {
                    netSalary = netSalary + ((Xmasprime/100) * netSalary);
                }
                Console.WriteLine("Salaire net du mois de " + month + " de " + user2.FirstName +  ": " + netSalary + "€");
            }
        }

        Console.WriteLine(user1.Id);
        Console.WriteLine(user1.FirstName);
        Console.WriteLine(user1.LastName);
        Console.WriteLine(user1.Old);
        Console.WriteLine(user1.Salary);
        Console.WriteLine(user1.Tax);
    }


    static double CalculSalary(double salary, double taxes)
    {
        double salary2 = (salary/12) - (taxes/100 * (salary/12));
        return salary2;
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