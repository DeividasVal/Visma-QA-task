using System;
using System.Collections.Generic;
using System.Linq;

namespace Visma_QA_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Band band = new Band();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Rock Music Band Generator");
                Console.WriteLine("1. Generate A Random Full Band Name");
                Console.WriteLine("2. Choose Adjective and Noun for Band Name");
                Console.WriteLine("3. Add Band Member");
                Console.WriteLine("4. View Band Information");
                Console.WriteLine("5. Show Adjective and Noun Count");
                Console.WriteLine("6. Add New Adjective");
                Console.WriteLine("7. Add New Noun");
                Console.WriteLine("8. Regenerate");
                Console.WriteLine("9. EXTRA: Remove Band Member");
                Console.WriteLine("10. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            band.GenerateBandName();
                            break;
                        case 2:
                            Console.WriteLine("Choose an adjective from the list:");
                            for (int i = 0; i < band.GetAdjectivesCount(); i++)
                            {
                                Console.WriteLine((i + 1) + ". " + band.GetAdjectiveByIndex(i));
                            }
                            Console.Write("Enter the number of the adjective: ");
                            if (int.TryParse(Console.ReadLine(), out int adjIndex) && adjIndex >= 1 && adjIndex <= band.GetAdjectivesCount())
                            {
                                Console.WriteLine("Choose a noun from the list:");
                                for (int i = 0; i < band.GetNounsCount(); i++)
                                {
                                    Console.WriteLine((i + 1) + ". " + band.GetNounByIndex(i));
                                }
                                Console.Write("Enter the number of the noun: ");
                                if (int.TryParse(Console.ReadLine(), out int nounIndex) && nounIndex >= 1 && nounIndex <= band.GetNounsCount())
                                {
                                    string chosenAdjective = band.GetAdjectiveByIndex(adjIndex - 1);
                                    string chosenNoun = band.GetNounByIndex(nounIndex - 1);
                                    band.CreateCustomBandName(chosenAdjective, chosenNoun);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid noun selection!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid adjective selection!");
                            }
                            break;

                        case 3:
                            band.AddBandMember();
                            break;
                        case 4:
                            band.DisplayBandInfo();
                            break;
                        case 5:
                            Console.WriteLine("Adjectives Count: " + band.GetAdjectivesCount() + ", Nouns Count: " + band.GetNounsCount());
                            break;
                        case 6:
                            Console.Write("Enter a new adjective: ");
                            string newAdjective = Console.ReadLine();
                            band.AddNewAdjective(newAdjective);
                            break;
                        case 7:
                            Console.Write("Enter a new noun: ");
                            string newNoun = Console.ReadLine();
                            band.AddNewNoun(newNoun);
                            break;
                        case 8:
                            band.Regenerate();
                            break;
                        case 9:
                            band.RemoveBandMember();
                            break;
                        case 10:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid option.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
