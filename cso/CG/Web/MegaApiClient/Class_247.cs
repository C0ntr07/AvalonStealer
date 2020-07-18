using System;
using System.IO;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000150 RID: 336
	internal class Class_247 : Class_249
	{
		// Token: 0x06000995 RID: 2453 RVA: 0x0003C27F File Offset: 0x0003A47F
		public Class_247(Stream stream_) : base(stream_, stream_.Length, Class_249.NClass_0.field_2, Class_223.dmethod_1476(), Class_223.dmethod_1476().CopySubArray(8, 0))
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0003C2A0 File Offset: 0x0003A4A0
		public new byte[] prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0003C2A8 File Offset: 0x0003A4A8
		public new byte[] prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0003C2B0 File Offset: 0x0003A4B0
		public new byte[] prop_2
		{
			get
			{
				if (this.field_3 != this.field_2)
				{
					throw new NotSupportedException("Stream must be fully read to obtain computed FileMac");
				}
				return this.field_4;
			}
		}
	}
}
