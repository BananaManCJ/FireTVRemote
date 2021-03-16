using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB_Lib
{
    public class ADBCommand
    {
        public static void ExecuteAdbCommand(string adbCommand) {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo("adb", adbCommand)
            {
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();
            p.WaitForExit();
        }

        private static void adbCommand(string adbCommand) {
            ExecuteAdbCommand(adbCommand);
        }

        public static void ConnectServer(string ipAddress) {
            ExecuteAdbCommand("kill-server");
            ExecuteAdbCommand("start-server");
            ExecuteAdbCommand("connect " + ipAddress);
        }

        public static void DisconnectServer() {
            ExecuteAdbCommand("disconnect");
            ExecuteAdbCommand("kill-server");
        }

        public static void ADBActionKey(ConsoleKey key) {
            switch (key) {
                case ConsoleKey.UpArrow:
                    adbCommand("shell input keyevent KEYCODE_DPAD_UP");
                    break;
                case ConsoleKey.DownArrow:
                    adbCommand("shell input keyevent KEYCODE_DPAD_DOWN");
                    break;
                case ConsoleKey.LeftArrow:
                    adbCommand("shell input keyevent KEYCODE_DPAD_LEFT");
                    break;
                case ConsoleKey.RightArrow:
                    adbCommand("shell input keyevent KEYCODE_DPAD_RIGHT");
                    break;
                case ConsoleKey.Escape:
                    adbCommand("shell input keyevent 3");
                    break;
                case ConsoleKey.Backspace:
                    adbCommand("shell input keyevent KEYCODE_BACK");
                    break;
                case ConsoleKey.Tab:
                    adbCommand("shell input keyevent KEYCODE_MENU");
                    break;
                case ConsoleKey.MediaPrevious:
                    adbCommand("shell input keyevent KEYCODE_MEDIA_REWIND");
                    break;
                case ConsoleKey.MediaNext:
                    adbCommand("shell input keyevent KEYCODE_MEDIA_FAST_FORWARD");
                    break;
                case ConsoleKey.MediaPlay:
                    adbCommand("shell input keyevent KEYCODE_MEDIA_PLAY_PAUSE");
                    break;
                case ConsoleKey.Enter:
                    adbCommand("shell input keyevent 66");
                    break;
                case ConsoleKey.A:
                    adbCommand("shell input keyevent 29");
                    break;
                case ConsoleKey.B:
                    adbCommand("shell input keyevent 30");
                    break;
                case ConsoleKey.C:
                    adbCommand("shell input keyevent 31");
                    break;
                case ConsoleKey.D:
                    adbCommand("shell input keyevent 32");
                    break;
                case ConsoleKey.E:
                    adbCommand("shell input keyevent 33");
                    break;
                case ConsoleKey.F:
                    adbCommand("shell input keyevent 34");
                    break;
                case ConsoleKey.G:
                    adbCommand("shell input keyevent 35");
                    break;
                case ConsoleKey.H:
                    adbCommand("shell input keyevent 36");
                    break;
                case ConsoleKey.I:
                    adbCommand("shell input keyevent 37");
                    break;
                case ConsoleKey.J:
                    adbCommand("shell input keyevent 38");
                    break;
                case ConsoleKey.K:
                    adbCommand("shell input keyevent 39");
                    break;
                case ConsoleKey.L:
                    adbCommand("shell input keyevent 40");
                    break;
                case ConsoleKey.M:
                    adbCommand("shell input keyevent 41");
                    break;
                case ConsoleKey.N:
                    adbCommand("shell input keyevent 42");
                    break;
                case ConsoleKey.O:
                    adbCommand("shell input keyevent 43");
                    break;
                case ConsoleKey.P:
                    adbCommand("shell input keyevent 44");
                    break;
                case ConsoleKey.Q:
                    adbCommand("shell input keyevent 45");
                    break;
                case ConsoleKey.R:
                    adbCommand("shell input keyevent 46");
                    break;
                case ConsoleKey.S:
                    adbCommand("shell input keyevent 47");
                    break;
                case ConsoleKey.T:
                    adbCommand("shell input keyevent 48");
                    break;
                case ConsoleKey.U:
                    adbCommand("shell input keyevent 49");
                    break;
                case ConsoleKey.V:
                    adbCommand("shell input keyevent 50");
                    break;
                case ConsoleKey.W:
                    adbCommand("shell input keyevent 51");
                    break;
                case ConsoleKey.X:
                    adbCommand("shell input keyevent 52");
                    break;
                case ConsoleKey.Y:
                    adbCommand("shell input keyevent 53");
                    break;
                case ConsoleKey.Z:
                    adbCommand("shell input keyevent 54");
                    break;
                case ConsoleKey.D0:
                    adbCommand("shell input keyevent 7");
                    break;
                case ConsoleKey.D1:
                    adbCommand("shell input keyevent 8");
                    break;
                case ConsoleKey.D2:
                    adbCommand("shell input keyevent 9");
                    break;
                case ConsoleKey.D3:
                    adbCommand("shell input keyevent 10");
                    break;
                case ConsoleKey.D4:
                    adbCommand("shell input keyevent 11");
                    break;
                case ConsoleKey.D5:
                    adbCommand("shell input keyevent 12");
                    break;
                case ConsoleKey.D6:
                    adbCommand("shell input keyevent 13");
                    break;
                case ConsoleKey.D7:
                    adbCommand("shell input keyevent 14");
                    break;
                case ConsoleKey.D8:
                    adbCommand("shell input keyevent 15");
                    break;
                case ConsoleKey.D9:
                    adbCommand("shell input keyevent 16");
                    break;
                case ConsoleKey.OemPeriod:
                    adbCommand("shell input keyevent 56");
                    break;
                case ConsoleKey.OemComma:
                    adbCommand("shell input keyevent 55");
                    break;
                case ConsoleKey.F5:
                default:    
                    break;
            }
        }
    }
}
