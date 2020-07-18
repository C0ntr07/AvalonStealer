using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200020F RID: 527
	internal class Class_399 : Class_397, Class_387, Class_395
	{
		// Token: 0x06000FE5 RID: 4069 RVA: 0x000504EF File Offset: 0x0004E6EF
		public Class_399(XDocumentType arg_0) : base(arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000504FF File Offset: 0x0004E6FF
		public new string prop_0
		{
			get
			{
				return this.field_0.Name;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0005050C File Offset: 0x0004E70C
		public new string prop_1
		{
			get
			{
				return this.field_0.SystemId;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00050519 File Offset: 0x0004E719
		public new string prop_2
		{
			get
			{
				return this.field_0.PublicId;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00050526 File Offset: 0x0004E726
		public new string prop_3
		{
			get
			{
				return this.field_0.InternalSubset;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00050455 File Offset: 0x0004E655
		public virtual string prop_4
		{
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x04000968 RID: 2408
		private readonly XDocumentType field_0;
	}
}
