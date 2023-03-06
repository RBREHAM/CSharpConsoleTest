using System.Collections;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] calendrier = new string[12];
        calendrier[0] = "Janvier";
        calendrier[1] = "Fevrier";
        calendrier[2] = "Mars";
        calendrier[3] = "Avril";
        calendrier[4] = "Mai";
        calendrier[5] = "Juin";
        calendrier[6] = "Juillet";
        calendrier[7] = "Aout";
        calendrier[8] = "Septembre";
        calendrier[9] = "Octobre";
        calendrier[10] = "Novembre";
        calendrier[11] = "Decembre";

        Console.WriteLine("Salaire annuel : ");
        double.TryParse(Console.ReadLine(), out double salary);
        Console.WriteLine("taxe : ");
        double.TryParse(Console.ReadLine(), out double taxe);

        foreach (string i in calendrier)
        {
            if (i == "Aout")
            {
                Console.WriteLine("Entreprise fermée pour le mois d'Aout");
            }
            else
            {
                double salaireNet = CalculSalary(salary, taxe);
                if (i == "Decembre")
                {
                    salaireNet = salaireNet + (0.1 * salaireNet);
                }
                Console.WriteLine("Salaire net du mois de " + i + " : " + salaireNet + "€");
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