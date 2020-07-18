using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200020A RID: 522
	internal class Class_394 : Class_388, Class_387, Class_393
	{
		// Token: 0x06000FC1 RID: 4033 RVA: 0x000503BE File Offset: 0x0004E5BE
		public Class_394(XmlDeclaration arg_0) : base(arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000503CE File Offset: 0x0004E5CE
		public new string prop_0
		{
			get
			{
				return this.field_0.Version;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000503DB File Offset: 0x0004E5DB
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000503E8 File Offset: 0x0004E5E8
		public new string prop_1
		{
			get
			{
				return this.field_0.Encoding;
			}
			set
			{
				this.field_0.Encoding = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000503F6 File Offset: 0x0004E5F6
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00050403 File Offset: 0x0004E603
		public new string prop_2
		{
			get
			{
				return this.field_0.Standalone;
			}
			set
			{
				this.field_0.Standalone = value;
			}
		}

		// Token: 0x04000964 RID: 2404
		private readonly XmlDeclaration field_0;
	}
}
