using System;

namespace Calculator {
    public class Program {

        private const string ANGE_VARDE_TEXT = "Ange två värden som heltal:";
        private const string VAL_TEXT = "X) Avsluta \n1) Addition \n2) Subtration \n3) Multiplikation \n4) Division \n99) Fler funktioner";
        private const string VAL_TEXT_ADV = "5) Beräkna area av en cirkel \n6) Beräkna volymen av ett klot \n7) Beräkna omkresten av en cirkel \n8) Beräkna en cirkelsektors area";

        private static bool showAdvanced = false;

        static void Main(string[] args) {

            bool belsebub = true;
            bool showResult;
            int value;
            string resultInString = null;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("Välj vad du vill göra:");
            ShowMenu();
            string input = Console.ReadLine();

            do {
                value = 0;
                resultInString = null;
                showResult = true;

                if (int.TryParse(input, out value)) {
                    switch (value) {
                        case (99): {
                                Console.WriteLine();
                                showAdvanced = true;
                                showResult = false;
                                break;
                            }
                        case (1): {
                                Console.WriteLine("Lägg till tal och separera med +, avsluta med enter");
                                string values = Console.ReadLine();
                                resultInString = MultipleAddition(values).ToString();
                                break;
                            }
                        case (2): {
                                Console.WriteLine("Lägg till tal och separera med -, avsluta med enter");
                                string values = Console.ReadLine();
                                resultInString = MultipleSubtraction(values).ToString();
                                break;
                            }
                        case (3): {
                                Console.WriteLine(ANGE_VARDE_TEXT);
                                int x1 = int.Parse(Console.ReadLine());
                                int x2 = int.Parse(Console.ReadLine());
                                resultInString = Multiplication(x1, x2).ToString();
                                break;
                            }
                        case (4): {
                                Console.WriteLine(ANGE_VARDE_TEXT);
                                int x1 = int.Parse(Console.ReadLine());
                                int x2 = int.Parse(Console.ReadLine());
                                resultInString = Division(x1, x2).ToString();
                                break;
                            }
                        case (5): {
                                Console.WriteLine("Ange cirkelns radie: ");
                                Double r = Double.Parse(Console.ReadLine());
                                resultInString = "Area = " + AreaOfCircle(r).ToString();
                                break;
                            }
                        case (6): {
                                Console.WriteLine("Ange klotets radie: ");
                                Double r = Double.Parse(Console.ReadLine());
                                resultInString = "Volym = " + VolumeOfSphere(r).ToString();
                                break;
                            }
                        case (7): {
                                Console.WriteLine("Ange cirkelns radie: ");
                                Double r = Double.Parse(Console.ReadLine());
                                resultInString = "Omkrets = " + CircumferenceOfCircle(r).ToString();
                                break;
                            }
                        case (8): {
                                Console.WriteLine("Ange cirkelns radie: ");
                                Double r = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Ange cirkelsektorns medelpunktsvinkel: ");
                                Double angle = Double.Parse(Console.ReadLine());
                                resultInString = "Cirkelsektorns area =  " + AreaOfCircleSector(angle, r).ToString();
                                break;
                            }
                        default:
                            Console.WriteLine("Du angav ett alternativ som inte fanns");
                            showResult = false;
                            break;
                    }
                }
                else if (input.ToLower() == "error") {
                    showResult = false;
                    Console.Clear();
                    Console.WriteLine("I am Error.");
                    Console.ReadLine();
                    break;
                }
                else if (input == "X" || input == "x") {
                    break;
                }
                else {
                    showResult = false;
                    Console.WriteLine("Du måste ange en siffra eller \"X\".");
                }

                if (showResult) {
                    Console.WriteLine("Resultat: " + resultInString + "\n");
                    showAdvanced = false;
                }

                ShowMenu();
                input = Console.ReadLine();
            } while (belsebub);
        }

        private static void ShowMenu() {
            
            if (showAdvanced) {
                Console.WriteLine(VAL_TEXT_ADV);
            } else {
                Console.WriteLine(VAL_TEXT);
            }
        }

        private static double MultipleAddition(string values) {
            string[] numberString;
            double result = 0;

            numberString = values.Split('+');
            foreach (string item in numberString) {
                if(Double.TryParse(item, out double value)) {
                    result += value;
                }
            }
            return result;
        }

        private static double MultipleSubtraction(string values) {
            string[] numberString;
            double result = 0;

            numberString = values.Split('-');
            foreach (string item in numberString) {
                if (Double.TryParse(item, out double value)) {
                    result -= value;
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

        private static double AreaOfCircle(double radius) {
            return Math.PI * Math.Pow(radius, 2);
        }

        private static double CircumferenceOfCircle(double radius) {
            return 2 * Math.PI * radius;
        }

        private static double AreaOfCircleSector(double angle, double radius) {
            return (angle / 360) * Math.PI * Math.Pow(radius, 2);
        }

        private static double VolumeOfSphere(double radius) {
            return (4 * Math.PI * (Math.Pow(radius, 3))) / 3;
        }
    }
}