//if  we enter odd number or even number it prints it

//Console.WriteLine("Enter a number: ");
//int x = Convert.ToInt32 (Console.ReadLine());
//if (x % 2== 0)
//{
//    Console.WriteLine("this is an even number");
//}
//else
//{
//    Console.WriteLine("this is an odd number");
//}


Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your gender: ");
string gender = Console.ReadLine();

Console.WriteLine("Enter your status (ative-nonactive): ");
string status = Console.ReadLine();
if (gender == "male" && status == "active")
{
    Console.WriteLine("Welcome Mr. " + name + ", you have access");
}
else if (gender == "female" && status == "active")
{

    Console.WriteLine("Welcome Ms. " + name + ", you have access");
}
else
{
    Console.WriteLine("Accesss denied");
}