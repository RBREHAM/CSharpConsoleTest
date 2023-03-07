using System.Collections;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        User user1 = new User(1, "Raphael", "Breham", 18, 1500, 20);

        Console.WriteLine(user1.firsName);

        double salary = 0;

        string[] months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };

        try
        {
            Console.WriteLine("Salaire annuel : ");
            salary = double.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Mauvais format !");
        }
        
        Console.WriteLine("taxe : ");
        double.TryParse(Console.ReadLine(), out double taxe);
        Console.WriteLine("taxe de Noel : ");
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
                Console.WriteLine("Salaire net du mois de " + month + " : " + netSalary + "€");
            }
        }
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


public class User
{
    public User(int Id, string FirstName, string LastName, int Old, int Salary, int Tax)
    {
        id = Id;
        firsName = FirstName;
        lastName = LastName;
        old = Old;
        salary = Salary;
        tax = Tax;
    }

    public int id { get; }
    public string firsName { get; }
    public string lastName { get; }
    public int old { get; }
    public int salary { get; }
    public int tax { get; }
}