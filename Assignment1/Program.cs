// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello user! Enter your name, please!");

string userName = Console.ReadLine();
if (userName != null) {
    MyFirstMethod();
}

static void MyFirstMethod()
{
    Console.WriteLine($"Nice to meet you! Can you describe yourself in one sentence, please?");
    string userInput = Console.ReadLine();
    Console.WriteLine(userInput);
}

