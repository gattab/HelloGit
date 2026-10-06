// See https://aka.ms/new-console-template for more information
Console.Write("ما اسمك؟ ");
var name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
    name = "صديقي";

Console.WriteLine($"أهلًا {name}! الوقت الآن {DateTime.Now:HH:mm}");