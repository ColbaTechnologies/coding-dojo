namespace BankOCR;

public class NrRef
{
    public string Ref { get; set; }
    public int Value { get; set; }

    public NrRef(int value, string reference)
    {
        Value = value;
        Ref = reference;
    }
}

public class NumberFinder
{
    public string FindNumber(string[] strings)
    {
        var one = new NrRef(1, "   \n  |\n  |\n");
        var two = new NrRef(2," _ \n _|\n|_ \n");
        var three = new NrRef(3," _ \n _|\n _|\n");
        var four = new NrRef(4,"   \n|_|\n  |\n");
        var five = new NrRef(5," _ \n|_ \n _|\n");
        var six = new NrRef(6," _ \n|_ \n|_|\n");
        var seven = new NrRef(7," _ \n  |\n  |\n");
        var eight = new NrRef(8," _ \n|_|\n|_|\n");
        var nine = new NrRef(9," _ \n|_|\n _|\n");

        var numbersReference = new[] { one, two, three, four, five, six, seven, eight, nine};
        
        var s = "";
        foreach (var VARIABLE in strings)
        {
            var sffwfw = numbersReference.Select(x =>
            {
                if (x.Ref == VARIABLE) return x.Value;
                return 0;
            });
            
            if (VARIABLE == two.Ref)
            {
                s += two.Value;
            }
            
            if (VARIABLE == three.Ref)
            {
                s += three.Value;
            }
            
            if (VARIABLE == four.Ref)
            {
                s += four.Value;
            }
            
            if (VARIABLE == five.Ref)
            {
                s += five.Value;
            }
            
            if (VARIABLE == six.Ref)
            {
                s += six.Value;
            }
            
            if (VARIABLE == seven.Ref)
            {
                s += seven.Value;
            }
            
            if (VARIABLE == eight.Ref)
            {
                s += eight.Value;
            }
            
            if (VARIABLE == nine.Ref)
            {
                s += nine.Value;
            }
        }

        return s;
    }
}