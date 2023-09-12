using OS_OPG.Codes;
using OS_OPG.Interfaces;

namespace OS_OPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlatformID os = Environment.OSVersion.Platform;

            Windows windows = new Windows();
            Linux linux= new Linux();

            if (os == PlatformID.Win32NT)
            {
                Console.WriteLine(windows.UserOS());
            } 
            else if (os == PlatformID.Unix)
            {
                Console.WriteLine(linux.UserOS());
            }
            else
            {
                Console.WriteLine("MACOS");
            }
        }
    }
}