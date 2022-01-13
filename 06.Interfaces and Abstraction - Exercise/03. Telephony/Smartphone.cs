namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        
        public string Call(string number)
        {
            return $"Calling... {number}";
        }

        public string Browsing(string website)
        {
            return $"Browsing: {website}!";
        }
    }
}
