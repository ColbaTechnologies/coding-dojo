namespace BankOCR;

internal record NrRef(int Value, string Ref);

public class NumberFinder
{
    private readonly NrRef[] _numbersReference;
    public NumberFinder()
    {
        var zero = new NrRef(0, " _ \n| |\n|_|\n");
        var one = new NrRef(1, "   \n  |\n  |\n");
        var two = new NrRef(2, " _ \n _|\n|_ \n");
        var three = new NrRef(3, " _ \n _|\n _|\n");
        var four = new NrRef(4, "   \n|_|\n  |\n");
        var five = new NrRef(5, " _ \n|_ \n _|\n");
        var six = new NrRef(6, " _ \n|_ \n|_|\n");
        var seven = new NrRef(7, " _ \n  |\n  |\n");
        var eight = new NrRef(8, " _ \n|_|\n|_|\n");
        var nine = new NrRef(9, " _ \n|_|\n _|\n");

        _numbersReference = new[] {zero, one, two, three, four, five, six, seven, eight, nine};
    }

    public string FindNumber(IEnumerable<string> strings)
    {
        var s = "";
        foreach (var possibleNumber in strings)
        {
            var points = _numbersReference.Select(refNr =>
            {
                // TODO: create distance calculator 
                if (refNr.Ref == possibleNumber) return refNr.Value;
                return -1;
            });
            
            var whoCanGetThePoint = points.Where(x => x != -1).ToList();
            if (whoCanGetThePoint.Count is 0)
            {
                s += "?";
            }
            else
            {
                s += whoCanGetThePoint.First();
            }
        }

        return s;
    }
}