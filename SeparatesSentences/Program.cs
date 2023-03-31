using System.Text.RegularExpressions;

string input = "In the beginning, the earth was without form. And void. And then the sun shone upon the sleeping earth. Into this swirling maelstrom of fire air and water, the first stirrings of life appeared.";

string[] sentences = Regex.Split(input, @"(?<=[\.!\?])\s+");

foreach (string sentence in sentences)
{
    Console.WriteLine(sentence);
}

Console.ReadLine();