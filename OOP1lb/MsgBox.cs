using System.Runtime.InteropServices;

namespace OOP1lb
{
    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);
    }
}

