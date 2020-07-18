using System;
using System.IO;
using Ionic.Zlib;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000073 RID: 115
	internal class Class_88
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000114C8 File Offset: 0x0000F6C8
		public static string gmethod_253(string str_0)
		{
			byte[] array = Convert.FromBase64String(str_0);
			string result = string.Empty;
			if (array != null && array.Length != 0)
			{
				using (MemoryStream memoryStream = new MemoryStream(array))
				{
					using (Class_192 class_ = new Class_192(memoryStream, Class_204.Decompress))
					{
						using (StreamReader streamReader = new StreamReader(class_))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			return result;
		}
	}
}
