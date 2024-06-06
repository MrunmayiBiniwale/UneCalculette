using System.Globalization;

namespace UneCalculette
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double res = 0;
            while(true)
            {
                Console.WriteLine("First Operand : ");
                double num1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Second Operand : ");
                double num2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Which operation do you choose : ");
                string operation = Console.ReadLine();
                if (operation.ToLower().Trim() == "add")
                {
                    res = add(num1, num2);
                    Console.WriteLine("" + num1 + " + " + num2 + " = " + res);
                }
                else if (operation.ToLower().Trim() == "subtract")
                {
                    res = subtract(num1, num2);
                    Console.WriteLine("" + num1 + " - " + num2 + " = " + res);
                }
                else if (operation.ToLower().Trim() == "multiply")
                {
                    res = multiply(num1, num2);
                    Console.WriteLine("" + num1 + " * " + num2 + " = " + res);
                }
                else if (operation.ToLower().Trim() == "divide")
                {
                    res = divide(num1, num2);
                    Console.WriteLine("" + num1 + " / " + num2 + " = " + res);
                }
                else if (operation.ToLower().Trim() == "modulo")
                {
                    res = modulo(num1, num2);
                    Console.WriteLine("" + num1 + " % " + num2 + " = " + res);
                }                    
                else
                    Console.WriteLine("Unknown operation " + operation);
            }
        }

        public static double add(double num1, double num2) 
        {
            double resultat = 0;
            resultat = num1 + num2;
            return resultat; 
        }
        public static double subtract(double num1, double num2) 
        {
            double resultat = 0;
            resultat = num1 - num2;
            return resultat;
        }
        public static double multiply(double num1, double num2) 
        {
            double resultat = 0;
            resultat = num1 * num2;
            return resultat;
        }
        public static double divide(double num1, double num2) 
        {
            double resultat = 0;
            resultat = num1 / num2;
            return resultat;
        }

        public static double modulo(double num1, double num2) 
        {
            double resultat = 0;
            resultat = num1 % num2;
            return resultat;
        }



    }
}
