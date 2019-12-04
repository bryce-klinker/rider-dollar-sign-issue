namespace Rider.Issue.Sample
{
    public class Dollars
    {
        public static string Format(double amount)
        {
            return amount.ToString("C");
        }

        public static string Sign()
        {
            return "$";
        }
    }
}
