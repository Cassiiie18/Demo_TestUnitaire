namespace MyTools
{
    public static class Extensions
    {
        public static bool IsPrime(this int n)
        {
            if (n < 0)
                throw new InvalidOperationException($"This number '{n}' is not valid");

            if (n < 2)
                return false;

            int square = (int)Math.Sqrt(n);

            for (int diviseur = 2;  diviseur <= square; diviseur++)
            {
                if (n % diviseur == 0)
                    return false;
            }

            return true;
        }
    }
}
