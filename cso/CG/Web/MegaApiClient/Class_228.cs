using System;
using System.Linq;
using System.Text;

namespace CG.Web.MegaApiClient
{
	// Token: 0x0200012F RID: 303
	internal static class Class_228
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x00039A29 File Offset: 0x00037C29
		public static string ToBase64(this byte[] data)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(Convert.ToBase64String(data));
			stringBuilder.Replace('+', '-');
			stringBuilder.Replace('/', '_');
			stringBuilder.Replace("=", string.Empty);
			return stringBuilder.ToString();
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00039A6C File Offset: 0x00037C6C
		public static byte[] FromBase64(this string data)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(data);
			stringBuilder.Append(string.Empty.PadRight((4 - data.Length % 4) % 4, '='));
			stringBuilder.Replace('-', '+');
			stringBuilder.Replace('_', '/');
			stringBuilder.Replace(",", string.Empty);
			return Convert.FromBase64String(stringBuilder.ToString());
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00039AD6 File Offset: 0x00037CD6
		public static string ToUTF8String(this byte[] data)
		{
			return Encoding.UTF8.GetString(data);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000336AF File Offset: 0x000318AF
		public static byte[] ToBytes(this string data)
		{
			return Encoding.UTF8.GetBytes(data);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00039AE4 File Offset: 0x00037CE4
		public static byte[] ToBytesPassword(this string data)
		{
			uint[] array = new uint[data.Length + 3 >> 2];
			for (int i = 0; i < data.Length; i++)
			{
				array[i >> 2] |= (uint)((uint)data[i] << (24 - (i & 3) * 8 & 31));
			}
			return array.SelectMany(delegate(uint x)
			{
				byte[] bytes = BitConverter.GetBytes(x);
				if (BitConverter.IsLittleEndian)
				{
					Array.Reverse(bytes);
				}
				return bytes;
			}).ToArray<byte>();
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00039B64 File Offset: 0x00037D64
		public static T[] CopySubArray<T>(this T[] source, int length, int offset = 0)
		{
			T[] array = new T[length];
			while (--length >= 0)
			{
				if (source.Length > offset + length)
				{
					array[length] = source[offset + length];
				}
			}
			return array;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00039BA4 File Offset: 0x00037DA4
		public static Class_219 FromMPINumber(this byte[] data)
		{
			byte[] array = new byte[((int)data[0] * 256 + (int)data[1] + 7) / 8];
			Array.Copy(data, 2, array, 0, array.Length);
			return new Class_219(array, -1, 0);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00039BDC File Offset: 0x00037DDC
		public static DateTime ToDateTime(this long seconds)
		{
			return Class_228.EpochStart.AddSeconds((double)seconds).ToLocalTime();
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00039C00 File Offset: 0x00037E00
		public static long ToEpoch(this DateTime datetime)
		{
			return (long)datetime.ToUniversalTime().Subtract(Class_228.EpochStart).TotalSeconds;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00039C2C File Offset: 0x00037E2C
		public static long DeserializeToLong(this byte[] data, int index, int length)
		{
			byte b = data[index];
			long num = 0L;
			if (b > 8 || (int)b >= length)
			{
				throw new ArgumentException("Invalid value");
			}
			while (b > 0)
			{
				long num2 = num << 8;
				byte b2 = b;
				b = b2 - 1;
				num = num2 + (long)((ulong)data[index + (int)b2]);
			}
			return num;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00039C70 File Offset: 0x00037E70
		public static byte[] SerializeToBytes(this long data)
		{
			byte[] array = new byte[9];
			byte b = 0;
			while (data != 0L)
			{
				array[(int)(b += 1)] = (byte)data;
				data >>= 8;
			}
			array[0] = b;
			Array.Resize<byte>(ref array, (int)(array[0] + 1));
			return array;
		}

		// Token: 0x0400062E RID: 1582
		private static readonly DateTime EpochStart = new DateTime(1970, 1, 1, 0, 0, 0, 0);
	}
}
