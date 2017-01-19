namespace TestSuite.CrackingTheCode.ReadThrough.BigO
{
    public class SumOfDigits
    {
        public int BruteForce(int n)
        {
            var result = 0;

            var s = n.ToString();
            foreach(var c in s)
            {
                var a = int.Parse(c.ToString());
                result += a;
            }

            return result;
        }

        public int Optimized(int n)
        {
            var result = 0;

            do
            {
                result += n % 10;
                n /= 10;
            } while (n > 0);

            return result;
        }
    }
}
