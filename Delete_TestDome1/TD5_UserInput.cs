using System;
/*
 * Public method void Add(char c) - adds the given character to the current value
Public method string GetValue() - returns the current value
*/
public class TextInput 
{
    private string Value = "";
    public virtual void Add(char c)
    {
        Value += c;
    }
    public virtual string GetValue()
    {
        return Value;
    }
}

public class NumericInput: TextInput
{
    public override void Add(char c)
    {
        if (!Char.IsDigit(c))
        {
            return;
        }
        base.Add(c);
    }
}

public class UserInput
{
    public static void Check(string[] args)
    {
        //TextInput input = new NumericInput();
        //input.Add('1');
        //input.Add('a');
        //input.Add('0');
        //Console.WriteLine(input.GetValue());
    }
}
