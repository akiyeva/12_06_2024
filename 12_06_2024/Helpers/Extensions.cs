namespace _12_06_2024.Helpers
{
    public static class Extensions
    {
        public static bool IsOdd(this int value)
        {
             return (value % 2 == 0);
        }

        public static bool IsEven(this int value)
        {
            return (value % 2 != 0);
        }

        public static bool IsContainsDigit(this string value) //1safsdf
        {

            for(int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i])) { 
                    return true;
                }
            }
            return false;
        }
    }
}
