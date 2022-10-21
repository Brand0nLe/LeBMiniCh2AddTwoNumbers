//Cuong Brandon Le
//10-20-22
//Mini Challenge 2 - Add Two Numbers
//Project takes 2 user inputs and stores them as integers. It then adds the two numbers and prints 
//the sum into the terminal. Has a play again option with data validation if user doesn't enter YES. 
//There's also data validation for when first two user inputs are not numbers.
//Peer Review: Griffin Parker - This program works exactly as it should. It takes your numbers, validates them both seperately to make sure that they're both numbers, and then adds them together to give the user the sum. It lets the user choose to restart the program by typing "yes"; anything else will end the program. 
//I think this program meets all the criteria of the assignment, but I would just recommend adding data validation on the restart section of the program to make sure the user has to type 'yes' or 'no' to loop and end the program respectively. I would also recommend adding a Console.Clear() at the beginning of the loop 
//of the program to keep the terminal less cluttered.


string numberOne = "";
string numberTwo = "";
int numOne;
int numTwo;
bool playAgain = true;
bool validNum = true;
string userInput = "";




while(playAgain == true)
{
    
Console.Clear();

Console.WriteLine("Let's do some math together!");
Console.WriteLine("------------------------------");
Console.WriteLine("Enter your first number:");
numberOne = Console.ReadLine();
validNum = Int32.TryParse(numberOne, out numOne);
if (validNum == false)
{
    Console.WriteLine("Please enter a valid number.");
    numberOne = Console.ReadLine();
}


Console.WriteLine("What do you want for your second number?");
numberTwo = Console.ReadLine();
validNum = Int32.TryParse(numberTwo, out numTwo);
if (validNum == false)
{
    Console.WriteLine("Please enter a valid number.");
    numberTwo = Console.ReadLine();
}

numOne = Convert.ToInt32(numberOne);
numTwo = Convert.ToInt32(numberTwo);


Console.WriteLine($"Your sum is: {numOne + numTwo}");
Console.WriteLine("Would you like to play again?");
Console.WriteLine("YES/NO");
userInput = Console.ReadLine().ToUpper();

if (userInput == "YES")
{
    playAgain = true;
}

else
{
    playAgain = false;
    Console.WriteLine("Well it was fun while it lasted. See you next time!");
}





}
