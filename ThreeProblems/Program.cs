/* 
* Name: Isaac Alford
* Course: CSCI-1250, Section 201
* Assignment: Lab 04, The Group Trip
* Date: October 12, 2026
* Discription: A menu to take the user through multiple oparations.
*/

// === CSCI 1250 Lab 06 ===
// 1. The Grade Checker
// 2. The Dice Table
// 3. The Score Report
// 4. All three
// 5. Quit
// Choose 1 through 5: 7
// Choose a number from 1 to 5.
// Choose 1 through 5: 3

//The Menu
int choice = 0;

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
choice = Convert.ToInt32(Console.Read());

System.Console.WriteLine();

// while, so the user can keep messing up and the code not crash 
while (choice > 5 || choice < 1)
{
        System.Console.WriteLine();
        System.Console.WriteLine("invalid choice Try again");
        System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
        System.Console.WriteLine("1. The Grade Checker");
        System.Console.WriteLine("2. The Dice Table");
        System.Console.WriteLine("3. The Score Report");
        System.Console.WriteLine("4. All three");
        System.Console.WriteLine("5. Quit");
        System.Console.Write("Choose a number 1-5: ");
        choice = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();
}


// if, so the user can have the option of using another if statment after each usage.

//Grade Checker
if (choice == 1 || choice == 4)
 {   
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



if (choice == 2 || choice == 4)
    {
    System.Console.WriteLine(2);
    }
if (choice == 3 || choice == 4)
    {
    System.Console.WriteLine(3);
    }

} while (choice != 5);


System.Console.WriteLine("Goodbye.");