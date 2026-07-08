using System.Globalization;
using System.Threading.Channels;



// creating the variables for the user inputs

double myNumber1 = 0.0; 
double myNumber2 = 0.0;

//asking for first user input
Console.WriteLine("Enter the first number!");
string userInput = Console.ReadLine();

//converint with Parse
myNumber1 = double.Parse(userInput, CultureInfo.InvariantCulture);

//asking for second user input,
Console.WriteLine("Enter the second number!");
userInput = Console.ReadLine();

//converint with Parse
myNumber2 = double.Parse(userInput, CultureInfo.InvariantCulture);

//defining the addition
double sum = myNumber1 + myNumber2;
sum = Math.Round(sum, 2);

//writing out what the user enters
//with concatination: Console.WriteLine("Calculate Beep Boop: " + myNumber1 + " + " + myNumber2 + " is " + sum);

//with interpolation
Console.WriteLine($"Calculating Beep Boop: {myNumber1.ToString(CultureInfo.InvariantCulture)} + {myNumber2.ToString(CultureInfo.InvariantCulture)} is {sum.ToString(CultureInfo.InvariantCulture)}");
Console.ReadKey();

