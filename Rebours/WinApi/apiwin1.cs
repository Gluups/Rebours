using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WinApi
{
	public class apiwin1
	{
		private const int EM_SETRECT = 0xB3;

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
			public RECT(int left, int top, int right, int bottom)
			{
				Left = left;
				Top = top;
				Right = right;
				Bottom = bottom;
			}
		}

		[DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		private static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

		public static void paddingRight(System.Windows.Forms.Control C)
		{
			RECT rc = new RECT(5, 0, C.ClientSize.Width - 5, C.ClientSize.Height);

			SendMessage(C.Handle, EM_SETRECT, 0, ref rc);

		}
	}
}
