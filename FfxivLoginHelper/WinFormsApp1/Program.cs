using System.Diagnostics;

namespace WinFormsApp1
{
    public class Program
    {
        /// <summary>
        /// Enter the filepath for the launcher here. it should look something 
        /// like "C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\boot\ffxivboot.exe"
        /// </summary>
        public static string _filePath = @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\boot\ffxivboot.exe";

        /// <summary>
        /// Enter your password here. People, for the love of god I beg you, 
        /// DO NOT save your password in this file and then share the file 
        /// for everyone to see.
        /// </summary>
        public static string _password = @"Enter password in between these quotes";

        static void Main()
        {
            Execute(_filePath, _password);
        }

        public static void Execute(string filePath, string password)
        {
            var process = new Process();
            process.StartInfo.FileName = filePath;
            process.StartInfo.Arguments = "-v -s -a";
            process.Start();
            process.Close();

            /// </summary>
            /// You may need to increase this delay based on how long your computer takes to
            /// load the launcher fully. Currently, it's set to 10 seconds (1000 = 1 second)
            /// </summary>
            Thread.Sleep(10000);

            SendKeys.SendWait(_password);
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{ENTER}");

            /// </summary>
            /// You may need to increase this delay based on how long your launcher takes to
            /// transition from the login page to the "Play" page. Currently, it's set to 5 seconds (1000 = 1 second)
            /// </summary>
            Thread.Sleep(5000);

            SendKeys.SendWait("{ENTER}");

            /// </summary>
            /// This second "{ENTER}" action handles getting passed any notices that may pop-up
            /// after hitting play.
            /// 
            /// You may need to increase this delay based on how long your launcher takes to
            /// transition from the "Play" page to the notice page. Currently, it's set to 2.5 seconds (1000 = 1 second)
            /// </summary>
            Thread.Sleep(2500);

            SendKeys.SendWait("{ENTER}");
        }   
    }
}