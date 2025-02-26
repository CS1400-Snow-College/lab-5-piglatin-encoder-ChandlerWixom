// Chandler Wixom, 2/26/2025, Lab 5 Piglatin / Encoder 
// 1) Pig Latin rules: If your word starts with a consonant, or a consonant cluster, move the cluster to the end and add AY, so Frank becomes ankfray. 
// If your word begins with a vowel and ends with a vowel just add 'way', so apple becomes appleway
using System.IO.Compression;
using System.Reflection.Metadata;

Console.WriteLine("This program will convert anything you type into Piglatin and encrypt it aswell");
Console.Write("Please enter your message: ");

string userMessage = Console.ReadLine();
string[] messageSplit = userMessage.Split(' ');
string vowels = "aeiou";

for (int i = 0; i < messageSplit.Length; i++)
{
   string end = "";
   string start = "";
   bool wasVowel = false;
   bool startVowel = false;
    for (int j = 0; j < messageSplit[i].Length; j++)
    {
        
        if (!wasVowel && !vowels.Contains(messageSplit[i][j]))
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
    Console.WriteLine(end + "way");
    else
     Console.WriteLine(end + "ay ");
   
}



// for (int i = 0; i < messageSplit.Length; i++)
// {
//     string punctuation = "" ;
//     string voules = "aeiou";
//     string endOfWord = "";
//     string beginingOfWord = "";
//     bool hadVoule = false;
//     bool vouleStart = false;
//     for (int j = 0; j < messageSplit[i].Length; j++)
//     {
        
//         if (".?!".Contains(messageSplit[i][j])) // checks if it is a puncutation
//         {
//             punctuation =  punctuation + messageSplit[i][j];
//             continue;
//         }

//         else if (!voules.Contains(messageSplit[i][j]) && !hadVoule) // checks if it doesnt have a voule in the spot and if it doesnt its added to the word
//         {


//             endOfWord = endOfWord + messageSplit[i][j];
//         }
//         else if (j == 0)
//         {
//             vouleStart = true;
//         }
//         else
//         {
//             hadVoule = true;
//             beginingOfWord = beginingOfWord + messageSplit[i][j];
//         }

//     }
//     pigLatin = pigLatin + beginingOfWord + endOfWord + "ay" + punctuation + " ";
   

// }
// Console.WriteLine($"In pig latin that's: {pigLatin}");