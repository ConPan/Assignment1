// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello user! Enter one word, please!");

string userName = Console.ReadLine();
if (userName != null)
{
    MyFirstMethod();
}

static void MyFirstMethod()
{
    Console.WriteLine($"Thank you! Could you enter some text, please?");
    string userInput = Console.ReadLine();
    Console.WriteLine("#" + userInput);
}