// using System.Globalization;

// CultureInfo.CurrentCulture = new CultureInfo("en-US");
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal totalResult = 0;
// string letters = "";

// foreach (var value in values)
// {
//     decimal number = 0;
//     if (decimal.TryParse(value, out number))
//     {
//         totalResult += number;
//     }
//     else
//     {
//         letters += value;
//     }
// }
// Console.WriteLine($"Message: {letters}");
// Console.WriteLine($"Total: {totalResult}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");