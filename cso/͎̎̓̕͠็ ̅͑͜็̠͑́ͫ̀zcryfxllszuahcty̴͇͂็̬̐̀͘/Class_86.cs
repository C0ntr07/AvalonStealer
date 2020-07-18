using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000071 RID: 113
	internal class Class_86
	{
		// Token: 0x06000209 RID: 521 RVA: 0x000113A0 File Offset: 0x0000F5A0
		public static string smethod_250()
		{
			string text = "acegikmoqsuwyBDFHJLNPRTVXZ";
			string text2 = "";
			Random random = new Random();
			int num = random.Next(0, text.Length);
			for (int i = 0; i < num; i++)
			{
				text2 += text[random.Next(10, text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00011411 File Offset: 0x0000F611
		public static int xmethod_251()
		{
			return new Random().Next(11, 99);
		}
	}
}
