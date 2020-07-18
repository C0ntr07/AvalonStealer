using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002BB RID: 699
	internal static class Class_507
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x0006DB6C File Offset: 0x0006BD6C
		static Class_507()
		{
			IList<char> list = new List<char>
			{
				'\n',
				'\r',
				'\t',
				'\\',
				'\f',
				'\b'
			};
			for (int i = 0; i < 32; i++)
			{
				list.Add((char)i);
			}
			foreach (char c in list.Union(new char[]
			{
				'\''
			}))
			{
				Class_507.SingleQuoteCharEscapeFlags[(int)c] = true;
			}
			foreach (char c2 in list.Union(new char[]
			{
				'"'
			}))
			{
				Class_507.DoubleQuoteCharEscapeFlags[(int)c2] = true;
			}
			foreach (char c3 in list.Union(new char[]
			{
				'"',
				'\'',
				'<',
				'>',
				'&'
			}))
			{
				Class_507.HtmlCharEscapeFlags[(int)c3] = true;
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0006DD10 File Offset: 0x0006BF10
		public static bool[] GetCharEscapeFlags(Class_356 stringEscapeHandling, char quoteChar)
		{
			if (stringEscapeHandling == Class_356.EscapeHtml)
			{
				return Class_507.HtmlCharEscapeFlags;
			}
			if (quoteChar == '"')
			{
				return Class_507.DoubleQuoteCharEscapeFlags;
			}
			return Class_507.SingleQuoteCharEscapeFlags;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0006DD34 File Offset: 0x0006BF34
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			if (s == null)
			{
				return false;
			}
			foreach (char c in s)
			{
				if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0006DD84 File Offset: 0x0006BF84
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Class_356 stringEscapeHandling, ref char[] writeBuffer)
		{
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
			if (s != null)
			{
				int num = 0;
				for (int i = 0; i < s.Length; i++)
				{
					char c = s[i];
					if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
					{
						char c2 = c;
						string text;
						if (c2 <= '\\')
						{
							switch (c2)
							{
							case '\b':
								text = "\\b";
								break;
							case '\t':
								text = "\\t";
								break;
							case '\n':
								text = "\\n";
								break;
							case '\v':
								goto IL_FE;
							case '\f':
								text = "\\f";
								break;
							case '\r':
								text = "\\r";
								break;
							default:
								if (c2 != '\\')
								{
									goto IL_FE;
								}
								text = "\\\\";
								break;
							}
						}
						else if (c2 != '\u0085')
						{
							switch (c2)
							{
							case '\u2028':
								text = "\\u2028";
								break;
							case '\u2029':
								text = "\\u2029";
								break;
							default:
								goto IL_FE;
							}
						}
						else
						{
							text = "\\u0085";
						}
						IL_171:
						if (text == null)
						{
							goto IL_229;
						}
						bool flag = string.Equals(text, "!");
						if (i > num)
						{
							int num2 = i - num + (flag ? 6 : 0);
							int num3 = flag ? 6 : 0;
							if (writeBuffer == null || writeBuffer.Length < num2)
							{
								char[] array = new char[num2];
								if (flag)
								{
									Array.Copy(writeBuffer, array, 6);
								}
								writeBuffer = array;
							}
							s.CopyTo(num, writeBuffer, num3, num2 - num3);
							writer.Write(writeBuffer, num3, num2 - num3);
						}
						num = i + 1;
						if (!flag)
						{
							writer.Write(text);
							goto IL_229;
						}
						writer.Write(writeBuffer, 0, 6);
						goto IL_229;
						IL_FE:
						if ((int)c >= charEscapeFlags.Length && stringEscapeHandling != Class_356.EscapeNonAscii)
						{
							text = null;
							goto IL_171;
						}
						if (c == '\'' && stringEscapeHandling != Class_356.EscapeHtml)
						{
							text = "\\'";
							goto IL_171;
						}
						if (c == '"' && stringEscapeHandling != Class_356.EscapeHtml)
						{
							text = "\\\"";
							goto IL_171;
						}
						if (writeBuffer == null)
						{
							writeBuffer = new char[6];
						}
						Class_515.ToCharAsUnicode(c, writeBuffer);
						text = "!";
						goto IL_171;
					}
					IL_229:;
				}
				if (num == 0)
				{
					writer.Write(s);
				}
				else
				{
					int num4 = s.Length - num;
					if (writeBuffer == null || writeBuffer.Length < num4)
					{
						writeBuffer = new char[num4];
					}
					s.CopyTo(num, writeBuffer, 0, num4);
					writer.Write(writeBuffer, 0, num4);
				}
			}
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0006E02A File Offset: 0x0006C22A
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters)
		{
			return Class_507.ToEscapedJavaScriptString(value, delimiter, appendDelimiters, Class_356.Default);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0006E038 File Offset: 0x0006C238
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, Class_356 stringEscapeHandling)
		{
			bool[] charEscapeFlags = Class_507.GetCharEscapeFlags(stringEscapeHandling, delimiter);
			string result;
			using (StringWriter stringWriter = Class_515.CreateStringWriter(Class_515.GetLength(value) ?? 16))
			{
				char[] array = null;
				Class_507.WriteEscapedJavaScriptString(stringWriter, value, delimiter, appendDelimiters, charEscapeFlags, stringEscapeHandling, ref array);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x04000C32 RID: 3122
		private const string EscapedUnicodeText = "!";

		// Token: 0x04000C33 RID: 3123
		internal static readonly bool[] SingleQuoteCharEscapeFlags = new bool[128];

		// Token: 0x04000C34 RID: 3124
		internal static readonly bool[] DoubleQuoteCharEscapeFlags = new bool[128];

		// Token: 0x04000C35 RID: 3125
		internal static readonly bool[] HtmlCharEscapeFlags = new bool[128];
	}
}
