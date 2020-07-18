using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000051 RID: 81
	internal class Class_58
	{
		// Token: 0x06000166 RID: 358 RVA: 0x0000DFDB File Offset: 0x0000C1DB
		public static string kmethod_157(object obje_0)
		{
			return Path.GetExtension((string)obje_0);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000DFEF File Offset: 0x0000C1EF
		public static string lmethod_158(object obje_0)
		{
			return Path.GetFileName((string)obje_0);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000E003 File Offset: 0x0000C203
		public static string pmethod_159(object obje_0)
		{
			return Path.GetDirectoryName((string)obje_0);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000E017 File Offset: 0x0000C217
		public static string[] smethod_160(object obje_0, object obje_1, object obje_2)
		{
			return Directory.GetFiles((string)obje_0, (string)obje_1, (SearchOption)obje_2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000E037 File Offset: 0x0000C237
		public static bool xmethod_161(object obje_0)
		{
			return File.Exists((string)obje_0);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000E04B File Offset: 0x0000C24B
		public static bool tmethod_162(object obje_0)
		{
			return Directory.Exists((string)obje_0);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000E060 File Offset: 0x0000C260
		public static void gmethod_163(object obje_0)
		{
			try
			{
				Directory.CreateDirectory((string)obje_0);
			}
			catch
			{
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000E09C File Offset: 0x0000C29C
		public static void cmethod_164(object obje_0)
		{
			try
			{
				Directory.Delete((string)obje_0);
			}
			catch
			{
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		public static void vmethod_165(object obje_0)
		{
			try
			{
				File.Delete((string)obje_0);
			}
			catch
			{
			}
		}
	}
}
