using System; 

// Definierar en klass 'Klasdiagram' med en bool egenskap 'stor'.
public class Klasdiagram
{
    public bool stor {get; set;}
}

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialiserar 'choice' till "y" för att komma in i loopen
            string choice = "y";
            while (choice.ToLower() == "y") // Loop som fortsätter så länge användaren väljer "y" eller "Y"
            {
                // Välkomstmeddelande
                Console.WriteLine("Welcome to Simple Calculator");

                // Tar emot första numret från användaren och konverterar det till en int
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                // Tar emot andra numret från användaren och konverterar det till en int
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Tar emot vilken operation användaren vill utföra
                Console.Write("Enter operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                // Initialiserar en variabel 'result' för att lagra resultatet av beräkningen
                int result = 0;

                // Switch-sats för att bestämma vilken operation som ska utföras
                switch (operation)
                {
                    case "+":
                        // Utför addition
                        result = num1 + num2;
                        Console.WriteLine($"Addition: {result}");
                        break;
                    case "-":
                        // Utför subtraktion
                        result = num1 - num2;
                        Console.WriteLine($"Subtraction: {result}");
                        break;
                    case "*":
                        // Utför multiplikation
                        result = num1 * num2;
                        Console.WriteLine($"Multiplication: {result}");
                        break;
                    case "/":
                        // Utför division om andra numret inte är noll
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Division: {result}");
                        }
                        else
                        {
                            // Felmeddelande om användaren försöker dividera med noll
                            Console.WriteLine("Cannot divide by zero!");
                        }
                        break;
                    default:
                        // Felmeddelande om användaren anger en ogiltig operation
                        Console.WriteLine("Invalid operation!");
                        break;
                }

                // Frågar användaren om hen vill fortsätta
                Console.Write("Do you want to continue (y/n): ");
                choice = Console.ReadLine();
            }
        }
    }
}
