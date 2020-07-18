using System;
using System.Security.Principal;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000085 RID: 133
	public static class Class_104
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001449C File Offset: 0x0001269C
		public static bool IsAdmin
		{
			get
			{
				return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000144BD File Offset: 0x000126BD
		public static bool IsWin64
		{
			get
			{
				return Environment.Is64BitOperatingSystem;
			}
		}
	}
}
