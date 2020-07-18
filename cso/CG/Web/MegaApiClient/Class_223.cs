using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CG.Web.MegaApiClient.Cryptography;
using CG.Web.MegaApiClient.Serialization;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000129 RID: 297
	internal class Class_223
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x00039618 File Offset: 0x00037818
		static Class_223()
		{
			Class_223.field_0 = new AesManaged();
			Class_223.field_1 = true;
			Class_223.field_0.Padding = PaddingMode.None;
			Class_223.field_0.Mode = CipherMode.CBC;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0003964C File Offset: 0x0003784C
		public static byte[] pmethod_1469(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byte[] array = new byte[byteDizi_0.Length];
			for (int i = 0; i < byteDizi_0.Length; i += 16)
			{
				Array.Copy(Class_223.tmethod_1472(byteDizi_0.CopySubArray(16, i), byteDizi_1), 0, array, i, 16);
			}
			return array;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00039690 File Offset: 0x00037890
		public static byte[] smethod_1470(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byte[] array = new byte[byteDizi_0.Length];
			using (ICryptoTransform cryptoTransform = Class_223.gmethod_1473(byteDizi_1))
			{
				for (int i = 0; i < byteDizi_0.Length; i += 16)
				{
					Array.Copy(Class_223.cmethod_1474(byteDizi_0.CopySubArray(16, i), cryptoTransform), 0, array, i, 16);
				}
			}
			return array;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000396FC File Offset: 0x000378FC
		public static void xmethod_1471(byte[] byteDizi_0, out byte[] arg_0, out byte[] arg_1, out byte[] arg_2)
		{
			arg_0 = new byte[8];
			arg_1 = new byte[8];
			Array.Copy(byteDizi_0, 16, arg_0, 0, 8);
			Array.Copy(byteDizi_0, 24, arg_1, 0, 8);
			arg_2 = new byte[16];
			for (int i = 0; i < 16; i++)
			{
				arg_2[i] = (byteDizi_0[i] ^ byteDizi_0[i + 16]);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0003975C File Offset: 0x0003795C
		public static byte[] tmethod_1472(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byte[] result;
			using (ICryptoTransform cryptoTransform = Class_223.field_0.CreateDecryptor(byteDizi_1, Class_223.field_2))
			{
				result = cryptoTransform.TransformFinalBlock(byteDizi_0, 0, byteDizi_0.Length);
			}
			return result;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000397AC File Offset: 0x000379AC
		public static ICryptoTransform gmethod_1473(byte[] byteDizi_0)
		{
			Class_223.NClass_0 nclass_ = new Class_223.NClass_0();
			nclass_.field_6 = byteDizi_0;
			return new Class_281(new Func<ICryptoTransform>(nclass_.nmethod_1), Class_223.field_1);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000397CF File Offset: 0x000379CF
		public static byte[] cmethod_1474(byte[] byteDizi_0, ICryptoTransform arg_0)
		{
			return arg_0.TransformFinalBlock(byteDizi_0, 0, byteDizi_0.Length);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000397DC File Offset: 0x000379DC
		public static byte[] vmethod_1475(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byte[] result;
			using (ICryptoTransform cryptoTransform = Class_223.gmethod_1473(byteDizi_1))
			{
				result = cryptoTransform.TransformFinalBlock(byteDizi_0, 0, byteDizi_0.Length);
			}
			return result;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00039820 File Offset: 0x00037A20
		public static byte[] dmethod_1476()
		{
			byte[] key;
			using (Aes aes = Aes.Create())
			{
				aes.Mode = CipherMode.CBC;
				aes.KeySize = 128;
				aes.Padding = PaddingMode.None;
				aes.GenerateKey();
				key = aes.Key;
			}
			return key;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0003987C File Offset: 0x00037A7C
		public static byte[] kmethod_1477(Class_254 arg_0, byte[] byteDizi_0)
		{
			byte[] array = ("MEGA" + Class_416.SerializeObject(arg_0, Class_322.None)).ToBytes();
			array = array.CopySubArray(array.Length + 16 - array.Length % 16, 0);
			return Class_223.vmethod_1475(array, byteDizi_0);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000398BC File Offset: 0x00037ABC
		public static Class_254 lmethod_1478(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byte[] data = Class_223.tmethod_1472(byteDizi_0, byteDizi_1);
			Class_254 result;
			try
			{
				string text = data.ToUTF8String().Substring(4);
				int num = text.IndexOf('\0');
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				result = Class_416.DeserializeObject<Class_254>(text);
			}
			catch (Exception ex)
			{
				result = new Class_254(string.Format("Attribute deserialization failed: {0}", ex.Message));
			}
			return result;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00039934 File Offset: 0x00037B34
		public static Class_219[] pmethod_1479(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byteDizi_0 = byteDizi_0.CopySubArray(byteDizi_0.Length + (16 - byteDizi_0.Length % 16), 0);
			byte[] array = Class_223.pmethod_1469(byteDizi_0, byteDizi_1);
			Class_219[] array2 = new Class_219[4];
			for (int i = 0; i < 4; i++)
			{
				array2[i] = array.FromMPINumber();
				int num = ((int)array[0] * 256 + (int)array[1] + 7) / 8;
				array = array.CopySubArray(array.Length - num - 2, num + 2);
			}
			return array2;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000399A6 File Offset: 0x00037BA6
		public static byte[] smethod_1480(Class_219 arg_0, Class_219 arg_1, Class_219 arg_2, Class_219 arg_3)
		{
			return arg_0.smethod_1430(arg_3, Class_219.gmethod_1403(arg_1, arg_2)).lmethod_1448();
		}

		// Token: 0x04000610 RID: 1552
		private static readonly Aes field_0;

		// Token: 0x04000611 RID: 1553
		private static readonly bool field_1;

		// Token: 0x04000612 RID: 1554
		private static readonly byte[] field_2 = new byte[16];

		// Token: 0x0200012A RID: 298
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x0600087A RID: 2170 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x000399BB File Offset: 0x00037BBB
			internal ICryptoTransform nmethod_1()
			{
				return Class_223.field_0.CreateEncryptor(this.field_6, Class_223.field_2);
			}

			// Token: 0x04000613 RID: 1555
			public byte[] field_6;
		}
	}
}
