using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000A8 RID: 168
	[ComVisible(true)]
	public class Class_129 : EventArgs
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0001639D File Offset: 0x0001459D
		internal Class_129()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000163A5 File Offset: 0x000145A5
		internal Class_129(string str_0, Class_128 arg_0)
		{
			this.field_4 = str_0;
			this.field_3 = arg_0;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000163BB File Offset: 0x000145BB
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000163C3 File Offset: 0x000145C3
		public int prop_0
		{
			get
			{
				return this.field_0;
			}
			set
			{
				this.field_0 = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000163CC File Offset: 0x000145CC
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000163D4 File Offset: 0x000145D4
		public Class_163 prop_1
		{
			get
			{
				return this.field_2;
			}
			set
			{
				this.field_2 = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000163DD File Offset: 0x000145DD
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000163E5 File Offset: 0x000145E5
		public bool prop_2
		{
			get
			{
				return this.field_1;
			}
			set
			{
				this.field_1 = (this.field_1 || value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000163FF File Offset: 0x000145FF
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00016407 File Offset: 0x00014607
		public Class_128 prop_3
		{
			get
			{
				return this.field_3;
			}
			set
			{
				this.field_3 = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00016410 File Offset: 0x00014610
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00016418 File Offset: 0x00014618
		public string prop_4
		{
			get
			{
				return this.field_4;
			}
			set
			{
				this.field_4 = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00016421 File Offset: 0x00014621
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00016429 File Offset: 0x00014629
		public long prop_5
		{
			get
			{
				return this.field_5;
			}
			set
			{
				this.field_5 = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00016432 File Offset: 0x00014632
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0001643A File Offset: 0x0001463A
		public long prop_6
		{
			get
			{
				return this.field_6;
			}
			set
			{
				this.field_6 = value;
			}
		}

		// Token: 0x0400020F RID: 527
		private int field_0;

		// Token: 0x04000210 RID: 528
		private bool field_1;

		// Token: 0x04000211 RID: 529
		private Class_163 field_2;

		// Token: 0x04000212 RID: 530
		private Class_128 field_3;

		// Token: 0x04000213 RID: 531
		private string field_4;

		// Token: 0x04000214 RID: 532
		private long field_5;

		// Token: 0x04000215 RID: 533
		private long field_6;
	}
}
