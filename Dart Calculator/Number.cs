namespace Dart_Calculator;

public class Number
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Number(string name, int value)
    {
        Name = name;
        Value = value;
    }
}