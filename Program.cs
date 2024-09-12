using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t\t\t\tAll Apps");

            bool ContineouApps = true;

            while (ContineouApps)
            {
                Console.Write("\n1, Scientific Calculator:");
                Console.Write("\t2, Rock Paper Scissors Game:");
                Console.Write("\t3, Generate Table:");
                Console.Write("\t4, Generate backward Table:");
                Console.Write("\n\n5, Multiplication Table Game:");
                Console.Write("\t6, School Grade System:");

                Console.WriteLine("Enter Number for Open App:");
                int enterNumber = int.Parse(Console.ReadLine());

                if (enterNumber == 1)
                {
                    Console.WriteLine("Scientific Calculator");

                    bool continueouCalculator = true;

                    while (continueouCalculator)
                    {
                        Console.WriteLine("\n Selections:");
                        Console.WriteLine("1. Addition (+)");
                        Console.WriteLine("2. Subtraction (-)");
                        Console.WriteLine("3. Multiplication (*)");
                        Console.WriteLine("4. Division (/)");
                        Console.WriteLine("5. Power (^)");
                        Console.WriteLine("6. Square Root (√)");
                        Console.WriteLine("7. Logrithm (log)");
                        Console.WriteLine("8. Sine (sin)");
                        Console.WriteLine("9. Cosine (cos)");
                        Console.WriteLine("10. Tangent (tan)");
                        Console.WriteLine("11. Exit");

                        Console.WriteLine("\n Enter Your Choice");
                        int choice = int.Parse(Console.ReadLine());

                        double num1, num2, result = 0;

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter num1:");
                                num1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter num2:");
                                num2 = int.Parse(Console.ReadLine());
                                result = num1 + num2;
                                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                                break;

                            case 2:
                                Console.WriteLine("Enter num1:");
                                num1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter num2:");
                                num2 = int.Parse(Console.ReadLine());
                                result = num1 - num2;
                                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                                break;

                            case 3:
                                Console.WriteLine("Enter num1:");
                                num1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter num2:");
                                num2 = int.Parse(Console.ReadLine());
                                result = num1 * num2;
                                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                                break;


                            case 4:
                                Console.WriteLine("Enter num1:");
                                num1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter num2:");
                                num2 = int.Parse(Console.ReadLine());
                                result = num1 / num2;

                                if (num2 != 0)
                                {
                                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                                }
                                else
                                {
                                    Console.WriteLine("Error: Division by zero is not allowed");
                                }
                                break;


                            case 5:
                                Console.WriteLine("Enter num1:");
                                num1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter num2:");
                                num2 = int.Parse(Console.ReadLine());
                                result = Math.Pow(num1, num2);
                                Console.WriteLine($"Result: {num1} ^ {num2} = {result}");
                                break;

                            case 6:
                                Console.WriteLine("Enter number:");
                                num1 = int.Parse(Console.ReadLine());

                                if (num1 >= 0)
                                {
                                    result = Math.Sqrt(num1);
                                    Console.WriteLine($"Result:  √ {num1} = {result}");
                                }
                                else
                                {
                                    Console.WriteLine("Error: Square root of a negative number is not allowed.");
                                }
                                break;

                            case 7:
                                Console.WriteLine("Enter number:");
                                num1 = int.Parse(Console.ReadLine());

                                if (num1 > 0)
                                {
                                    result = Math.Log(num1);
                                    Console.WriteLine($"Result: log({num1}) = {result}");
                                }
                                else
                                {
                                    Console.WriteLine("Error: Logarithm of zero or a negative number is not allowed."); ;
                                }
                                break;

                            case 8:
                                Console.WriteLine("Enter number:");
                                num1 = int.Parse(Console.ReadLine());
                                result = Math.Sin(num1 * (Math.PI / 180)); // Convert degrees to radians
                                Console.WriteLine($"Result: sin({num1}°) = {result}");
                                break;

                            case 9:
                                Console.WriteLine("Enter number:");
                                num1 = int.Parse(Console.ReadLine());
                                result = Math.Cos(num1 * (Math.PI / 180)); // Convert degrees to radians
                                Console.WriteLine($"Result: Cos({num1}°) = {result}");
                                break;

                            case 10:
                                Console.WriteLine("Enter number:");
                                num1 = int.Parse(Console.ReadLine());
                                result = Math.Tan(num1 * (Math.PI / 180)); // Convert degrees to radians
                                Console.WriteLine($"Result: tan({num1}°) = {result}");
                                break;

                            case 11:
                                continueouCalculator = false;
                                Console.WriteLine("Exiting calculator. Goodbye!!!");
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please select a valid operation");
                                break;
                        }
                    }
                }

                else if (enterNumber == 2)
                {

                    Console.WriteLine("Welcome to Rock, Paper and Scissors...");

                    Console.WriteLine("\nEnter Username:");
                    string Username = Console.ReadLine();

                    bool ContnieouGame = true;

                    while (ContnieouGame)
                    {


                        Console.WriteLine("\nChoose: rock, paper & scissors:");
                        string PlayerChoice = Console.ReadLine().Trim().ToLower();

                        Random random = new Random();
                        int RandomNumber = random.Next(1, 4);
                        string ComputerChoice = "";

                        if (RandomNumber == 1) ComputerChoice = "rock";
                        if (RandomNumber == 2) ComputerChoice = "paper";
                        else ComputerChoice = "scissors";

                        Console.WriteLine($"Computer Choice: {ComputerChoice}");

                        if (PlayerChoice == ComputerChoice)
                        {
                            Console.WriteLine("Match has been tie!!!");
                        }

                        else if (PlayerChoice == "rock" && ComputerChoice == "scissors" || PlayerChoice == "scissors"
                            && ComputerChoice == "paper" || PlayerChoice == "paper" && ComputerChoice == "rock")
                        {
                            Console.WriteLine($"{Username} : You Win!!!");
                        }

                        else if (ComputerChoice == "rock" && PlayerChoice == "scissors" || ComputerChoice == "scissors"
                            && PlayerChoice == "paper" || ComputerChoice == "paper" && PlayerChoice == "rock")
                        {
                            Console.WriteLine($"{Username} : You Lose!!!");
                        }

                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please enter rock, paper, or scissors");
                        }

                        Console.WriteLine("\nDo you want play again...(yes/no)");
                        string PlayAgain = Console.ReadLine().Trim().ToLower();

                        if (PlayAgain != "yes")
                        {
                            ContnieouGame = false;
                            Console.WriteLine("\nThanks for playing! Goodbye...");
                        }

                    }


                }

                else if (enterNumber == 3)
                {
                    
                    Console.WriteLine("Generate Table\n");

                    bool ContinueouTable = true;

                    while (ContinueouTable)
                    {
                        Console.WriteLine("Enter Number to generate Table:");
                        int Table = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"{i} x {Table} = {i * Table}");
                        }

                        Console.WriteLine("Do you want to exit the Generate Table App!!!(yes/no)");
                        string leaveapp = Console.ReadLine().Trim().ToLower();

                        if(leaveapp != "yes")
                        {
                            ContinueouTable = false;
                            Console.WriteLine("Thanks for Visiting!!!");
                        }

                    }

                   

                }

                else if (enterNumber == 4)
                {

                    Console.WriteLine("Generate backward Table");

                    bool ContineouTable = true;

                    while (ContineouTable)
                    {
                        Console.WriteLine("Enter Number to generate backward Table:");
                        int Table = int.Parse(Console.ReadLine());

                        for (int i = 10; i >= 1; i--)
                        {
                            Console.WriteLine($"{i} x {Table} = {i * Table}");
                        
                        }


                        Console.WriteLine("Do you want to exit the Generate Table App!!!(yes/no)");
                        string leaveapp = Console.ReadLine().Trim().ToLower();

                        if (leaveapp != "yes")
                        {
                            ContineouTable = false;
                            Console.WriteLine("Thanks for Visiting!!!");
                        }

                    }
                }

                else if (enterNumber == 5)
                {


                    bool ContineoGenerateTable = true;

                    Console.WriteLine("Welcome to the Multiplication Table Game!");

                    while (ContineoGenerateTable)
                    {
                        Console.WriteLine("\nHow many tables would you want like to generate!");

                        int TablesGenerate = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= TablesGenerate; i++)
                        {

                            Console.WriteLine($"\nMultiplication of Table {i} \n");

                            for (int j = 1; j <= 10; j++)
                            {
                                Console.WriteLine($"{i} x {j} = {i * j}");
                            }

                        }

                        Console.WriteLine("\n Do you want to Contineou generate tables!!! (yes/no)");
                        string GenerateTable = Console.ReadLine().Trim().ToLower();

                        if (GenerateTable != "yes")
                        {
                            ContineoGenerateTable = false;
                            Console.WriteLine("Good Bye !!!");
                        }

                    }



                }

                else if (enterNumber == 6)
                {

                    bool continueProgram = true;

                    while (continueProgram)
                    {
                        Console.WriteLine("\nSchool Grade System");
                        Console.WriteLine("\nAre you entering subject numbers for student results?" +
                            " (yes/no or type 'exit' to quit)");
                        string enter = Console.ReadLine().Trim().ToLower();

                        if (enter == "exit")
                        {
                            continueProgram = false;
                        }

                        if (enter == "yes")
                        {
                            Console.WriteLine("\nEnter the class (9th/10th)");
                            string ChooseClass = Console.ReadLine().Trim().ToLower();

                            if (ChooseClass == "9th")
                            {
                                Console.WriteLine("\nEnter Student Id");
                                int Id = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Student Name");
                                string studentName = Console.ReadLine().Trim().ToUpper();

                                Console.WriteLine("\nEnter Father Name");
                                string fatherName = Console.ReadLine().Trim().ToUpper();

                                Console.WriteLine("\nEnter Math Number (Total: 75)");
                                int Math = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter English Number (Total: 100)");
                                int English = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Computer Number (Total: 60)");
                                int Computer = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Chemistry Number (Total: 60)");
                                int Chemistry = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Physics Number (Total: 60)");
                                int Physics = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Urdu Number (Total: 75)");
                                int Urdu = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Islamiat Number (Total: 75)");
                                int Islamiat = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Physics Practical Number (Total: 15)");
                                int PhysicsPracticel = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Chemistry Practical Number (Total: 15)");
                                int ChemistryPracticel = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Computer Practical Number (Total: 15)");
                                int ComputerPracticel = int.Parse(Console.ReadLine());

                                if (Math <= 75 && English <= 100 && Computer <= 60 && Chemistry <= 60 && Physics <= 60
                                    && Islamiat <= 75 && Urdu <= 75 && PhysicsPracticel <= 15 && ChemistryPracticel
                                    <= 15 && ComputerPracticel <= 15)
                                {
                                    int totalScore = 550;

                                    float percentage = (float)(Math + English + Computer + Chemistry + Physics + Islamiat
                                        + Urdu + PhysicsPracticel + ChemistryPracticel + ComputerPracticel)
                                        / totalScore * 100;

                                    Console.WriteLine($"\nMath: {Math}, English: {English}, Computer: {Computer}, " +
                                        $"Chemistry: {Chemistry}, Islamiat: {Islamiat}, Urdu: {Urdu}, Physics: {Physics}");

                                    GradeOutput(percentage);

                                    Console.WriteLine($"\nStudent Id: {Id}, Student Name: {studentName}, Father Name:" +
                                        $" {fatherName}");
                                }
                                else
                                {
                                    Console.WriteLine("\nEnter Valid Number!!!");
                                }
                            }
                            else if (ChooseClass == "10th")
                            {
                                Console.WriteLine("\nEnter Student Id");
                                int Id = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Student Name");
                                string studentName = Console.ReadLine().Trim().ToUpper();

                                Console.WriteLine("\nEnter Father Name");
                                string fatherName = Console.ReadLine().Trim().ToUpper();

                                Console.WriteLine("\nEnter Math Number (Total: 75)");
                                int Math = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter English Number (Total: 100)");
                                int English = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Computer Number (Total: 60)");
                                int Computer = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Chemistry Number (Total: 60)");
                                int Chemistry = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Physics Number (Total: 60)");
                                int Physics = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Sindhi Number (Total: 75)");
                                int Sindhi = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter P.S.T Number (Total: 75)");
                                int pst = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Physics Practical Number (Total: 15)");
                                int PhysicsPracticel = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Chemistry Practical Number (Total: 15)");
                                int ChemistryPracticel = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nEnter Computer Practical Number (Total: 15)");
                                int ComputerPracticel = int.Parse(Console.ReadLine());

                                if (Math <= 75 && English <= 100 && Computer <= 60 && Chemistry <= 60 && Physics
                                    <= 60 && pst <= 75 && Sindhi <= 75 && PhysicsPracticel <= 15 && ChemistryPracticel
                                    <= 15 && ComputerPracticel <= 15)
                                {
                                    int totalScore = 550;

                                    float percentage = (float)(Math + English + Computer + Chemistry + Physics + pst
                                        + Sindhi + PhysicsPracticel + ChemistryPracticel + ComputerPracticel)
                                        / totalScore * 100;

                                    Console.WriteLine($"\nMath: {Math}, English: {English}, Computer: {Computer}, " +
                                        $"Chemistry: {Chemistry}, P.S.T: {pst}, Sindhi: {Sindhi}, Physics: {Physics}");

                                    GradeOutput(percentage);

                                    Console.WriteLine($"\nStudent Id: {Id}, Student Name: {studentName}, " +
                                        $"Father Name: {fatherName}");
                                }
                                else
                                {
                                    Console.WriteLine("\nEnter Valid Number!!!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                        }

                        Console.WriteLine("\nDo you want to enter another student's information? (yes/no)");
                        string continueInput = Console.ReadLine().Trim().ToLower();

                        if (continueInput != "yes")
                        {
                            continueProgram = false;
                        }
                    }

                    Console.WriteLine("Program exited.");
                }

                else
                {
                    Console.WriteLine("\nError: Enter Valid Number between 1/4");
                }
                 
                Console.WriteLine("\nDo you want leave the Apps (yes/no)");
                string leaveApps = Console.ReadLine().Trim().ToLower();

                if (leaveApps == "yes")
                {
                    ContineouApps = false;
                    Console.WriteLine("\n Thank you for visiting!!! Good Bye...");
                }

            }


             void GradeOutput(float percentage)
            {
                if (percentage > 90)
                {
                    Console.WriteLine($"\n{percentage:F2}%: Your Grade is A1: congratulations!!!");
                }
                else if (percentage > 80)
                {
                    Console.WriteLine($"\n{percentage:F2}%: Your Grade is A+: congratulations!!!");
                }
                else if (percentage > 70)
                {
                    Console.WriteLine($"\n{percentage:F2}%: Your Grade is A: congratulations!!!");
                }
                else if (percentage > 60)
                {
                    Console.WriteLine($"\n{percentage:F2}%: Your Grade is B: congratulations but Do a little more hard work " +
                        $"work!!!");
                }
                else if (percentage > 50)
                {
                    Console.WriteLine($"\n{percentage:F2}%: Your Grade is C: better luck next time!!!");
                }
                else if (percentage > 35)
                {
                    Console.WriteLine($"\n{percentage:F2}%: Your Grade is D: better luck next time!!!");
                }
                else
                {
                    Console.WriteLine($"\n{percentage:F2}%: You have Failed!!!");
                }
            }

        }
    }
}
