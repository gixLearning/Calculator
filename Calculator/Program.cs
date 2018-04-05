using System;

namespace Calculator {
    public class Program {

        private const string ANGE_VARDE_TEXT = "Ange två värden som heltal:";

        static void Main(string[] args) {

            //Fields


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("Välj vad du vill göra:");
            Console.WriteLine("1) Addition 2) Subtration 3) Multiplikation 4) Division");
            string input = Console.ReadLine();


            int value;
            double result = 0;

            if (int.TryParse(input, out value)) {
                switch (value) {
                    case (1): {
                            Console.WriteLine(ANGE_VARDE_TEXT);
                            int x1 = int.Parse(Console.ReadLine());
                            int x2 = int.Parse(Console.ReadLine());
                            result = Addition(x1, x2);
                            break;
                        }
                    case (2): {
                            Console.WriteLine(ANGE_VARDE_TEXT);
                            int x1 = int.Parse(Console.ReadLine());
                            int x2 = int.Parse(Console.ReadLine());
                            result = Addition(x1, x2);
                            break;
                        }
                    case (3): {
                            Console.WriteLine(ANGE_VARDE_TEXT);
                            int x1 = int.Parse(Console.ReadLine());
                            int x2 = int.Parse(Console.ReadLine());
                            result = Multiplication(x1, x2);
                            break;
                        }
                    case (4): {
                            Console.WriteLine(ANGE_VARDE_TEXT);
                            int x1 = int.Parse(Console.ReadLine());
                            int x2 = int.Parse(Console.ReadLine());
                            result = Division(x1, x2);
                            break;
                        }
                    default:
                        Console.WriteLine("Du angav ett alternativ som inte fanns");
                        break;
                }
            }
            else {
                Console.WriteLine("Du måste ange en siffra, lol!");
            }

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Resultat: " + result);
            Console.ReadKey();
        }
        private static int Addition(int firstValue, int secondValue) {
            int result = firstValue + secondValue;
            return result;
        }

        private static int Subtraction(int firstValue, int secondValue) {
            int result = firstValue - secondValue;
            return result;
        }

        private static int Multiplication(double firstValue, double secondValue) {
            double result = firstValue * secondValue;

            var returnValue = Convert.ToInt32(result);

            return returnValue;
        }

        private static double Division(int firstValue, int secondValue) {
            return firstValue / secondValue;
        }
    }
}
