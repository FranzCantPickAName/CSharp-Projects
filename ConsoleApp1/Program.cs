List<string> words = new List<string>();
Console.WriteLine("Count of elements is " + words.Count);

words.Add("Hello");
Console.WriteLine("Count of elements is " + words.Count);

List<string> words2 = new List<string>
{
    "one",
    "two",
    "three"
};

//words2.Remove("two");
//words2.RemoveAt(0);

words2.AddRange(new[]  { "four", "five", "six" });

Console.WriteLine("Count of elements is " + words2.Count);
Console.WriteLine("Index of element 'four' is: " + words2.IndexOf("four"));
Console.WriteLine("Index of element 'seven' is: " + words2.IndexOf("seven"));

Console.WriteLine("Does the list contain 'four'? : " + words2.Contains("four"));
Console.WriteLine("Does the list contain 'seven'? : " + words2.Contains("seven"));

foreach (string word in words2)
{
    Console.WriteLine(word);
}



//words2[3] = "not three";

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
