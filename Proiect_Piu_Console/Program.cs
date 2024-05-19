using Clase;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Proiect_Piu_Console
{
    class Program
    {
        [Flags]
        public enum RaspMultiple
        {
            Pisica = 1,
            Cainele = 2,
        };

        public const RaspMultiple AnimaleCompanie = RaspMultiple.Pisica & RaspMultiple.Cainele;
        static void Main(string[] args)
        {
            Date quizDate = new Date("D:\\code shit\\New folder\\Database.txt");

            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Select an option:");
                Console.WriteLine("S. Incepe Joc");
                Console.WriteLine("A. Adauga Intrebare");
                Console.WriteLine("C. Cautare Intrebare");
                Console.WriteLine("F. Intrebare cu mai multe raspunsuri");
                Console.WriteLine("X. Exit");

                Console.Write("Alegerea dumneavoastra: ");
                string choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "S":
                        StartQuiz(quizDate);
                        break;
                    case "A":
                        AdaugaIntrebare();
                        break;
                    case "C":
                        SearchQuestion();
                        break;
                    case "F":
                        Intreb2Rasp();
                        break;
                    case "X":
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            }
        }

        static void StartQuiz(Date quizDate)
        {
            int score = 0;
            while (true)
            {
                Console.Clear();
                var (question, answer) = quizDate.GetNextQuestion();
                if (question == "Gata intrebari")
                    break;

                Console.WriteLine(question);

                Console.Write("Ranspunsul dumneavoastra: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.Trim().ToLower() == answer.ToLower())
                {
                    Console.WriteLine("Corect!");
                    score++;
                }
                else
                    Console.WriteLine("Gresit! Raspunsul corect era " + answer);

                Console.WriteLine();
                Console.ReadKey();
            }

            Console.WriteLine("Felicitari! Scorul tau final este: " + score + "!");
            Console.ReadKey();
        }
        static void AdaugaIntrebare()
        {
            Console.Clear();
            Console.WriteLine("Adauga o intrebare:");
            Console.Write("Introduceti Intrebarea Dumneavoastra: ");
            string question = Console.ReadLine().Trim();

            Console.Write("Introduceti raspunsul dumneavoastra: ");
            string answer = Console.ReadLine().Trim();

            string filePath = "D:\\code shit\\New folder\\Database.txt";

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(question + ";" + answer);
                Console.WriteLine("Question added successfully!");
            }

        }

        static void SearchQuestion()
        {
            Console.Clear();
            Console.Write("Introduce numarul intrebari: ");
            int questionNumber;
            if (!int.TryParse(Console.ReadLine(), out questionNumber) || questionNumber <= 0)
            {
                Console.WriteLine("Nu este un numar!");
                return;
            }

            string filePath = "D:\\code shit\\New folder\\Database.txt";
            string[] lines = File.ReadAllLines(filePath);
            if (questionNumber <= lines.Length)
            {
                string[] parts = lines[questionNumber - 1].Split(';');
                Console.WriteLine("Intrebarea: " + parts[0]);
                Console.WriteLine("Raspunsul: " + parts[1]);


            }
            else
            {
                Console.WriteLine("Intrebarea cu acest numar nu exista.");
            }
            Console.ReadKey();
        }

        static void Intreb2Rasp()
        {
            Repeta:
            Console.Clear();
            Console.WriteLine("Care dintre urmatoarele animale sunt animale de companie?");
            Console.WriteLine("1. Pisica ");
            Console.WriteLine("2. Melcul ");
            Console.WriteLine("3. Lupul ");
            Console.WriteLine("4. Cainele ");
            Console.WriteLine("\nScrieti raspunsurile cu spatiu intre ele si cu litere mari. (ex. Vaca Liliacul)");

            string raspuns2 = Console.ReadLine();
            string[] raspunsuri2 = raspuns2.Split(' ');
            string[] testing = new string[raspunsuri2.Length];

            if (testing.Length == 2)
            {
                for (int i = 0; i < raspunsuri2.Length; i++)
                {
                    if (Enum.IsDefined(typeof(RaspMultiple), raspunsuri2[i]))
                    {
                        testing[i] = "a";
                    }
                    else
                    {
                        testing[i] = "b";
                    }
                }

                if (testing[0] == "a" && testing[1] == "a")
                {
                    Console.WriteLine("Raspunsurile sunt corecte!");
                }
                else { Console.WriteLine("Raspunsurile sunt incorecte."); }
            }
            else
            {
                Console.WriteLine("Raspunsul Introdus nu este valid, Incercati din nou, sau apasati pe X sa iesiti.");
                if (Console.ReadLine().ToLower() == "x")
                {
                    goto sfarsit;
                }
                else
                {
                    goto Repeta;
                }
            }
            Console.ReadKey();
        sfarsit:;
        }
    }
}
