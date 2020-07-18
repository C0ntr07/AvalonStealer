using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200020C RID: 524
	internal class Class_396 : Class_388, Class_387, Class_395
	{
		// Token: 0x06000FCB RID: 4043 RVA: 0x00050411 File Offset: 0x0004E611
		public Class_396(XmlDocumentType arg_0) : base(arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00050421 File Offset: 0x0004E621
		public new string prop_0
		{
			get
			{
				return this.field_0.Name;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0005042E File Offset: 0x0004E62E
		public new string prop_1
		{
			get
			{
				return this.field_0.SystemId;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0005043B File Offset: 0x0004E63B
		public new string prop_2
		{
			get
			{
				return this.field_0.PublicId;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00050448 File Offset: 0x0004E648
		public new string prop_3
		{
			get
			{
				return this.field_0.InternalSubset;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00050455 File Offset: 0x0004E655
		public virtual string prop_4
		{
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x04000965 RID: 2405
		private readonly XmlDocumentType field_0;
	}
}
