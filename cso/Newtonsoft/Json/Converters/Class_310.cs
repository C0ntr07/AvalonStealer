using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A5 RID: 421
	public class Class_310 : Class_299
	{
		// Token: 0x06000C22 RID: 3106 RVA: 0x00043AFC File Offset: 0x00041CFC
		public virtual void vmethod_2185(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Regex arg_2 = (Regex)obje_0;
			Class_297 class_ = arg_0 as Class_297;
			if (class_ != null)
			{
				this.kmethod_2187(class_, arg_2);
				return;
			}
			this.lmethod_2188(arg_0, arg_2, arg_1);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00043B2F File Offset: 0x00041D2F
		private bool dmethod_2186(RegexOptions arg_0, RegexOptions arg_1)
		{
			return (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00043B38 File Offset: 0x00041D38
		private void kmethod_2187(Class_297 arg_0, Regex arg_1)
		{
			string text = null;
			if (this.dmethod_2186(arg_1.Options, RegexOptions.IgnoreCase))
			{
				text += "i";
			}
			if (this.dmethod_2186(arg_1.Options, RegexOptions.Multiline))
			{
				text += "m";
			}
			if (this.dmethod_2186(arg_1.Options, RegexOptions.Singleline))
			{
				text += "s";
			}
			text += "u";
			if (this.dmethod_2186(arg_1.Options, RegexOptions.ExplicitCapture))
			{
				text += "x";
			}
			arg_0.pmethod_2129(arg_1.ToString(), text);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00043BDC File Offset: 0x00041DDC
		private void lmethod_2188(Class_296 arg_0, Regex arg_1, Class_418 arg_2)
		{
			Class_441 class_ = arg_2.prop_14 as Class_441;
			arg_0.kmethod_2007();
			arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Pattern") : "Pattern");
			arg_0.kmethod_2037(arg_1.ToString());
			arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Options") : "Options");
			arg_2.kmethod_3177(arg_0, arg_1.Options);
			arg_0.lmethod_2008();
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00043C61 File Offset: 0x00041E61
		public virtual object pmethod_2189(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.StartObject)
			{
				return this.xmethod_2191(arg_0, arg_2);
			}
			if (arg_0.prop_9 == Class_508.String)
			{
				return this.smethod_2190(arg_0);
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected token when reading Regex.");
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00043C9C File Offset: 0x00041E9C
		private object smethod_2190(Class_285 arg_0)
		{
			string text = (string)arg_0.prop_10;
			int num = text.LastIndexOf('/');
			string pattern = text.Substring(1, num - 1);
			string text2 = text.Substring(num + 1);
			RegexOptions regexOptions = RegexOptions.None;
			foreach (char c in text2)
			{
				char c2 = c;
				if (c2 <= 'm')
				{
					if (c2 != 'i')
					{
						if (c2 == 'm')
						{
							regexOptions |= RegexOptions.Multiline;
						}
					}
					else
					{
						regexOptions |= RegexOptions.IgnoreCase;
					}
				}
				else if (c2 != 's')
				{
					if (c2 == 'x')
					{
						regexOptions |= RegexOptions.ExplicitCapture;
					}
				}
				else
				{
					regexOptions |= RegexOptions.Singleline;
				}
			}
			return new Regex(pattern, regexOptions);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00043D68 File Offset: 0x00041F68
		private Regex xmethod_2191(Class_285 arg_0, Class_418 arg_1)
		{
			string text = null;
			RegexOptions? regexOptions = null;
			while (arg_0.vmethod_1885())
			{
				Class_508 class_ = arg_0.prop_9;
				switch (class_)
				{
				case Class_508.PropertyName:
				{
					string a = arg_0.prop_10.ToString();
					if (!arg_0.vmethod_1885())
					{
						throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading Regex.");
					}
					if (string.Equals(a, "Pattern", StringComparison.OrdinalIgnoreCase))
					{
						text = (string)arg_0.prop_10;
					}
					else if (string.Equals(a, "Options", StringComparison.OrdinalIgnoreCase))
					{
						regexOptions = new RegexOptions?(arg_1.pmethod_3169<RegexOptions>(arg_0));
					}
					else
					{
						arg_0.smethod_1900();
					}
					break;
				}
				case Class_508.Comment:
					break;
				default:
					if (class_ == Class_508.EndObject)
					{
						if (text == null)
						{
							throw Class_417.xmethod_3101(arg_0, "Error deserializing Regex. No pattern found.");
						}
						return new Regex(text, regexOptions ?? RegexOptions.None);
					}
					break;
				}
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading Regex.");
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00043E67 File Offset: 0x00042067
		public virtual bool tmethod_2192(Type arg_0)
		{
			return arg_0 == typeof(Regex);
		}

		// Token: 0x040007AC RID: 1964
		private const string field_0 = "Pattern";

		// Token: 0x040007AD RID: 1965
		private const string field_1 = "Options";
	}
}
