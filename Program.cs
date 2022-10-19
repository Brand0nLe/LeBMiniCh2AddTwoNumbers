//Cuong Brandon Le
//10-18-22
//Mini Challenge 2 - Add Two Numbers

//need to add loop and data validation
string numberOne = "";
string numberTwo = "";
int numOne;
int numTwo;



Console.WriteLine("Let's do some math together!");
Console.WriteLine("Enter your first number:");
numberOne = Console.ReadLine();

Console.WriteLine("What do you want for your second number?");
numberTwo = Console.ReadLine();

numOne = Convert.ToInt32(numberOne);
numTwo = Convert.ToInt32(numberTwo);


Console.WriteLine($"Your sum is: {numOne + numTwo}");
