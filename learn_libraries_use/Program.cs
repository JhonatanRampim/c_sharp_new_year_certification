/*
    This code reverse string and count how many 'o' appears in the text.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();

Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");