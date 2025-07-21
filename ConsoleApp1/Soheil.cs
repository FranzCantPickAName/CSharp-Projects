// this is first test for pull and push

// test

var variousNumbers = new int[] { 10, -8, 2, 12, -17 };
int countOfNonPositiveNumbers;
var onlyPositive = GetOnlyPositive(variousNumbers, out countOfNonPositiveNumbers);

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    var result = new List<int>();
    countOfNonPositive = 0;
    foreach (var  number in numbers)
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
    Console.WriteLine(onlyPositive[number]);
}