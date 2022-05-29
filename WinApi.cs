using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ControllerEmu {
    public class WinApi {
        [DllImport("kernel32.dll")] public static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("user32.dll")] public static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")] public extern static IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)] public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        [DllImport("user32.dll", SetLastError = true)] public static extern bool GetClientRect(IntPtr hwnd, out RECT lpRect);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")] public static extern IntPtr SetWindowsHookEx(int idHook, KeyHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")] public static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyHookData lParam);

        public static string GetWindowTitle(IntPtr hWnd) {
            StringBuilder sbTitle = new StringBuilder(255);
            GetWindowText(hWnd, sbTitle, 255);

            return sbTitle.ToString();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left, Top, Right, Bottom;

            public RECT(int left, int top, int right, int bottom) {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(System.Drawing.Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom) { }

            public RECT(int dimensions) {
                Left = dimensions;
                Top = dimensions;
                Right = dimensions;
                Bottom = dimensions;
            }

            public int X {
                get { return Left; }
                set { Right -= (Left - value); Left = value; }
            }

            public int Y {
                get { return Top; }
                set { Bottom -= (Top - value); Top = value; }
            }

            public int Height {
                get { return Bottom - Top; }
                set { Bottom = value + Top; }
            }

            public int Width {
                get { return Right - Left; }
                set { Right = value + Left; }
            }

            public System.Drawing.Point Location {
                get { return new System.Drawing.Point(Left, Top); }
                set { X = value.X; Y = value.Y; }
            }

            public System.Drawing.Size Size {
                get { return new System.Drawing.Size(Width, Height); }
                set { Width = value.Width; Height = value.Height; }
            }

            public static implicit operator System.Drawing.Rectangle(RECT r) {
                return new System.Drawing.Rectangle(r.Left, r.Top, r.Width, r.Height);
            }

            public static implicit operator RECT(System.Drawing.Rectangle r) {
                return new RECT(r);
            }

            public static bool operator ==(RECT r1, RECT r2) {
                return r1.Equals(r2);
            }

            public static bool operator !=(RECT r1, RECT r2) {
                return !r1.Equals(r2);
            }

            public bool Equals(RECT r) {
                return r.Left == Left && r.Top == Top && r.Right == Right && r.Bottom == Bottom;
            }

            public override bool Equals(object obj) {
                if(obj is RECT)
                    return Equals((RECT)obj);
                else if(obj is System.Drawing.Rectangle)
                    return Equals(new RECT((System.Drawing.Rectangle)obj));
                return false;
            }

            public bool Empty() {
                return Left == 0 && Right == 0 && Top == 0 && Bottom == 0;
            }

            public override int GetHashCode() {
                return ((System.Drawing.Rectangle)this).GetHashCode();
            }

            public override string ToString() {
                return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{{Left={0},Top={1},Right={2},Bottom={3}}}", Left, Top, Right, Bottom);
            }
        }
    }
}
