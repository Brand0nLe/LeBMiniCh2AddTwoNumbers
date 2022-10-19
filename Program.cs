//Cuong Brandon Le
//10-18-22
//Mini Challenge 2 - Add Two Numbers

//need to add data validation
string numberOne = "";
string numberTwo = "";
int numOne;
int numTwo;
bool playAgain = true;
string userInput = "";



while(playAgain == true)
{
Console.WriteLine("Let's do some math together!");
Console.WriteLine("Enter your first number:");
numberOne = Console.ReadLine();

Console.WriteLine("What do you want for your second number?");
numberTwo = Console.ReadLine();

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
