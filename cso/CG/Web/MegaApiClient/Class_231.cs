using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000133 RID: 307
	public interface Class_231
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000898 RID: 2200
		// (remove) Token: 0x06000899 RID: 2201
		event EventHandler<Class_222> ApiRequestFailed;

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600089A RID: 2202
		bool prop_0 { get; }

		// Token: 0x0600089B RID: 2203
		Class_239.NClass_1 cmethod_1494(string str_0, string str_1);

		// Token: 0x0600089C RID: 2204
		Class_239.NClass_1 vmethod_1495(string str_0, string str_1, string str_2);

		// Token: 0x0600089D RID: 2205
		Class_239.NClass_1 dmethod_1496(Class_239.NClass_0 arg_0);

		// Token: 0x0600089E RID: 2206
		void kmethod_1497(Class_239.NClass_1 arg_0);

		// Token: 0x0600089F RID: 2207
		void lmethod_1498();

		// Token: 0x060008A0 RID: 2208
		void pmethod_1499();

		// Token: 0x060008A1 RID: 2209
		void smethod_1500();

		// Token: 0x060008A2 RID: 2210
		string xmethod_1501();

		// Token: 0x060008A3 RID: 2211
		Class_229 tmethod_1502();

		// Token: 0x060008A4 RID: 2212
		IEnumerable<Class_236> gmethod_1503();

		// Token: 0x060008A5 RID: 2213
		IEnumerable<Class_233> cmethod_1504();

		// Token: 0x060008A6 RID: 2214
		IEnumerable<Class_233> vmethod_1505(Class_233 arg_0);

		// Token: 0x060008A7 RID: 2215
		void dmethod_1506(Class_233 arg_0, bool bool_0 = true);

		// Token: 0x060008A8 RID: 2216
		Class_233 kmethod_1507(string str_0, Class_233 arg_0);

		// Token: 0x060008A9 RID: 2217
		Uri lmethod_1508(Class_233 arg_0);

		// Token: 0x060008AA RID: 2218
		void pmethod_1509(Class_233 arg_0, string str_0, CancellationToken? arg_1 = null);

		// Token: 0x060008AB RID: 2219
		void smethod_1510(Uri arg_0, string str_0, CancellationToken? arg_1 = null);

		// Token: 0x060008AC RID: 2220
		Stream xmethod_1511(Class_233 arg_0, CancellationToken? arg_1 = null);

		// Token: 0x060008AD RID: 2221
		Stream tmethod_1512(Uri arg_0, CancellationToken? arg_1 = null);

		// Token: 0x060008AE RID: 2222
		Class_232 gmethod_1513(Uri arg_0);

		// Token: 0x060008AF RID: 2223
		IEnumerable<Class_233> cmethod_1514(Uri arg_0);

		// Token: 0x060008B0 RID: 2224
		Class_233 vmethod_1515(string str_0, Class_233 arg_0, CancellationToken? arg_1 = null);

		// Token: 0x060008B1 RID: 2225
		Class_233 dmethod_1516(Stream stream_, string str_0, Class_233 arg_0, DateTime? arg_1 = null, CancellationToken? arg_2 = null);

		// Token: 0x060008B2 RID: 2226
		Class_233 kmethod_1517(Class_233 arg_0, Class_233 arg_1);

		// Token: 0x060008B3 RID: 2227
		Class_233 lmethod_1518(Class_233 arg_0, string str_0);

		// Token: 0x060008B4 RID: 2228
		Class_239.NClass_0 pmethod_1519(string str_0, string str_1, string str_2 = null);
	}
}
