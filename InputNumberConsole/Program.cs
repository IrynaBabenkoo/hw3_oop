Console.Write("Введіть ціле число: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
    Console.WriteLine($"Ви ввели число {number}");
else
    Console.WriteLine("Помилка: потрібно ввести саме ціле число.");

Console.ReadLine();

