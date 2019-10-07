using System;

namespace Homework2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            string firstName;
            string lastName;
            string userAnswer;
            int cpuAnswer;
            int userScore = 0;
            int cpuScore = 0;

            Console.WriteLine("Insert your firstname:");
            firstName = Console.ReadLine();
            Console.WriteLine("Insert your lastname");
            lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}!");
            Console.WriteLine("Lets play rock, paper, scissors");

            while (userScore<3 && cpuScore<3)
            {
                Console.Clear();
                Console.WriteLine($"Your score: {userScore}\nCPU score: {cpuScore}");
                Console.WriteLine("Choose, rock (kivi), paper (paber) or scissors (käärid)?");
                userAnswer = Console.ReadLine();

                if (userAnswer == "rock" || userAnswer == "paper" || userAnswer == "scissors" || userAnswer == "kivi" ||
                    userAnswer == "paber" || userAnswer == "käärid")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This is not correct answer.");
                }

                Random rnd = new Random();
                cpuAnswer = rnd.Next(1, 4);

                if (cpuAnswer == 1)
                {
                    Console.WriteLine("CPU answer is Paper (paber)");
                }
                else if (cpuAnswer ==2)
                {
                    Console.WriteLine("CPU answer is Rock (kivi)");
                }
                else
                {
                    Console.WriteLine("CPU answer is Scissors (käärid)");
                }
                    

                // 1 - paber, 2 - kivi, 3 - käärid.
                // kasutaja saab punkti 
                
                if (
                    ((userAnswer == "rock" || userAnswer == "kivi") && cpuAnswer == 3) ||
                    ((userAnswer == "paper" || userAnswer == "paber") && cpuAnswer == 2) ||
                    ((userAnswer == "scissors" || userAnswer == "käärid") && cpuAnswer == 1)
                )
                {
                   Console.WriteLine("User won. User gets one point.");
                   userScore++;
                }
                // arvuti saab punkti 
                else if (
                    ((userAnswer == "rock" || userAnswer == "kivi") && cpuAnswer == 1) ||
                    ((userAnswer == "paper" || userAnswer == "paber") && cpuAnswer == 3) ||
                    ((userAnswer == "scissors" || userAnswer == "käärid") && cpuAnswer == 2)
                )
                {
                    Console.WriteLine("CPU won. CPU gets one point.");
                    cpuScore++;
                }
                else
                {
                    Console.WriteLine("Tie!");
                }
                Console.WriteLine($"Your score: {userScore}\nCPU score: {cpuScore}\nPress any key to continue...");
                Console.ReadKey();
            
            }

            Console.Clear();
            Console.WriteLine("Game over!");
            
            if (userScore == 3)
            {
                Console.WriteLine($"User won! Score: {userScore} - {cpuScore}");
            }
            else
            {
                Console.WriteLine($"CPU won! Score: {cpuScore} - {userScore}");
            }

            Console.ReadLine();

            //Reeglid: käärid lõikavad paberit, paber katab kivi, kivi nürib käärid.
            //Iga võidu eest saab osaleja, kas arvuti või mängia ühe punkti.
            //Mäng lõpeb siis, kui üks osalejast saab kolm punkti ja võidab mängu.
            


        }
    }
}