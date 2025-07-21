
var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine();


    switch (userInput)
    {
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        case "E":
        case "e":
            shallExit = true;
            break;
        default:
            PrintSelectedOption("Invalid input!");
            break;

    }
}

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("The list is empty.");
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description: ");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));
    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == null || description.Length == 0)
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        //ShowNoTodosMessage();
        Console.WriteLine("The list is empty.");
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove: ");
        SeeAllTodos();
    }
    while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty.");
        return false;
    }
    if (int.TryParse(userInput, out index) && index >= 1 && index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}







