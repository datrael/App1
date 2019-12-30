using System.IO;
namespace WpfApp12
{
    public class FileLogger : Logger
    {
        public override void ReadLogs()
        {
            string order = System.IO.File.ReadAllText(@"c:\opt");
            System.Console.WriteLine("orders.txt = {0}", order);
        }
        public override void Log(string message)
        {
            string[] lines = {"Pierwsza linia loga"};
            System.IO.File.ReadAllText(@"c:\opt\logi.txt");
            System.Console.WriteLine(message);
        }
    }
}
