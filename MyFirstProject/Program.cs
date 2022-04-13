// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("swapnali the developer");


/*int a = 4;
Console.WriteLine("Complex conditional operator:");


if (a < 11)
{
    if (a < 5)
    {
        Console.WriteLine("a <5");

    }
    else
    {
        Console.WriteLine("a > 5 and a < 11");
    }
}
else
{ 
    Console.WriteLine("a >= 11");
}
*/

int dogType = 3;

switch (dogType)
{
    case 1:
        Console.WriteLine("Poodle");
        break;
    case 2:
        Console.WriteLine("Golden Retriever");
        break;
    case 3:
        Console.WriteLine("Goldendoodle");
        goto add;
       
        break;
    default:
        Console.WriteLine("Unknown dog.");
        break;
}

 add:
{
    int N1 = 5;
    int N2 = 10;

    //Console.WriteLine("Enter 1st no.");
    //N1 = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Enter 2nd no.");
    //N2 = Convert.ToInt32(Console.ReadLine());

    int result;
    result = Convert.ToInt32(N1 + N2);
    //return result;
    Console.WriteLine("the result is :" + result);
}

//string s = "dd+dfg+sdfg+afg+dfhng+th+retw";

//string[] str = s.Split("+");

//Console.WriteLine(str[5]);

//int i = 4;

//Console.Write("{0}",i.ToString ("D3"));


//bool condition = true;

//// the loop condition is tested prior to every loop
//// the loop executes only while the condition is true 
//while (condition)
//{
//    Console.WriteLine("Loop!");

//    // condition is set from the return value of DoSomeWork()
//    condition = DoSomeWork();
//}

//static bool DoSomeWork()
//{
//    return false;
//}