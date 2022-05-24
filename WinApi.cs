using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ControllerEmu {
    public class WinApi {
        [DllImport("kernel32.dll")] public static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("user32.dll")] public static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")] public extern static IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")] public static extern IntPtr SetWindowsHookEx(int idHook, KeyHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")] public static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyHookData lParam);

        public static string GetWindowTitle(IntPtr hWnd) {
            StringBuilder sbTitle = new StringBuilder(255);
            GetWindowText(hWnd, sbTitle, 255);

            return sbTitle.ToString();
        }
    }
}
