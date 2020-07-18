using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000211 RID: 529
	internal class Class_401 : Class_400, Class_387, Class_389
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0005068E File Offset: 0x0004E88E
		private new XDocument prop_0
		{
			get
			{
				return (XDocument)base.prop_0;
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0005069B File Offset: 0x0004E89B
		public Class_401(XDocument arg_0) : base(arg_0)
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000506A4 File Offset: 0x0004E8A4
		public virtual IList<Class_387> prop_1
		{
			get
			{
				IList<Class_387> list = base.prop_1;
				if (this.prop_0.Declaration != null && list[0].prop_0 != XmlNodeType.XmlDeclaration)
				{
					list.Insert(0, new Class_398(this.prop_0.Declaration));
				}
				return list;
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x000506F3 File Offset: 0x0004E8F3
		public Class_387 tmethod_2912(string str_0)
		{
			return new Class_397(new XComment(str_0));
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00050700 File Offset: 0x0004E900
		public Class_387 gmethod_2913(string str_0)
		{
			return new Class_397(new XText(str_0));
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0005070D File Offset: 0x0004E90D
		public Class_387 cmethod_2914(string str_0)
		{
			return new Class_397(new XCData(str_0));
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00050700 File Offset: 0x0004E900
		public Class_387 vmethod_2915(string str_0)
		{
			return new Class_397(new XText(str_0));
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00050700 File Offset: 0x0004E900
		public Class_387 dmethod_2916(string str_0)
		{
			return new Class_397(new XText(str_0));
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0005071A File Offset: 0x0004E91A
		public Class_387 kmethod_2917(string str_0, string str_1, string str_2)
		{
			return new Class_398(new XDeclaration(str_0, str_1, str_2));
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00050729 File Offset: 0x0004E929
		public Class_387 lmethod_2918(string str_0, string str_1, string str_2, string str_3)
		{
			return new Class_399(new XDocumentType(str_0, str_1, str_2, str_3));
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0005073A File Offset: 0x0004E93A
		public Class_387 pmethod_2919(string str_0, string str_1)
		{
			return new Class_404(new XProcessingInstruction(str_0, str_1));
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00050748 File Offset: 0x0004E948
		public Class_391 smethod_2920(string str_0)
		{
			return new Class_406(new XElement(str_0));
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0005075C File Offset: 0x0004E95C
		public Class_391 xmethod_2921(string str_0, string str_1)
		{
			string localName = Class_513.GetLocalName(str_0);
			return new Class_406(new XElement(XName.Get(localName, str_1)));
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00050781 File Offset: 0x0004E981
		public Class_387 tmethod_2922(string str_0, string str_1)
		{
			return new Class_405(new XAttribute(str_0, str_1));
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00050794 File Offset: 0x0004E994
		public Class_387 gmethod_2923(string str_0, string str_1, string str_2)
		{
			string localName = Class_513.GetLocalName(str_0);
			return new Class_405(new XAttribute(XName.Get(localName, str_1), str_2));
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x000507BA File Offset: 0x0004E9BA
		public new Class_391 prop_2
		{
			get
			{
				if (this.prop_0.Root == null)
				{
					return null;
				}
				return new Class_406(this.prop_0.Root);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000507E0 File Offset: 0x0004E9E0
		public virtual Class_387 vmethod_2925(Class_387 arg_0)
		{
			Class_398 class_ = arg_0 as Class_398;
			if (class_ != null)
			{
				this.prop_0.Declaration = class_.prop_0;
				return class_;
			}
			return base.pmethod_2909(arg_0);
		}
	}
}
