using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000B8 RID: 184
	internal abstract class Class_145
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000355 RID: 853 RVA: 0x000167D2 File Offset: 0x000149D2
		// (set) Token: 0x06000356 RID: 854 RVA: 0x000167DA File Offset: 0x000149DA
		internal virtual bool prop_0 { get; set; }

		// Token: 0x06000357 RID: 855
		internal abstract bool xmethod_461(string str_0);

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("SelectorTrace")]
		protected static void tmethod_462(string str_0, params object[] arg_0)
		{
		}

		// Token: 0x06000359 RID: 857
		internal abstract bool gmethod_463(Class_163 arg_0);

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private bool field_0;
	}
}
