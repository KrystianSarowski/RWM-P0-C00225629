

public class XOR21Filter 
{
    public static int xor21(int x)
    {
        return x ^ 21;
    }

    public static int[] xor21s(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xor21(xs[i]);
        }
        return result;
    }
}
