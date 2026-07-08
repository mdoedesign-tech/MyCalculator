using System.Threading.Channels;



// creating the variables for the user inputs

int myNumber1 = 0; 
int myNumber2 = 0;

//asking for first user input
Console.WriteLine("Enter the first whole number!");
string userInput = Console.ReadLine();

//converint with Parse
myNumber1 = int.Parse(userInput);

//asking for second user input
Console.WriteLine("Enter the second whole number!");
userInput = Console.ReadLine();

//converint with Parse
myNumber2 = int.Parse(userInput);

//defining the addition
int sum = myNumber1 + myNumber2;

//writing out what the user enters
Console.WriteLine("Calculate Beep Boop: " + myNumber1 + " + " + myNumber2 + " is " + sum);
Console.ReadKey();

