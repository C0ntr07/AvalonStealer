using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000206 RID: 518
	internal class Class_390 : Class_388, Class_387, Class_389
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x0005021F File Offset: 0x0004E41F
		public Class_390(XmlDocument arg_0) : base(arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0005022F File Offset: 0x0004E42F
		public Class_387 cmethod_2844(string str_0)
		{
			return new Class_388(this.field_0.CreateComment(str_0));
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00050242 File Offset: 0x0004E442
		public Class_387 vmethod_2845(string str_0)
		{
			return new Class_388(this.field_0.CreateTextNode(str_0));
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00050255 File Offset: 0x0004E455
		public Class_387 dmethod_2846(string str_0)
		{
			return new Class_388(this.field_0.CreateCDataSection(str_0));
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00050268 File Offset: 0x0004E468
		public Class_387 kmethod_2847(string str_0)
		{
			return new Class_388(this.field_0.CreateWhitespace(str_0));
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0005027B File Offset: 0x0004E47B
		public Class_387 lmethod_2848(string str_0)
		{
			return new Class_388(this.field_0.CreateSignificantWhitespace(str_0));
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0005028E File Offset: 0x0004E48E
		public Class_387 pmethod_2849(string str_0, string str_1, string str_2)
		{
			return new Class_394(this.field_0.CreateXmlDeclaration(str_0, str_1, str_2));
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000502A3 File Offset: 0x0004E4A3
		public Class_387 smethod_2850(string str_0, string str_1, string str_2, string str_3)
		{
			return new Class_396(this.field_0.CreateDocumentType(str_0, str_1, str_2, null));
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000502B9 File Offset: 0x0004E4B9
		public Class_387 xmethod_2851(string str_0, string str_1)
		{
			return new Class_388(this.field_0.CreateProcessingInstruction(str_0, str_1));
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000502CD File Offset: 0x0004E4CD
		public Class_391 tmethod_2852(string str_0)
		{
			return new Class_392(this.field_0.CreateElement(str_0));
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000502E0 File Offset: 0x0004E4E0
		public Class_391 gmethod_2853(string str_0, string str_1)
		{
			return new Class_392(this.field_0.CreateElement(str_0, str_1));
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000502F4 File Offset: 0x0004E4F4
		public Class_387 cmethod_2854(string str_0, string str_1)
		{
			return new Class_388(this.field_0.CreateAttribute(str_0))
			{
				prop_6 = str_1
			};
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0005031C File Offset: 0x0004E51C
		public Class_387 vmethod_2855(string str_0, string str_1, string str_2)
		{
			return new Class_388(this.field_0.CreateAttribute(str_0, str_1))
			{
				prop_6 = str_2
			};
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00050344 File Offset: 0x0004E544
		public new Class_391 prop_0
		{
			get
			{
				if (this.field_0.DocumentElement == null)
				{
					return null;
				}
				return new Class_392(this.field_0.DocumentElement);
			}
		}

		// Token: 0x04000962 RID: 2402
		private readonly XmlDocument field_0;
	}
}
