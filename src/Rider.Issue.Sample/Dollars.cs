namespace Rider.Issue.Sample
{
    public class Dollars
    {
        public static string Get(double amount)
        {
            return amount.ToString("C");
        }
    }
}
