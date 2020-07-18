using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001DE RID: 478
	internal struct Class_358
	{
		// Token: 0x06000D89 RID: 3465 RVA: 0x00048C04 File Offset: 0x00046E04
		public bool Parse(string text)
		{
			this._text = text;
			this._length = text.Length;
			return this.ParseDate(0) && this.ParseChar(Class_358.Lzyyyy_MM_dd, 'T') && this.ParseTimeAndZoneAndWhitespace(Class_358.Lzyyyy_MM_ddT);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00048C58 File Offset: 0x00046E58
		private bool ParseDate(int start)
		{
			return this.Parse4Digit(start, out this.Year) && 1 <= this.Year && this.ParseChar(start + Class_358.Lzyyyy, '-') && this.Parse2Digit(start + Class_358.Lzyyyy_, out this.Month) && 1 <= this.Month && this.Month <= 12 && this.ParseChar(start + Class_358.Lzyyyy_MM, '-') && this.Parse2Digit(start + Class_358.Lzyyyy_MM_, out this.Day) && 1 <= this.Day && this.Day <= DateTime.DaysInMonth(this.Year, this.Month);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00048D1E File Offset: 0x00046F1E
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return this.ParseTime(ref start) && this.ParseZone(start);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00048D38 File Offset: 0x00046F38
		private bool ParseTime(ref int start)
		{
			if (!this.Parse2Digit(start, out this.Hour) || this.Hour >= 24 || !this.ParseChar(start + Class_358.LzHH, ':') || !this.Parse2Digit(start + Class_358.LzHH_, out this.Minute) || this.Minute >= 60 || !this.ParseChar(start + Class_358.LzHH_mm, ':') || !this.Parse2Digit(start + Class_358.LzHH_mm_, out this.Second) || this.Second >= 60)
			{
				return false;
			}
			start += Class_358.LzHH_mm_ss;
			if (this.ParseChar(start, '.'))
			{
				this.Fraction = 0;
				int num = 0;
				while (++start < this._length && num < 7)
				{
					int num2 = (int)(this._text[start] - '0');
					if (num2 < 0 || num2 > 9)
					{
						break;
					}
					this.Fraction = this.Fraction * 10 + num2;
					num++;
				}
				if (num < 7)
				{
					if (num == 0)
					{
						return false;
					}
					this.Fraction *= Class_358.Power10[7 - num];
				}
			}
			return true;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00048E78 File Offset: 0x00047078
		private bool ParseZone(int start)
		{
			if (start < this._length)
			{
				char c = this._text[start];
				if (c == 'Z' || c == 'z')
				{
					this.Zone = Class_357.Utc;
					start++;
				}
				else
				{
					if (start + 2 < this._length && this.Parse2Digit(start + Class_358.Lz_, out this.ZoneHour) && this.ZoneHour <= 99)
					{
						switch (c)
						{
						case '+':
							this.Zone = Class_357.LocalEastOfUtc;
							start += Class_358.Lz_zz;
							break;
						case '-':
							this.Zone = Class_357.LocalWestOfUtc;
							start += Class_358.Lz_zz;
							break;
						}
					}
					if (start < this._length)
					{
						if (this.ParseChar(start, ':'))
						{
							start++;
							if (start + 1 < this._length && this.Parse2Digit(start, out this.ZoneMinute) && this.ZoneMinute <= 99)
							{
								start += 2;
							}
						}
						else if (start + 1 < this._length && this.Parse2Digit(start, out this.ZoneMinute) && this.ZoneMinute <= 99)
						{
							start += 2;
						}
					}
				}
			}
			return start == this._length;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00048FC4 File Offset: 0x000471C4
		private bool Parse4Digit(int start, out int num)
		{
			if (start + 3 < this._length)
			{
				int num2 = (int)(this._text[start] - '0');
				int num3 = (int)(this._text[start + 1] - '0');
				int num4 = (int)(this._text[start + 2] - '0');
				int num5 = (int)(this._text[start + 3] - '0');
				if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10 && 0 <= num5 && num5 < 10)
				{
					num = ((num2 * 10 + num3) * 10 + num4) * 10 + num5;
					return true;
				}
			}
			num = 0;
			return false;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0004907C File Offset: 0x0004727C
		private bool Parse2Digit(int start, out int num)
		{
			if (start + 1 < this._length)
			{
				int num2 = (int)(this._text[start] - '0');
				int num3 = (int)(this._text[start + 1] - '0');
				if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10)
				{
					num = num2 * 10 + num3;
					return true;
				}
			}
			num = 0;
			return false;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000490E5 File Offset: 0x000472E5
		private bool ParseChar(int start, char ch)
		{
			return start < this._length && this._text[start] == ch;
		}

		// Token: 0x04000894 RID: 2196
		private const short MaxFractionDigits = 7;

		// Token: 0x04000895 RID: 2197
		public int Year;

		// Token: 0x04000896 RID: 2198
		public int Month;

		// Token: 0x04000897 RID: 2199
		public int Day;

		// Token: 0x04000898 RID: 2200
		public int Hour;

		// Token: 0x04000899 RID: 2201
		public int Minute;

		// Token: 0x0400089A RID: 2202
		public int Second;

		// Token: 0x0400089B RID: 2203
		public int Fraction;

		// Token: 0x0400089C RID: 2204
		public int ZoneHour;

		// Token: 0x0400089D RID: 2205
		public int ZoneMinute;

		// Token: 0x0400089E RID: 2206
		public Class_357 Zone;

		// Token: 0x0400089F RID: 2207
		private string _text;

		// Token: 0x040008A0 RID: 2208
		private int _length;

		// Token: 0x040008A1 RID: 2209
		private static readonly int[] Power10 = new int[]
		{
			-1,
			10,
			100,
			1000,
			10000,
			100000,
			1000000
		};

		// Token: 0x040008A2 RID: 2210
		private static readonly int Lzyyyy = "yyyy".Length;

		// Token: 0x040008A3 RID: 2211
		private static readonly int Lzyyyy_ = "yyyy-".Length;

		// Token: 0x040008A4 RID: 2212
		private static readonly int Lzyyyy_MM = "yyyy-MM".Length;

		// Token: 0x040008A5 RID: 2213
		private static readonly int Lzyyyy_MM_ = "yyyy-MM-".Length;

		// Token: 0x040008A6 RID: 2214
		private static readonly int Lzyyyy_MM_dd = "yyyy-MM-dd".Length;

		// Token: 0x040008A7 RID: 2215
		private static readonly int Lzyyyy_MM_ddT = "yyyy-MM-ddT".Length;

		// Token: 0x040008A8 RID: 2216
		private static readonly int LzHH = "HH".Length;

		// Token: 0x040008A9 RID: 2217
		private static readonly int LzHH_ = "HH:".Length;

		// Token: 0x040008AA RID: 2218
		private static readonly int LzHH_mm = "HH:mm".Length;

		// Token: 0x040008AB RID: 2219
		private static readonly int LzHH_mm_ = "HH:mm:".Length;

		// Token: 0x040008AC RID: 2220
		private static readonly int LzHH_mm_ss = "HH:mm:ss".Length;

		// Token: 0x040008AD RID: 2221
		private static readonly int Lz_ = "-".Length;

		// Token: 0x040008AE RID: 2222
		private static readonly int Lz_zz = "-zz".Length;
	}
}
