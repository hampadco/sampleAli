
public static class multiplication
{
    public static int Multiply(this int[] arr)
    {
        int result = 1;
        foreach (int i in arr)
        {
            result *= i;//result=result*i;
        }
        return result;
    }
    
    
}