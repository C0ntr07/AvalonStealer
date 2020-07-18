using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200020E RID: 526
	internal class Class_398 : Class_397, Class_387, Class_393
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00050487 File Offset: 0x0004E687
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0005048F File Offset: 0x0004E68F
		internal new XDeclaration prop_0 { get; private set; }

		// Token: 0x06000FDE RID: 4062 RVA: 0x00050498 File Offset: 0x0004E698
		public Class_398(XDeclaration arg_0) : base(null)
		{
			this.prop_0 = arg_0;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000504A8 File Offset: 0x0004E6A8
		public virtual XmlNodeType prop_1
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000504AC File Offset: 0x0004E6AC
		public new string prop_2
		{
			get
			{
				return this.prop_0.Version;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000504B9 File Offset: 0x0004E6B9
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x000504C6 File Offset: 0x0004E6C6
		public new string prop_3
		{
			get
			{
				return this.prop_0.Encoding;
			}
			set
			{
				this.prop_0.Encoding = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000504D4 File Offset: 0x0004E6D4
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000504E1 File Offset: 0x0004E6E1
		public new string prop_4
		{
			get
			{
				return this.prop_0.Standalone;
			}
			set
			{
				this.prop_0.Standalone = value;
			}
		}

		// Token: 0x04000967 RID: 2407
		[CompilerGenerated]
		private XDeclaration field_0;
	}
}
