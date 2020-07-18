using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200007C RID: 124
	public class Class_97
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00012158 File Offset: 0x00010358
		public Class_97(TextReader arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.field_0 = arg_0;
			this.field_1 = new StringBuilder();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00012196 File Offset: 0x00010396
		public object pmethod_269()
		{
			object result = this.smethod_270();
			this.gmethod_273();
			if (this.tmethod_272() >= 0)
			{
				throw this.lmethod_278("extra characters in JSON input");
			}
			return result;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000121C8 File Offset: 0x000103C8
		private object smethod_270()
		{
			this.gmethod_273();
			int num = this.xmethod_271();
			if (num < 0)
			{
				throw this.lmethod_278("Incomplete JSON input");
			}
			if (num <= 102)
			{
				if (num == 34)
				{
					return this.vmethod_275();
				}
				if (num != 91)
				{
					if (num == 102)
					{
						this.kmethod_277("false");
						return false;
					}
				}
				else
				{
					this.tmethod_272();
					List<object> list = new List<object>();
					this.gmethod_273();
					if (this.xmethod_271() == 93)
					{
						this.tmethod_272();
						return list;
					}
					for (;;)
					{
						object item = this.smethod_270();
						list.Add(item);
						this.gmethod_273();
						num = this.xmethod_271();
						if (num != 44)
						{
							break;
						}
						this.tmethod_272();
					}
					if (this.tmethod_272() != 93)
					{
						throw this.lmethod_278("JSON array must end with ']'");
					}
					return list.ToArray();
				}
			}
			else
			{
				if (num == 110)
				{
					this.kmethod_277("null");
					return null;
				}
				if (num == 116)
				{
					this.kmethod_277("true");
					return true;
				}
				if (num == 123)
				{
					this.tmethod_272();
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					this.gmethod_273();
					if (this.xmethod_271() == 125)
					{
						this.tmethod_272();
						return dictionary;
					}
					for (;;)
					{
						this.gmethod_273();
						if (this.xmethod_271() == 125)
						{
							break;
						}
						string key = this.vmethod_275();
						this.gmethod_273();
						this.dmethod_276(':');
						this.gmethod_273();
						dictionary[key] = this.smethod_270();
						this.gmethod_273();
						num = this.tmethod_272();
						if (num != 44 && num == 125)
						{
							goto IL_16C;
						}
					}
					this.tmethod_272();
					IL_16C:
					int num2 = 0;
					KeyValuePair<string, object>[] array = new KeyValuePair<string, object>[dictionary.Count];
					foreach (KeyValuePair<string, object> keyValuePair in dictionary)
					{
						array[num2++] = keyValuePair;
					}
					return array;
				}
			}
			if ((48 <= num && num <= 57) || num == 45)
			{
				return this.cmethod_274();
			}
			throw this.lmethod_278(string.Format("Unexpected character '{0}'", (char)num));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00012414 File Offset: 0x00010614
		private int xmethod_271()
		{
			if (!this.field_3)
			{
				this.field_5 = this.field_0.Read();
				this.field_3 = true;
			}
			return this.field_5;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001244C File Offset: 0x0001064C
		private int tmethod_272()
		{
			object obj = this.field_3 ? this.field_5 : this.field_0.Read();
			this.field_3 = false;
			if (this.field_6)
			{
				this.field_4++;
				this.field_2 = 0;
				this.field_6 = false;
			}
			object obj2 = obj;
			if (obj2 == 10)
			{
				this.field_6 = true;
			}
			this.field_2++;
			return obj2;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000124D4 File Offset: 0x000106D4
		private void gmethod_273()
		{
			for (;;)
			{
				int num = this.xmethod_271();
				if (num - 9 > 1 && num != 13 && num != 32)
				{
					break;
				}
				this.tmethod_272();
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00012518 File Offset: 0x00010718
		private object cmethod_274()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.xmethod_271() == 45)
			{
				stringBuilder.Append((char)this.tmethod_272());
			}
			int num = 0;
			bool flag = this.xmethod_271() == 48;
			int num2;
			for (;;)
			{
				num2 = this.xmethod_271();
				if (num2 < 48 || 57 < num2)
				{
					goto IL_7E;
				}
				stringBuilder.Append((char)this.tmethod_272());
				if (flag && num == 1)
				{
					break;
				}
				num++;
			}
			throw this.lmethod_278("leading zeros are not allowed");
			IL_7E:
			if (num == 0)
			{
				throw this.lmethod_278("Invalid JSON numeric literal; no digit found");
			}
			bool flag2 = false;
			int num3 = 0;
			if (this.xmethod_271() == 46)
			{
				flag2 = true;
				stringBuilder.Append((char)this.tmethod_272());
				if (this.xmethod_271() < 0)
				{
					throw this.lmethod_278("Invalid JSON numeric literal; extra dot");
				}
				for (;;)
				{
					num2 = this.xmethod_271();
					if (num2 < 48 || 57 < num2)
					{
						break;
					}
					stringBuilder.Append((char)this.tmethod_272());
					num3++;
				}
				if (num3 == 0)
				{
					throw this.lmethod_278("Invalid JSON numeric literal; extra dot");
				}
			}
			num2 = this.xmethod_271();
			if (num2 != 101 && num2 != 69)
			{
				if (!flag2)
				{
					int num4;
					if (int.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num4))
					{
						return num4;
					}
					long num5;
					if (long.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num5))
					{
						return num5;
					}
					ulong num6;
					if (ulong.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num6))
					{
						return num6;
					}
				}
				decimal num7;
				if (decimal.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num7) && num7 != 0m)
				{
					return num7;
				}
			}
			else
			{
				stringBuilder.Append((char)this.tmethod_272());
				if (this.xmethod_271() < 0)
				{
					throw new ArgumentException("Invalid JSON numeric literal; incomplete exponent");
				}
				int num8 = this.xmethod_271();
				if (num8 != 43)
				{
					if (num8 == 45)
					{
						stringBuilder.Append((char)this.tmethod_272());
					}
				}
				else
				{
					stringBuilder.Append((char)this.tmethod_272());
				}
				if (this.xmethod_271() < 0)
				{
					throw this.lmethod_278("Invalid JSON numeric literal; incomplete exponent");
				}
				for (;;)
				{
					num2 = this.xmethod_271();
					if (num2 < 48 || 57 < num2)
					{
						break;
					}
					stringBuilder.Append((char)this.tmethod_272());
				}
			}
			return double.Parse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000127AC File Offset: 0x000109AC
		private string vmethod_275()
		{
			if (this.xmethod_271() != 34)
			{
				throw this.lmethod_278("Invalid JSON string literal format");
			}
			this.tmethod_272();
			this.field_1.Length = 0;
			for (;;)
			{
				int num = this.tmethod_272();
				if (num < 0)
				{
					goto IL_209;
				}
				if (num == 34)
				{
					break;
				}
				if (num != 92)
				{
					this.field_1.Append((char)num);
				}
				else
				{
					num = this.tmethod_272();
					if (num < 0)
					{
						goto Block_5;
					}
					if (num <= 92)
					{
						if (num != 34 && num != 47 && num != 92)
						{
							goto Block_9;
						}
						this.field_1.Append((char)num);
					}
					else if (num <= 102)
					{
						if (num != 98)
						{
							if (num != 102)
							{
								goto Block_12;
							}
							this.field_1.Append('\f');
						}
						else
						{
							this.field_1.Append('\b');
						}
					}
					else
					{
						if (num != 110)
						{
							switch (num)
							{
							case 114:
								this.field_1.Append('\r');
								continue;
							case 116:
								this.field_1.Append('\t');
								continue;
							case 117:
							{
								ushort num2 = 0;
								for (int i = 0; i < 4; i++)
								{
									num2 = (ushort)(num2 << 4);
									if ((num = this.tmethod_272()) < 0)
									{
										goto Block_15;
									}
									if (48 <= num && num <= 57)
									{
										num2 += (ushort)(num - 48);
									}
									if (65 <= num && num <= 70)
									{
										num2 += (ushort)(num - 65 + 10);
									}
									if (97 <= num && num <= 102)
									{
										num2 += (ushort)(num - 97 + 10);
									}
								}
								this.field_1.Append((char)num2);
								continue;
							}
							}
							goto Block_14;
						}
						this.field_1.Append('\n');
					}
				}
			}
			return this.field_1.ToString();
			Block_5:
			throw this.lmethod_278("Invalid JSON string literal; incomplete escape sequence");
			Block_9:
			Block_12:
			Block_14:
			goto IL_1FD;
			Block_15:
			throw this.lmethod_278("Incomplete unicode character escape literal");
			IL_1FD:
			throw this.lmethod_278("Invalid JSON string literal; unexpected escape character");
			IL_209:
			throw this.lmethod_278("JSON string is not closed");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000129D0 File Offset: 0x00010BD0
		private void dmethod_276(char char_0)
		{
			int num;
			if ((num = this.tmethod_272()) != (int)char_0)
			{
				throw this.lmethod_278(string.Format("Expected '{0}', got '{1}'", char_0, (char)num));
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00012A18 File Offset: 0x00010C18
		private void kmethod_277(string str_0)
		{
			for (int i = 0; i < str_0.Length; i++)
			{
				if (this.tmethod_272() != (int)str_0[i])
				{
					throw this.lmethod_278(string.Format("Expected '{0}', differed at {1}", str_0, i));
				}
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00012A6F File Offset: 0x00010C6F
		private Exception lmethod_278(string str_0)
		{
			return new ArgumentException(string.Format("{0}. At line {1}, column {2}", str_0, this.field_4, this.field_2));
		}

		// Token: 0x0400017A RID: 378
		private readonly TextReader field_0;

		// Token: 0x0400017B RID: 379
		private readonly StringBuilder field_1;

		// Token: 0x0400017C RID: 380
		private int field_2;

		// Token: 0x0400017D RID: 381
		private bool field_3;

		// Token: 0x0400017E RID: 382
		private int field_4 = 1;

		// Token: 0x0400017F RID: 383
		private int field_5;

		// Token: 0x04000180 RID: 384
		private bool field_6;
	}
}
