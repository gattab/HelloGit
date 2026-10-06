// See https://aka.ms/new-console-template for more information
Console.Write("ما اسمك؟ ");
var name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
    name = "صديقي";

Console.WriteLine($"مرحبًا يا {name}! الساعة {DateTime.Now:HH:mm}");

Console.WriteLine($"Hello {name}! Time is {DateTime.Now:HH:mm}");

