
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
Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
  

