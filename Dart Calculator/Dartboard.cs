using System.Diagnostics.CodeAnalysis;

namespace Dart_Calculator;

public class Dartboard
{
    public List<Number> PossibleNumberList;

    public Dartboard()
    {
        PossibleNumberList = new List<Number>
        {
            new("Single 1", 1),
            new("Single 2", 2),
            new("Single 3", 3),
            new("Single 4", 4),
            new("Single 5", 5),
            new("Single 6", 6),
            new("Single 7", 7),
            new("Single 8", 8),
            new("Single 9", 9),
            new("Single 10", 10),
            new("Single 11", 11),
            new("Single 12", 12),
            new("Single 13", 13),
            new("Single 14", 14),
            new("Single 15", 15),
            new("Single 16", 16),
            new("Single 17", 17),
            new("Single 18", 18),
            new("Single 19", 19),
            new("Single 20", 20),
            new("Double 1", 2),
            new("Double 2", 4),
            new("Double 3", 6),
            new("Double 4", 8),
            new("Double 5", 10),
            new("Double 6", 12),
            new("Double 7", 14),
            new("Double 8", 16),
            new("Double 9", 18),
            new("Double 10", 20),
            new("Double 11", 22),
            new("Double 12", 24),
            new("Double 13", 26),
            new("Double 14", 28),
            new("Double 15", 30),
            new("Double 16", 32),
            new("Double 17", 34),
            new("Double 18", 36),
            new("Double 19", 38),
            new("Double 20", 40),
            new("Triple 1", 3),
            new("Triple 2", 6),
            new("Triple 3", 9),
            new("Triple 4", 12),
            new("Triple 5", 15),
            new("Triple 6", 18),
            new("Triple 7", 21),
            new("Triple 8", 24),
            new("Triple 9", 27),
            new("Triple 10", 30),
            new("Triple 11", 33),
            new("Triple 12", 36),
            new("Triple 13", 39),
            new("Triple 14", 42),
            new("Triple 15", 45),
            new("Triple 16", 48),
            new("Triple 17", 51),
            new("Triple 18", 54),
            new("Triple 19", 57),
            new("Triple 20", 60),
            new("Bullseye", 50),
            new("Outer Bull", 25)
        };
    }

    public int random(int min, int max)
    {
        Random random = new Random();
        int rnd = random.Next(min, max);
        return rnd;
    }

    public int calculator(int first, int second, int third)
    {
        int sum = first + second + third;
        return sum;
    }
}