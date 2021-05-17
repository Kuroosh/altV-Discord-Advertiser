using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Debug.Core
{
    public class Debug
    {
        private const bool DebugModeEnabled = true;

        public static void CatchExceptions(Exception ex, [CallerMemberName] string functionName = "")
        {
            if (!DebugModeEnabled) return;
            string[] text = { "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", "[EXCEPTION " + functionName + "] " + ex.Message, "[EXCEPTION " + functionName + "] " + ex.StackTrace };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text[0]);
            Console.WriteLine(text[1]);
            Console.WriteLine(text[2]);
            Console.WriteLine(text[0]);
            Console.ResetColor();
        }
    }
}
