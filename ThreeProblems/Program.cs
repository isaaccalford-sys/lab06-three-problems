/* 
* Name: Isaac Alford
* Course: CSCI-1250, Section 201
* Assignment: Lab 06, Three Short Problems
* Date: October 23, 2026
* Discription: A menu that keeps running until the useer quits, to take the user through multiple oparations.
*/

//The Menu
int choice = 0;
Random rng = new Random(4000);


// do while, so that it can run once and then run until chioce is 5 and not just end.
do 
{

    choice = 0;
    System.Console.WriteLine();
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    System.Console.Write("Choose a number 1-5: ");
    choice = Convert.ToInt32(Console.ReadLine());

    

 // while, so the user can keep messing up and the code not crash 
        while (choice > 5 || choice < 1)
        {
                
                System.Console.WriteLine("invalid choice Try again");
                System.Console.Write("Choose a number 1-5: ");
                choice = Convert.ToInt32(Console.ReadLine());
        }


 // if, so the user can have the option of using another if statment after each usage.

 //Grade Checker
    if (choice == 1 || choice == 4)
    {   
    System.Console.WriteLine();
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    System.Console.Write("Provide a score: ");
    int grade = Convert.ToInt32(Console.ReadLine());

    while (grade <= 0 || grade >= 100)
        {
            System.Console.WriteLine("Grade must be between 0 and 100.");

            System.Console.Write("Provide a score: ");
            grade = Convert.ToInt32(Console.ReadLine());
        }

    if (grade >= 90)
        {
            System.Console.WriteLine($"{grade} earns an A.");
        }
    else if (grade >= 80)
        {
            System.Console.WriteLine($"{grade} earns an B.");
        }        
    else if (grade >= 70)
        {
            System.Console.WriteLine($"{grade} earns an C.");
        }      
    else if (grade >= 60)
        {
            System.Console.WriteLine($"{grade} earns an D.");
        }      
    else if (grade < 60)
        {
            System.Console.WriteLine($"{grade} earns an F.");
        }       
    }


 //dice table
    if (choice == 2 || choice == 4)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

        int rollCounter = 0;
        int winCounter = 0;
        char reRollcheck;
        string modifier = "";

            // do while, so that the dice can continue iterating until the user presses n 
            do
            {    

                rollCounter++;

                int firstDie = rng.Next(1,7);
                int secoundDie = rng.Next(1,7);
                int dieTotal = firstDie + secoundDie;

                    // if so it will only run once and else ifs so that they will only run if previous statments do not.
                    if ( firstDie == 1 && secoundDie == 1)
                    {
                        modifier = " Snake eyes.";
                    }

                    else if ( firstDie == secoundDie )
                    {
                        modifier = " Doubles!";
                    }

                    else if (firstDie + secoundDie == 7 || firstDie + secoundDie == 11)
                    {
                        winCounter++;
                        modifier = " A winner.";
                    }
                    // else to catch all other possible outcomes 
                    else
                        {
                            modifier = "";
                        }
                

                System.Console.WriteLine($"Roll {rollCounter}: {firstDie} and {secoundDie}, total {dieTotal}.{modifier}");


                System.Console.Write("Roll again? (y/n): ");
                reRollcheck = Convert.ToChar(Console.ReadLine().ToUpper().Trim());


                    //check for correct input needs to be while to allow for reapeted incorrect input
                    while (reRollcheck != 'Y' && reRollcheck != 'N')
                        {
                            System.Console.WriteLine("Invalid Input press (y/n)");
                            reRollcheck = Convert.ToChar(Console.ReadLine().ToUpper().Trim());
                        }


            } while (reRollcheck != 'N');

        System.Console.WriteLine($"You rolled {rollCounter} and won {winCounter}.");
    }

 //Score report
    if (choice == 3 || choice == 4)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");

        
        int[] scoreList = new int[5];
        int scoreCounter = 0;
        int scoreTotal = 0;
        int highestScore = 0;
        int passCounter = 0;
        
        for (int i = 0; i < scoreList.Length; i++)

            {
                scoreCounter++;
                System.Console.Write($"score {i + 1}: ");
                scoreList[i] = Convert.ToInt32(Console.ReadLine());
            }

        foreach (int score in scoreList)
            {
                scoreTotal += score;

                if (score > highestScore)
                {
                    highestScore = score;
                }

                if (score >= 60)
                {
                    passCounter++;
                }
            
            }    

        double scoreAvarage = (double)scoreTotal  / scoreList.Length;

        System.Console.WriteLine();
        System.Console.WriteLine($"Scores entered: {scoreCounter}");
        System.Console.WriteLine($"Total: {scoreTotal}");
        System.Console.WriteLine($"Avarage: {scoreAvarage.ToString("F1")}");
        System.Console.WriteLine($"Highest: {highestScore}");
        System.Console.WriteLine($"Passing: {passCounter} of {scoreList.Length}");


    }
 

} while(choice != 5);

System.Console.WriteLine();
System.Console.WriteLine("Goodbye.");
System.Console.WriteLine();