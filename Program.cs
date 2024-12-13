using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, Advent of Code Day 1");

var InputList = InputParse("TestData.txt");

List<string> Left = new List<string>();
List<string> Right = new List<string>();

foreach (var input in InputList)
{
    Console.WriteLine($"Input is: {input}");

    string leftString = input.Substring(0, 1);
    string rightString = input.Substring(4,1);

    /*Console.WriteLine($"Left string: {leftString}");
    Console.WriteLine($"Right string: {rightString}");
    */

    Left.Add(leftString);
    Right.Add(rightString);
}

Left.Select(int.Parse).ToList();
Right.Select(int.Parse).ToList();

Left.Sort();
Right.Sort();


int sumOfDistance = 0;

sumOfDistance = Left.Zip(Right,(a, b) => Math.Abs((a - b)));

foreach(var leftInput in Left)
{
    foreach(var rightInput in Right)
    {
        sumOfDistance += Math.Abs((Int32.Parse(leftInput)-Int32.Parse(rightInput)));
        Console.WriteLine($"Left input: {leftInput}, Right input: {rightInput}, Running sum: {sumOfDistance}");
        break;
    }
}



/*foreach(var num in Left)
{
    Console.WriteLine(num);
}
*/
Console.WriteLine(sumOfDistance);













List<string> InputParse(string FileName)
{
    return System.IO.File.ReadAllLines(FileName).ToList();
}
