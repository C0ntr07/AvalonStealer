using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000208 RID: 520
	internal class Class_392 : Class_388, Class_387, Class_391
	{
		// Token: 0x06000FB8 RID: 4024 RVA: 0x00050368 File Offset: 0x0004E568
		public Class_392(XmlElement arg_0) : base(arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00050378 File Offset: 0x0004E578
		public void smethod_2860(Class_387 arg_0)
		{
			Class_388 class_ = (Class_388)arg_0;
			this.field_0.SetAttributeNode((XmlAttribute)class_.prop_0);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000503A3 File Offset: 0x0004E5A3
		public string xmethod_2861(string str_0)
		{
			return this.field_0.GetPrefixOfNamespace(str_0);
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000503B1 File Offset: 0x0004E5B1
		public new bool prop_0
		{
			get
			{
				return this.field_0.IsEmpty;
			}
		}

		// Token: 0x04000963 RID: 2403
		private readonly XmlElement field_0;
	}
}
