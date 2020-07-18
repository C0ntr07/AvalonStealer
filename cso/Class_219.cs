using System;
using System.Collections.Generic;

// Token: 0x02000125 RID: 293
public class Class_219
{
	// Token: 0x06000807 RID: 2055 RVA: 0x00035862 File Offset: 0x00033A62
	public Class_219()
	{
		this.field_2 = new uint[1000];
		this.field_3 = 1;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00035884 File Offset: 0x00033A84
	public Class_219(long sayıUınt_0)
	{
		this.field_2 = new uint[1000];
		long num = sayıUınt_0;
		this.field_3 = 0;
		while (sayıUınt_0 != 0L && this.field_3 < 1000)
		{
			this.field_2[this.field_3] = (uint)(sayıUınt_0 & (long)((ulong)-1));
			sayıUınt_0 >>= 32;
			this.field_3++;
		}
		if (num > 0L)
		{
			if (sayıUınt_0 != 0L || (this.field_2[999] & 2147483648U) != 0U)
			{
				throw new ArithmeticException("Positive overflow in constructor.");
			}
		}
		else if (num < 0L && (sayıUınt_0 != -1L || (this.field_2[this.field_3 - 1] & 2147483648U) == 0U))
		{
			throw new ArithmeticException("Negative underflow in constructor.");
		}
		if (this.field_3 == 0)
		{
			this.field_3 = 1;
		}
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00035968 File Offset: 0x00033B68
	public Class_219(ulong arg_0)
	{
		this.field_2 = new uint[1000];
		this.field_3 = 0;
		while (arg_0 != 0UL && this.field_3 < 1000)
		{
			this.field_2[this.field_3] = (uint)(arg_0 & (ulong)-1);
			arg_0 >>= 32;
			this.field_3++;
		}
		if (arg_0 != 0UL || (this.field_2[999] & 2147483648U) != 0U)
		{
			throw new ArithmeticException("Positive overflow in constructor.");
		}
		if (this.field_3 == 0)
		{
			this.field_3 = 1;
		}
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00035A0C File Offset: 0x00033C0C
	public Class_219(Class_219 arg_0)
	{
		this.field_2 = new uint[1000];
		this.field_3 = arg_0.field_3;
		for (int i = 0; i < this.field_3; i++)
		{
			this.field_2[i] = arg_0.field_2[i];
		}
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00035A60 File Offset: 0x00033C60
	public Class_219(string str_0, int sayıInt_0)
	{
		Class_219 arg_ = new Class_219(1L);
		Class_219 class_ = new Class_219();
		str_0 = str_0.ToUpper().Trim();
		int num = 0;
		if (str_0[0] == '-')
		{
			num = 1;
		}
		for (int i = str_0.Length - 1; i >= num; i--)
		{
			int num2 = (int)str_0[i];
			if (num2 >= 48 && num2 <= 57)
			{
				num2 -= 48;
			}
			else if (num2 >= 65 && num2 <= 90)
			{
				num2 = num2 - 65 + 10;
			}
			else
			{
				num2 = 9999999;
			}
			if (num2 >= sayıInt_0)
			{
				throw new ArithmeticException("Invalid string in constructor.");
			}
			if (str_0[0] == '-')
			{
				num2 = -num2;
			}
			class_ = Class_219.pmethod_1399(class_, Class_219.gmethod_1403(arg_, Class_219.kmethod_1397(num2)));
			if (i - 1 >= num)
			{
				arg_ = Class_219.gmethod_1403(arg_, Class_219.kmethod_1397(sayıInt_0));
			}
		}
		if (str_0[0] == '-')
		{
			if ((class_.field_2[999] & 2147483648U) == 0U)
			{
				throw new ArithmeticException("Negative underflow in constructor.");
			}
		}
		else if ((class_.field_2[999] & 2147483648U) != 0U)
		{
			throw new ArithmeticException("Positive overflow in constructor.");
		}
		this.field_2 = new uint[1000];
		for (int j = 0; j < class_.field_3; j++)
		{
			this.field_2[j] = class_.field_2[j];
		}
		this.field_3 = class_.field_3;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00035BF0 File Offset: 0x00033DF0
	public Class_219(IList<byte> arg_0, int sayıInt_0 = -1, int sayıInt_1 = 0)
	{
		int num = (sayıInt_0 == -1) ? (arg_0.Count - sayıInt_1) : sayıInt_0;
		this.field_3 = num >> 2;
		int num2 = num & 3;
		if (num2 != 0)
		{
			this.field_3++;
		}
		if (this.field_3 > 1000 || num > arg_0.Count - sayıInt_1)
		{
			throw new ArithmeticException("Byte overflow in constructor.");
		}
		this.field_2 = new uint[1000];
		int i = num - 1;
		int num3 = 0;
		while (i >= 3)
		{
			this.field_2[num3] = (uint)(((int)arg_0[sayıInt_1 + i - 3] << 24) + ((int)arg_0[sayıInt_1 + i - 2] << 16) + ((int)arg_0[sayıInt_1 + i - 1] << 8) + (int)arg_0[sayıInt_1 + i]);
			i -= 4;
			num3++;
		}
		if (num2 == 1)
		{
			this.field_2[this.field_3 - 1] = (uint)arg_0[sayıInt_1];
		}
		else if (num2 == 2)
		{
			this.field_2[this.field_3 - 1] = (uint)(((int)arg_0[sayıInt_1] << 8) + (int)arg_0[sayıInt_1 + 1]);
		}
		else if (num2 == 3)
		{
			this.field_2[this.field_3 - 1] = (uint)(((int)arg_0[sayıInt_1] << 16) + ((int)arg_0[sayıInt_1 + 1] << 8) + (int)arg_0[sayıInt_1 + 2]);
		}
		if (this.field_3 == 0)
		{
			this.field_3 = 1;
		}
		while (this.field_3 > 1 && this.field_2[this.field_3 - 1] == 0U)
		{
			this.field_3--;
		}
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00035D90 File Offset: 0x00033F90
	public Class_219(uint[] arg_0)
	{
		this.field_3 = arg_0.Length;
		if (this.field_3 > 1000)
		{
			throw new ArithmeticException("Byte overflow in constructor.");
		}
		this.field_2 = new uint[1000];
		int i = this.field_3 - 1;
		int num = 0;
		while (i >= 0)
		{
			this.field_2[num] = arg_0[i];
			i--;
			num++;
		}
		while (this.field_3 > 1 && this.field_2[this.field_3 - 1] == 0U)
		{
			this.field_3--;
		}
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00035E2E File Offset: 0x0003402E
	public static Class_219 dmethod_1396(ulong arg_0)
	{
		return new Class_219(arg_0);
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00035E36 File Offset: 0x00034036
	public static Class_219 kmethod_1397(int sayıInt_0)
	{
		return new Class_219((long)sayıInt_0);
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00035E3F File Offset: 0x0003403F
	public static Class_219 lmethod_1398(uint arg_0)
	{
		return new Class_219((ulong)arg_0);
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00035E48 File Offset: 0x00034048
	public static Class_219 pmethod_1399(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 class_ = new Class_219
		{
			field_3 = ((arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3)
		};
		long num = 0L;
		for (int i = 0; i < class_.field_3; i++)
		{
			long num2 = (long)((ulong)arg_0.field_2[i] + (ulong)arg_1.field_2[i] + (ulong)num);
			num = num2 >> 32;
			class_.field_2[i] = (uint)(num2 & (long)((ulong)-1));
		}
		if (num != 0L && class_.field_3 < 1000)
		{
			class_.field_2[class_.field_3] = (uint)num;
			class_.field_3++;
		}
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		int num3 = 999;
		if ((arg_0.field_2[num3] & 2147483648U) == (arg_1.field_2[num3] & 2147483648U) && (class_.field_2[num3] & 2147483648U) != (arg_0.field_2[num3] & 2147483648U))
		{
			throw new ArithmeticException();
		}
		return class_;
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00035F7C File Offset: 0x0003417C
	public static Class_219 smethod_1400(Class_219 arg_0)
	{
		Class_219 class_ = new Class_219(arg_0);
		long num = 1L;
		int num2 = 0;
		while (num != 0L && num2 < 1000)
		{
			long num3 = (long)((ulong)class_.field_2[num2]);
			num3 += 1L;
			class_.field_2[num2] = (uint)(num3 & (long)((ulong)-1));
			num = num3 >> 32;
			num2++;
		}
		if (num2 > class_.field_3)
		{
			class_.field_3 = num2;
		}
		else
		{
			while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
			{
				class_.field_3--;
			}
		}
		int num4 = 999;
		if ((arg_0.field_2[num4] & 2147483648U) == 0U && (class_.field_2[num4] & 2147483648U) != (arg_0.field_2[num4] & 2147483648U))
		{
			throw new ArithmeticException("Overflow in ++.");
		}
		return class_;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0003605C File Offset: 0x0003425C
	public static Class_219 xmethod_1401(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 class_ = new Class_219
		{
			field_3 = ((arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3)
		};
		long num = 0L;
		for (int i = 0; i < class_.field_3; i++)
		{
			long num2 = (long)((ulong)arg_0.field_2[i] - (ulong)arg_1.field_2[i] - (ulong)num);
			class_.field_2[i] = (uint)(num2 & (long)((ulong)-1));
			if (num2 < 0L)
			{
				num = 1L;
			}
			else
			{
				num = 0L;
			}
		}
		if (num != 0L)
		{
			for (int j = class_.field_3; j < 1000; j++)
			{
				class_.field_2[j] = uint.MaxValue;
			}
			class_.field_3 = 1000;
		}
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		int num3 = 999;
		if ((arg_0.field_2[num3] & 2147483648U) != (arg_1.field_2[num3] & 2147483648U) && (class_.field_2[num3] & 2147483648U) != (arg_0.field_2[num3] & 2147483648U))
		{
			throw new ArithmeticException();
		}
		return class_;
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x000361A0 File Offset: 0x000343A0
	public static Class_219 tmethod_1402(Class_219 arg_0)
	{
		Class_219 class_ = new Class_219(arg_0);
		bool flag = true;
		int num = 0;
		while (flag && num < 1000)
		{
			long num2 = (long)((ulong)class_.field_2[num]);
			num2 -= 1L;
			class_.field_2[num] = (uint)(num2 & (long)((ulong)-1));
			if (num2 >= 0L)
			{
				flag = false;
			}
			num++;
		}
		if (num > class_.field_3)
		{
			class_.field_3 = num;
		}
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		int num3 = 999;
		if ((arg_0.field_2[num3] & 2147483648U) != 0U && (class_.field_2[num3] & 2147483648U) != (arg_0.field_2[num3] & 2147483648U))
		{
			throw new ArithmeticException("Underflow in --.");
		}
		return class_;
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00036284 File Offset: 0x00034484
	public static Class_219 gmethod_1403(Class_219 arg_0, Class_219 arg_1)
	{
		int num = 999;
		bool flag = false;
		bool flag2 = false;
		try
		{
			if ((arg_0.field_2[num] & 2147483648U) != 0U)
			{
				flag = true;
				arg_0 = Class_219.pmethod_1409(arg_0);
			}
			if ((arg_1.field_2[num] & 2147483648U) != 0U)
			{
				flag2 = true;
				arg_1 = Class_219.pmethod_1409(arg_1);
			}
		}
		catch (Exception)
		{
		}
		Class_219 class_ = new Class_219();
		try
		{
			for (int i = 0; i < arg_0.field_3; i++)
			{
				if (arg_0.field_2[i] != 0U)
				{
					ulong num2 = 0UL;
					int j = 0;
					int num3 = i;
					while (j < arg_1.field_3)
					{
						ulong num4 = (ulong)arg_0.field_2[i] * (ulong)arg_1.field_2[j] + (ulong)class_.field_2[num3] + num2;
						class_.field_2[num3] = (uint)(num4 & (ulong)-1);
						num2 = num4 >> 32;
						j++;
						num3++;
					}
					if (num2 != 0UL)
					{
						class_.field_2[i + arg_1.field_3] = (uint)num2;
					}
				}
			}
		}
		catch (Exception)
		{
			throw new ArithmeticException("Multiplication overflow.");
		}
		class_.field_3 = arg_0.field_3 + arg_1.field_3;
		if (class_.field_3 > 1000)
		{
			class_.field_3 = 1000;
		}
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		if ((class_.field_2[num] & 2147483648U) != 0U)
		{
			if (flag != flag2 && class_.field_2[num] == 2147483648U)
			{
				if (class_.field_3 == 1)
				{
					return class_;
				}
				bool flag3 = true;
				int num5 = 0;
				while (num5 < class_.field_3 - 1 && flag3)
				{
					if (class_.field_2[num5] != 0U)
					{
						flag3 = false;
					}
					num5++;
				}
				if (flag3)
				{
					return class_;
				}
			}
			throw new ArithmeticException("Multiplication overflow.");
		}
		if (flag != flag2)
		{
			return Class_219.pmethod_1409(class_);
		}
		return class_;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x000364A8 File Offset: 0x000346A8
	public static Class_219 cmethod_1404(Class_219 arg_0, int sayıInt_0)
	{
		Class_219 class_ = new Class_219(arg_0);
		class_.field_3 = Class_219.vmethod_1405(class_.field_2, sayıInt_0);
		return class_;
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x000364C4 File Offset: 0x000346C4
	private static int vmethod_1405(uint[] arg_0, int sayıInt_0)
	{
		int num = 32;
		int num2 = arg_0.Length;
		while (num2 > 1 && arg_0[num2 - 1] == 0U)
		{
			num2--;
		}
		for (int i = sayıInt_0; i > 0; i -= num)
		{
			if (i < num)
			{
				num = i;
			}
			ulong num3 = 0UL;
			for (int j = 0; j < num2; j++)
			{
				ulong num4 = (ulong)arg_0[j] << num;
				num4 |= num3;
				arg_0[j] = (uint)(num4 & (ulong)-1);
				num3 = num4 >> 32;
			}
			if (num3 != 0UL && num2 + 1 <= arg_0.Length)
			{
				arg_0[num2] = (uint)num3;
				num2++;
			}
		}
		return num2;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0003655C File Offset: 0x0003475C
	public static Class_219 dmethod_1406(Class_219 arg_0, int sayıInt_0)
	{
		Class_219 class_ = new Class_219(arg_0);
		class_.field_3 = Class_219.kmethod_1407(class_.field_2, sayıInt_0);
		if ((arg_0.field_2[999] & 2147483648U) != 0U)
		{
			for (int i = 999; i >= class_.field_3; i--)
			{
				class_.field_2[i] = uint.MaxValue;
			}
			uint num = 2147483648U;
			int num2 = 0;
			while (num2 < 32 && (class_.field_2[class_.field_3 - 1] & num) == 0U)
			{
				class_.field_2[class_.field_3 - 1] |= num;
				num >>= 1;
				num2++;
			}
			class_.field_3 = 1000;
		}
		return class_;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00036610 File Offset: 0x00034810
	private static int kmethod_1407(uint[] arg_0, int sayıInt_0)
	{
		int num = 32;
		int num2 = 0;
		int num3 = arg_0.Length;
		while (num3 > 1 && arg_0[num3 - 1] == 0U)
		{
			num3--;
		}
		for (int i = sayıInt_0; i > 0; i -= num)
		{
			if (i < num)
			{
				num = i;
				num2 = 32 - num;
			}
			ulong num4 = 0UL;
			for (int j = num3 - 1; j >= 0; j--)
			{
				ulong num5 = (ulong)arg_0[j] >> num;
				num5 |= num4;
				num4 = ((ulong)arg_0[j] << num2 & (ulong)-1);
				arg_0[j] = (uint)num5;
			}
		}
		while (num3 > 1 && arg_0[num3 - 1] == 0U)
		{
			num3--;
		}
		return num3;
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x000366B4 File Offset: 0x000348B4
	public static Class_219 lmethod_1408(Class_219 arg_0)
	{
		Class_219 class_ = new Class_219(arg_0);
		for (int i = 0; i < 1000; i++)
		{
			class_.field_2[i] = ~arg_0.field_2[i];
		}
		class_.field_3 = 1000;
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		return class_;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00036728 File Offset: 0x00034928
	public static Class_219 pmethod_1409(Class_219 arg_0)
	{
		if (arg_0.field_3 == 1 && arg_0.field_2[0] == 0U)
		{
			return new Class_219();
		}
		Class_219 class_ = new Class_219(arg_0);
		for (int i = 0; i < 1000; i++)
		{
			class_.field_2[i] = ~arg_0.field_2[i];
		}
		long num = 1L;
		int num2 = 0;
		while (num != 0L && num2 < 1000)
		{
			long num3 = (long)((ulong)class_.field_2[num2]);
			num3 += 1L;
			class_.field_2[num2] = (uint)(num3 & (long)((ulong)-1));
			num = num3 >> 32;
			num2++;
		}
		if ((arg_0.field_2[999] & 2147483648U) == (class_.field_2[999] & 2147483648U))
		{
			throw new ArithmeticException("Overflow in negation.\n");
		}
		class_.field_3 = 1000;
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		return class_;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00036831 File Offset: 0x00034A31
	public static bool smethod_1410(Class_219 arg_0, Class_219 arg_1)
	{
		return !arg_0.Equals(arg_1);
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00036840 File Offset: 0x00034A40
	public virtual bool xmethod_1411(object obje_0)
	{
		Class_219 class_ = (Class_219)obje_0;
		if (this.field_3 != class_.field_3)
		{
			return false;
		}
		for (int i = 0; i < this.field_3; i++)
		{
			if (this.field_2[i] != class_.field_2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00036893 File Offset: 0x00034A93
	public virtual int tmethod_1412()
	{
		return this.ToString().GetHashCode();
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x000368A0 File Offset: 0x00034AA0
	public static bool gmethod_1413(Class_219 arg_0, Class_219 arg_1)
	{
		int num = 999;
		if ((arg_0.field_2[num] & 2147483648U) != 0U && (arg_1.field_2[num] & 2147483648U) == 0U)
		{
			return false;
		}
		if ((arg_0.field_2[num] & 2147483648U) == 0U && (arg_1.field_2[num] & 2147483648U) != 0U)
		{
			return true;
		}
		num = ((arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3) - 1;
		while (num >= 0 && arg_0.field_2[num] == arg_1.field_2[num])
		{
			num--;
		}
		return num >= 0 && arg_0.field_2[num] > arg_1.field_2[num];
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0003696C File Offset: 0x00034B6C
	public static bool cmethod_1414(Class_219 arg_0, Class_219 arg_1)
	{
		int num = 999;
		if ((arg_0.field_2[num] & 2147483648U) != 0U && (arg_1.field_2[num] & 2147483648U) == 0U)
		{
			return true;
		}
		if ((arg_0.field_2[num] & 2147483648U) == 0U && (arg_1.field_2[num] & 2147483648U) != 0U)
		{
			return false;
		}
		num = ((arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3) - 1;
		while (num >= 0 && arg_0.field_2[num] == arg_1.field_2[num])
		{
			num--;
		}
		return num >= 0 && arg_0.field_2[num] < arg_1.field_2[num];
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00036A37 File Offset: 0x00034C37
	public static bool vmethod_1415(Class_219 arg_0, Class_219 arg_1)
	{
		return arg_0.Equals(arg_1) || Class_219.gmethod_1413(arg_0, arg_1);
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00036A4E File Offset: 0x00034C4E
	public static bool dmethod_1416(Class_219 arg_0, Class_219 arg_1)
	{
		return arg_0.Equals(arg_1) || Class_219.cmethod_1414(arg_0, arg_1);
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00036A68 File Offset: 0x00034C68
	private static void kmethod_1417(Class_219 arg_0, Class_219 arg_1, Class_219 arg_2, Class_219 arg_3)
	{
		uint[] array = new uint[1000];
		int num = arg_0.field_3 + 1;
		uint[] array2 = new uint[num];
		uint num2 = 2147483648U;
		uint num3 = arg_1.field_2[arg_1.field_3 - 1];
		int num4 = 0;
		int num5 = 0;
		while (num2 != 0U && (num3 & num2) == 0U)
		{
			num4++;
			num2 >>= 1;
		}
		for (int i = 0; i < arg_0.field_3; i++)
		{
			array2[i] = arg_0.field_2[i];
		}
		Class_219.vmethod_1405(array2, num4);
		arg_1 = Class_219.cmethod_1404(arg_1, num4);
		int j = num - arg_1.field_3;
		int num6 = num - 1;
		ulong num7 = (ulong)arg_1.field_2[arg_1.field_3 - 1];
		ulong num8 = (ulong)arg_1.field_2[arg_1.field_3 - 2];
		int num9 = arg_1.field_3 + 1;
		uint[] array3 = new uint[num9];
		while (j > 0)
		{
			ulong num10 = ((ulong)array2[num6] << 32) + (ulong)array2[num6 - 1];
			ulong num11 = num10 / num7;
			ulong num12 = num10 % num7;
			bool flag = false;
			while (!flag)
			{
				flag = true;
				if (num11 == 4294967296UL || num11 * num8 > (num12 << 32) + (ulong)array2[num6 - 2])
				{
					num11 -= 1UL;
					num12 += num7;
					if (num12 < 4294967296UL)
					{
						flag = false;
					}
				}
			}
			for (int k = 0; k < num9; k++)
			{
				array3[k] = array2[num6 - k];
			}
			Class_219 class_ = new Class_219(array3);
			Class_219 class_2 = Class_219.gmethod_1403(arg_1, new Class_219((long)num11));
			while (Class_219.gmethod_1413(class_2, class_))
			{
				num11 -= 1UL;
				class_2 = Class_219.xmethod_1401(class_2, arg_1);
			}
			Class_219 class_3 = Class_219.xmethod_1401(class_, class_2);
			for (int l = 0; l < num9; l++)
			{
				array2[num6 - l] = class_3.field_2[arg_1.field_3 - l];
			}
			array[num5++] = (uint)num11;
			num6--;
			j--;
		}
		arg_2.field_3 = num5;
		int m = 0;
		int n = arg_2.field_3 - 1;
		while (n >= 0)
		{
			arg_2.field_2[m] = array[n];
			n--;
			m++;
		}
		while (m < 1000)
		{
			arg_2.field_2[m] = 0U;
			m++;
		}
		while (arg_2.field_3 > 1 && arg_2.field_2[arg_2.field_3 - 1] == 0U)
		{
			arg_2.field_3--;
		}
		if (arg_2.field_3 == 0)
		{
			arg_2.field_3 = 1;
		}
		arg_3.field_3 = Class_219.kmethod_1407(array2, num4);
		for (m = 0; m < arg_3.field_3; m++)
		{
			arg_3.field_2[m] = array2[m];
		}
		while (m < 1000)
		{
			arg_3.field_2[m] = 0U;
			m++;
		}
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00036D58 File Offset: 0x00034F58
	private static void lmethod_1418(Class_219 arg_0, Class_219 arg_1, Class_219 arg_2, Class_219 arg_3)
	{
		uint[] array = new uint[1000];
		int num = 0;
		for (int i = 0; i < 1000; i++)
		{
			arg_3.field_2[i] = arg_0.field_2[i];
		}
		arg_3.field_3 = arg_0.field_3;
		while (arg_3.field_3 > 1 && arg_3.field_2[arg_3.field_3 - 1] == 0U)
		{
			arg_3.field_3--;
		}
		ulong num2 = (ulong)arg_1.field_2[0];
		int j = arg_3.field_3 - 1;
		ulong num3 = (ulong)arg_3.field_2[j];
		if (num3 >= num2)
		{
			ulong num4 = num3 / num2;
			array[num++] = (uint)num4;
			arg_3.field_2[j] = (uint)(num3 % num2);
		}
		j--;
		while (j >= 0)
		{
			num3 = ((ulong)arg_3.field_2[j + 1] << 32) + (ulong)arg_3.field_2[j];
			ulong num5 = num3 / num2;
			array[num++] = (uint)num5;
			arg_3.field_2[j + 1] = 0U;
			arg_3.field_2[j--] = (uint)(num3 % num2);
		}
		arg_2.field_3 = num;
		int k = 0;
		int l = arg_2.field_3 - 1;
		while (l >= 0)
		{
			arg_2.field_2[k] = array[l];
			l--;
			k++;
		}
		while (k < 1000)
		{
			arg_2.field_2[k] = 0U;
			k++;
		}
		while (arg_2.field_3 > 1 && arg_2.field_2[arg_2.field_3 - 1] == 0U)
		{
			arg_2.field_3--;
		}
		if (arg_2.field_3 == 0)
		{
			arg_2.field_3 = 1;
		}
		while (arg_3.field_3 > 1 && arg_3.field_2[arg_3.field_3 - 1] == 0U)
		{
			arg_3.field_3--;
		}
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00036F3C File Offset: 0x0003513C
	public static Class_219 pmethod_1419(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 class_ = new Class_219();
		Class_219 arg_2 = new Class_219();
		int num = 999;
		bool flag = false;
		bool flag2 = false;
		if ((arg_0.field_2[num] & 2147483648U) != 0U)
		{
			arg_0 = Class_219.pmethod_1409(arg_0);
			flag2 = true;
		}
		if ((arg_1.field_2[num] & 2147483648U) != 0U)
		{
			arg_1 = Class_219.pmethod_1409(arg_1);
			flag = true;
		}
		if (Class_219.cmethod_1414(arg_0, arg_1))
		{
			return class_;
		}
		if (arg_1.field_3 == 1)
		{
			Class_219.lmethod_1418(arg_0, arg_1, class_, arg_2);
		}
		else
		{
			Class_219.kmethod_1417(arg_0, arg_1, class_, arg_2);
		}
		if (flag2 != flag)
		{
			return Class_219.pmethod_1409(class_);
		}
		return class_;
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00036FDC File Offset: 0x000351DC
	public static Class_219 smethod_1420(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 arg_2 = new Class_219();
		Class_219 class_ = new Class_219(arg_0);
		int num = 999;
		bool flag = false;
		if ((arg_0.field_2[num] & 2147483648U) != 0U)
		{
			arg_0 = Class_219.pmethod_1409(arg_0);
			flag = true;
		}
		if ((arg_1.field_2[num] & 2147483648U) != 0U)
		{
			arg_1 = Class_219.pmethod_1409(arg_1);
		}
		if (Class_219.cmethod_1414(arg_0, arg_1))
		{
			return class_;
		}
		if (arg_1.field_3 == 1)
		{
			Class_219.lmethod_1418(arg_0, arg_1, arg_2, class_);
		}
		else
		{
			Class_219.kmethod_1417(arg_0, arg_1, arg_2, class_);
		}
		if (flag)
		{
			return Class_219.pmethod_1409(class_);
		}
		return class_;
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00037078 File Offset: 0x00035278
	public static Class_219 xmethod_1421(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 class_ = new Class_219();
		int num = (arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3;
		for (int i = 0; i < num; i++)
		{
			uint num2 = arg_0.field_2[i] & arg_1.field_2[i];
			class_.field_2[i] = num2;
		}
		class_.field_3 = 1000;
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		return class_;
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00037114 File Offset: 0x00035314
	public static Class_219 tmethod_1422(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 class_ = new Class_219();
		int num = (arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3;
		for (int i = 0; i < num; i++)
		{
			uint num2 = arg_0.field_2[i] | arg_1.field_2[i];
			class_.field_2[i] = num2;
		}
		class_.field_3 = 1000;
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		return class_;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x000371B0 File Offset: 0x000353B0
	public static Class_219 gmethod_1423(Class_219 arg_0, Class_219 arg_1)
	{
		Class_219 class_ = new Class_219();
		int num = (arg_0.field_3 > arg_1.field_3) ? arg_0.field_3 : arg_1.field_3;
		for (int i = 0; i < num; i++)
		{
			uint num2 = arg_0.field_2[i] ^ arg_1.field_2[i];
			class_.field_2[i] = num2;
		}
		class_.field_3 = 1000;
		while (class_.field_3 > 1 && class_.field_2[class_.field_3 - 1] == 0U)
		{
			class_.field_3--;
		}
		return class_;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0003724C File Offset: 0x0003544C
	public Class_219 cmethod_1424(Class_219 arg_0)
	{
		if (Class_219.gmethod_1413(this, arg_0))
		{
			return new Class_219(this);
		}
		return new Class_219(arg_0);
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00037267 File Offset: 0x00035467
	public Class_219 vmethod_1425(Class_219 arg_0)
	{
		if (Class_219.cmethod_1414(this, arg_0))
		{
			return new Class_219(this);
		}
		return new Class_219(arg_0);
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00037282 File Offset: 0x00035482
	public Class_219 dmethod_1426()
	{
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			return Class_219.pmethod_1409(this);
		}
		return new Class_219(this);
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x000372A8 File Offset: 0x000354A8
	public virtual string kmethod_1427()
	{
		return this.lmethod_1428(10);
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x000372B4 File Offset: 0x000354B4
	public string lmethod_1428(int sayıInt_0)
	{
		if (sayıInt_0 < 2 || sayıInt_0 > 36)
		{
			throw new ArgumentException("Radix must be >= 2 and <= 36");
		}
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string text2 = "";
		Class_219 class_ = this;
		bool flag = false;
		if ((class_.field_2[999] & 2147483648U) != 0U)
		{
			flag = true;
			try
			{
				class_ = Class_219.pmethod_1409(class_);
			}
			catch (Exception)
			{
			}
		}
		Class_219 class_2 = new Class_219();
		Class_219 class_3 = new Class_219();
		Class_219 arg_ = new Class_219((long)sayıInt_0);
		if (class_.field_3 == 1 && class_.field_2[0] == 0U)
		{
			text2 = "0";
		}
		else
		{
			while (class_.field_3 > 1 || (class_.field_3 == 1 && class_.field_2[0] != 0U))
			{
				Class_219.lmethod_1418(class_, arg_, class_2, class_3);
				if (class_3.field_2[0] < 10U)
				{
					text2 = class_3.field_2[0] + text2;
				}
				else
				{
					text2 = text[(int)(class_3.field_2[0] - 10U)].ToString() + text2;
				}
				class_ = class_2;
			}
			if (flag)
			{
				text2 = "-" + text2;
			}
		}
		return text2;
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x000373F0 File Offset: 0x000355F0
	public string pmethod_1429()
	{
		string text = this.field_2[this.field_3 - 1].ToString("X");
		for (int i = this.field_3 - 2; i >= 0; i--)
		{
			text += this.field_2[i].ToString("X8");
		}
		return text;
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x00037450 File Offset: 0x00035650
	public Class_219 smethod_1430(Class_219 arg_0, Class_219 arg_1)
	{
		if ((arg_0.field_2[999] & 2147483648U) != 0U)
		{
			throw new ArithmeticException("Positive exponents only.");
		}
		Class_219 class_ = Class_219.kmethod_1397(1);
		bool flag = false;
		Class_219 class_2;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_2 = Class_219.smethod_1420(Class_219.pmethod_1409(this), arg_1);
			flag = true;
		}
		else
		{
			class_2 = Class_219.smethod_1420(this, arg_1);
		}
		if ((arg_1.field_2[999] & 2147483648U) != 0U)
		{
			arg_1 = Class_219.pmethod_1409(arg_1);
		}
		Class_219 class_3 = new Class_219();
		int num = arg_1.field_3 << 1;
		class_3.field_2[num] = 1U;
		class_3.field_3 = num + 1;
		class_3 = Class_219.pmethod_1419(class_3, arg_1);
		int num2 = arg_0.cmethod_1434();
		int num3 = 0;
		for (int i = 0; i < arg_0.field_3; i++)
		{
			uint num4 = 1U;
			int j = 0;
			while (j < 32)
			{
				if ((arg_0.field_2[i] & num4) != 0U)
				{
					class_ = this.xmethod_1431(Class_219.gmethod_1403(class_, class_2), arg_1, class_3);
				}
				num4 <<= 1;
				class_2 = this.xmethod_1431(Class_219.gmethod_1403(class_2, class_2), arg_1, class_3);
				if (class_2.field_3 == 1 && class_2.field_2[0] == 1U)
				{
					if (flag && (arg_0.field_2[0] & 1U) != 0U)
					{
						return Class_219.pmethod_1409(class_);
					}
					return class_;
				}
				else
				{
					num3++;
					if (num3 == num2)
					{
						break;
					}
					j++;
				}
			}
		}
		if (flag && (arg_0.field_2[0] & 1U) != 0U)
		{
			return Class_219.pmethod_1409(class_);
		}
		return class_;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x000375E4 File Offset: 0x000357E4
	private Class_219 xmethod_1431(Class_219 arg_0, Class_219 arg_1, Class_219 arg_2)
	{
		int num = arg_1.field_3;
		int num2 = num + 1;
		int num3 = num - 1;
		Class_219 class_ = new Class_219();
		int i = num3;
		int num4 = 0;
		while (i < arg_0.field_3)
		{
			class_.field_2[num4] = arg_0.field_2[i];
			i++;
			num4++;
		}
		class_.field_3 = arg_0.field_3 - num3;
		if (class_.field_3 <= 0)
		{
			class_.field_3 = 1;
		}
		Class_219 class_2 = Class_219.gmethod_1403(class_, arg_2);
		Class_219 class_3 = new Class_219();
		int j = num2;
		int num5 = 0;
		while (j < class_2.field_3)
		{
			class_3.field_2[num5] = class_2.field_2[j];
			j++;
			num5++;
		}
		class_3.field_3 = class_2.field_3 - num2;
		if (class_3.field_3 <= 0)
		{
			class_3.field_3 = 1;
		}
		Class_219 class_4 = new Class_219();
		int num6 = (arg_0.field_3 > num2) ? num2 : arg_0.field_3;
		for (int k = 0; k < num6; k++)
		{
			class_4.field_2[k] = arg_0.field_2[k];
		}
		class_4.field_3 = num6;
		Class_219 class_5 = new Class_219();
		for (int l = 0; l < class_3.field_3; l++)
		{
			if (class_3.field_2[l] != 0U)
			{
				ulong num7 = 0UL;
				int num8 = l;
				int num9 = 0;
				while (num9 < arg_1.field_3 && num8 < num2)
				{
					ulong num10 = (ulong)class_3.field_2[l] * (ulong)arg_1.field_2[num9] + (ulong)class_5.field_2[num8] + num7;
					class_5.field_2[num8] = (uint)(num10 & (ulong)-1);
					num7 = num10 >> 32;
					num9++;
					num8++;
				}
				if (num8 < num2)
				{
					class_5.field_2[num8] = (uint)num7;
				}
			}
		}
		class_5.field_3 = num2;
		while (class_5.field_3 > 1 && class_5.field_2[class_5.field_3 - 1] == 0U)
		{
			class_5.field_3--;
		}
		class_4 = Class_219.xmethod_1401(class_4, class_5);
		if ((class_4.field_2[999] & 2147483648U) != 0U)
		{
			Class_219 class_6 = new Class_219();
			class_6.field_2[num2] = 1U;
			class_6.field_3 = num2 + 1;
			class_4 = Class_219.pmethod_1399(class_4, class_6);
		}
		while (Class_219.vmethod_1415(class_4, arg_1))
		{
			class_4 = Class_219.xmethod_1401(class_4, arg_1);
		}
		return class_4;
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00037864 File Offset: 0x00035A64
	public Class_219 tmethod_1432(Class_219 arg_0)
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		Class_219 class_2;
		if ((arg_0.field_2[999] & 2147483648U) != 0U)
		{
			class_2 = Class_219.pmethod_1409(arg_0);
		}
		else
		{
			class_2 = arg_0;
		}
		Class_219 class_3 = class_2;
		while (class_.field_3 > 1 || (class_.field_3 == 1 && class_.field_2[0] != 0U))
		{
			class_3 = class_;
			class_ = Class_219.smethod_1420(class_2, class_);
			class_2 = class_3;
		}
		return class_3;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x000378F0 File Offset: 0x00035AF0
	public void gmethod_1433(int sayıInt_0, Random arg_0)
	{
		int num = sayıInt_0 >> 5;
		int num2 = sayıInt_0 & 31;
		if (num2 != 0)
		{
			num++;
		}
		if (num > 1000 || sayıInt_0 <= 0)
		{
			throw new ArithmeticException("Number of required bits is not valid.");
		}
		byte[] array = new byte[num * 4];
		arg_0.NextBytes(array);
		for (int i = 0; i < num; i++)
		{
			this.field_2[i] = BitConverter.ToUInt32(array, i * 4);
		}
		for (int j = num; j < 1000; j++)
		{
			this.field_2[j] = 0U;
		}
		if (num2 != 0)
		{
			uint num3;
			if (sayıInt_0 != 1)
			{
				num3 = 1U << num2 - 1;
				this.field_2[num - 1] |= num3;
			}
			num3 = uint.MaxValue >> 32 - num2;
			this.field_2[num - 1] &= num3;
		}
		else
		{
			this.field_2[num - 1] |= 2147483648U;
		}
		this.field_3 = num;
		if (this.field_3 == 0)
		{
			this.field_3 = 1;
		}
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00037A00 File Offset: 0x00035C00
	public int cmethod_1434()
	{
		while (this.field_3 > 1 && this.field_2[this.field_3 - 1] == 0U)
		{
			this.field_3--;
		}
		uint num = this.field_2[this.field_3 - 1];
		uint num2 = 2147483648U;
		int num3 = 32;
		while (num3 > 0 && (num & num2) == 0U)
		{
			num3--;
			num2 >>= 1;
		}
		num3 += this.field_3 - 1 << 5;
		if (num3 != 0)
		{
			return num3;
		}
		return 1;
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00037A88 File Offset: 0x00035C88
	public bool vmethod_1435(int sayıInt_0)
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		if (class_.field_3 == 1)
		{
			if (class_.field_2[0] == 0U || class_.field_2[0] == 1U)
			{
				return false;
			}
			if (class_.field_2[0] == 2U || class_.field_2[0] == 3U)
			{
				return true;
			}
		}
		if ((class_.field_2[0] & 1U) == 0U)
		{
			return false;
		}
		int num = class_.cmethod_1434();
		Class_219 class_2 = new Class_219();
		Class_219 arg_ = Class_219.xmethod_1401(class_, new Class_219(1L));
		Random random = new Random();
		for (int i = 0; i < sayıInt_0; i++)
		{
			bool flag = false;
			while (!flag)
			{
				int j;
				for (j = 0; j < 2; j = (int)(random.NextDouble() * (double)num))
				{
				}
				class_2.gmethod_1433(j, random);
				int num2 = class_2.field_3;
				if (num2 > 1 || (num2 == 1 && class_2.field_2[0] != 1U))
				{
					flag = true;
				}
			}
			Class_219 class_3 = class_2.tmethod_1432(class_);
			if (class_3.field_3 == 1 && class_3.field_2[0] != 1U)
			{
				return false;
			}
			Class_219 class_4 = class_2.smethod_1430(arg_, class_);
			int num3 = class_4.field_3;
			if (num3 > 1 || (num3 == 1 && class_4.field_2[0] != 1U))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00037C00 File Offset: 0x00035E00
	public bool dmethod_1436(int sayıInt_0)
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		if (class_.field_3 == 1)
		{
			if (class_.field_2[0] == 0U || class_.field_2[0] == 1U)
			{
				return false;
			}
			if (class_.field_2[0] == 2U || class_.field_2[0] == 3U)
			{
				return true;
			}
		}
		if ((class_.field_2[0] & 1U) == 0U)
		{
			return false;
		}
		Class_219 class_2 = Class_219.xmethod_1401(class_, new Class_219(1L));
		int num = 0;
		for (int i = 0; i < class_2.field_3; i++)
		{
			uint num2 = 1U;
			for (int j = 0; j < 32; j++)
			{
				if ((class_2.field_2[i] & num2) != 0U)
				{
					i = class_2.field_3;
					break;
				}
				num2 <<= 1;
				num++;
			}
		}
		Class_219 arg_ = Class_219.dmethod_1406(class_2, num);
		int num3 = class_.cmethod_1434();
		Class_219 class_3 = new Class_219();
		Random random = new Random();
		for (int k = 0; k < sayıInt_0; k++)
		{
			bool flag = false;
			while (!flag)
			{
				int l;
				for (l = 0; l < 2; l = (int)(random.NextDouble() * (double)num3))
				{
				}
				class_3.gmethod_1433(l, random);
				int num4 = class_3.field_3;
				if (num4 > 1 || (num4 == 1 && class_3.field_2[0] != 1U))
				{
					flag = true;
				}
			}
			Class_219 class_4 = class_3.tmethod_1432(class_);
			if (class_4.field_3 == 1 && class_4.field_2[0] != 1U)
			{
				return false;
			}
			Class_219 class_5 = class_3.smethod_1430(arg_, class_);
			bool flag2 = false;
			if (class_5.field_3 == 1 && class_5.field_2[0] == 1U)
			{
				flag2 = true;
			}
			int num5 = 0;
			while (!flag2 && num5 < num)
			{
				if (class_5.Equals(class_2))
				{
					flag2 = true;
					break;
				}
				class_5 = Class_219.smethod_1420(Class_219.gmethod_1403(class_5, class_5), class_);
				num5++;
			}
			if (!flag2)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00037E20 File Offset: 0x00036020
	public bool kmethod_1437(int sayıInt_0)
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		if (class_.field_3 == 1)
		{
			if (class_.field_2[0] == 0U || class_.field_2[0] == 1U)
			{
				return false;
			}
			if (class_.field_2[0] == 2U || class_.field_2[0] == 3U)
			{
				return true;
			}
		}
		if ((class_.field_2[0] & 1U) == 0U)
		{
			return false;
		}
		int num = class_.cmethod_1434();
		Class_219 class_2 = new Class_219();
		Class_219 class_3 = Class_219.xmethod_1401(class_, Class_219.kmethod_1397(1));
		Class_219 arg_ = Class_219.dmethod_1406(class_3, 1);
		Random random = new Random();
		for (int i = 0; i < sayıInt_0; i++)
		{
			bool flag = false;
			while (!flag)
			{
				int j;
				for (j = 0; j < 2; j = (int)(random.NextDouble() * (double)num))
				{
				}
				class_2.gmethod_1433(j, random);
				int num2 = class_2.field_3;
				if (num2 > 1 || (num2 == 1 && class_2.field_2[0] != 1U))
				{
					flag = true;
				}
			}
			Class_219 class_4 = class_2.tmethod_1432(class_);
			if (class_4.field_3 == 1 && class_4.field_2[0] != 1U)
			{
				return false;
			}
			Class_219 class_5 = class_2.smethod_1430(arg_, class_);
			if (class_5.Equals(class_3))
			{
				class_5 = Class_219.kmethod_1397(-1);
			}
			Class_219 arg_2 = Class_219.kmethod_1397(Class_219.cmethod_1444(class_2, class_));
			if (Class_219.smethod_1410(class_5, arg_2))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00037FAC File Offset: 0x000361AC
	public bool lmethod_1438()
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		if (class_.field_3 == 1)
		{
			if (class_.field_2[0] == 0U || class_.field_2[0] == 1U)
			{
				return false;
			}
			if (class_.field_2[0] == 2U || class_.field_2[0] == 3U)
			{
				return true;
			}
		}
		return (class_.field_2[0] & 1U) != 0U && this.pmethod_1439(class_);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00038040 File Offset: 0x00036240
	private bool pmethod_1439(Class_219 arg_0)
	{
		long num = 5L;
		long num2 = -1L;
		long num3 = 0L;
		bool flag = false;
		while (!flag)
		{
			int num4 = Class_219.cmethod_1444(new Class_219(num), arg_0);
			if (num4 == -1)
			{
				flag = true;
			}
			else
			{
				if (num4 == 0 && Class_219.cmethod_1414(new Class_219(Math.Abs(num)), arg_0))
				{
					return false;
				}
				if (num3 == 20L)
				{
					Class_219 class_ = arg_0.xmethod_1451();
					if (Class_219.gmethod_1403(class_, class_).Equals(arg_0))
					{
						return false;
					}
				}
				num = (Math.Abs(num) + 2L) * num2;
				num2 = -num2;
			}
			num3 += 1L;
		}
		long num5 = 1L - num >> 2;
		Class_219 class_2 = Class_219.pmethod_1399(arg_0, Class_219.kmethod_1397(1));
		int num6 = 0;
		for (int i = 0; i < class_2.field_3; i++)
		{
			uint num7 = 1U;
			for (int j = 0; j < 32; j++)
			{
				if ((class_2.field_2[i] & num7) != 0U)
				{
					i = class_2.field_3;
					break;
				}
				num7 <<= 1;
				num6++;
			}
		}
		Class_219 arg_ = Class_219.dmethod_1406(class_2, num6);
		Class_219 class_3 = new Class_219();
		int num8 = arg_0.field_3 << 1;
		class_3.field_2[num8] = 1U;
		class_3.field_3 = num8 + 1;
		class_3 = Class_219.pmethod_1419(class_3, arg_0);
		Class_219[] array = Class_219.gmethod_1453(Class_219.kmethod_1397(1), new Class_219(num5), arg_, arg_0, class_3, 0);
		bool flag2 = false;
		if ((array[0].field_3 == 1 && array[0].field_2[0] == 0U) || (array[1].field_3 == 1 && array[1].field_2[0] == 0U))
		{
			flag2 = true;
		}
		for (int k = 1; k < num6; k++)
		{
			if (!flag2)
			{
				array[1] = arg_0.xmethod_1431(Class_219.gmethod_1403(array[1], array[1]), arg_0, class_3);
				array[1] = Class_219.smethod_1420(Class_219.xmethod_1401(array[1], Class_219.cmethod_1404(array[2], 1)), arg_0);
				if (array[1].field_3 == 1 && array[1].field_2[0] == 0U)
				{
					flag2 = true;
				}
			}
			array[2] = arg_0.xmethod_1431(Class_219.gmethod_1403(array[2], array[2]), arg_0, class_3);
		}
		if (flag2)
		{
			Class_219 class_4 = arg_0.tmethod_1432(new Class_219(num5));
			if (class_4.field_3 == 1 && class_4.field_2[0] == 1U)
			{
				if ((array[2].field_2[999] & 2147483648U) != 0U)
				{
					Class_219[] array2 = array;
					array2[2] = Class_219.pmethod_1399(array2[2], arg_0);
				}
				Class_219 class_5 = Class_219.smethod_1420(new Class_219(num5 * (long)Class_219.cmethod_1444(new Class_219(num5), arg_0)), arg_0);
				if ((class_5.field_2[999] & 2147483648U) != 0U)
				{
					class_5 = Class_219.pmethod_1399(class_5, arg_0);
				}
				if (Class_219.smethod_1410(array[2], class_5))
				{
					flag2 = false;
				}
			}
		}
		return flag2;
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00038374 File Offset: 0x00036574
	public bool smethod_1440(int sayıInt_0)
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		for (int i = 0; i < Class_219.field_1.Length; i++)
		{
			Class_219 class_2 = Class_219.kmethod_1397(Class_219.field_1[i]);
			if (Class_219.vmethod_1415(class_2, class_))
			{
				break;
			}
			if (Class_219.smethod_1420(class_, class_2).tmethod_1442() == 0)
			{
				return false;
			}
		}
		return class_.dmethod_1436(sayıInt_0);
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x000383F8 File Offset: 0x000365F8
	public bool xmethod_1441()
	{
		Class_219 class_;
		if ((this.field_2[999] & 2147483648U) != 0U)
		{
			class_ = Class_219.pmethod_1409(this);
		}
		else
		{
			class_ = this;
		}
		if (class_.field_3 == 1)
		{
			if (class_.field_2[0] == 0U || class_.field_2[0] == 1U)
			{
				return false;
			}
			if (class_.field_2[0] == 2U || class_.field_2[0] == 3U)
			{
				return true;
			}
		}
		if ((class_.field_2[0] & 1U) == 0U)
		{
			return false;
		}
		for (int i = 0; i < Class_219.field_1.Length; i++)
		{
			Class_219 class_2 = Class_219.kmethod_1397(Class_219.field_1[i]);
			if (Class_219.vmethod_1415(class_2, class_))
			{
				break;
			}
			if (Class_219.smethod_1420(class_, class_2).tmethod_1442() == 0)
			{
				return false;
			}
		}
		Class_219 class_3 = Class_219.xmethod_1401(class_, new Class_219(1L));
		int num = 0;
		for (int j = 0; j < class_3.field_3; j++)
		{
			uint num2 = 1U;
			for (int k = 0; k < 32; k++)
			{
				if ((class_3.field_2[j] & num2) != 0U)
				{
					j = class_3.field_3;
					break;
				}
				num2 <<= 1;
				num++;
			}
		}
		Class_219 arg_ = Class_219.dmethod_1406(class_3, num);
		class_.cmethod_1434();
		Class_219 class_4 = Class_219.kmethod_1397(2).smethod_1430(arg_, class_);
		bool flag = false;
		if (class_4.field_3 == 1 && class_4.field_2[0] == 1U)
		{
			flag = true;
		}
		int num3 = 0;
		while (!flag && num3 < num)
		{
			if (class_4.Equals(class_3))
			{
				flag = true;
				break;
			}
			class_4 = Class_219.smethod_1420(Class_219.gmethod_1403(class_4, class_4), class_);
			num3++;
		}
		if (flag)
		{
			flag = this.pmethod_1439(class_);
		}
		return flag;
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x000385C3 File Offset: 0x000367C3
	public int tmethod_1442()
	{
		return (int)this.field_2[0];
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x000385D0 File Offset: 0x000367D0
	public long gmethod_1443()
	{
		long num = 0L;
		num = (long)((ulong)this.field_2[0]);
		try
		{
			num |= (long)((long)((ulong)this.field_2[1]) << 32);
		}
		catch (Exception)
		{
			if ((this.field_2[0] & 2147483648U) != 0U)
			{
				num = (long)this.field_2[0];
			}
		}
		return num;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00038634 File Offset: 0x00036834
	public static int cmethod_1444(Class_219 arg_0, Class_219 arg_1)
	{
		if ((arg_1.field_2[0] & 1U) == 0U)
		{
			throw new ArgumentException("Jacobi defined only for odd integers.");
		}
		if (Class_219.vmethod_1415(arg_0, arg_1))
		{
			arg_0 = Class_219.smethod_1420(arg_0, arg_1);
		}
		if (arg_0.field_3 == 1 && arg_0.field_2[0] == 0U)
		{
			return 0;
		}
		if (arg_0.field_3 == 1 && arg_0.field_2[0] == 1U)
		{
			return 1;
		}
		if (Class_219.cmethod_1414(arg_0, Class_219.kmethod_1397(0)))
		{
			if ((Class_219.xmethod_1401(arg_1, Class_219.kmethod_1397(1)).field_2[0] & 2U) == 0U)
			{
				return Class_219.cmethod_1444(Class_219.pmethod_1409(arg_0), arg_1);
			}
			return -Class_219.cmethod_1444(Class_219.pmethod_1409(arg_0), arg_1);
		}
		else
		{
			int num = 0;
			for (int i = 0; i < arg_0.field_3; i++)
			{
				uint num2 = 1U;
				for (int j = 0; j < 32; j++)
				{
					if ((arg_0.field_2[i] & num2) != 0U)
					{
						i = arg_0.field_3;
						break;
					}
					num2 <<= 1;
					num++;
				}
			}
			Class_219 class_ = Class_219.dmethod_1406(arg_0, num);
			int num3 = 1;
			if ((num & 1) != 0 && ((arg_1.field_2[0] & 7U) == 3U || (arg_1.field_2[0] & 7U) == 5U))
			{
				num3 = -1;
			}
			if ((arg_1.field_2[0] & 3U) == 3U && (class_.field_2[0] & 3U) == 3U)
			{
				num3 = -num3;
			}
			if (class_.field_3 == 1 && class_.field_2[0] == 1U)
			{
				return num3;
			}
			return num3 * Class_219.cmethod_1444(Class_219.smethod_1420(arg_1, class_), class_);
		}
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x000387C8 File Offset: 0x000369C8
	public static Class_219 vmethod_1445(int sayıInt_0, int sayıInt_1, Random arg_0)
	{
		Class_219 class_ = new Class_219();
		bool flag = false;
		while (!flag)
		{
			class_.gmethod_1433(sayıInt_0, arg_0);
			class_.field_2[0] |= 1U;
			flag = class_.smethod_1440(sayıInt_1);
		}
		return class_;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00038808 File Offset: 0x00036A08
	public Class_219 dmethod_1446(int sayıInt_0, Random arg_0)
	{
		bool flag = false;
		Class_219 class_ = new Class_219();
		while (!flag)
		{
			class_.gmethod_1433(sayıInt_0, arg_0);
			Class_219 class_2 = class_.tmethod_1432(this);
			if (class_2.field_3 == 1 && class_2.field_2[0] == 1U)
			{
				flag = true;
			}
		}
		return class_;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00038854 File Offset: 0x00036A54
	public Class_219 kmethod_1447(Class_219 arg_0)
	{
		Class_219[] array = new Class_219[]
		{
			Class_219.kmethod_1397(0),
			Class_219.kmethod_1397(1)
		};
		Class_219[] array2 = new Class_219[2];
		Class_219[] array3 = new Class_219[]
		{
			Class_219.kmethod_1397(0),
			Class_219.kmethod_1397(0)
		};
		int num = 0;
		Class_219 arg_ = arg_0;
		Class_219 class_ = this;
		while (class_.field_3 > 1 || (class_.field_3 == 1 && class_.field_2[0] != 0U))
		{
			Class_219 class_2 = new Class_219();
			Class_219 class_3 = new Class_219();
			if (num > 1)
			{
				Class_219 class_4 = Class_219.smethod_1420(Class_219.xmethod_1401(array[0], Class_219.gmethod_1403(array[1], array2[0])), arg_0);
				array[0] = array[1];
				array[1] = class_4;
			}
			if (class_.field_3 == 1)
			{
				Class_219.lmethod_1418(arg_, class_, class_2, class_3);
			}
			else
			{
				Class_219.kmethod_1417(arg_, class_, class_2, class_3);
			}
			array2[0] = array2[1];
			array3[0] = array3[1];
			array2[1] = class_2;
			array3[1] = class_3;
			arg_ = class_;
			class_ = class_3;
			num++;
		}
		if (array3[0].field_3 > 1 || (array3[0].field_3 == 1 && array3[0].field_2[0] != 1U))
		{
			throw new ArithmeticException("No inverse!");
		}
		Class_219 class_5 = Class_219.smethod_1420(Class_219.xmethod_1401(array[0], Class_219.gmethod_1403(array[1], array2[0])), arg_0);
		if ((class_5.field_2[999] & 2147483648U) != 0U)
		{
			class_5 = Class_219.pmethod_1399(class_5, arg_0);
		}
		return class_5;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00038A18 File Offset: 0x00036C18
	public byte[] lmethod_1448()
	{
		int num = this.cmethod_1434();
		int num2 = num >> 3;
		if ((num & 7) != 0)
		{
			num2++;
		}
		byte[] array = new byte[num2];
		int num3 = 0;
		uint num4 = this.field_2[this.field_3 - 1];
		uint num5;
		if ((num5 = (num4 >> 24 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		if ((num5 = (num4 >> 16 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		else if (num3 > 0)
		{
			num3++;
		}
		if ((num5 = (num4 >> 8 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		else if (num3 > 0)
		{
			num3++;
		}
		if ((num5 = (num4 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		else if (num3 > 0)
		{
			num3++;
		}
		int i = this.field_3 - 2;
		while (i >= 0)
		{
			num4 = this.field_2[i];
			array[num3 + 3] = (byte)(num4 & 255U);
			num4 >>= 8;
			array[num3 + 2] = (byte)(num4 & 255U);
			num4 >>= 8;
			array[num3 + 1] = (byte)(num4 & 255U);
			num4 >>= 8;
			array[num3] = (byte)(num4 & 255U);
			i--;
			num3 += 4;
		}
		return array;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00038B58 File Offset: 0x00036D58
	public void pmethod_1449(uint arg_0)
	{
		uint num = arg_0 >> 5;
		byte b = (byte)(arg_0 & 31U);
		uint num2 = 1U << (int)b;
		this.field_2[(int)num] |= num2;
		if ((ulong)num >= (ulong)((long)this.field_3))
		{
			this.field_3 = (int)(num + 1U);
		}
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00038BA0 File Offset: 0x00036DA0
	public void smethod_1450(uint arg_0)
	{
		uint num = arg_0 >> 5;
		if ((ulong)num < (ulong)((long)this.field_3))
		{
			byte b = (byte)(arg_0 & 31U);
			uint num2 = 1U << (int)b;
			uint num3 = uint.MaxValue ^ num2;
			this.field_2[(int)num] &= num3;
			if (this.field_3 > 1 && this.field_2[this.field_3 - 1] == 0U)
			{
				this.field_3--;
			}
		}
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00038C10 File Offset: 0x00036E10
	public Class_219 xmethod_1451()
	{
		uint num = (uint)this.cmethod_1434();
		if ((num & 1U) != 0U)
		{
			num = (num >> 1) + 1U;
		}
		else
		{
			num >>= 1;
		}
		uint num2 = num >> 5;
		byte b = (byte)(num & 31U);
		Class_219 class_ = new Class_219();
		uint num3;
		if (b == 0)
		{
			num3 = 2147483648U;
		}
		else
		{
			num3 = 1U << (int)b;
			num2 += 1U;
		}
		class_.field_3 = (int)num2;
		for (int i = (int)(num2 - 1U); i >= 0; i--)
		{
			while (num3 != 0U)
			{
				class_.field_2[i] ^= num3;
				if (Class_219.gmethod_1413(Class_219.gmethod_1403(class_, class_), this))
				{
					class_.field_2[i] ^= num3;
				}
				num3 >>= 1;
			}
			num3 = 2147483648U;
		}
		return class_;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00038CD0 File Offset: 0x00036ED0
	public static Class_219[] tmethod_1452(Class_219 arg_0, Class_219 arg_1, Class_219 arg_2, Class_219 arg_3)
	{
		if (arg_2.field_3 == 1 && arg_2.field_2[0] == 0U)
		{
			return new Class_219[]
			{
				Class_219.kmethod_1397(0),
				Class_219.smethod_1420(Class_219.kmethod_1397(2), arg_3),
				Class_219.smethod_1420(Class_219.kmethod_1397(1), arg_3)
			};
		}
		Class_219 class_ = new Class_219();
		int num = arg_3.field_3 << 1;
		class_.field_2[num] = 1U;
		class_.field_3 = num + 1;
		class_ = Class_219.pmethod_1419(class_, arg_3);
		int num2 = 0;
		for (int i = 0; i < arg_2.field_3; i++)
		{
			uint num3 = 1U;
			for (int j = 0; j < 32; j++)
			{
				if ((arg_2.field_2[i] & num3) != 0U)
				{
					i = arg_2.field_3;
					break;
				}
				num3 <<= 1;
				num2++;
			}
		}
		Class_219 arg_4 = Class_219.dmethod_1406(arg_2, num2);
		return Class_219.gmethod_1453(arg_0, arg_1, arg_4, arg_3, class_, num2);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00038DB8 File Offset: 0x00036FB8
	private static Class_219[] gmethod_1453(Class_219 arg_0, Class_219 arg_1, Class_219 arg_2, Class_219 arg_3, Class_219 arg_4, int sayıInt_0)
	{
		Class_219[] array = new Class_219[3];
		if ((arg_2.field_2[0] & 1U) == 0U)
		{
			throw new ArgumentException("Argument k must be odd.");
		}
		int num = arg_2.cmethod_1434();
		uint num2 = 1U << (num & 31) - 1;
		Class_219 class_ = Class_219.smethod_1420(Class_219.kmethod_1397(2), arg_3);
		Class_219 class_2 = Class_219.smethod_1420(Class_219.kmethod_1397(1), arg_3);
		Class_219 class_3 = Class_219.smethod_1420(arg_0, arg_3);
		Class_219 class_4 = class_2;
		bool flag = true;
		for (int i = arg_2.field_3 - 1; i >= 0; i--)
		{
			while (num2 != 0U && (i != 0 || num2 != 1U))
			{
				if ((arg_2.field_2[i] & num2) != 0U)
				{
					class_4 = Class_219.smethod_1420(Class_219.gmethod_1403(class_4, class_3), arg_3);
					class_ = Class_219.smethod_1420(Class_219.xmethod_1401(Class_219.gmethod_1403(class_, class_3), Class_219.gmethod_1403(arg_0, class_2)), arg_3);
					class_3 = arg_3.xmethod_1431(Class_219.gmethod_1403(class_3, class_3), arg_3, arg_4);
					class_3 = Class_219.smethod_1420(Class_219.xmethod_1401(class_3, Class_219.cmethod_1404(Class_219.gmethod_1403(class_2, arg_1), 1)), arg_3);
					if (flag)
					{
						flag = false;
					}
					else
					{
						class_2 = arg_3.xmethod_1431(Class_219.gmethod_1403(class_2, class_2), arg_3, arg_4);
					}
					class_2 = Class_219.smethod_1420(Class_219.gmethod_1403(class_2, arg_1), arg_3);
				}
				else
				{
					class_4 = Class_219.smethod_1420(Class_219.xmethod_1401(Class_219.gmethod_1403(class_4, class_), class_2), arg_3);
					class_3 = Class_219.smethod_1420(Class_219.xmethod_1401(Class_219.gmethod_1403(class_, class_3), Class_219.gmethod_1403(arg_0, class_2)), arg_3);
					class_ = arg_3.xmethod_1431(Class_219.gmethod_1403(class_, class_), arg_3, arg_4);
					class_ = Class_219.smethod_1420(Class_219.xmethod_1401(class_, Class_219.cmethod_1404(class_2, 1)), arg_3);
					if (flag)
					{
						class_2 = Class_219.smethod_1420(arg_1, arg_3);
						flag = false;
					}
					else
					{
						class_2 = arg_3.xmethod_1431(Class_219.gmethod_1403(class_2, class_2), arg_3, arg_4);
					}
				}
				num2 >>= 1;
			}
			num2 = 2147483648U;
		}
		class_4 = Class_219.smethod_1420(Class_219.xmethod_1401(Class_219.gmethod_1403(class_4, class_), class_2), arg_3);
		class_ = Class_219.smethod_1420(Class_219.xmethod_1401(Class_219.gmethod_1403(class_, class_3), Class_219.gmethod_1403(arg_0, class_2)), arg_3);
		if (flag)
		{
			flag = false;
		}
		else
		{
			class_2 = arg_3.xmethod_1431(Class_219.gmethod_1403(class_2, class_2), arg_3, arg_4);
		}
		class_2 = Class_219.smethod_1420(Class_219.gmethod_1403(class_2, arg_1), arg_3);
		for (int j = 0; j < sayıInt_0; j++)
		{
			class_4 = Class_219.smethod_1420(Class_219.gmethod_1403(class_4, class_), arg_3);
			class_ = Class_219.smethod_1420(Class_219.xmethod_1401(Class_219.gmethod_1403(class_, class_), Class_219.cmethod_1404(class_2, 1)), arg_3);
			if (flag)
			{
				class_2 = Class_219.smethod_1420(arg_1, arg_3);
				flag = false;
			}
			else
			{
				class_2 = arg_3.xmethod_1431(Class_219.gmethod_1403(class_2, class_2), arg_3, arg_4);
			}
		}
		array[0] = class_4;
		array[1] = class_;
		array[2] = class_2;
		return array;
	}

	// Token: 0x040005F5 RID: 1525
	private const int field_0 = 1000;

	// Token: 0x040005F6 RID: 1526
	public static readonly int[] field_1 = new int[]
	{
		2,
		3,
		5,
		7,
		11,
		13,
		17,
		19,
		23,
		29,
		31,
		37,
		41,
		43,
		47,
		53,
		59,
		61,
		67,
		71,
		73,
		79,
		83,
		89,
		97,
		101,
		103,
		107,
		109,
		113,
		127,
		131,
		137,
		139,
		149,
		151,
		157,
		163,
		167,
		173,
		179,
		181,
		191,
		193,
		197,
		199,
		211,
		223,
		227,
		229,
		233,
		239,
		241,
		251,
		257,
		263,
		269,
		271,
		277,
		281,
		283,
		293,
		307,
		311,
		313,
		317,
		331,
		337,
		347,
		349,
		353,
		359,
		367,
		373,
		379,
		383,
		389,
		397,
		401,
		409,
		419,
		421,
		431,
		433,
		439,
		443,
		449,
		457,
		461,
		463,
		467,
		479,
		487,
		491,
		499,
		503,
		509,
		521,
		523,
		541,
		547,
		557,
		563,
		569,
		571,
		577,
		587,
		593,
		599,
		601,
		607,
		613,
		617,
		619,
		631,
		641,
		643,
		647,
		653,
		659,
		661,
		673,
		677,
		683,
		691,
		701,
		709,
		719,
		727,
		733,
		739,
		743,
		751,
		757,
		761,
		769,
		773,
		787,
		797,
		809,
		811,
		821,
		823,
		827,
		829,
		839,
		853,
		857,
		859,
		863,
		877,
		881,
		883,
		887,
		907,
		911,
		919,
		929,
		937,
		941,
		947,
		953,
		967,
		971,
		977,
		983,
		991,
		997,
		1009,
		1013,
		1019,
		1021,
		1031,
		1033,
		1039,
		1049,
		1051,
		1061,
		1063,
		1069,
		1087,
		1091,
		1093,
		1097,
		1103,
		1109,
		1117,
		1123,
		1129,
		1151,
		1153,
		1163,
		1171,
		1181,
		1187,
		1193,
		1201,
		1213,
		1217,
		1223,
		1229,
		1231,
		1237,
		1249,
		1259,
		1277,
		1279,
		1283,
		1289,
		1291,
		1297,
		1301,
		1303,
		1307,
		1319,
		1321,
		1327,
		1361,
		1367,
		1373,
		1381,
		1399,
		1409,
		1423,
		1427,
		1429,
		1433,
		1439,
		1447,
		1451,
		1453,
		1459,
		1471,
		1481,
		1483,
		1487,
		1489,
		1493,
		1499,
		1511,
		1523,
		1531,
		1543,
		1549,
		1553,
		1559,
		1567,
		1571,
		1579,
		1583,
		1597,
		1601,
		1607,
		1609,
		1613,
		1619,
		1621,
		1627,
		1637,
		1657,
		1663,
		1667,
		1669,
		1693,
		1697,
		1699,
		1709,
		1721,
		1723,
		1733,
		1741,
		1747,
		1753,
		1759,
		1777,
		1783,
		1787,
		1789,
		1801,
		1811,
		1823,
		1831,
		1847,
		1861,
		1867,
		1871,
		1873,
		1877,
		1879,
		1889,
		1901,
		1907,
		1913,
		1931,
		1933,
		1949,
		1951,
		1973,
		1979,
		1987,
		1993,
		1997,
		1999
	};

	// Token: 0x040005F7 RID: 1527
	private uint[] field_2;

	// Token: 0x040005F8 RID: 1528
	public int field_3;
}
