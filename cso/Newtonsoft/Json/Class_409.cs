using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200021C RID: 540
	public class Class_409 : Class_285, Class_353
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x000522DE File Offset: 0x000504DE
		public Class_409(TextReader arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.field_2 = arg_0;
			this.field_7 = 1;
			this.field_3 = new char[1025];
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00052315 File Offset: 0x00050515
		private Class_509 cmethod_2984()
		{
			if (this.field_9 == null)
			{
				this.field_9 = new Class_509(1025);
			}
			else
			{
				this.field_9.prop_0 = 0;
			}
			return this.field_9;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00052349 File Offset: 0x00050549
		private void vmethod_2985(int sayıInt_0)
		{
			this.field_7++;
			this.field_6 = sayıInt_0 - 1;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00052364 File Offset: 0x00050564
		private void dmethod_2986(char char_0)
		{
			this.field_5++;
			this.lmethod_2988();
			this.xmethod_3001(char_0);
			base.cmethod_1904(true);
			if (this.field_4 == Class_408.ReadAsBytes)
			{
				byte[] obje_;
				if (this.field_10.Length == 0)
				{
					obje_ = new byte[0];
				}
				else
				{
					obje_ = Convert.FromBase64CharArray(this.field_10.Chars, this.field_10.StartIndex, this.field_10.Length);
				}
				base.gmethod_1903(Class_508.Bytes, obje_, false);
				return;
			}
			if (this.field_4 == Class_408.ReadAsString)
			{
				string obje_2 = this.field_10.ToString();
				base.gmethod_1903(Class_508.String, obje_2, false);
				this.field_2 = char_0;
				return;
			}
			string text = this.field_10.ToString();
			if (this.field_10 != Class_320.None)
			{
				Class_320 dateParseHandling;
				if (this.field_4 == Class_408.ReadAsDateTime)
				{
					dateParseHandling = Class_320.DateTime;
				}
				else if (this.field_4 == Class_408.ReadAsDateTimeOffset)
				{
					dateParseHandling = Class_320.DateTimeOffset;
				}
				else
				{
					dateParseHandling = this.field_10;
				}
				object obje_3;
				if (Class_502.TryParseDateTime(text, dateParseHandling, base.prop_4, base.prop_7, base.prop_14, out obje_3))
				{
					base.gmethod_1903(Class_508.Date, obje_3, false);
					return;
				}
			}
			base.gmethod_1903(Class_508.String, text, false);
			this.field_2 = char_0;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000524A4 File Offset: 0x000506A4
		private static void kmethod_2987(char[] charDizi_0, int sayıInt_0, char[] charDizi_1, int sayıInt_1, int sayıInt_2)
		{
			Buffer.BlockCopy(charDizi_0, sayıInt_0 * 2, charDizi_1, sayıInt_1 * 2, sayıInt_2 * 2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000524B8 File Offset: 0x000506B8
		private void lmethod_2988()
		{
			int num = this.field_3.Length;
			if ((double)(num - this.field_5) <= (double)num * 0.1)
			{
				int num2 = this.field_4 - this.field_5;
				if (num2 > 0)
				{
					Class_409.kmethod_2987(this.field_3, this.field_5, this.field_3, 0, num2);
				}
				this.field_6 -= this.field_5;
				this.field_5 = 0;
				this.field_4 = num2;
				this.field_3[this.field_4] = '\0';
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00052545 File Offset: 0x00050745
		private int pmethod_2989(bool bool_0)
		{
			return this.smethod_2990(bool_0, 0);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00052550 File Offset: 0x00050750
		private int smethod_2990(bool bool_0, int sayıInt_0)
		{
			if (this.field_8)
			{
				return 0;
			}
			if (this.field_4 + sayıInt_0 >= this.field_3.Length - 1)
			{
				if (bool_0)
				{
					int num = Math.Max(this.field_3.Length * 2, this.field_4 + sayıInt_0 + 1);
					char[] charDizi_ = new char[num];
					Class_409.kmethod_2987(this.field_3, 0, charDizi_, 0, this.field_3.Length);
					this.field_3 = charDizi_;
				}
				else
				{
					int num2 = this.field_4 - this.field_5;
					if (num2 + sayıInt_0 + 1 >= this.field_3.Length)
					{
						char[] charDizi_2 = new char[num2 + sayıInt_0 + 1];
						if (num2 > 0)
						{
							Class_409.kmethod_2987(this.field_3, this.field_5, charDizi_2, 0, num2);
						}
						this.field_3 = charDizi_2;
					}
					else if (num2 > 0)
					{
						Class_409.kmethod_2987(this.field_3, this.field_5, this.field_3, 0, num2);
					}
					this.field_6 -= this.field_5;
					this.field_5 = 0;
					this.field_4 = num2;
				}
			}
			int count = this.field_3.Length - this.field_4 - 1;
			int num3 = this.field_2.Read(this.field_3, this.field_4, count);
			this.field_4 += num3;
			if (num3 == 0)
			{
				this.field_8 = true;
			}
			this.field_3[this.field_4] = '\0';
			return num3;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000526B8 File Offset: 0x000508B8
		private bool xmethod_2991(int sayıInt_0, bool bool_0)
		{
			return this.field_5 + sayıInt_0 < this.field_4 || this.tmethod_2992(sayıInt_0, bool_0);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000526D8 File Offset: 0x000508D8
		private bool tmethod_2992(int sayıInt_0, bool bool_0)
		{
			if (this.field_8)
			{
				return false;
			}
			int num = this.field_5 + sayıInt_0 - this.field_4 + 1;
			int num2 = 0;
			do
			{
				int num3 = this.smethod_2990(bool_0, num - num2);
				if (num3 == 0)
				{
					break;
				}
				num2 += num3;
			}
			while (num2 < num);
			return num2 >= num;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00052729 File Offset: 0x00050929
		[DebuggerStepThrough]
		public virtual bool gmethod_2993()
		{
			this.field_4 = Class_408.Read;
			if (!this.tmethod_1892())
			{
				base.xmethod_1901(Class_508.None);
				return false;
			}
			return true;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0003F9F9 File Offset: 0x0003DBF9
		public virtual byte[] cmethod_2994()
		{
			return base.cmethod_1894();
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0003FA01 File Offset: 0x0003DC01
		public virtual decimal? vmethod_2995()
		{
			return base.vmethod_1895();
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0003FA09 File Offset: 0x0003DC09
		public virtual int? dmethod_2996()
		{
			return base.dmethod_1896();
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0003FA11 File Offset: 0x0003DC11
		public virtual string kmethod_2997()
		{
			return base.kmethod_1897();
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0003FA19 File Offset: 0x0003DC19
		public virtual DateTime? lmethod_2998()
		{
			return base.lmethod_1898();
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0003FA21 File Offset: 0x0003DC21
		public virtual DateTimeOffset? pmethod_2999()
		{
			return base.gmethod_1893();
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00052748 File Offset: 0x00050948
		internal virtual bool smethod_3000()
		{
			for (;;)
			{
				switch (this.field_3)
				{
				case Class_285.NClass_0.field_5:
				case Class_285.NClass_0.field_7:
				case Class_285.NClass_0.field_10:
				case Class_285.NClass_0.field_11:
				case Class_285.NClass_0.field_14:
				case Class_285.NClass_0.field_15:
					goto IL_46;
				case Class_285.NClass_0.field_8:
				case Class_285.NClass_0.field_9:
					goto IL_4D;
				case Class_285.NClass_0.field_13:
					if (this.dmethod_3006())
					{
						return true;
					}
					continue;
				case Class_285.NClass_0.field_17:
					goto IL_5E;
				}
				break;
			}
			goto IL_C6;
			IL_46:
			return this.xmethod_3011();
			IL_4D:
			return this.kmethod_3007();
			IL_5E:
			if (!this.xmethod_2991(0, false))
			{
				return false;
			}
			this.cmethod_3014(false);
			if (this.field_8)
			{
				return false;
			}
			if (this.field_3[this.field_5] == '/')
			{
				this.lmethod_3018();
				return true;
			}
			throw Class_414.lmethod_3098(this, "Additional text encountered after finished reading JSON content: {0}.".FormatWith(CultureInfo.InvariantCulture, this.field_3[this.field_5]));
			IL_C6:
			throw Class_414.lmethod_3098(this, "Unexpected state: {0}.".FormatWith(CultureInfo.InvariantCulture, base.prop_0));
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0005283C File Offset: 0x00050A3C
		private void xmethod_3001(char char_0)
		{
			int num = this.field_5;
			int num2 = this.field_5;
			int num3 = this.field_5;
			Class_509 class_ = null;
			char c2;
			for (;;)
			{
				char c = this.field_3[num++];
				if (c <= '\r')
				{
					if (c != '\0')
					{
						if (c != '\n')
						{
							if (c == '\r')
							{
								this.field_5 = num - 1;
								this.gmethod_3013(true);
								num = this.field_5;
							}
						}
						else
						{
							this.field_5 = num - 1;
							this.tmethod_3012();
							num = this.field_5;
						}
					}
					else if (this.field_4 == num - 1)
					{
						num--;
						if (this.pmethod_2989(true) == 0)
						{
							break;
						}
					}
				}
				else if (c != '"' && c != '\'')
				{
					if (c == '\\')
					{
						this.field_5 = num;
						if (!this.xmethod_2991(0, true))
						{
							goto Block_10;
						}
						int sayıInt_ = num - 1;
						c2 = this.field_3[num];
						char c3 = c2;
						char c4;
						if (c3 <= '\\')
						{
							if (c3 <= '\'')
							{
								if (c3 != '"' && c3 != '\'')
								{
									goto Block_14;
								}
							}
							else if (c3 != '/')
							{
								if (c3 != '\\')
								{
									goto Block_16;
								}
								num++;
								c4 = '\\';
								goto IL_2F8;
							}
							c4 = c2;
							num++;
						}
						else if (c3 <= 'f')
						{
							if (c3 != 'b')
							{
								if (c3 != 'f')
								{
									goto Block_19;
								}
								num++;
								c4 = '\f';
							}
							else
							{
								num++;
								c4 = '\b';
							}
						}
						else
						{
							if (c3 != 'n')
							{
								switch (c3)
								{
								case 'r':
									num++;
									c4 = '\r';
									goto IL_2F8;
								case 't':
									num++;
									c4 = '\t';
									goto IL_2F8;
								case 'u':
									num++;
									this.field_5 = num;
									c4 = this.gmethod_3003();
									if (char.IsLowSurrogate(c4))
									{
										c4 = '�';
									}
									else if (char.IsHighSurrogate(c4))
									{
										bool flag;
										do
										{
											flag = false;
											if (this.xmethod_2991(2, true) && this.field_3[this.field_5] == '\\' && this.field_3[this.field_5 + 1] == 'u')
											{
												char char_ = c4;
												this.field_5 += 2;
												c4 = this.gmethod_3003();
												if (!char.IsLowSurrogate(c4))
												{
													if (char.IsHighSurrogate(c4))
													{
														char_ = '�';
														flag = true;
													}
													else
													{
														char_ = '�';
													}
												}
												if (class_ == null)
												{
													class_ = this.cmethod_2984();
												}
												this.tmethod_3002(class_, char_, num3, sayıInt_);
												num3 = this.field_5;
											}
											else
											{
												c4 = '�';
											}
										}
										while (flag);
									}
									num = this.field_5;
									goto IL_2F8;
								}
								goto Block_21;
							}
							num++;
							c4 = '\n';
						}
						IL_2F8:
						if (class_ == null)
						{
							class_ = this.cmethod_2984();
						}
						this.tmethod_3002(class_, c4, num3, sayıInt_);
						num3 = num;
					}
				}
				else if (this.field_3[num - 1] == char_0)
				{
					goto Block_30;
				}
			}
			this.field_5 = num;
			throw Class_414.lmethod_3098(this, "Unterminated string. Expected delimiter: {0}.".FormatWith(CultureInfo.InvariantCulture, char_0));
			Block_10:
			this.field_5 = num;
			throw Class_414.lmethod_3098(this, "Unterminated string. Expected delimiter: {0}.".FormatWith(CultureInfo.InvariantCulture, char_0));
			Block_14:
			Block_16:
			Block_19:
			Block_21:
			num++;
			this.field_5 = num;
			throw Class_414.lmethod_3098(this, "Bad JSON escape sequence: {0}.".FormatWith(CultureInfo.InvariantCulture, "\\" + c2));
			Block_30:
			num--;
			if (num2 == num3)
			{
				this.field_10 = new Class_492(this.field_3, num2, num - num2);
			}
			else
			{
				if (class_ == null)
				{
					class_ = this.cmethod_2984();
				}
				if (num > num3)
				{
					class_.lmethod_4138(this.field_3, num3, num - num3);
				}
				this.field_10 = new Class_492(class_.gmethod_4143(), 0, class_.prop_0);
			}
			num++;
			this.field_5 = num;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00052C14 File Offset: 0x00050E14
		private void tmethod_3002(Class_509 arg_0, char char_0, int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_1 > sayıInt_0)
			{
				arg_0.lmethod_4138(this.field_3, sayıInt_0, sayıInt_1 - sayıInt_0);
			}
			arg_0.kmethod_4137(char_0);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00052C38 File Offset: 0x00050E38
		private char gmethod_3003()
		{
			if (this.xmethod_2991(4, true))
			{
				string s = new string(this.field_3, this.field_5, 4);
				char c = Convert.ToChar(int.Parse(s, NumberStyles.HexNumber, NumberFormatInfo.InvariantInfo));
				char result = c;
				this.field_5 += 4;
				return result;
			}
			throw Class_414.lmethod_3098(this, "Unexpected end while parsing unicode character.");
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00052CA0 File Offset: 0x00050EA0
		private void cmethod_3004()
		{
			int num = this.field_5;
			for (;;)
			{
				char c = this.field_3[num];
				if (c <= 'F')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '+':
						case '-':
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
						case 'A':
						case 'B':
						case 'C':
						case 'D':
						case 'E':
						case 'F':
							goto IL_F3;
						}
						break;
					}
					this.field_5 = num;
					if (this.field_4 != num || this.pmethod_2989(true) == 0)
					{
						return;
					}
					continue;
				}
				else if (c != 'X')
				{
					switch (c)
					{
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
						break;
					default:
						if (c != 'x')
						{
							goto Block_6;
						}
						break;
					}
				}
				IL_F3:
				num++;
			}
			Block_6:
			this.field_5 = num;
			char c2 = this.field_3[this.field_5];
			if (char.IsWhiteSpace(c2) || c2 == ',' || c2 == '}' || c2 == ']' || c2 == ')' || c2 == '/')
			{
				return;
			}
			throw Class_414.lmethod_3098(this, "Unexpected character encountered while parsing number: {0}.".FormatWith(CultureInfo.InvariantCulture, c2));
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00052E0D File Offset: 0x0005100D
		private void vmethod_3005()
		{
			if (this.field_9 != null)
			{
				this.field_9.prop_0 = 0;
			}
			this.field_10 = default(Class_492);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00052E34 File Offset: 0x00051034
		private bool dmethod_3006()
		{
			char c;
			for (;;)
			{
				c = this.field_3[this.field_5];
				char c2 = c;
				if (c2 <= ')')
				{
					if (c2 <= '\r')
					{
						if (c2 != '\0')
						{
							switch (c2)
							{
							case '\t':
								break;
							case '\n':
								this.tmethod_3012();
								continue;
							case '\v':
							case '\f':
								goto IL_15A;
							case '\r':
								this.gmethod_3013(false);
								continue;
							default:
								goto IL_15A;
							}
						}
						else
						{
							if (this.field_4 != this.field_5)
							{
								this.field_5++;
								continue;
							}
							if (this.pmethod_2989(false) == 0)
							{
								break;
							}
							continue;
						}
					}
					else if (c2 != ' ')
					{
						if (c2 != ')')
						{
							goto IL_15A;
						}
						goto IL_FA;
					}
					this.field_5++;
					continue;
				}
				if (c2 <= '/')
				{
					if (c2 == ',')
					{
						goto IL_11A;
					}
					if (c2 == '/')
					{
						goto IL_112;
					}
				}
				else
				{
					if (c2 == ']')
					{
						goto IL_E2;
					}
					if (c2 == '}')
					{
						goto IL_CA;
					}
				}
				IL_15A:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_178;
				}
				this.field_5++;
			}
			this.field_3 = Class_285.NClass_0.field_17;
			return false;
			IL_CA:
			this.field_5++;
			base.xmethod_1901(Class_508.EndObject);
			return true;
			IL_E2:
			this.field_5++;
			base.xmethod_1901(Class_508.EndArray);
			return true;
			IL_FA:
			this.field_5++;
			base.xmethod_1901(Class_508.EndConstructor);
			return true;
			IL_112:
			this.lmethod_3018();
			return true;
			IL_11A:
			this.field_5++;
			base.kmethod_1907();
			return false;
			IL_178:
			throw Class_414.lmethod_3098(this, "After parsing a value an unexpected character was encountered: {0}.".FormatWith(CultureInfo.InvariantCulture, c));
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00052FD4 File Offset: 0x000511D4
		private bool kmethod_3007()
		{
			for (;;)
			{
				char c = this.field_3[this.field_5];
				char c2 = c;
				if (c2 <= '\r')
				{
					if (c2 != '\0')
					{
						switch (c2)
						{
						case '\t':
							break;
						case '\n':
							this.tmethod_3012();
							continue;
						case '\v':
						case '\f':
							goto IL_D7;
						case '\r':
							this.gmethod_3013(false);
							continue;
						default:
							goto IL_D7;
						}
					}
					else
					{
						if (this.field_4 != this.field_5)
						{
							this.field_5++;
							continue;
						}
						if (this.pmethod_2989(false) == 0)
						{
							break;
						}
						continue;
					}
				}
				else if (c2 != ' ')
				{
					if (c2 == '/')
					{
						goto IL_A5;
					}
					if (c2 != '}')
					{
						goto IL_D7;
					}
					goto IL_8D;
				}
				this.field_5++;
				continue;
				IL_D7:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_F5;
				}
				this.field_5++;
			}
			return false;
			IL_8D:
			base.xmethod_1901(Class_508.EndObject);
			this.field_5++;
			return true;
			IL_A5:
			this.lmethod_3018();
			return true;
			IL_F5:
			return this.lmethod_3008();
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000530DC File Offset: 0x000512DC
		private bool lmethod_3008()
		{
			char c = this.field_3[this.field_5];
			char char_;
			if (c == '"' || c == '\'')
			{
				this.field_5++;
				char_ = c;
				this.lmethod_2988();
				this.xmethod_3001(char_);
			}
			else
			{
				if (!this.pmethod_3009(c))
				{
					throw Class_414.lmethod_3098(this, "Invalid property identifier character: {0}.".FormatWith(CultureInfo.InvariantCulture, this.field_3[this.field_5]));
				}
				char_ = '\0';
				this.lmethod_2988();
				this.smethod_3010();
			}
			string text;
			if (this.field_11 != null)
			{
				text = this.field_11.pmethod_4039(this.field_10.Chars, this.field_10.StartIndex, this.field_10.Length);
				if (text == null)
				{
					text = this.field_10.ToString();
				}
			}
			else
			{
				text = this.field_10.ToString();
			}
			this.cmethod_3014(false);
			if (this.field_3[this.field_5] != ':')
			{
				throw Class_414.lmethod_3098(this, "Invalid character after parsing property name. Expected ':' but got: {0}.".FormatWith(CultureInfo.InvariantCulture, this.field_3[this.field_5]));
			}
			this.field_5++;
			base.tmethod_1902(Class_508.PropertyName, text);
			this.field_2 = char_;
			this.vmethod_3005();
			return true;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0005323F File Offset: 0x0005143F
		private bool pmethod_3009(char char_0)
		{
			return char.IsLetterOrDigit(char_0) || char_0 == '_' || char_0 == '$';
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0005325C File Offset: 0x0005145C
		private void smethod_3010()
		{
			int num = this.field_5;
			char c2;
			for (;;)
			{
				char c = this.field_3[this.field_5];
				if (c == '\0')
				{
					if (this.field_4 != this.field_5)
					{
						goto IL_42;
					}
					if (this.pmethod_2989(true) == 0)
					{
						break;
					}
				}
				else
				{
					c2 = this.field_3[this.field_5];
					if (!this.pmethod_3009(c2))
					{
						goto IL_87;
					}
					this.field_5++;
				}
			}
			throw Class_414.lmethod_3098(this, "Unexpected end while parsing unquoted property name.");
			IL_42:
			this.field_10 = new Class_492(this.field_3, num, this.field_5 - num);
			return;
			IL_87:
			if (char.IsWhiteSpace(c2) || c2 == ':')
			{
				this.field_10 = new Class_492(this.field_3, num, this.field_5 - num);
				return;
			}
			throw Class_414.lmethod_3098(this, "Invalid JavaScript property identifier character: {0}.".FormatWith(CultureInfo.InvariantCulture, c2));
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0005333C File Offset: 0x0005153C
		private bool xmethod_3011()
		{
			char c;
			for (;;)
			{
				c = this.field_3[this.field_5];
				char c2 = c;
				if (c2 <= 'I')
				{
					if (c2 <= '\r')
					{
						if (c2 != '\0')
						{
							switch (c2)
							{
							case '\t':
								break;
							case '\n':
								this.tmethod_3012();
								continue;
							case '\v':
							case '\f':
								goto IL_29C;
							case '\r':
								this.gmethod_3013(false);
								continue;
							default:
								goto IL_29C;
							}
						}
						else
						{
							if (this.field_4 != this.field_5)
							{
								this.field_5++;
								continue;
							}
							if (this.pmethod_2989(false) == 0)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						switch (c2)
						{
						case ' ':
							break;
						case '!':
							goto IL_29C;
						case '"':
							goto IL_122;
						default:
							switch (c2)
							{
							case '\'':
								goto IL_122;
							case '(':
							case '*':
							case '+':
							case '.':
								goto IL_29C;
							case ')':
								goto IL_25A;
							case ',':
								goto IL_250;
							case '-':
								goto IL_1C4;
							case '/':
								goto IL_1FA;
							default:
								if (c2 != 'I')
								{
									goto IL_29C;
								}
								goto IL_1BC;
							}
							break;
						}
					}
					this.field_5++;
					continue;
				}
				if (c2 <= 'f')
				{
					if (c2 == 'N')
					{
						goto IL_1B4;
					}
					switch (c2)
					{
					case '[':
						goto IL_221;
					case '\\':
						break;
					case ']':
						goto IL_238;
					default:
						if (c2 == 'f')
						{
							goto IL_133;
						}
						break;
					}
				}
				else
				{
					if (c2 == 'n')
					{
						goto IL_13B;
					}
					switch (c2)
					{
					case 't':
						goto IL_12B;
					case 'u':
						goto IL_202;
					default:
						if (c2 == '{')
						{
							goto IL_20A;
						}
						break;
					}
				}
				IL_29C:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_2BA;
				}
				this.field_5++;
			}
			return false;
			IL_122:
			this.dmethod_2986(c);
			return true;
			IL_12B:
			this.tmethod_3022();
			return true;
			IL_133:
			this.vmethod_3025();
			return true;
			IL_13B:
			if (this.xmethod_2991(1, true))
			{
				char c3 = this.field_3[this.field_5 + 1];
				if (c3 == 'u')
				{
					this.gmethod_3023();
				}
				else
				{
					if (c3 != 'e')
					{
						throw Class_414.lmethod_3098(this, "Unexpected character encountered while parsing value: {0}.".FormatWith(CultureInfo.InvariantCulture, this.field_3[this.field_5]));
					}
					this.vmethod_3015();
				}
				return true;
			}
			throw Class_414.lmethod_3098(this, "Unexpected end.");
			IL_1B4:
			this.lmethod_3028();
			return true;
			IL_1BC:
			this.kmethod_3027();
			return true;
			IL_1C4:
			if (this.xmethod_2991(1, true) && this.field_3[this.field_5 + 1] == 'I')
			{
				this.dmethod_3026();
			}
			else
			{
				this.dmethod_3016();
			}
			return true;
			IL_1FA:
			this.lmethod_3018();
			return true;
			IL_202:
			this.cmethod_3024();
			return true;
			IL_20A:
			this.field_5++;
			base.xmethod_1901(Class_508.StartObject);
			return true;
			IL_221:
			this.field_5++;
			base.xmethod_1901(Class_508.StartArray);
			return true;
			IL_238:
			this.field_5++;
			base.xmethod_1901(Class_508.EndArray);
			return true;
			IL_250:
			base.xmethod_1901(Class_508.Undefined);
			return true;
			IL_25A:
			this.field_5++;
			base.xmethod_1901(Class_508.EndConstructor);
			return true;
			IL_2BA:
			if (char.IsNumber(c) || c == '-' || c == '.')
			{
				this.dmethod_3016();
				return true;
			}
			throw Class_414.lmethod_3098(this, "Unexpected character encountered while parsing value: {0}.".FormatWith(CultureInfo.InvariantCulture, c));
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00053641 File Offset: 0x00051841
		private void tmethod_3012()
		{
			this.field_5++;
			this.vmethod_2985(this.field_5);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00053660 File Offset: 0x00051860
		private void gmethod_3013(bool bool_0)
		{
			this.field_5++;
			if (this.xmethod_2991(1, bool_0) && this.field_3[this.field_5] == '\n')
			{
				this.field_5++;
			}
			this.vmethod_2985(this.field_5);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000536B8 File Offset: 0x000518B8
		private bool cmethod_3014(bool bool_0)
		{
			bool flag = false;
			bool flag2 = false;
			while (!flag)
			{
				char c = this.field_3[this.field_5];
				char c2 = c;
				if (c2 != '\0')
				{
					if (c2 != '\n')
					{
						if (c2 != '\r')
						{
							if (c == ' ' || char.IsWhiteSpace(c))
							{
								flag2 = true;
								this.field_5++;
							}
							else
							{
								flag = true;
							}
						}
						else
						{
							this.gmethod_3013(false);
						}
					}
					else
					{
						this.tmethod_3012();
					}
				}
				else if (this.field_4 == this.field_5)
				{
					if (this.pmethod_2989(false) == 0)
					{
						flag = true;
					}
				}
				else
				{
					this.field_5++;
				}
			}
			return !bool_0 || flag2;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00053784 File Offset: 0x00051984
		private void vmethod_3015()
		{
			if (!this.smethod_3020("new"))
			{
				throw Class_414.lmethod_3098(this, "Unexpected content while parsing JSON.");
			}
			this.cmethod_3014(false);
			int num = this.field_5;
			char c;
			for (;;)
			{
				c = this.field_3[this.field_5];
				if (c == '\0')
				{
					if (this.field_4 != this.field_5)
					{
						goto IL_59;
					}
					if (this.pmethod_2989(true) == 0)
					{
						break;
					}
				}
				else
				{
					if (!char.IsLetterOrDigit(c))
					{
						goto IL_8E;
					}
					this.field_5++;
				}
			}
			throw Class_414.lmethod_3098(this, "Unexpected end while parsing constructor.");
			IL_59:
			int num2 = this.field_5;
			this.field_5++;
			goto IL_118;
			IL_8E:
			if (c == '\r')
			{
				num2 = this.field_5;
				this.gmethod_3013(true);
			}
			else if (c == '\n')
			{
				num2 = this.field_5;
				this.tmethod_3012();
			}
			else if (char.IsWhiteSpace(c))
			{
				num2 = this.field_5;
				this.field_5++;
			}
			else
			{
				if (c != '(')
				{
					throw Class_414.lmethod_3098(this, "Unexpected character while parsing constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, c));
				}
				num2 = this.field_5;
			}
			IL_118:
			this.field_10 = new Class_492(this.field_3, num, num2 - num);
			string obje_ = this.field_10.ToString();
			this.cmethod_3014(false);
			if (this.field_3[this.field_5] != '(')
			{
				throw Class_414.lmethod_3098(this, "Unexpected character while parsing constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, this.field_3[this.field_5]));
			}
			this.field_5++;
			this.vmethod_3005();
			base.tmethod_1902(Class_508.StartConstructor, obje_);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0005393C File Offset: 0x00051B3C
		private void dmethod_3016()
		{
			this.lmethod_2988();
			char c = this.field_3[this.field_5];
			int num = this.field_5;
			this.cmethod_3004();
			base.cmethod_1904(true);
			this.field_10 = new Class_492(this.field_3, num, this.field_5 - num);
			bool flag = char.IsDigit(c) && this.field_10.Length == 1;
			bool flag2 = c == '0' && this.field_10.Length > 1 && this.field_10.Chars[this.field_10.StartIndex + 1] != '.' && this.field_10.Chars[this.field_10.StartIndex + 1] != 'e' && this.field_10.Chars[this.field_10.StartIndex + 1] != 'E';
			object obje_;
			Class_508 arg_2;
			if (this.field_4 == Class_408.ReadAsInt32)
			{
				if (flag)
				{
					obje_ = (int)(c - '0');
				}
				else
				{
					if (flag2)
					{
						string text = this.field_10.ToString();
						try
						{
							int num2 = text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(text, 16) : Convert.ToInt32(text, 8);
							obje_ = num2;
							goto IL_207;
						}
						catch (Exception arg_)
						{
							throw Class_414.pmethod_3099(this, "Input string '{0}' is not a valid integer.".FormatWith(CultureInfo.InvariantCulture, text), arg_);
						}
					}
					int num3;
					Class_498 class_ = Class_499.Int32TryParse(this.field_10.Chars, this.field_10.StartIndex, this.field_10.Length, out num3);
					if (class_ == Class_498.Success)
					{
						obje_ = num3;
					}
					else
					{
						if (class_ == Class_498.Overflow)
						{
							throw Class_414.lmethod_3098(this, "JSON integer {0} is too large or small for an Int32.".FormatWith(CultureInfo.InvariantCulture, this.field_10.ToString()));
						}
						throw Class_414.lmethod_3098(this, "Input string '{0}' is not a valid integer.".FormatWith(CultureInfo.InvariantCulture, this.field_10.ToString()));
					}
				}
				IL_207:
				arg_2 = Class_508.Integer;
			}
			else if (this.field_4 == Class_408.ReadAsDecimal)
			{
				if (flag)
				{
					obje_ = c - 48m;
				}
				else
				{
					if (flag2)
					{
						string text2 = this.field_10.ToString();
						try
						{
							long value = text2.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text2, 16) : Convert.ToInt64(text2, 8);
							obje_ = Convert.ToDecimal(value);
							goto IL_311;
						}
						catch (Exception arg_3)
						{
							throw Class_414.pmethod_3099(this, "Input string '{0}' is not a valid decimal.".FormatWith(CultureInfo.InvariantCulture, text2), arg_3);
						}
					}
					string s = this.field_10.ToString();
					decimal num4;
					if (!decimal.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num4))
					{
						throw Class_414.lmethod_3098(this, "Input string '{0}' is not a valid decimal.".FormatWith(CultureInfo.InvariantCulture, this.field_10.ToString()));
					}
					obje_ = num4;
				}
				IL_311:
				arg_2 = Class_508.Float;
			}
			else if (flag)
			{
				obje_ = (long)((ulong)c - 48UL);
				arg_2 = Class_508.Integer;
			}
			else if (flag2)
			{
				string text3 = this.field_10.ToString();
				try
				{
					obje_ = (text3.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text3, 16) : Convert.ToInt64(text3, 8));
				}
				catch (Exception arg_4)
				{
					throw Class_414.pmethod_3099(this, "Input string '{0}' is not a valid number.".FormatWith(CultureInfo.InvariantCulture, text3), arg_4);
				}
				arg_2 = Class_508.Integer;
			}
			else
			{
				long num5;
				Class_498 class_2 = Class_499.Int64TryParse(this.field_10.Chars, this.field_10.StartIndex, this.field_10.Length, out num5);
				if (class_2 == Class_498.Success)
				{
					obje_ = num5;
					arg_2 = Class_508.Integer;
				}
				else if (class_2 == Class_498.Overflow)
				{
					string text4 = this.field_10.ToString();
					if (text4.Length > 380)
					{
						throw Class_414.lmethod_3098(this, "JSON integer {0} is too large to parse.".FormatWith(CultureInfo.InvariantCulture, this.field_10.ToString()));
					}
					obje_ = Class_409.kmethod_3017(text4, CultureInfo.InvariantCulture);
					arg_2 = Class_508.Integer;
				}
				else
				{
					string text5 = this.field_10.ToString();
					if (this.field_11 == Class_315.Decimal)
					{
						decimal num6;
						if (!decimal.TryParse(text5, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num6))
						{
							throw Class_414.lmethod_3098(this, "Input string '{0}' is not a valid decimal.".FormatWith(CultureInfo.InvariantCulture, text5));
						}
						obje_ = num6;
					}
					else
					{
						double num7;
						if (!double.TryParse(text5, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num7))
						{
							throw Class_414.lmethod_3098(this, "Input string '{0}' is not a valid number.".FormatWith(CultureInfo.InvariantCulture, text5));
						}
						obje_ = num7;
					}
					arg_2 = Class_508.Float;
				}
			}
			this.vmethod_3005();
			base.gmethod_1903(arg_2, obje_, false);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00053E74 File Offset: 0x00052074
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object kmethod_3017(string str_0, CultureInfo arg_0)
		{
			return BigInteger.Parse(str_0, arg_0);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00053E84 File Offset: 0x00052084
		private void lmethod_3018()
		{
			this.field_5++;
			if (!this.xmethod_2991(1, false))
			{
				throw Class_414.lmethod_3098(this, "Unexpected end while parsing comment.");
			}
			bool flag;
			if (this.field_3[this.field_5] == '*')
			{
				flag = false;
			}
			else
			{
				if (this.field_3[this.field_5] != '/')
				{
					throw Class_414.lmethod_3098(this, "Error parsing comment. Expected: *, got {0}.".FormatWith(CultureInfo.InvariantCulture, this.field_3[this.field_5]));
				}
				flag = true;
			}
			this.field_5++;
			int num = this.field_5;
			bool flag2 = false;
			while (!flag2)
			{
				char c = this.field_3[this.field_5];
				if (c <= '\n')
				{
					if (c != '\0')
					{
						if (c == '\n')
						{
							if (flag)
							{
								this.field_10 = new Class_492(this.field_3, num, this.field_5 - num);
								flag2 = true;
							}
							this.tmethod_3012();
							continue;
						}
					}
					else
					{
						if (this.field_4 != this.field_5)
						{
							this.field_5++;
							continue;
						}
						if (this.pmethod_2989(true) != 0)
						{
							continue;
						}
						if (!flag)
						{
							throw Class_414.lmethod_3098(this, "Unexpected end while parsing comment.");
						}
						this.field_10 = new Class_492(this.field_3, num, this.field_5 - num);
						flag2 = true;
						continue;
					}
				}
				else
				{
					if (c == '\r')
					{
						if (flag)
						{
							this.field_10 = new Class_492(this.field_3, num, this.field_5 - num);
							flag2 = true;
						}
						this.gmethod_3013(true);
						continue;
					}
					if (c == '*')
					{
						this.field_5++;
						if (!flag && this.xmethod_2991(0, true) && this.field_3[this.field_5] == '/')
						{
							this.field_10 = new Class_492(this.field_3, num, this.field_5 - num - 1);
							this.field_5++;
							flag2 = true;
							continue;
						}
						continue;
					}
				}
				this.field_5++;
			}
			base.tmethod_1902(Class_508.Comment, this.field_10.ToString());
			this.vmethod_3005();
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000540C8 File Offset: 0x000522C8
		private bool pmethod_3019(string str_0)
		{
			if (!this.xmethod_2991(str_0.Length - 1, true))
			{
				return false;
			}
			for (int i = 0; i < str_0.Length; i++)
			{
				if (this.field_3[this.field_5 + i] != str_0[i])
				{
					return false;
				}
			}
			this.field_5 += str_0.Length;
			return true;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00054130 File Offset: 0x00052330
		private bool smethod_3020(string str_0)
		{
			return this.pmethod_3019(str_0) && (!this.xmethod_2991(0, false) || this.xmethod_3021(this.field_3[this.field_5]) || this.field_3[this.field_5] == '\0');
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00054188 File Offset: 0x00052388
		private bool xmethod_3021(char char_0)
		{
			if (char_0 <= ')')
			{
				switch (char_0)
				{
				case '\t':
				case '\n':
				case '\r':
					break;
				case '\v':
				case '\f':
					goto IL_B8;
				default:
					if (char_0 != ' ')
					{
						if (char_0 != ')')
						{
							goto IL_B8;
						}
						if (base.prop_0 == Class_285.NClass_0.field_15 || base.prop_0 == Class_285.NClass_0.field_14)
						{
							return true;
						}
						return false;
					}
					break;
				}
				return true;
			}
			if (char_0 <= '/')
			{
				if (char_0 != ',')
				{
					if (char_0 != '/')
					{
						goto IL_B8;
					}
					if (!this.xmethod_2991(1, false))
					{
						return false;
					}
					char c = this.field_3[this.field_5 + 1];
					return c == '*' || c == '/';
				}
			}
			else if (char_0 != ']' && char_0 != '}')
			{
				goto IL_B8;
			}
			return true;
			IL_B8:
			if (char.IsWhiteSpace(char_0))
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005425B File Offset: 0x0005245B
		private void tmethod_3022()
		{
			if (this.smethod_3020(Class_416.True))
			{
				base.tmethod_1902(Class_508.Boolean, true);
				return;
			}
			throw Class_414.lmethod_3098(this, "Error parsing boolean value.");
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00054287 File Offset: 0x00052487
		private void gmethod_3023()
		{
			if (this.smethod_3020(Class_416.Null))
			{
				base.xmethod_1901(Class_508.Null);
				return;
			}
			throw Class_414.lmethod_3098(this, "Error parsing null value.");
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000542AD File Offset: 0x000524AD
		private void cmethod_3024()
		{
			if (this.smethod_3020(Class_416.Undefined))
			{
				base.xmethod_1901(Class_508.Undefined);
				return;
			}
			throw Class_414.lmethod_3098(this, "Error parsing undefined value.");
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x000542D3 File Offset: 0x000524D3
		private void vmethod_3025()
		{
			if (this.smethod_3020(Class_416.False))
			{
				base.tmethod_1902(Class_508.Boolean, false);
				return;
			}
			throw Class_414.lmethod_3098(this, "Error parsing boolean value.");
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00054300 File Offset: 0x00052500
		private void dmethod_3026()
		{
			if (!this.smethod_3020(Class_416.NegativeInfinity))
			{
				throw Class_414.lmethod_3098(this, "Error parsing negative infinity value.");
			}
			if (this.field_11 == Class_315.Decimal)
			{
				throw new Class_414("Cannot read -Infinity as a decimal.");
			}
			base.tmethod_1902(Class_508.Float, double.NegativeInfinity);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00054358 File Offset: 0x00052558
		private void kmethod_3027()
		{
			if (!this.smethod_3020(Class_416.PositiveInfinity))
			{
				throw Class_414.lmethod_3098(this, "Error parsing positive infinity value.");
			}
			if (this.field_11 == Class_315.Decimal)
			{
				throw new Class_414("Cannot read Infinity as a decimal.");
			}
			base.tmethod_1902(Class_508.Float, double.PositiveInfinity);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000543B0 File Offset: 0x000525B0
		private void lmethod_3028()
		{
			if (!this.smethod_3020(Class_416.NaN))
			{
				throw Class_414.lmethod_3098(this, "Error parsing NaN value.");
			}
			if (this.field_11 == Class_315.Decimal)
			{
				throw new Class_414("Cannot read NaN as a decimal.");
			}
			base.tmethod_1902(Class_508.Float, double.NaN);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00054405 File Offset: 0x00052605
		public virtual void pmethod_3029()
		{
			base.tmethod_1912();
			if (base.prop_1 && this.field_2 != null)
			{
				this.field_2.Close();
			}
			if (this.field_9 != null)
			{
				this.field_9.pmethod_4139();
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public bool smethod_3030()
		{
			return true;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00054444 File Offset: 0x00052644
		public new int prop_0
		{
			get
			{
				if (base.prop_0 == Class_285.NClass_0.field_5 && this.prop_1 == 0)
				{
					return 0;
				}
				return this.field_7;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00054464 File Offset: 0x00052664
		public new int prop_1
		{
			get
			{
				return this.field_5 - this.field_6;
			}
		}

		// Token: 0x04000982 RID: 2434
		private const char field_0 = '�';

		// Token: 0x04000983 RID: 2435
		private const int field_1 = 380;

		// Token: 0x04000984 RID: 2436
		private new readonly TextReader field_2;

		// Token: 0x04000985 RID: 2437
		private new char[] field_3;

		// Token: 0x04000986 RID: 2438
		private new int field_4;

		// Token: 0x04000987 RID: 2439
		private int field_5;

		// Token: 0x04000988 RID: 2440
		private int field_6;

		// Token: 0x04000989 RID: 2441
		private int field_7;

		// Token: 0x0400098A RID: 2442
		private bool field_8;

		// Token: 0x0400098B RID: 2443
		private Class_509 field_9;

		// Token: 0x0400098C RID: 2444
		private new Class_492 field_10;

		// Token: 0x0400098D RID: 2445
		internal new Class_487 field_11;
	}
}
