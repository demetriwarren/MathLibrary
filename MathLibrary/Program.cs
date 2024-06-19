using MathLib;
using StringLib;

namespace MathConsole;

public class Program
{
    static void Main(string[] args)
    {
        var fact = MathLib.Math.Fact(5);
        Console.WriteLine(fact);

        var mod = MathLib.Math.Mod(8, 3);
        Console.WriteLine($"8 % 3 is {mod}");

        var answer = MathLib.Math.Add(11, 22);
        Console.WriteLine(answer);

        var sl = new StringLibrary();                       //sl = stringline - Creating an instance of StringLibrary from the lib to reference. after this is added make sure "using [namespace]" is added at the top
        var newStr = sl.Concat("Hello, ", "World!");
        Console.WriteLine(newStr);

        var converted = sl.ToUpperEveryOther("aBCdeFG15C!@vwEvrwEVE");
        Console.WriteLine(converted);


        
    }
}
