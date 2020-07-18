using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x020001B5 RID: 437
	internal struct Class_326
	{
		// Token: 0x06000C58 RID: 3160 RVA: 0x000442F1 File Offset: 0x000424F1
		public Class_326(Class_325 type)
		{
			this.Type = type;
			this.HasIndex = Class_326.TypeHasIndex(type);
			this.Position = -1;
			this.PropertyName = null;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00044314 File Offset: 0x00042514
		internal void WriteTo(StringBuilder sb)
		{
			switch (this.Type)
			{
			case Class_325.Object:
			{
				if (sb.Length > 0)
				{
					sb.Append('.');
				}
				string propertyName = this.PropertyName;
				if (propertyName.IndexOfAny(Class_326.SpecialCharacters) != -1)
				{
					sb.Append("['");
					sb.Append(propertyName);
					sb.Append("']");
					return;
				}
				sb.Append(propertyName);
				return;
			}
			case Class_325.Array:
			case Class_325.Constructor:
				sb.Append('[');
				sb.Append(this.Position);
				sb.Append(']');
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000443B3 File Offset: 0x000425B3
		internal static bool TypeHasIndex(Class_325 type)
		{
			return type == Class_325.Array || type == Class_325.Constructor;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000443C4 File Offset: 0x000425C4
		internal static string BuildPath(IEnumerable<Class_326> positions)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (Class_326 class_ in positions)
			{
				class_.WriteTo(stringBuilder);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00044424 File Offset: 0x00042624
		internal static string FormatMessage(Class_353 lineInfo, string path, string message)
		{
			if (!message.EndsWith(Environment.NewLine, StringComparison.Ordinal))
			{
				message = message.Trim();
				if (!message.EndsWith('.'))
				{
					message += ".";
				}
				message += " ";
			}
			message += "Path '{0}'".FormatWith(CultureInfo.InvariantCulture, path);
			if (lineInfo != null && lineInfo.lmethod_2368())
			{
				message += ", line {0}, position {1}".FormatWith(CultureInfo.InvariantCulture, lineInfo.prop_0, lineInfo.prop_1);
			}
			message += ".";
			return message;
		}

		// Token: 0x040007D9 RID: 2009
		private static readonly char[] SpecialCharacters = new char[]
		{
			'.',
			' ',
			'[',
			']',
			'(',
			')'
		};

		// Token: 0x040007DA RID: 2010
		internal Class_325 Type;

		// Token: 0x040007DB RID: 2011
		internal int Position;

		// Token: 0x040007DC RID: 2012
		internal string PropertyName;

		// Token: 0x040007DD RID: 2013
		internal bool HasIndex;
	}
}
