using System;

namespace Calculator {
    public class Program {

        private const string ANGE_VARDE_TEXT = "Ange två värden som heltal:";
        private const string VAL_TEXT = "1) Addition 2) Subtration 3) Multiplikation 4) Division X) Avsluta";

        static void Main(string[] args) {

            bool belsebub = true;
            bool showResult;
            int value;
            string resultInString = null;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("Välj vad du vill göra:");
            Console.WriteLine(VAL_TEXT);
            string input = Console.ReadLine();

            do {
                value = 0;
                resultInString = null;
                showResult = false;

                if (int.TryParse(input, out value)) {
                    switch (value) {
                        //case (1): {
                        //        Console.WriteLine(ANGE_VARDE_TEXT);
                        //        int x1 = int.Parse(Console.ReadLine());
                        //        int x2 = int.Parse(Console.ReadLine());
                        //        resultInString = Addition(x1, x2).ToString();
                        //        showResult = true;
                        //        break;
                        //    }
                        case (1): {
                                Console.WriteLine("Lägg till tal och separera med +, avsluta med enter");
                                string values = Console.ReadLine();
                                resultInString = MultipleAddition(values).ToString();
                                showResult = true;
                                break;
                            }
                        case (2): {
                                Console.WriteLine(ANGE_VARDE_TEXT);
                                int x1 = int.Parse(Console.ReadLine());
                                int x2 = int.Parse(Console.ReadLine());
                                resultInString = Subtraction(x1, x2).ToString();
                                showResult = true;
                                break;
                            }
                        case (3): {
                                Console.WriteLine(ANGE_VARDE_TEXT);
                                int x1 = int.Parse(Console.ReadLine());
                                int x2 = int.Parse(Console.ReadLine());
                                resultInString = Multiplication(x1, x2).ToString();
                                showResult = true;
                                break;
                            }
                        case (4): {
                                Console.WriteLine(ANGE_VARDE_TEXT);
                                int x1 = int.Parse(Console.ReadLine());
                                int x2 = int.Parse(Console.ReadLine());
                                resultInString = Division(x1, x2).ToString();
                                showResult = true;
                                break;
                            }
                        default:
                            Console.WriteLine("Du angav ett alternativ som inte fanns");
                            break;
                    }
                }
                else if (input == "error") {
                    Console.WriteLine("I am Error.");
                    Console.ReadLine();
                    break;
                }
                else if (input == "X" || input == "x") {
                    break;
                }
                else {
                    Console.WriteLine("Du måste ange en siffra eller \"X\".");
                }

                if (showResult) {
                    Console.WriteLine("Resultat: " + resultInString + "\n");
                    Console.WriteLine(VAL_TEXT);
                }
                input = Console.ReadLine();
            } while (belsebub);
        }

        private static int MultipleAddition(string values) {
            string[] siffror;
            int result = 0;

            siffror = values.Split('+');
            foreach (string item in siffror) {
                if(int.TryParse(item, out int value)) {
                    result = result + value;
                }
            }
            return result;
        }
        private static int Addition(int firstValue, int secondValue) {
            return firstValue + secondValue;
        }

        private static int Subtraction(int firstValue, int secondValue) {
            return firstValue - secondValue;
        }

        private static double Multiplication(double firstValue, double secondValue) {
            return firstValue * secondValue;
        }

        private static double Division(int firstValue, int secondValue) {
            return (double)firstValue / (double)secondValue;
        }
    }
}
