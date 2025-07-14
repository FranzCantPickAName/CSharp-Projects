
int myNumber = 18;
bool myBoolean = false;

myBoolean = (myNumber > 10) ? true : false;
if (myBoolean)
    Console.WriteLine("Number is grater than 10");
else Console.WriteLine("Number is lower than 10");

int firstNumber = 5;
int secondNumber = 2;

Console.WriteLine("Sum is:" + (firstNumber+secondNumber));
Console.WriteLine("Sum is:" + (firstNumber - secondNumber));
Console.WriteLine("Mul is:" + firstNumber*secondNumber);
Console.WriteLine("Div is:" + firstNumber/secondNumber);
Console.WriteLine("Rem is:" + firstNumber % secondNumber);


//Arithmetical Operators
decimal a = 10M;
decimal b = 3M;
decimal c = a + b; //Output: 13
decimal d = a - b; //Output: 7
decimal e = a * b; //Output: 30
decimal f = a / b; //Output: 3.3333333
decimal g = a % b; //Output: 1
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);


//Assignment Operators
a += 20M;
Console.WriteLine(a); //Output: 30
a -= 20M;
Console.WriteLine(a); //Output: 10
a *= 3M;
Console.WriteLine(a); //Output: 30
a /= 3M;
Console.WriteLine(a); //Output: 10
a %= 3M;
Console.WriteLine(a); //Output: 1

//Increment / Decrement Operators
a = 10M;
Console.WriteLine();
Console.WriteLine(++a); //Output: 11
Console.WriteLine(a++); //Output: 11
Console.WriteLine(a); //Output: 12
Console.WriteLine(--a); //Output: 11
Console.WriteLine(a--); //Output: 11
Console.WriteLine(a); //Output: 10

//Comparison Operators
Console.WriteLine();
bool b1 = a == 10;
Console.WriteLine(b1); //Output: true
bool b2 = a != 10;
Console.WriteLine(b2); //Output: false
bool b3 = a < 10;
Console.WriteLine(b3); //Output: false
bool b4 = a > 10;
Console.WriteLine(b4); //Output: false
bool b5 = a <= 10;
Console.WriteLine(b5); //Output: true
bool b6 = a >= 10;
Console.WriteLine(b6); //Output: true


//Logical Operators
Console.WriteLine();
bool b7 = a == 10 & b == 10;
Console.WriteLine(b7); //Output: false
bool b8 = a == 10 && b == 10;
Console.WriteLine(b8); //Output: false
bool b9 = a == 10 | b == 10;
Console.WriteLine(b9); //Output: true
bool b10 = a == 10 || b == 10;
Console.WriteLine(b10); //Output: true
bool b11 = !(a == 10);
Console.WriteLine(b11); //Output: false
bool b12 = a == 10 ^ b == 10;
Console.WriteLine(b12); //Output: true

//concatenation operator
string name = "Scott";
int age = 20;
string message = "Hey " + name + ", your age is " + age + ".";
Console.WriteLine(message);

//ternary operator
string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
Console.WriteLine(title);

//operator precedence
double z = 10 + 4 * 30 / 10;
Console.WriteLine(z); //Output: 22



// test from kambiz
// test from Soheil


int debugFirstNumber = 10;
int debugSecondNumber = 6;
int debugThirdNumber = 7;

int debugFourNumber = debugFirstNumber + debugSecondNumber;
int debugFiveNumber = debugThirdNumber + debugFourNumber +1;

Console.WriteLine(debugFiveNumber);

// test from kambiz
// test from Soheil

var word = "Soheil";
var varNumber = 11;
var userNumber = Console.ReadLine();
Console.WriteLine(word.GetType());
Console.WriteLine(varNumber.GetType());
Console.WriteLine(userNumber);

string userInput = Console.ReadLine();
bool userInputABC = userInput == "ABC";
bool userInputNotABC = userInput != "ABC";
bool userInputNotABCTwo = !(userInput == "ABC");

Console.WriteLine(userInputABC);
Console.WriteLine(userInputNotABC);
Console.WriteLine(userInputNotABCTwo);


Console.ReadKey();