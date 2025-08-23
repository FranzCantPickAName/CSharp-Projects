using MyCategory;

Category category = new Category(20, "General");

//category.CategoryID = 20;
//category.CategoryName = "General";

Console.WriteLine(category.CategoryID);
Console.WriteLine(category.CategoryName);
Console.WriteLine(category.GetCategoryNameLength());

Structure1 structure1;
structure1.x = 10;
structure1.y = 20;

Class1 class1;
class1 = new Class1();
class1.x = 10;
class1.y = 20;

Structure1 structure2;

Class1 class2;

structure2 = structure1;

class2 = class1;

structure2.x = 100;
structure2.y = 200;

class2.x = 100;
class2.y = 200;

Console.WriteLine(structure1.x);
Console.WriteLine(structure1.y);
Console.WriteLine(structure2.x);
Console.WriteLine(structure2.y);

Console.WriteLine(class1.x);
Console.WriteLine(class1.y);
Console.WriteLine(class2.x);
Console.WriteLine(class2.y);


Console.ReadKey();



