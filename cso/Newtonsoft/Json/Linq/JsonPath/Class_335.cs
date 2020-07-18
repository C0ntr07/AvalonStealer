using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001C3 RID: 451
	internal class Class_335
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00045CB4 File Offset: 0x00043EB4
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00045CBC File Offset: 0x00043EBC
		public List<Class_329> prop_0 { get; private set; }

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00045CC5 File Offset: 0x00043EC5
		public Class_335(string str_0)
		{
			Class_517.ArgumentNotNull(str_0, "expression");
			this.field_0 = str_0;
			this.prop_0 = new List<Class_329>();
			this.smethod_2270();
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00045CF0 File Offset: 0x00043EF0
		private void smethod_2270()
		{
			int sayıInt_ = this.field_1;
			this.cmethod_2274();
			if (this.field_0.Length == this.field_1)
			{
				return;
			}
			if (this.field_0[this.field_1] == '$')
			{
				if (this.field_0.Length == 1)
				{
					return;
				}
				char c = this.field_0[this.field_1 + 1];
				if (c == '.' || c == '[')
				{
					this.field_1++;
					sayıInt_ = this.field_1;
				}
			}
			if (!this.xmethod_2271(this.prop_0, sayıInt_, false))
			{
				int index = this.field_1;
				this.cmethod_2274();
				if (this.field_1 < this.field_0.Length)
				{
					throw new Class_318("Unexpected character while parsing path: " + this.field_0[index]);
				}
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00045DDC File Offset: 0x00043FDC
		private bool xmethod_2271(List<Class_329> arg_0, int sayıInt_0, bool bool_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			while (this.field_1 < this.field_0.Length && !flag4)
			{
				char c = this.field_0[this.field_1];
				char c2 = c;
				if (c2 <= ')')
				{
					if (c2 != ' ')
					{
						switch (c2)
						{
						case '(':
							break;
						case ')':
							goto IL_FB;
						default:
							goto IL_1F1;
						}
					}
					else
					{
						if (this.field_1 < this.field_0.Length)
						{
							flag4 = true;
							continue;
						}
						continue;
					}
				}
				else
				{
					if (c2 == '.')
					{
						if (this.field_1 > sayıInt_0)
						{
							string text = this.field_0.Substring(sayıInt_0, this.field_1 - sayıInt_0);
							if (text == "*")
							{
								text = null;
							}
							Class_329 item = flag ? new Class_341
							{
								prop_0 = text
							} : new Class_333
							{
								prop_0 = text
							};
							arg_0.Add(item);
							flag = false;
						}
						if (this.field_1 + 1 < this.field_0.Length && this.field_0[this.field_1 + 1] == '.')
						{
							flag = true;
							this.field_1++;
						}
						this.field_1++;
						sayıInt_0 = this.field_1;
						flag2 = false;
						flag3 = true;
						continue;
					}
					switch (c2)
					{
					case '[':
						break;
					case '\\':
						goto IL_1F1;
					case ']':
						goto IL_FB;
					default:
						goto IL_1F1;
					}
				}
				if (this.field_1 > sayıInt_0)
				{
					string str_ = this.field_0.Substring(sayıInt_0, this.field_1 - sayıInt_0);
					Class_329 item2 = flag ? new Class_341
					{
						prop_0 = str_
					} : new Class_333
					{
						prop_0 = str_
					};
					arg_0.Add(item2);
					flag = false;
				}
				arg_0.Add(this.tmethod_2272(c));
				this.field_1++;
				sayıInt_0 = this.field_1;
				flag2 = true;
				flag3 = false;
				continue;
				IL_FB:
				flag4 = true;
				continue;
				IL_1F1:
				if (bool_0 && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
				{
					flag4 = true;
				}
				else
				{
					if (flag2)
					{
						throw new Class_318("Unexpected character following indexer: " + c);
					}
					this.field_1++;
				}
			}
			bool flag5 = this.field_1 == this.field_0.Length;
			if (this.field_1 > sayıInt_0)
			{
				string text2 = this.field_0.Substring(sayıInt_0, this.field_1 - sayıInt_0).TrimEnd(new char[0]);
				if (text2 == "*")
				{
					text2 = null;
				}
				Class_329 item3 = flag ? new Class_341
				{
					prop_0 = text2
				} : new Class_333
				{
					prop_0 = text2
				};
				arg_0.Add(item3);
			}
			else if (flag3 && (flag5 || bool_0))
			{
				throw new Class_318("Unexpected end while parsing path.");
			}
			return flag5;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00046118 File Offset: 0x00044318
		private Class_329 tmethod_2272(char char_0)
		{
			this.field_1++;
			char char_ = (char_0 == '[') ? ']' : ')';
			this.tmethod_2282("Path ended with open indexer.");
			this.cmethod_2274();
			if (this.field_0[this.field_1] == '\'')
			{
				return this.xmethod_2281(char_);
			}
			if (this.field_0[this.field_1] == '?')
			{
				return this.vmethod_2275(char_);
			}
			return this.gmethod_2273(char_);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000461A0 File Offset: 0x000443A0
		private Class_329 gmethod_2273(char char_0)
		{
			int num = this.field_1;
			int? num2 = null;
			List<int> list = null;
			int num3 = 0;
			int? arg_ = null;
			int? arg_2 = null;
			int? arg_3 = null;
			while (this.field_1 < this.field_0.Length)
			{
				char c = this.field_0[this.field_1];
				if (c == ' ')
				{
					num2 = new int?(this.field_1);
					this.cmethod_2274();
				}
				else if (c == char_0)
				{
					int num4 = (num2 ?? this.field_1) - num;
					if (list != null)
					{
						if (num4 == 0)
						{
							throw new Class_318("Array index expected.");
						}
						string value = this.field_0.Substring(num, num4);
						int item = Convert.ToInt32(value, CultureInfo.InvariantCulture);
						list.Add(item);
						return new Class_331
						{
							prop_0 = list
						};
					}
					else
					{
						if (num3 > 0)
						{
							if (num4 > 0)
							{
								string value2 = this.field_0.Substring(num, num4);
								int value3 = Convert.ToInt32(value2, CultureInfo.InvariantCulture);
								if (num3 == 1)
								{
									arg_2 = new int?(value3);
								}
								else
								{
									arg_3 = new int?(value3);
								}
							}
							return new Class_332
							{
								prop_0 = arg_,
								prop_1 = arg_2,
								prop_2 = arg_3
							};
						}
						if (num4 == 0)
						{
							throw new Class_318("Array index expected.");
						}
						string value4 = this.field_0.Substring(num, num4);
						int value5 = Convert.ToInt32(value4, CultureInfo.InvariantCulture);
						return new Class_330
						{
							prop_0 = new int?(value5)
						};
					}
				}
				else if (c == ',')
				{
					int num5 = (num2 ?? this.field_1) - num;
					if (num5 == 0)
					{
						throw new Class_318("Array index expected.");
					}
					if (list == null)
					{
						list = new List<int>();
					}
					string value6 = this.field_0.Substring(num, num5);
					list.Add(Convert.ToInt32(value6, CultureInfo.InvariantCulture));
					this.field_1++;
					this.cmethod_2274();
					num = this.field_1;
					num2 = null;
				}
				else if (c == '*')
				{
					this.field_1++;
					this.tmethod_2282("Path ended with open indexer.");
					this.cmethod_2274();
					if (this.field_0[this.field_1] != char_0)
					{
						throw new Class_318("Unexpected character while parsing path indexer: " + c);
					}
					return new Class_330();
				}
				else if (c == ':')
				{
					int num6 = (num2 ?? this.field_1) - num;
					if (num6 > 0)
					{
						string value7 = this.field_0.Substring(num, num6);
						int value8 = Convert.ToInt32(value7, CultureInfo.InvariantCulture);
						if (num3 == 0)
						{
							arg_ = new int?(value8);
						}
						else if (num3 == 1)
						{
							arg_2 = new int?(value8);
						}
						else
						{
							arg_3 = new int?(value8);
						}
					}
					num3++;
					this.field_1++;
					this.cmethod_2274();
					num = this.field_1;
					num2 = null;
				}
				else
				{
					if (!char.IsDigit(c) && c != '-')
					{
						throw new Class_318("Unexpected character while parsing path indexer: " + c);
					}
					if (num2 != null)
					{
						throw new Class_318("Unexpected character while parsing path indexer: " + c);
					}
					this.field_1++;
				}
			}
			throw new Class_318("Path ended with open indexer.");
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00046568 File Offset: 0x00044768
		private void cmethod_2274()
		{
			while (this.field_1 < this.field_0.Length)
			{
				if (this.field_0[this.field_1] != ' ')
				{
					return;
				}
				this.field_1++;
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000465B4 File Offset: 0x000447B4
		private Class_329 vmethod_2275(char char_0)
		{
			this.field_1++;
			this.tmethod_2282("Path ended with open indexer.");
			if (this.field_0[this.field_1] != '(')
			{
				throw new Class_318("Unexpected character while parsing path indexer: " + this.field_0[this.field_1]);
			}
			this.field_1++;
			Class_337 arg_ = this.dmethod_2276();
			this.field_1++;
			this.tmethod_2282("Path ended with open indexer.");
			this.cmethod_2274();
			if (this.field_0[this.field_1] != char_0)
			{
				throw new Class_318("Unexpected character while parsing path indexer: " + this.field_0[this.field_1]);
			}
			return new Class_340
			{
				prop_0 = arg_
			};
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00046698 File Offset: 0x00044898
		private Class_337 dmethod_2276()
		{
			Class_337 class_ = null;
			Class_338 class_2 = null;
			while (this.field_1 < this.field_0.Length)
			{
				this.cmethod_2274();
				if (this.field_0[this.field_1] != '@')
				{
					throw new Class_318("Unexpected character while parsing path query: " + this.field_0[this.field_1]);
				}
				this.field_1++;
				List<Class_329> arg_ = new List<Class_329>();
				if (this.xmethod_2271(arg_, this.field_1, true))
				{
					throw new Class_318("Path ended with open query.");
				}
				this.cmethod_2274();
				this.tmethod_2282("Path ended with open query.");
				object obje_ = null;
				Class_336 class_3;
				if (this.field_0[this.field_1] == ')' || this.field_0[this.field_1] == '|' || this.field_0[this.field_1] == '&')
				{
					class_3 = Class_336.Exists;
				}
				else
				{
					class_3 = this.smethod_2280();
					this.cmethod_2274();
					this.tmethod_2282("Path ended with open query.");
					obje_ = this.kmethod_2277();
					this.cmethod_2274();
					this.tmethod_2282("Path ended with open query.");
				}
				Class_339 class_4 = new Class_339
				{
					prop_0 = arg_,
					prop_0 = class_3,
					prop_1 = ((class_3 != Class_336.Exists) ? new Class_362(obje_) : null)
				};
				if (this.field_0[this.field_1] == ')')
				{
					if (class_2 != null)
					{
						class_2.prop_0.Add(class_4);
						return class_;
					}
					return class_4;
				}
				else
				{
					if (this.field_0[this.field_1] == '&' && this.pmethod_2279("&&"))
					{
						if (class_2 == null || class_2.prop_0 != Class_336.And)
						{
							Class_338 class_5 = new Class_338
							{
								prop_0 = Class_336.And
							};
							if (class_2 != null)
							{
								class_2.prop_0.Add(class_5);
							}
							class_2 = class_5;
							if (class_ == null)
							{
								class_ = class_2;
							}
						}
						class_2.prop_0.Add(class_4);
					}
					if (this.field_0[this.field_1] == '|' && this.pmethod_2279("||"))
					{
						if (class_2 == null || class_2.prop_0 != Class_336.Or)
						{
							Class_338 class_6 = new Class_338
							{
								prop_0 = Class_336.Or
							};
							if (class_2 != null)
							{
								class_2.prop_0.Add(class_6);
							}
							class_2 = class_6;
							if (class_ == null)
							{
								class_ = class_2;
							}
						}
						class_2.prop_0.Add(class_4);
					}
				}
			}
			throw new Class_318("Path ended with open query.");
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00046934 File Offset: 0x00044B34
		private object kmethod_2277()
		{
			char c = this.field_0[this.field_1];
			if (c == '\'')
			{
				return this.lmethod_2278();
			}
			if (char.IsDigit(c) || c == '-')
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(c);
				this.field_1++;
				while (this.field_1 < this.field_0.Length)
				{
					c = this.field_0[this.field_1];
					if (c == ' ' || c == ')')
					{
						string text = stringBuilder.ToString();
						if (text.IndexOfAny(new char[]
						{
							'.',
							'E',
							'e'
						}) != -1)
						{
							double num;
							if (double.TryParse(text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num))
							{
								return num;
							}
							throw new Class_318("Could not read query value.");
						}
						else
						{
							long num2;
							if (long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out num2))
							{
								return num2;
							}
							throw new Class_318("Could not read query value.");
						}
					}
					else
					{
						stringBuilder.Append(c);
						this.field_1++;
					}
				}
			}
			else if (c == 't')
			{
				if (this.pmethod_2279("true"))
				{
					return true;
				}
			}
			else if (c == 'f')
			{
				if (this.pmethod_2279("false"))
				{
					return false;
				}
			}
			else if (c == 'n' && this.pmethod_2279("null"))
			{
				return null;
			}
			throw new Class_318("Could not read query value.");
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00046AC0 File Offset: 0x00044CC0
		private string lmethod_2278()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.field_1++;
			while (this.field_1 < this.field_0.Length)
			{
				char c = this.field_0[this.field_1];
				if (c == '\\' && this.field_1 + 1 < this.field_0.Length)
				{
					this.field_1++;
					if (this.field_0[this.field_1] == '\'')
					{
						stringBuilder.Append('\'');
					}
					else
					{
						if (this.field_0[this.field_1] != '\\')
						{
							throw new Class_318("Unknown escape chracter: \\" + this.field_0[this.field_1]);
						}
						stringBuilder.Append('\\');
					}
					this.field_1++;
				}
				else
				{
					if (c == '\'')
					{
						this.field_1++;
						return stringBuilder.ToString();
					}
					this.field_1++;
					stringBuilder.Append(c);
				}
			}
			throw new Class_318("Path ended with an open string.");
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00046C00 File Offset: 0x00044E00
		private bool pmethod_2279(string str_0)
		{
			int num = this.field_1;
			foreach (char c in str_0)
			{
				if (num >= this.field_0.Length || this.field_0[num] != c)
				{
					return false;
				}
				num++;
			}
			this.field_1 = num;
			return true;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00046C74 File Offset: 0x00044E74
		private Class_336 smethod_2280()
		{
			if (this.field_1 + 1 >= this.field_0.Length)
			{
				throw new Class_318("Path ended with open query.");
			}
			if (this.pmethod_2279("=="))
			{
				return Class_336.Equals;
			}
			if (this.pmethod_2279("!=") || this.pmethod_2279("<>"))
			{
				return Class_336.NotEquals;
			}
			if (this.pmethod_2279("<="))
			{
				return Class_336.LessThanOrEquals;
			}
			if (this.pmethod_2279("<"))
			{
				return Class_336.LessThan;
			}
			if (this.pmethod_2279(">="))
			{
				return Class_336.GreaterThanOrEquals;
			}
			if (this.pmethod_2279(">"))
			{
				return Class_336.GreaterThan;
			}
			throw new Class_318("Could not read query operator.");
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00046D2C File Offset: 0x00044F2C
		private Class_329 xmethod_2281(char char_0)
		{
			List<string> list = null;
			while (this.field_1 < this.field_0.Length)
			{
				string text = this.lmethod_2278();
				this.cmethod_2274();
				this.tmethod_2282("Path ended with open indexer.");
				if (this.field_0[this.field_1] == char_0)
				{
					if (list != null)
					{
						list.Add(text);
						return new Class_334
						{
							prop_0 = list
						};
					}
					return new Class_333
					{
						prop_0 = text
					};
				}
				else
				{
					if (this.field_0[this.field_1] != ',')
					{
						throw new Class_318("Unexpected character while parsing path indexer: " + this.field_0[this.field_1]);
					}
					this.field_1++;
					this.cmethod_2274();
					if (list == null)
					{
						list = new List<string>();
					}
					list.Add(text);
				}
			}
			throw new Class_318("Path ended with open indexer.");
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00046E24 File Offset: 0x00045024
		private void tmethod_2282(string str_0)
		{
			if (this.field_1 >= this.field_0.Length)
			{
				throw new Class_318(str_0);
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00046E43 File Offset: 0x00045043
		internal IEnumerable<Class_361> gmethod_2283(Class_361 arg_0, bool bool_0)
		{
			return Class_335.cmethod_2284(this.prop_0, arg_0, bool_0);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00046E54 File Offset: 0x00045054
		internal static IEnumerable<Class_361> cmethod_2284(List<Class_329> arg_0, Class_361 arg_1, bool bool_0)
		{
			IEnumerable<Class_361> enumerable = new Class_361[]
			{
				arg_1
			};
			foreach (Class_329 class_ in arg_0)
			{
				enumerable = class_.vmethod_2245(enumerable, bool_0);
			}
			return enumerable;
		}

		// Token: 0x0400082F RID: 2095
		private readonly string field_0;

		// Token: 0x04000830 RID: 2096
		private int field_1;

		// Token: 0x04000831 RID: 2097
		[CompilerGenerated]
		private List<Class_329> field_2;
	}
}
