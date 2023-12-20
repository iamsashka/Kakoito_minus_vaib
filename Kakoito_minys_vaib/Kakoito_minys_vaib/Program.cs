using Kakoito_minys_vaib;

namespace MyApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Authorization authorization = new Authorization();
            authorization.Authorize();
        }
    }
}
