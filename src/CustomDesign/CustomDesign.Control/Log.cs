using System.IO;

namespace CustomDesign.Control
{
    public static class Log
    {
#if NETCOREAPP
static string Prefix = "NET5.0: ";
#else
        static string Prefix = "net462: ";
#endif


        public static void Write(string msg)
        {
            using (var file = File.AppendText("c:\\Temp\\AR-24749\\log.txt"))
                file.WriteLine(Prefix + msg);
        }
    }
}
