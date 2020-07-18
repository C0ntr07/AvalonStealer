using System;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000028 RID: 40
	public static class Class_28
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x000064C4 File Offset: 0x000046C4
		public static string Decrypt(byte[] encryptedBytes, byte[] key, byte[] iv)
		{
			string text = string.Empty;
			string result;
			try
			{
				Class_33 class_ = new Class_33(new Class_27(), null);
				Class_26 arg_ = new Class_26(new Class_39(key), 128, iv, null);
				class_.pmethod_89(false, arg_);
				byte[] array = new byte[class_.smethod_90(encryptedBytes.Length)];
				int sayıInt_ = class_.xmethod_91(encryptedBytes, 0, encryptedBytes.Length, array, 0);
				class_.tmethod_92(array, sayıInt_);
				text = Encoding.UTF8.GetString(array).TrimEnd("\r\n\0".ToCharArray());
				result = text;
			}
			catch
			{
				result = text;
			}
			return result;
		}
	}
}
