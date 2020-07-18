using System;
using System.IO;
using System.Text;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x020000E2 RID: 226
	internal class Class_178
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x000266AC File Offset: 0x000248AC
		public Class_178(object obje_0)
		{
			this.field_0 = (obje_0 as Class_168);
			this.field_1 = (obje_0 as Class_177);
			this.field_2 = (obje_0 as Class_176);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000266D8 File Offset: 0x000248D8
		public Class_168 prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000266E0 File Offset: 0x000248E0
		public Class_177 prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000266E8 File Offset: 0x000248E8
		public string prop_2
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_8;
				}
				if (this.field_2 != null)
				{
					throw new NotSupportedException();
				}
				return this.field_1.prop_19;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0002671D File Offset: 0x0002491D
		public string prop_3
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.field_16;
				}
				if (this.field_2 != null)
				{
					return this.field_2.field_8;
				}
				return this.field_1.field_2;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00026758 File Offset: 0x00024958
		public Class_169 prop_4
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.field_45;
				}
				if (this.field_2 != null)
				{
					throw new NotSupportedException();
				}
				return this.field_1.field_6;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0002678D File Offset: 0x0002498D
		public int prop_5
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_4;
				}
				if (this.field_2 != null)
				{
					throw new NotSupportedException();
				}
				return 0;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000267B8 File Offset: 0x000249B8
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000267E9 File Offset: 0x000249E9
		public Class_199 prop_6
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.field_42;
				}
				if (this.field_2 != null)
				{
					return null;
				}
				return this.field_1.field_23;
			}
			set
			{
				if (this.field_0 != null)
				{
					this.field_0.field_42 = value;
					return;
				}
				if (this.field_1 != null)
				{
					this.field_1.field_23 = value;
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0002681A File Offset: 0x00024A1A
		public long prop_7
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_34;
				}
				return this.field_1.prop_16;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0002683E File Offset: 0x00024A3E
		public int prop_8
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_35;
				}
				return this.field_1.prop_17;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00026862 File Offset: 0x00024A62
		public int prop_9
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_5;
				}
				if (this.field_2 != null)
				{
					return this.field_2.prop_1;
				}
				return this.field_1.prop_2;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0002689D File Offset: 0x00024A9D
		public Class_203 prop_10
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_7;
				}
				return this.field_1.prop_3;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x000268C1 File Offset: 0x00024AC1
		public Class_169 prop_11
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_17;
				}
				return this.field_1.prop_8;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x000268E5 File Offset: 0x00024AE5
		public Encoding prop_12
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_22;
				}
				if (this.field_1 != null)
				{
					return this.field_1.prop_13;
				}
				return null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00026916 File Offset: 0x00024B16
		public Encoding prop_13
		{
			get
			{
				if (this.field_0 != null)
				{
					return Class_168.prop_24;
				}
				if (this.field_1 != null)
				{
					return Class_177.prop_15;
				}
				return null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002693B File Offset: 0x00024B3B
		public Class_170 prop_14
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_23;
				}
				if (this.field_1 != null)
				{
					return this.field_1.prop_14;
				}
				return Class_170.Default;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0002696C File Offset: 0x00024B6C
		public Stream prop_15
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0.prop_44;
				}
				return this.field_2.prop_3;
			}
		}

		// Token: 0x04000394 RID: 916
		private Class_168 field_0;

		// Token: 0x04000395 RID: 917
		private Class_177 field_1;

		// Token: 0x04000396 RID: 918
		private Class_176 field_2;
	}
}
