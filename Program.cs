// Chandler Wixom, 2/26/2025, Lab 5 Piglatin / Encoder 
// 1) Pig Latin rules: If your word starts with a consonant, or a consonant cluster, move the cluster to the end and add AY, so Frank becomes ankfray. 
// If your word begins with a vowel and ends with a vowel just add 'way', so apple becomes appleway
using System.IO.Compression;
using System.Reflection.Metadata;

Console.WriteLine("This program will convert anything you type into Piglatin and encrypt it aswell");
Console.Write("Please enter your message: ");

string userMessage = Console.ReadLine();
Console.Write("In pig latin that's: ");
string[] messageSplit = userMessage.Split(' ');
string vowels = "aeiou";
string punctuation = ",./:!;";

for (int i = 0; i < messageSplit.Length; i++)
{
    string end = "";
    string start = "";
    string wordPunctuation = "";
    bool wasVowel = false;
    bool startVowel = false;
    for (int j = 0; j < messageSplit[i].Length; j++)
    {
        if (punctuation.Contains(messageSplit[i][j]))
        {
            wordPunctuation = wordPunctuation + messageSplit[i][j];
            break;
        }
        else if (!wasVowel && !vowels.Contains(messageSplit[i][j]))
        {
            end = end + messageSplit[i][j];
        }
        else
        {
            wasVowel = true;
            if (j == 0)
            {
                startVowel = true;
            }
        }
        if (wasVowel)
        {
            start = start + messageSplit[i][j];
        }

    }
    Console.Write(start);
    if (startVowel)
        Console.Write(end + "way");
    else
        Console.Write(end + "ay");

    Console.Write(wordPunctuation + " ");

}
Console.Write("\nWe can encrypt that as: ");
Random rand = new Random();
int offset = rand.Next(1, 26);

for (int i = 0; i < messageSplit.Length; i++)
{
    string tempWord = "";
    for (int j = 0; j < messageSplit[i].Length; j++)
    {
        int temp = messageSplit[i][j] + 1;  // rounds over if its past z

        temp = ((temp - 97) % 26) + 97;

        tempWord = tempWord + (char)temp;
    }
    Console.Write(tempWord + " ");
}


