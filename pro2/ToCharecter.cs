public static class ToCharecter
{
    public static string ToChar(this int number)
    {
        switch (number)
        {
            case 1:
                return "one";
            case 2:

                return "two";
            case 3:
                return "three";
            case 4:

                return "four";
            case 5:
                return "five";

                default:
                return "Invalid Number";
        }
    }
    
}