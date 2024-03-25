namespace cw14_2bapp;

public class NWD
{
    public int? A { get; set; }
    public int? B { get; set; }
    public NWD(int? a, int? b)
    {
        A = a;
        B = b;
    }
    public int? Result { get; set; }
    public int? NWDIter(int? a, int? b)
    {
        if (a != null && b != null)
        {
            int? temp = a;
            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            Result = a;
            return Result;
        }
        Result = 0;
        return Result;

    }

}
