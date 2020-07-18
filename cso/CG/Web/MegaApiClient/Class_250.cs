using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000155 RID: 341
	public class Class_250 : Class_238
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x0003C92D File Offset: 0x0003AB2D
		public Class_250(int sayıInt_0 = -1, string str_0 = null)
		{
			this.prop_0 = 65536;
			this.field_1 = sayıInt_0;
			this.field_2 = (str_0 ?? this.tmethod_1712());
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0003C95B File Offset: 0x0003AB5B
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x0003C963 File Offset: 0x0003AB63
		public int prop_0 { get; set; }

		// Token: 0x060009B8 RID: 2488 RVA: 0x0003C96C File Offset: 0x0003AB6C
		public string kmethod_1707(Uri arg_0, string str_0)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream(str_0.ToBytes()))
			{
				result = this.smethod_1710(arg_0, memoryStream, "application/json");
			}
			return result;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0003C9B8 File Offset: 0x0003ABB8
		public string lmethod_1708(Uri arg_0, Stream stream_)
		{
			return this.smethod_1710(arg_0, stream_, "application/octet-stream");
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0003C9C7 File Offset: 0x0003ABC7
		public Stream pmethod_1709(Uri arg_0)
		{
			HttpWebRequest httpWebRequest = this.xmethod_1711(arg_0);
			httpWebRequest.Method = "GET";
			return httpWebRequest.GetResponse().GetResponseStream();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0003C9E8 File Offset: 0x0003ABE8
		private string smethod_1710(Uri arg_0, Stream stream_, string str_0)
		{
			HttpWebRequest httpWebRequest = this.xmethod_1711(arg_0);
			httpWebRequest.ContentLength = stream_.Length;
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = str_0;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				stream_.Position = 0L;
				stream_.CopyTo(requestStream, this.prop_0);
			}
			string result;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (Stream responseStream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
					}
				}
			}
			return result;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		private HttpWebRequest xmethod_1711(Uri arg_0)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(arg_0);
			httpWebRequest.Timeout = this.field_1;
			httpWebRequest.UserAgent = this.field_2;
			return httpWebRequest;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0003CB00 File Offset: 0x0003AD00
		private string tmethod_1712()
		{
			AssemblyName name = Assembly.GetExecutingAssembly().GetName();
			return string.Format("{0} v{1}", name.Name, name.Version.ToString(2));
		}

		// Token: 0x040006A3 RID: 1699
		private const int field_0 = -1;

		// Token: 0x040006A4 RID: 1700
		private readonly int field_1;

		// Token: 0x040006A5 RID: 1701
		private readonly string field_2;

		// Token: 0x040006A6 RID: 1702
		[CompilerGenerated]
		private int field_3;
	}
}
