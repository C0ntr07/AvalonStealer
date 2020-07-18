using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000077 RID: 119
	internal class Class_92
	{
		// Token: 0x06000218 RID: 536 RVA: 0x000117BC File Offset: 0x0000F9BC
		public static void kmethod_257()
		{
			for (;;)
			{
				Class_92.lmethod_258();
				if (Class_107.tmethod_382() == 1)
				{
					Class_92.smethod_260();
				}
				if (Class_109.kmethod_407() == 1)
				{
					Class_92.smethod_260();
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000117FA File Offset: 0x0000F9FA
		public static void lmethod_258()
		{
			if (Class_92.xmethod_261(true) != 0)
			{
				Class_92.smethod_260();
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00011818 File Offset: 0x0000FA18
		public static bool pmethod_259()
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				Thread.Sleep(10);
				if (DateTime.Now.Ticks - ticks < 10L)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00011884 File Offset: 0x0000FA84
		public static void smethod_260()
		{
			if (Class_84.\u032B\u0354\u034E\u032F\u0366\u0368\u0307\u033C\u0E47\u0333\u0345\u0353\u0020\u0352\u0345\u0325zdylgnkylhhanena\u0332\u0311\u031A\u0367\u0357\u0352\u036B\u0356\u0332\u0361\u0364\u035C\u0020\u0349\u0308\u0304eupkpbthvweozwih)
			{
				Class_81.smethod_240();
				Environment.FailFast("fuck you");
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000118AC File Offset: 0x0000FAAC
		private static int xmethod_261(bool bool_0)
		{
			int result = 0;
			if (Class_92.field_0.Count == 0 && Class_92.field_1.Count == 0)
			{
				Class_92.tmethod_262();
			}
			foreach (Process process in Process.GetProcesses())
			{
				if (Class_92.field_0.Contains(process.ProcessName) || Class_92.field_1.Contains(process.MainWindowTitle))
				{
					result = 1;
					if (bool_0)
					{
						try
						{
							process.Kill();
						}
						catch
						{
						}
					}
					if (Class_84.\u032B\u0354\u034E\u032F\u0366\u0368\u0307\u033C\u0E47\u0333\u0345\u0353\u0020\u0352\u0345\u0325zdylgnkylhhanena\u0332\u0311\u031A\u0367\u0357\u0352\u036B\u0356\u0332\u0361\u0364\u035C\u0020\u0349\u0308\u0304eupkpbthvweozwih)
					{
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011968 File Offset: 0x0000FB68
		private static int tmethod_262()
		{
			if (Class_92.field_0.Count > 0 && Class_92.field_1.Count > 0)
			{
				return 1;
			}
			Class_92.field_0.Add("ollydbg");
			Class_92.field_0.Add("ida");
			Class_92.field_0.Add("ida64");
			Class_92.field_0.Add("idag");
			Class_92.field_0.Add("idag64");
			Class_92.field_0.Add("idaw");
			Class_92.field_0.Add("idaw64");
			Class_92.field_0.Add("idaq");
			Class_92.field_0.Add("idaq64");
			Class_92.field_0.Add("idau");
			Class_92.field_0.Add("idau64");
			Class_92.field_0.Add("scylla");
			Class_92.field_0.Add("scylla_x64");
			Class_92.field_0.Add("scylla_x86");
			Class_92.field_0.Add("protection_id");
			Class_92.field_0.Add("x64dbg");
			Class_92.field_0.Add("x32dbg");
			Class_92.field_0.Add("windbg");
			Class_92.field_0.Add("reshacker");
			Class_92.field_0.Add("ImportREC");
			Class_92.field_0.Add("IMMUNITYDEBUGGER");
			Class_92.field_0.Add("MegaDumper");
			Class_92.field_0.Add("4fr33");
			Class_92.field_0.Add("HTTPAnalyzerStdV7");
			Class_92.field_0.Add("ProcessHacker");
			Class_92.field_0.Add("ExtremeDumper");
			Class_92.field_0.Add("dnSpy");
			Class_92.field_0.Add("dnSpy-x86");
			Class_92.field_0.Add("netstat");
			Class_92.field_0.Add("netmon");
			Class_92.field_0.Add("tcpview");
			Class_92.field_0.Add("filemon");
			Class_92.field_0.Add("regmon");
			Class_92.field_1.Add("charles");
			Class_92.field_1.Add("wpe pro");
			Class_92.field_1.Add("OLLYDBG");
			Class_92.field_1.Add("anvir");
			Class_92.field_1.Add("fiddler");
			Class_92.field_1.Add("effetech http sniffer");
			Class_92.field_1.Add("firesheep");
			Class_92.field_1.Add("IEWatch");
			Class_92.field_1.Add("dumpcap");
			Class_92.field_1.Add("wireshark");
			Class_92.field_1.Add("ida");
			Class_92.field_1.Add("disassembly");
			Class_92.field_1.Add("scylla");
			Class_92.field_1.Add("Debug");
			Class_92.field_1.Add("[CPU");
			Class_92.field_1.Add("Immunity");
			Class_92.field_1.Add("WinDbg");
			Class_92.field_1.Add("x32dbg");
			Class_92.field_1.Add("x64dbg");
			Class_92.field_1.Add("Import reconstructor");
			Class_92.field_1.Add("MegaDumper");
			Class_92.field_1.Add("MegaDumper 1.0 by CodeCracker / SnD");
			return 0;
		}

		// Token: 0x04000173 RID: 371
		private static HashSet<string> field_0 = new HashSet<string>();

		// Token: 0x04000174 RID: 372
		private static HashSet<string> field_1 = new HashSet<string>();
	}
}
