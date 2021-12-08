using System.Diagnostics;

namespace Program
{

    public class Program
    {
        /// <summary>
        /// Enter the filepath for the launcher here. it should look something 
        /// like "C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\boot\ffxivboot.exe"
        /// </summary>
        public static string _filePath = @"D:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\boot\ffxivboot.exe";
        /// <summary>
        /// Enter your password here. People, I beg you, DO NOT save your password 
        /// in this file and then share the file for everyone to see.
        /// </summary>
        public static string _password = "";

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

            
        }

    }


}