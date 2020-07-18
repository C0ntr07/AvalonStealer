using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000204 RID: 516
	internal class Class_388 : Class_387
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x00050077 File Offset: 0x0004E277
		public Class_388(XmlNode arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00050086 File Offset: 0x0004E286
		public object prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0005008E File Offset: 0x0004E28E
		public XmlNodeType prop_1
		{
			get
			{
				return this.field_0.NodeType;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x0005009B File Offset: 0x0004E29B
		public virtual string prop_2
		{
			get
			{
				return this.field_0.LocalName;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x000500A8 File Offset: 0x0004E2A8
		public IList<Class_387> prop_3
		{
			get
			{
				if (this.field_1 == null)
				{
					this.field_1 = this.field_0.ChildNodes.Cast<XmlNode>().Select(new Func<XmlNode, Class_387>(Class_388.cmethod_2824)).ToList<Class_387>();
				}
				return this.field_1;
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000500E8 File Offset: 0x0004E2E8
		internal static Class_387 cmethod_2824(XmlNode arg_0)
		{
			XmlNodeType nodeType = arg_0.NodeType;
			if (nodeType == XmlNodeType.Element)
			{
				return new Class_392((XmlElement)arg_0);
			}
			if (nodeType == XmlNodeType.DocumentType)
			{
				return new Class_396((XmlDocumentType)arg_0);
			}
			if (nodeType != XmlNodeType.XmlDeclaration)
			{
				return new Class_388(arg_0);
			}
			return new Class_394((XmlDeclaration)arg_0);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00050142 File Offset: 0x0004E342
		public IList<Class_387> prop_4
		{
			get
			{
				if (this.field_0.Attributes == null)
				{
					return null;
				}
				return this.field_0.Attributes.Cast<XmlAttribute>().Select(new Func<XmlAttribute, Class_387>(Class_388.cmethod_2824)).ToList<Class_387>();
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0005017C File Offset: 0x0004E37C
		public Class_387 prop_5
		{
			get
			{
				XmlNode xmlNode = (this.field_0 is XmlAttribute) ? ((XmlAttribute)this.field_0).OwnerElement : this.field_0.ParentNode;
				if (xmlNode == null)
				{
					return null;
				}
				return Class_388.cmethod_2824(xmlNode);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x000501C8 File Offset: 0x0004E3C8
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x000501D5 File Offset: 0x0004E3D5
		public string prop_6
		{
			get
			{
				return this.field_0.Value;
			}
			set
			{
				this.field_0.Value = value;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000501E4 File Offset: 0x0004E3E4
		public Class_387 pmethod_2829(Class_387 arg_0)
		{
			Class_388 class_ = (Class_388)arg_0;
			this.field_0.AppendChild(class_.field_0);
			this.field_1 = null;
			return arg_0;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00050212 File Offset: 0x0004E412
		public string prop_7
		{
			get
			{
				return this.field_0.NamespaceURI;
			}
		}

		// Token: 0x04000960 RID: 2400
		private readonly XmlNode field_0;

		// Token: 0x04000961 RID: 2401
		private IList<Class_387> field_1;
	}
}
