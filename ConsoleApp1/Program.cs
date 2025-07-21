
string myNumber = "100 0";
int parsedNumber = 0;
bool conversionSuccess = false;

conversionSuccess = int.TryParse(myNumber, out parsedNumber);

if (conversionSuccess)
{
    Console.WriteLine("Conversion was successful." + parsedNumber);
}
else
{
    Console.WriteLine("Conversion failed.");
}

string myNumber2 = "2000";
int convertedNumber = 0;

convertedNumber = Convert.ToInt32(myNumber2);

Console.WriteLine(convertedNumber);

int myAge = 0;
string myAgeString = myAge.ToString();


string userInput;


Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

userInput = Console.ReadLine();


switch (userInput)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs.");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO.");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO.");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit.");
        break;
    default:
        PrintSelectedOption("Invalid input!");
        break;

}


void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}


var variousNumbers = new int[] { 10, -8, 2, 12, -17 , -22};
int countOfNonPositiveNumbers;
var onlyPositive = GetOnlyPositive(variousNumbers, out countOfNonPositiveNumbers);

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    var result = new List<int>();
    countOfNonPositive = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            ++countOfNonPositive;
        }
    }
    return result;
}

Console.WriteLine(countOfNonPositiveNumbers);
foreach (int number in onlyPositive)
{
    Console.WriteLine(number);
}

Console.ReadKey();
