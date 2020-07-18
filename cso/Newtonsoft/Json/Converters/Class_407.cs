using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000217 RID: 535
	public class Class_407 : Class_299
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00050A28 File Offset: 0x0004EC28
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00050A30 File Offset: 0x0004EC30
		public new string prop_0 { get; set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00050A39 File Offset: 0x0004EC39
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x00050A41 File Offset: 0x0004EC41
		public new bool prop_1 { get; set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00050A4A File Offset: 0x0004EC4A
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x00050A52 File Offset: 0x0004EC52
		public bool prop_2 { get; set; }

		// Token: 0x06001029 RID: 4137 RVA: 0x00050A5C File Offset: 0x0004EC5C
		public virtual void smethod_2960(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Class_387 class_ = this.xmethod_2961(obje_0);
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
			this.tmethod_2962(class_, xmlNamespaceManager);
			if (!this.prop_2)
			{
				arg_0.kmethod_2007();
			}
			this.kmethod_2967(arg_0, class_, xmlNamespaceManager, !this.prop_2);
			if (!this.prop_2)
			{
				arg_0.lmethod_2008();
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00050AB8 File Offset: 0x0004ECB8
		private Class_387 xmethod_2961(object obje_0)
		{
			if (obje_0 is XObject)
			{
				return Class_400.lmethod_2908((XObject)obje_0);
			}
			if (obje_0 is XmlNode)
			{
				return Class_388.cmethod_2824((XmlNode)obje_0);
			}
			throw new ArgumentException("Value must be an XML object.", "value");
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00050AF8 File Offset: 0x0004ECF8
		private void tmethod_2962(Class_387 arg_0, XmlNamespaceManager arg_1)
		{
			List<Class_387> list = null;
			Class_387 class_ = arg_0;
			while ((class_ = class_.prop_4) != null)
			{
				if (class_.prop_0 == XmlNodeType.Element)
				{
					if (list == null)
					{
						list = new List<Class_387>();
					}
					list.Add(class_);
				}
			}
			if (list != null)
			{
				list.Reverse();
				foreach (Class_387 class_2 in list)
				{
					arg_1.PushScope();
					foreach (Class_387 class_3 in class_2.prop_3)
					{
						if (class_3.prop_6 == "http://www.w3.org/2000/xmlns/" && class_3.prop_1 != "xmlns")
						{
							arg_1.AddNamespace(class_3.prop_1, class_3.prop_5);
						}
					}
				}
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00050C10 File Offset: 0x0004EE10
		private string gmethod_2963(Class_387 arg_0, XmlNamespaceManager arg_1)
		{
			string text = (arg_0.prop_6 == null || (arg_0.prop_1 == "xmlns" && arg_0.prop_6 == "http://www.w3.org/2000/xmlns/")) ? null : arg_1.LookupPrefix(arg_0.prop_6);
			if (!string.IsNullOrEmpty(text))
			{
				return text + ":" + arg_0.prop_1;
			}
			return arg_0.prop_1;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00050C88 File Offset: 0x0004EE88
		private string cmethod_2964(Class_387 arg_0, XmlNamespaceManager arg_1)
		{
			switch (arg_0.prop_0)
			{
			case XmlNodeType.Element:
				return this.gmethod_2963(arg_0, arg_1);
			case XmlNodeType.Attribute:
				if (arg_0.prop_6 == "http://james.newtonking.com/projects/json")
				{
					return "$" + arg_0.prop_1;
				}
				return "@" + this.gmethod_2963(arg_0, arg_1);
			case XmlNodeType.Text:
				return "#text";
			case XmlNodeType.CDATA:
				return "#cdata-section";
			case XmlNodeType.ProcessingInstruction:
				return "?" + this.gmethod_2963(arg_0, arg_1);
			case XmlNodeType.Comment:
				return "#comment";
			case XmlNodeType.DocumentType:
				return "!" + this.gmethod_2963(arg_0, arg_1);
			case XmlNodeType.Whitespace:
				return "#whitespace";
			case XmlNodeType.SignificantWhitespace:
				return "#significant-whitespace";
			case XmlNodeType.XmlDeclaration:
				return "?xml";
			}
			throw new Class_417("Unexpected XmlNodeType when getting node name: " + arg_0.prop_0);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00050D94 File Offset: 0x0004EF94
		private bool vmethod_2965(Class_387 arg_0)
		{
			Class_387 class_;
			if (arg_0.prop_3 == null)
			{
				class_ = null;
			}
			else
			{
				IEnumerable<Class_387> source = arg_0.prop_3;
				if (Class_407.field_10 == null)
				{
					Class_407.field_10 = new Func<Class_387, bool>(Class_407.tmethod_2982);
				}
				class_ = source.SingleOrDefault(Class_407.field_10);
			}
			Class_387 class_2 = class_;
			return class_2 != null && XmlConvert.ToBoolean(class_2.prop_5);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00050DF4 File Offset: 0x0004EFF4
		private void dmethod_2966(Class_296 arg_0, Class_387 arg_1, XmlNamespaceManager arg_2, bool bool_0)
		{
			Dictionary<string, List<Class_387>> dictionary = new Dictionary<string, List<Class_387>>();
			for (int i = 0; i < arg_1.prop_2.Count; i++)
			{
				Class_387 class_ = arg_1.prop_2[i];
				string key = this.cmethod_2964(class_, arg_2);
				List<Class_387> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = new List<Class_387>();
					dictionary.Add(key, list);
				}
				list.Add(class_);
			}
			foreach (KeyValuePair<string, List<Class_387>> keyValuePair in dictionary)
			{
				List<Class_387> value = keyValuePair.Value;
				if (value.Count == 1 && !this.vmethod_2965(value[0]))
				{
					this.kmethod_2967(arg_0, value[0], arg_2, bool_0);
				}
				else
				{
					string key2 = keyValuePair.Key;
					if (bool_0)
					{
						arg_0.gmethod_2013(key2);
					}
					arg_0.pmethod_2009();
					for (int j = 0; j < value.Count; j++)
					{
						this.kmethod_2967(arg_0, value[j], arg_2, false);
					}
					arg_0.smethod_2010();
				}
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00050F3C File Offset: 0x0004F13C
		private void kmethod_2967(Class_296 arg_0, Class_387 arg_1, XmlNamespaceManager arg_2, bool bool_0)
		{
			Func<Class_387, bool> func = null;
			Class_407.NClass_0 nclass_ = new Class_407.NClass_0();
			nclass_.field_1 = arg_1;
			switch (nclass_.field_1.prop_0)
			{
			case XmlNodeType.Element:
				if (this.vmethod_2965(nclass_.field_1))
				{
					IEnumerable<Class_387> source = nclass_.field_1.prop_2;
					if (func == null)
					{
						func = new Func<Class_387, bool>(nclass_.nmethod_1);
					}
					if (source.All(func) && nclass_.field_1.prop_2.Count > 0)
					{
						this.dmethod_2966(arg_0, nclass_.field_1, arg_2, false);
						return;
					}
				}
				arg_2.PushScope();
				foreach (Class_387 class_ in nclass_.field_1.prop_3)
				{
					if (class_.prop_6 == "http://www.w3.org/2000/xmlns/")
					{
						string prefix = (class_.prop_1 != "xmlns") ? class_.prop_1 : string.Empty;
						string uri = class_.prop_5;
						arg_2.AddNamespace(prefix, uri);
					}
				}
				if (bool_0)
				{
					arg_0.gmethod_2013(this.cmethod_2964(nclass_.field_1, arg_2));
				}
				if (!this.smethod_2980(nclass_.field_1.prop_3).Any<Class_387>() && nclass_.field_1.prop_2.Count == 1 && nclass_.field_1.prop_2[0].prop_0 == XmlNodeType.Text)
				{
					arg_0.kmethod_2037(nclass_.field_1.prop_2[0].prop_5);
				}
				else if (nclass_.field_1.prop_2.Count == 0 && Class_510.IsNullOrEmpty<Class_387>(nclass_.field_1.prop_3))
				{
					Class_391 class_2 = (Class_391)nclass_.field_1;
					if (class_2.prop_0)
					{
						arg_0.gmethod_2033();
					}
					else
					{
						arg_0.kmethod_2037(string.Empty);
					}
				}
				else
				{
					arg_0.kmethod_2007();
					for (int i = 0; i < nclass_.field_1.prop_3.Count; i++)
					{
						this.kmethod_2967(arg_0, nclass_.field_1.prop_3[i], arg_2, true);
					}
					this.dmethod_2966(arg_0, nclass_.field_1, arg_2, true);
					arg_0.lmethod_2008();
				}
				arg_2.PopScope();
				return;
			case XmlNodeType.Attribute:
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				if (nclass_.field_1.prop_6 == "http://www.w3.org/2000/xmlns/" && nclass_.field_1.prop_5 == "http://james.newtonking.com/projects/json")
				{
					return;
				}
				if (nclass_.field_1.prop_6 == "http://james.newtonking.com/projects/json" && nclass_.field_1.prop_1 == "Array")
				{
					return;
				}
				if (bool_0)
				{
					arg_0.gmethod_2013(this.cmethod_2964(nclass_.field_1, arg_2));
				}
				arg_0.kmethod_2037(nclass_.field_1.prop_5);
				return;
			case XmlNodeType.Comment:
				if (bool_0)
				{
					arg_0.vmethod_2075(nclass_.field_1.prop_5);
					return;
				}
				return;
			case XmlNodeType.Document:
			case XmlNodeType.DocumentFragment:
				this.dmethod_2966(arg_0, nclass_.field_1, arg_2, bool_0);
				return;
			case XmlNodeType.DocumentType:
			{
				Class_395 class_3 = (Class_395)nclass_.field_1;
				arg_0.gmethod_2013(this.cmethod_2964(nclass_.field_1, arg_2));
				arg_0.kmethod_2007();
				if (!string.IsNullOrEmpty(class_3.prop_0))
				{
					arg_0.gmethod_2013("@name");
					arg_0.kmethod_2037(class_3.prop_0);
				}
				if (!string.IsNullOrEmpty(class_3.prop_2))
				{
					arg_0.gmethod_2013("@public");
					arg_0.kmethod_2037(class_3.prop_2);
				}
				if (!string.IsNullOrEmpty(class_3.prop_1))
				{
					arg_0.gmethod_2013("@system");
					arg_0.kmethod_2037(class_3.prop_1);
				}
				if (!string.IsNullOrEmpty(class_3.prop_3))
				{
					arg_0.gmethod_2013("@internalSubset");
					arg_0.kmethod_2037(class_3.prop_3);
				}
				arg_0.lmethod_2008();
				return;
			}
			case XmlNodeType.XmlDeclaration:
			{
				Class_393 class_4 = (Class_393)nclass_.field_1;
				arg_0.gmethod_2013(this.cmethod_2964(nclass_.field_1, arg_2));
				arg_0.kmethod_2007();
				if (!string.IsNullOrEmpty(class_4.prop_0))
				{
					arg_0.gmethod_2013("@version");
					arg_0.kmethod_2037(class_4.prop_0);
				}
				if (!string.IsNullOrEmpty(class_4.prop_1))
				{
					arg_0.gmethod_2013("@encoding");
					arg_0.kmethod_2037(class_4.prop_1);
				}
				if (!string.IsNullOrEmpty(class_4.prop_2))
				{
					arg_0.gmethod_2013("@standalone");
					arg_0.kmethod_2037(class_4.prop_2);
				}
				arg_0.lmethod_2008();
				return;
			}
			}
			throw new Class_417("Unexpected XmlNodeType when serializing nodes: " + nclass_.field_1.prop_0);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00051454 File Offset: 0x0004F654
		public virtual object lmethod_2968(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.Null)
			{
				return null;
			}
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
			Class_389 class_ = null;
			Class_387 class_2 = null;
			if (typeof(XObject).IsAssignableFrom(arg_1))
			{
				if (arg_1 != typeof(XDocument) && arg_1 != typeof(XElement))
				{
					throw new Class_417("XmlNodeConverter only supports deserializing XDocument or XElement.");
				}
				XDocument arg_3 = new XDocument();
				class_ = new Class_401(arg_3);
				class_2 = class_;
			}
			if (typeof(XmlNode).IsAssignableFrom(arg_1))
			{
				if (arg_1 != typeof(XmlDocument))
				{
					throw new Class_417("XmlNodeConverter only supports deserializing XmlDocuments");
				}
				class_ = new Class_390(new XmlDocument
				{
					XmlResolver = null
				});
				class_2 = class_;
			}
			if (class_ == null || class_2 == null)
			{
				throw new Class_417("Unexpected type when converting XML: " + arg_1);
			}
			if (arg_0.prop_9 != Class_508.StartObject)
			{
				throw new Class_417("XmlNodeConverter can only convert JSON that begins with an object.");
			}
			if (!string.IsNullOrEmpty(this.prop_0))
			{
				this.smethod_2970(arg_0, class_, class_2, this.prop_0, xmlNamespaceManager);
			}
			else
			{
				arg_0.vmethod_1885();
				this.lmethod_2978(arg_0, class_, xmlNamespaceManager, class_2);
			}
			if (arg_1 == typeof(XElement))
			{
				XElement xelement = (XElement)class_.prop_0.prop_7;
				xelement.Remove();
				return xelement;
			}
			return class_.prop_7;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000515C8 File Offset: 0x0004F7C8
		private void pmethod_2969(Class_285 arg_0, Class_389 arg_1, XmlNamespaceManager arg_2, string str_0, Class_387 arg_3)
		{
			if (str_0 != null)
			{
				if (str_0 == "#text")
				{
					arg_3.kmethod_2817(arg_1.tmethod_2832(arg_0.prop_10.ToString()));
					return;
				}
				if (str_0 == "#cdata-section")
				{
					arg_3.kmethod_2817(arg_1.gmethod_2833(arg_0.prop_10.ToString()));
					return;
				}
				if (str_0 == "#whitespace")
				{
					arg_3.kmethod_2817(arg_1.cmethod_2834(arg_0.prop_10.ToString()));
					return;
				}
				if (str_0 == "#significant-whitespace")
				{
					arg_3.kmethod_2817(arg_1.vmethod_2835(arg_0.prop_10.ToString()));
					return;
				}
			}
			if (!string.IsNullOrEmpty(str_0) && str_0[0] == '?')
			{
				this.vmethod_2975(arg_0, arg_1, arg_3, str_0);
				return;
			}
			if (string.Equals(str_0, "!DOCTYPE", StringComparison.OrdinalIgnoreCase))
			{
				this.dmethod_2976(arg_0, arg_1, arg_3);
				return;
			}
			if (arg_0.prop_9 == Class_508.StartArray)
			{
				this.tmethod_2972(arg_0, arg_1, str_0, arg_3, arg_2);
				return;
			}
			this.smethod_2970(arg_0, arg_1, arg_3, str_0, arg_2);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000516F8 File Offset: 0x0004F8F8
		private void smethod_2970(Class_285 arg_0, Class_389 arg_1, Class_387 arg_2, string str_0, XmlNamespaceManager arg_3)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new Class_417("XmlNodeConverter cannot convert JSON with an empty property name to XML.");
			}
			Dictionary<string, string> dictionary = this.cmethod_2974(arg_0, arg_3);
			string prefix = Class_513.GetPrefix(str_0);
			if (str_0.StartsWith('@'))
			{
				string text = str_0.Substring(1);
				string text2 = arg_0.prop_10.ToString();
				string prefix2 = Class_513.GetPrefix(text);
				Class_387 arg_4 = (!string.IsNullOrEmpty(prefix2)) ? arg_1.tmethod_2842(text, arg_3.LookupNamespace(prefix2), text2) : arg_1.xmethod_2841(text, text2);
				((Class_391)arg_2).kmethod_2857(arg_4);
				return;
			}
			Class_391 class_ = this.kmethod_2977(str_0, arg_1, prefix, arg_3);
			arg_2.kmethod_2817(class_);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				string prefix3 = Class_513.GetPrefix(keyValuePair.Key);
				Class_387 arg_5 = (!string.IsNullOrEmpty(prefix3)) ? arg_1.tmethod_2842(keyValuePair.Key, arg_3.LookupNamespace(prefix3), keyValuePair.Value) : arg_1.xmethod_2841(keyValuePair.Key, keyValuePair.Value);
				class_.kmethod_2857(arg_5);
			}
			if (arg_0.prop_9 == Class_508.String || arg_0.prop_9 == Class_508.Integer || arg_0.prop_9 == Class_508.Float || arg_0.prop_9 == Class_508.Boolean || arg_0.prop_9 == Class_508.Date)
			{
				class_.kmethod_2817(arg_1.tmethod_2832(this.xmethod_2971(arg_0)));
				return;
			}
			if (arg_0.prop_9 == Class_508.Null)
			{
				return;
			}
			if (arg_0.prop_9 != Class_508.EndObject)
			{
				arg_3.PushScope();
				this.lmethod_2978(arg_0, arg_1, arg_3, class_);
				arg_3.PopScope();
			}
			arg_3.RemoveNamespace(string.Empty, arg_3.DefaultNamespace);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000518E8 File Offset: 0x0004FAE8
		private string xmethod_2971(Class_285 arg_0)
		{
			if (arg_0.prop_9 == Class_508.String)
			{
				return arg_0.prop_10.ToString();
			}
			if (arg_0.prop_9 == Class_508.Integer)
			{
				return XmlConvert.ToString(Convert.ToInt64(arg_0.prop_10, CultureInfo.InvariantCulture));
			}
			if (arg_0.prop_9 == Class_508.Float)
			{
				if (arg_0.prop_10 is decimal)
				{
					return XmlConvert.ToString((decimal)arg_0.prop_10);
				}
				if (arg_0.prop_10 is float)
				{
					return XmlConvert.ToString((float)arg_0.prop_10);
				}
				return XmlConvert.ToString(Convert.ToDouble(arg_0.prop_10, CultureInfo.InvariantCulture));
			}
			else
			{
				if (arg_0.prop_9 == Class_508.Boolean)
				{
					return XmlConvert.ToString(Convert.ToBoolean(arg_0.prop_10, CultureInfo.InvariantCulture));
				}
				if (arg_0.prop_9 == Class_508.Date)
				{
					if (arg_0.prop_10 is DateTimeOffset)
					{
						return XmlConvert.ToString((DateTimeOffset)arg_0.prop_10);
					}
					DateTime value = Convert.ToDateTime(arg_0.prop_10, CultureInfo.InvariantCulture);
					return XmlConvert.ToString(value, Class_502.ToSerializationMode(value.Kind));
				}
				else
				{
					if (arg_0.prop_9 == Class_508.Null)
					{
						return null;
					}
					throw Class_417.xmethod_3101(arg_0, "Cannot get an XML string value from token type '{0}'.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
				}
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00051A38 File Offset: 0x0004FC38
		private void tmethod_2972(Class_285 arg_0, Class_389 arg_1, string str_0, Class_387 arg_2, XmlNamespaceManager arg_3)
		{
			Func<Class_391, bool> func = null;
			Class_407.NClass_1 nclass_ = new Class_407.NClass_1();
			nclass_.field_2 = str_0;
			string prefix = Class_513.GetPrefix(nclass_.field_2);
			Class_391 class_ = this.kmethod_2977(nclass_.field_2, arg_1, prefix, arg_3);
			arg_2.kmethod_2817(class_);
			int num = 0;
			while (arg_0.vmethod_1885() && arg_0.prop_9 != Class_508.EndArray)
			{
				this.pmethod_2969(arg_0, arg_1, arg_3, nclass_.field_2, class_);
				num++;
			}
			if (this.prop_1)
			{
				this.gmethod_2973(class_, arg_1);
			}
			if (num == 1 && this.prop_1)
			{
				IEnumerable<Class_391> source = class_.prop_2.OfType<Class_391>();
				if (func == null)
				{
					func = new Func<Class_391, bool>(nclass_.nmethod_3);
				}
				Class_391 arg_4 = source.Single(func);
				this.gmethod_2973(arg_4, arg_1);
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00051B04 File Offset: 0x0004FD04
		private void gmethod_2973(Class_391 arg_0, Class_389 arg_1)
		{
			arg_0.kmethod_2857(arg_1.tmethod_2842("json:Array", "http://james.newtonking.com/projects/json", "true"));
			if (arg_0 is Class_406 && arg_0.lmethod_2858("http://james.newtonking.com/projects/json") == null)
			{
				arg_0.kmethod_2857(arg_1.tmethod_2842("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00051B64 File Offset: 0x0004FD64
		private Dictionary<string, string> cmethod_2974(Class_285 arg_0, XmlNamespaceManager arg_1)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			bool flag = false;
			bool flag2 = false;
			if (arg_0.prop_9 != Class_508.String && arg_0.prop_9 != Class_508.Null && arg_0.prop_9 != Class_508.Boolean && arg_0.prop_9 != Class_508.Integer && arg_0.prop_9 != Class_508.Float && arg_0.prop_9 != Class_508.Date && arg_0.prop_9 != Class_508.StartConstructor)
			{
				while (!flag && !flag2 && arg_0.vmethod_1885())
				{
					Class_508 class_ = arg_0.prop_9;
					switch (class_)
					{
					case Class_508.PropertyName:
					{
						string text = arg_0.prop_10.ToString();
						if (!string.IsNullOrEmpty(text))
						{
							char c = text[0];
							char c2 = c;
							if (c2 != '$')
							{
								if (c2 == '@')
								{
									text = text.Substring(1);
									arg_0.vmethod_1885();
									string text2 = this.xmethod_2971(arg_0);
									dictionary.Add(text, text2);
									string prefix;
									if (this.pmethod_2979(text, out prefix))
									{
										arg_1.AddNamespace(prefix, text2);
									}
								}
								else
								{
									flag = true;
								}
							}
							else
							{
								text = text.Substring(1);
								arg_0.vmethod_1885();
								string text2 = arg_0.prop_10.ToString();
								string text3 = arg_1.LookupPrefix("http://james.newtonking.com/projects/json");
								if (text3 == null)
								{
									int? num = null;
									while (arg_1.LookupNamespace("json" + num) != null)
									{
										num = new int?(num.GetValueOrDefault() + 1);
									}
									text3 = "json" + num;
									dictionary.Add("xmlns:" + text3, "http://james.newtonking.com/projects/json");
									arg_1.AddNamespace(text3, "http://james.newtonking.com/projects/json");
								}
								dictionary.Add(text3 + ":" + text, text2);
							}
						}
						else
						{
							flag = true;
						}
						break;
					}
					case Class_508.Comment:
						flag2 = true;
						break;
					default:
						if (class_ != Class_508.EndObject)
						{
							throw new Class_417("Unexpected JsonToken: " + arg_0.prop_9);
						}
						flag2 = true;
						break;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00051D80 File Offset: 0x0004FF80
		private void vmethod_2975(Class_285 arg_0, Class_389 arg_1, Class_387 arg_2, string str_0)
		{
			if (str_0 == "?xml")
			{
				string str_ = null;
				string str_2 = null;
				string str_3 = null;
				while (arg_0.vmethod_1885() && arg_0.prop_9 != Class_508.EndObject)
				{
					string a;
					if ((a = arg_0.prop_10.ToString()) != null)
					{
						if (a == "@version")
						{
							arg_0.vmethod_1885();
							str_ = arg_0.prop_10.ToString();
							continue;
						}
						if (a == "@encoding")
						{
							arg_0.vmethod_1885();
							str_2 = arg_0.prop_10.ToString();
							continue;
						}
						if (a == "@standalone")
						{
							arg_0.vmethod_1885();
							str_3 = arg_0.prop_10.ToString();
							continue;
						}
					}
					throw new Class_417("Unexpected property name encountered while deserializing XmlDeclaration: " + arg_0.prop_10);
				}
				Class_387 arg_3 = arg_1.dmethod_2836(str_, str_2, str_3);
				arg_2.kmethod_2817(arg_3);
				return;
			}
			Class_387 arg_4 = arg_1.lmethod_2838(str_0.Substring(1), arg_0.prop_10.ToString());
			arg_2.kmethod_2817(arg_4);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00051EA0 File Offset: 0x000500A0
		private void dmethod_2976(Class_285 arg_0, Class_389 arg_1, Class_387 arg_2)
		{
			string str_ = null;
			string str_2 = null;
			string str_3 = null;
			string str_4 = null;
			while (arg_0.vmethod_1885() && arg_0.prop_9 != Class_508.EndObject)
			{
				string a;
				if ((a = arg_0.prop_10.ToString()) != null)
				{
					if (a == "@name")
					{
						arg_0.vmethod_1885();
						str_ = arg_0.prop_10.ToString();
						continue;
					}
					if (a == "@public")
					{
						arg_0.vmethod_1885();
						str_2 = arg_0.prop_10.ToString();
						continue;
					}
					if (a == "@system")
					{
						arg_0.vmethod_1885();
						str_3 = arg_0.prop_10.ToString();
						continue;
					}
					if (a == "@internalSubset")
					{
						arg_0.vmethod_1885();
						str_4 = arg_0.prop_10.ToString();
						continue;
					}
				}
				throw new Class_417("Unexpected property name encountered while deserializing XmlDeclaration: " + arg_0.prop_10);
			}
			Class_387 arg_3 = arg_1.kmethod_2837(str_, str_2, str_3, str_4);
			arg_2.kmethod_2817(arg_3);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00051FBC File Offset: 0x000501BC
		private Class_391 kmethod_2977(string str_0, Class_389 arg_0, string str_1, XmlNamespaceManager arg_1)
		{
			string text = string.IsNullOrEmpty(str_1) ? arg_1.DefaultNamespace : arg_1.LookupNamespace(str_1);
			return (!string.IsNullOrEmpty(text)) ? arg_0.smethod_2840(str_0, text) : arg_0.pmethod_2839(str_0);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0005200C File Offset: 0x0005020C
		private void lmethod_2978(Class_285 arg_0, Class_389 arg_1, XmlNamespaceManager arg_2, Class_387 arg_3)
		{
			Class_508 class_;
			for (;;)
			{
				Func<Class_391, bool> func = null;
				Class_407.NClass_2 nclass_ = new Class_407.NClass_2();
				class_ = arg_0.prop_9;
				switch (class_)
				{
				case Class_508.StartConstructor:
				{
					string str_ = arg_0.prop_10.ToString();
					while (arg_0.vmethod_1885())
					{
						if (arg_0.prop_9 == Class_508.EndConstructor)
						{
							break;
						}
						this.pmethod_2969(arg_0, arg_1, arg_2, str_, arg_3);
					}
					goto IL_182;
				}
				case Class_508.PropertyName:
				{
					if (arg_3.prop_0 == XmlNodeType.Document && arg_1.prop_0 != null)
					{
						goto Block_3;
					}
					nclass_.field_3 = arg_0.prop_10.ToString();
					arg_0.vmethod_1885();
					if (arg_0.prop_9 != Class_508.StartArray)
					{
						this.pmethod_2969(arg_0, arg_1, arg_2, nclass_.field_3, arg_3);
						goto IL_182;
					}
					int num = 0;
					while (arg_0.vmethod_1885() && arg_0.prop_9 != Class_508.EndArray)
					{
						this.pmethod_2969(arg_0, arg_1, arg_2, nclass_.field_3, arg_3);
						num++;
					}
					if (num == 1 && this.prop_1)
					{
						IEnumerable<Class_391> source = arg_3.prop_2.OfType<Class_391>();
						if (func == null)
						{
							func = new Func<Class_391, bool>(nclass_.nmethod_5);
						}
						Class_391 arg_4 = source.Single(func);
						this.gmethod_2973(arg_4, arg_1);
						goto IL_182;
					}
					goto IL_182;
				}
				case Class_508.Comment:
					arg_3.kmethod_2817(arg_1.xmethod_2831((string)arg_0.prop_10));
					goto IL_182;
				}
				break;
				IL_182:
				if (arg_0.prop_9 != Class_508.PropertyName && !arg_0.vmethod_1885())
				{
					return;
				}
			}
			switch (class_)
			{
			case Class_508.EndObject:
			case Class_508.EndArray:
				return;
			default:
				throw new Class_417("Unexpected JsonToken when deserializing node: " + arg_0.prop_9);
			}
			Block_3:
			throw new Class_417("JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifing a DeserializeRootElementName.");
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000521B4 File Offset: 0x000503B4
		private bool pmethod_2979(string str_0, out string arg_0)
		{
			if (str_0.StartsWith("xmlns", StringComparison.Ordinal))
			{
				if (str_0.Length == 5)
				{
					arg_0 = string.Empty;
					return true;
				}
				if (str_0[5] == ':')
				{
					arg_0 = str_0.Substring(6, str_0.Length - 6);
					return true;
				}
			}
			arg_0 = null;
			return false;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0005220C File Offset: 0x0005040C
		private IEnumerable<Class_387> smethod_2980(IEnumerable<Class_387> arg_0)
		{
			if (Class_407.field_11 == null)
			{
				Class_407.field_11 = new Func<Class_387, bool>(Class_407.gmethod_2983);
			}
			return arg_0.Where(Class_407.field_11);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00052234 File Offset: 0x00050434
		public virtual bool xmethod_2981(Type arg_0)
		{
			return typeof(XObject).IsAssignableFrom(arg_0) || typeof(XmlNode).IsAssignableFrom(arg_0);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00052265 File Offset: 0x00050465
		[CompilerGenerated]
		private static bool tmethod_2982(Class_387 arg_0)
		{
			return arg_0.prop_1 == "Array" && arg_0.prop_6 == "http://james.newtonking.com/projects/json";
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0005228E File Offset: 0x0005048E
		[CompilerGenerated]
		private static bool gmethod_2983(Class_387 arg_0)
		{
			return arg_0.prop_6 != "http://james.newtonking.com/projects/json";
		}

		// Token: 0x0400096B RID: 2411
		private const string field_0 = "#text";

		// Token: 0x0400096C RID: 2412
		private const string field_1 = "#comment";

		// Token: 0x0400096D RID: 2413
		private const string field_2 = "#cdata-section";

		// Token: 0x0400096E RID: 2414
		private const string field_3 = "#whitespace";

		// Token: 0x0400096F RID: 2415
		private const string field_4 = "#significant-whitespace";

		// Token: 0x04000970 RID: 2416
		private const string field_5 = "?xml";

		// Token: 0x04000971 RID: 2417
		private const string field_6 = "http://james.newtonking.com/projects/json";

		// Token: 0x04000972 RID: 2418
		[CompilerGenerated]
		private string field_7;

		// Token: 0x04000973 RID: 2419
		[CompilerGenerated]
		private bool field_8;

		// Token: 0x04000974 RID: 2420
		[CompilerGenerated]
		private bool field_9;

		// Token: 0x04000975 RID: 2421
		[CompilerGenerated]
		private static Func<Class_387, bool> field_10;

		// Token: 0x04000976 RID: 2422
		[CompilerGenerated]
		private static Func<Class_387, bool> field_11;

		// Token: 0x02000218 RID: 536
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06001042 RID: 4162 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06001043 RID: 4163 RVA: 0x000522A0 File Offset: 0x000504A0
			public bool nmethod_1(Class_387 arg_0)
			{
				return arg_0.prop_1 == this.field_1.prop_1;
			}

			// Token: 0x04000977 RID: 2423
			public Class_387 field_1;
		}

		// Token: 0x02000219 RID: 537
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x06001044 RID: 4164 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}

			// Token: 0x06001045 RID: 4165 RVA: 0x000522B8 File Offset: 0x000504B8
			public bool nmethod_3(Class_391 arg_0)
			{
				return arg_0.prop_1 == this.field_2;
			}

			// Token: 0x04000978 RID: 2424
			public string field_2;
		}

		// Token: 0x0200021A RID: 538
		[CompilerGenerated]
		private sealed class NClass_2
		{
			// Token: 0x06001046 RID: 4166 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_4()
			{
				base..ctor();
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x000522CB File Offset: 0x000504CB
			public bool nmethod_5(Class_391 arg_0)
			{
				return arg_0.prop_1 == this.field_3;
			}

			// Token: 0x04000979 RID: 2425
			public string field_3;
		}
	}
}
