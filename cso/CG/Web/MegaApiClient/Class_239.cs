using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using CG.Web.MegaApiClient.Serialization;
using Medo.Security.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CG.Web.MegaApiClient
{
	// Token: 0x0200013B RID: 315
	public class Class_239 : Class_231
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00039CF9 File Offset: 0x00037EF9
		public Class_239() : this(new Class_244("axhQiYyQ", true, null, 65536, 1048576), new Class_250(-1, null))
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00039D1E File Offset: 0x00037F1E
		public Class_239(Class_244 arg_0) : this(arg_0, new Class_250(-1, null))
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00039D2E File Offset: 0x00037F2E
		public Class_239(Class_238 arg_0) : this(new Class_244("axhQiYyQ", true, null, 65536, 1048576), arg_0)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00039D50 File Offset: 0x00037F50
		public Class_239(Class_244 arg_0, Class_238 arg_1)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("options");
			}
			if (arg_1 == null)
			{
				throw new ArgumentNullException("webClient");
			}
			this.field_2 = arg_0;
			this.field_3 = arg_1;
			this.field_3.prop_0 = arg_0.prop_3;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00039DCC File Offset: 0x00037FCC
		public Class_239.NClass_0 dmethod_1546(string str_0, string str_1, string str_2 = null)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("email");
			}
			if (string.IsNullOrEmpty(str_1))
			{
				throw new ArgumentNullException("password");
			}
			Class_269 arg_ = new Class_269(str_0);
			Class_270 class_ = this.lmethod_1578<Class_270>(arg_, null);
			if (class_.prop_1 == 2 && !string.IsNullOrEmpty(class_.prop_0))
			{
				byte[] byteDizi_ = class_.prop_0.FromBase64();
				byte[] byteDizi_2 = str_1.ToBytesPassword();
				byte[] array = new byte[32];
				using (HMACSHA512 hmacsha = new HMACSHA512())
				{
					array = new Class_220(hmacsha, byteDizi_2, byteDizi_, 100000).smethod_1460(array.Length);
				}
				if (!string.IsNullOrEmpty(str_2))
				{
					return new Class_239.NClass_0(str_0, array.Skip(16).ToArray<byte>().ToBase64(), array.Take(16).ToArray<byte>(), str_2);
				}
				return new Class_239.NClass_0(str_0, array.Skip(16).ToArray<byte>().ToBase64(), array.Take(16).ToArray<byte>(), null);
			}
			else
			{
				if (class_.prop_1 != 1)
				{
					throw new NotSupportedException("Version of account not supported");
				}
				byte[] byteDizi_3 = Class_239.dmethod_1576(str_1.ToBytesPassword());
				string str_3 = Class_239.vmethod_1575(str_0.ToLowerInvariant(), byteDizi_3);
				if (!string.IsNullOrEmpty(str_2))
				{
					return new Class_239.NClass_0(str_0, str_3, byteDizi_3, str_2);
				}
				return new Class_239.NClass_0(str_0, str_3, byteDizi_3, null);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060008D4 RID: 2260 RVA: 0x00039F44 File Offset: 0x00038144
		// (remove) Token: 0x060008D5 RID: 2261 RVA: 0x00039F7C File Offset: 0x0003817C
		public event EventHandler<Class_222> ApiRequestFailed
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Class_222> eventHandler = this.field_10;
				EventHandler<Class_222> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_222> value2 = (EventHandler<Class_222>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_222>>(ref this.field_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Class_222> eventHandler = this.field_10;
				EventHandler<Class_222> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_222> value2 = (EventHandler<Class_222>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_222>>(ref this.field_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00039FB1 File Offset: 0x000381B1
		public bool prop_0
		{
			get
			{
				return this.field_6 != null;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00039FBC File Offset: 0x000381BC
		public Class_239.NClass_1 smethod_1550(string str_0, string str_1)
		{
			return this.tmethod_1552(this.dmethod_1546(str_0, str_1, null));
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00039FCD File Offset: 0x000381CD
		public Class_239.NClass_1 xmethod_1551(string str_0, string str_1, string str_2)
		{
			return this.tmethod_1552(this.dmethod_1546(str_0, str_1, str_2));
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00039FE0 File Offset: 0x000381E0
		public Class_239.NClass_1 tmethod_1552(Class_239.NClass_0 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("authInfos");
			}
			this.cmethod_1584();
			this.field_9 = true;
			Class_264 arg_;
			if (!string.IsNullOrEmpty(arg_0.nprop_3))
			{
				arg_ = new Class_264(arg_0.nprop_0, arg_0.nprop_1, arg_0.nprop_3);
			}
			else
			{
				arg_ = new Class_264(arg_0.nprop_0, arg_0.nprop_1);
			}
			Class_265 class_ = this.lmethod_1578<Class_265>(arg_, null);
			byte[] byteDizi_ = class_.prop_3.FromBase64();
			this.field_7 = Class_223.pmethod_1469(byteDizi_, arg_0.nprop_2);
			Class_219[] array = Class_223.pmethod_1479(class_.prop_2.FromBase64(), this.field_7);
			byte[] source = Class_223.smethod_1480(class_.prop_0.FromBase64().FromMPINumber(), array[0], array[1], array[2]);
			this.field_6 = source.Take(43).ToArray<byte>().ToBase64();
			return new Class_239.NClass_1(this.field_6, this.field_7);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0003A0DA File Offset: 0x000382DA
		public void gmethod_1553(Class_239.NClass_1 arg_0)
		{
			this.cmethod_1584();
			this.field_9 = true;
			this.field_6 = arg_0.nprop_0;
			this.field_7 = arg_0.nprop_1;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0003A101 File Offset: 0x00038301
		public void cmethod_1554()
		{
			this.vmethod_1555();
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0003A10C File Offset: 0x0003830C
		public void vmethod_1555()
		{
			this.cmethod_1584();
			this.field_9 = false;
			Random random = new Random();
			this.field_7 = new byte[16];
			random.NextBytes(this.field_7);
			byte[] array = new byte[16];
			random.NextBytes(array);
			byte[] array2 = new byte[16];
			random.NextBytes(array2);
			byte[] data = Class_223.vmethod_1475(this.field_7, array);
			byte[] array3 = Class_223.vmethod_1475(array2, this.field_7);
			byte[] array4 = new byte[32];
			Array.Copy(array2, 0, array4, 0, 16);
			Array.Copy(array3, 0, array4, 16, array3.Length);
			Class_253 arg_ = new Class_253(data.ToBase64(), array4.ToBase64());
			Class_264 arg_2 = new Class_264(this.kmethod_1577(arg_), null);
			Class_265 class_ = this.lmethod_1578<Class_265>(arg_2, null);
			this.field_6 = class_.prop_1;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0003A1D4 File Offset: 0x000383D4
		public void dmethod_1556()
		{
			this.gmethod_1583();
			if (this.field_9)
			{
				this.kmethod_1577(new Class_266());
			}
			this.field_7 = null;
			this.field_6 = null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0003A201 File Offset: 0x00038401
		public string kmethod_1557()
		{
			this.gmethod_1583();
			if (!this.field_9)
			{
				throw new NotSupportedException("Anonymous login is not supported");
			}
			return this.field_7.ToBase64();
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0003A22C File Offset: 0x0003842C
		public Class_229 lmethod_1558()
		{
			this.gmethod_1583();
			Class_251 arg_ = new Class_251();
			return this.lmethod_1578<Class_252>(arg_, null);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0003A250 File Offset: 0x00038450
		public IEnumerable<Class_236> pmethod_1559()
		{
			this.gmethod_1583();
			Class_273 arg_ = new Class_273();
			return this.lmethod_1578<Class_274>(arg_, null);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0003A274 File Offset: 0x00038474
		public IEnumerable<Class_233> smethod_1560()
		{
			this.gmethod_1583();
			Class_261 arg_ = new Class_261(null);
			Class_241[] source = this.lmethod_1578<Class_262>(arg_, this.field_7).prop_0;
			if (this.field_5 == null)
			{
				this.field_5 = source.First(new Func<Class_241, bool>(Class_239.NClass_2.field_6.nmethod_16));
			}
			return source.Distinct<Class_241>().OfType<Class_233>();
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0003A2E8 File Offset: 0x000384E8
		public IEnumerable<Class_233> xmethod_1561(Class_233 arg_0)
		{
			Class_239.NClass_3 nclass_ = new Class_239.NClass_3();
			nclass_.field_8 = arg_0;
			if (nclass_.field_8 == null)
			{
				throw new ArgumentNullException("parent");
			}
			return this.smethod_1560().Where(new Func<Class_233, bool>(nclass_.nmethod_18));
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0003A330 File Offset: 0x00038530
		public void tmethod_1562(Class_233 arg_0, bool bool_0 = true)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("node");
			}
			if (arg_0.prop_1 != Class_235.Directory && arg_0.prop_1 != Class_235.File)
			{
				throw new ArgumentException("Invalid node type");
			}
			this.gmethod_1583();
			if (bool_0)
			{
				this.gmethod_1573(arg_0, this.field_5);
				return;
			}
			this.kmethod_1577(new Class_256(arg_0));
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0003A398 File Offset: 0x00038598
		public Class_233 gmethod_1563(string str_0, Class_233 arg_0)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("name");
			}
			if (arg_0 == null)
			{
				throw new ArgumentNullException("parent");
			}
			if (arg_0.prop_1 == Class_235.File)
			{
				throw new ArgumentException("Invalid parent node");
			}
			this.gmethod_1583();
			byte[] byteDizi_ = Class_223.dmethod_1476();
			byte[] data = Class_223.kmethod_1477(new Class_254(str_0), byteDizi_);
			byte[] data2 = Class_223.vmethod_1475(byteDizi_, this.field_7);
			Class_255 arg_ = Class_255.cmethod_1744(arg_0, data.ToBase64(), data2.ToBase64(), byteDizi_);
			return this.lmethod_1578<Class_262>(arg_, this.field_7).prop_0[0];
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0003A434 File Offset: 0x00038634
		public Uri cmethod_1564(Class_233 arg_0)
		{
			Class_239.NClass_4 nclass_ = new Class_239.NClass_4();
			nclass_.field_9 = arg_0;
			if (nclass_.field_9 == null)
			{
				throw new ArgumentNullException("node");
			}
			if (nclass_.field_9.prop_1 != Class_235.File && nclass_.field_9.prop_1 != Class_235.Directory)
			{
				throw new ArgumentException("Invalid node");
			}
			this.gmethod_1583();
			if (nclass_.field_9.prop_1 == Class_235.Directory)
			{
				this.kmethod_1577(new Class_278(nclass_.field_9, this.field_7, this.smethod_1560()));
				nclass_.field_9 = this.smethod_1560().First(new Func<Class_233, bool>(nclass_.nmethod_20));
			}
			Class_234 class_ = nclass_.field_9 as Class_234;
			if (class_ == null)
			{
				throw new ArgumentException("node must implement INodeCrypto");
			}
			Class_260 arg_ = new Class_260(nclass_.field_9);
			string arg = this.lmethod_1578<string>(arg_, null);
			return new Uri(Class_239.field_1, string.Format("/{0}/{1}#{2}", (nclass_.field_9.prop_1 == Class_235.Directory) ? "folder" : "file", arg, (nclass_.field_9.prop_1 == Class_235.Directory) ? class_.prop_1.ToBase64() : class_.prop_4.ToBase64()));
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0003A578 File Offset: 0x00038778
		public void vmethod_1565(Class_233 arg_0, string str_0, CancellationToken? arg_1 = null)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("node");
			}
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("outputFile");
			}
			using (Stream stream = this.kmethod_1567(arg_0, arg_1))
			{
				this.tmethod_1582(stream, str_0);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0003A5E0 File Offset: 0x000387E0
		public void dmethod_1566(Uri arg_0, string str_0, CancellationToken? arg_1 = null)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("outputFile");
			}
			using (Stream stream = this.lmethod_1568(arg_0, arg_1))
			{
				this.tmethod_1582(stream, str_0);
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0003A650 File Offset: 0x00038850
		public Stream kmethod_1567(Class_233 arg_0, CancellationToken? arg_1 = null)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("node");
			}
			if (arg_0.prop_1 != Class_235.File)
			{
				throw new ArgumentException("Invalid node");
			}
			Class_234 class_ = arg_0 as Class_234;
			if (class_ == null)
			{
				throw new ArgumentException("node must implement INodeCrypto");
			}
			this.gmethod_1583();
			Class_257 arg_2 = new Class_257(arg_0);
			Class_259 class_2 = this.lmethod_1578<Class_259>(arg_2, null);
			Stream stream = new Class_248(new Class_245(this.field_3.vmethod_1545(new Uri(class_2.prop_0))), class_2.prop_1, class_.prop_0, class_.prop_2, class_.prop_3);
			if (arg_1 != null)
			{
				stream = new Class_246(stream, arg_1.Value);
			}
			return stream;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0003A708 File Offset: 0x00038908
		public Stream lmethod_1568(Uri arg_0, CancellationToken? arg_1 = null)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("uri");
			}
			this.gmethod_1583();
			string str_;
			byte[] byteDizi_;
			byte[] byteDizi_2;
			byte[] byteDizi_3;
			this.vmethod_1585(arg_0, out str_, out byteDizi_, out byteDizi_2, out byteDizi_3);
			Class_258 arg_2 = new Class_258(str_);
			Class_259 class_ = this.lmethod_1578<Class_259>(arg_2, null);
			Stream stream = new Class_248(new Class_245(this.field_3.vmethod_1545(new Uri(class_.prop_0))), class_.prop_1, byteDizi_3, byteDizi_, byteDizi_2);
			if (arg_1 != null)
			{
				stream = new Class_246(stream, arg_1.Value);
			}
			return stream;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0003A7A0 File Offset: 0x000389A0
		public Class_232 pmethod_1569(Uri arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("uri");
			}
			this.gmethod_1583();
			string str_;
			byte[] array;
			byte[] array2;
			byte[] byteDizi_;
			this.vmethod_1585(arg_0, out str_, out array, out array2, out byteDizi_);
			Class_258 arg_ = new Class_258(str_);
			Class_259 arg_2 = this.lmethod_1578<Class_259>(arg_, null);
			return new Class_240(str_, arg_2, byteDizi_);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0003A7F8 File Offset: 0x000389F8
		public IEnumerable<Class_233> smethod_1570(Uri arg_0)
		{
			Class_239.NClass_5 nclass_ = new Class_239.NClass_5();
			if (arg_0 == null)
			{
				throw new ArgumentNullException("uri");
			}
			this.gmethod_1583();
			byte[] array;
			byte[] array2;
			byte[] byteDizi_;
			this.vmethod_1585(arg_0, out nclass_.field_10, out array, out array2, out byteDizi_);
			Class_261 arg_ = new Class_261(nclass_.field_10);
			return this.lmethod_1578<Class_262>(arg_, byteDizi_).prop_0.Select(new Func<Class_241, Class_242>(nclass_.nmethod_22)).OfType<Class_233>();
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0003A86C File Offset: 0x00038A6C
		public Class_233 xmethod_1571(string str_0, Class_233 arg_0, CancellationToken? arg_1 = null)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("filename");
			}
			if (arg_0 == null)
			{
				throw new ArgumentNullException("parent");
			}
			if (!File.Exists(str_0))
			{
				throw new FileNotFoundException(str_0);
			}
			this.gmethod_1583();
			DateTime lastWriteTime = File.GetLastWriteTime(str_0);
			Class_233 result;
			using (FileStream fileStream = new FileStream(str_0, FileMode.Open, FileAccess.Read))
			{
				result = this.tmethod_1572(fileStream, Path.GetFileName(str_0), arg_0, new DateTime?(lastWriteTime), arg_1);
			}
			return result;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0003A904 File Offset: 0x00038B04
		public Class_233 tmethod_1572(Stream stream_, string str_0, Class_233 arg_0, DateTime? arg_1 = null, CancellationToken? arg_2 = null)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("name");
			}
			if (arg_0 == null)
			{
				throw new ArgumentNullException("parent");
			}
			if (arg_0.prop_1 == Class_235.File)
			{
				throw new ArgumentException("Invalid parent node");
			}
			this.gmethod_1583();
			if (arg_2 != null)
			{
				stream_ = new Class_246(stream_, arg_2.Value);
			}
			string text = string.Empty;
			int num = 0;
			TimeSpan timeSpan;
			while (this.field_2.prop_2.nmethod_1(++num, out timeSpan))
			{
				Class_279 arg_3 = new Class_279(stream_.Length);
				Class_280 class_ = this.lmethod_1578<Class_280>(arg_3, null);
				Class_227 class_2 = Class_227.Ok;
				using (Class_247 class_3 = new Class_247(stream_))
				{
					long num2 = 0L;
					int[] array = this.lmethod_1588(class_3.prop_0, class_3.Length).ToArray<int>();
					Uri arg_4 = null;
					for (int i = 0; i < array.Length; i++)
					{
						text = string.Empty;
						int num3 = array[i];
						byte[] buffer = new byte[num3];
						class_3.Read(buffer, 0, num3);
						using (MemoryStream memoryStream = new MemoryStream(buffer))
						{
							arg_4 = new Uri(class_.prop_0 + "/" + num2);
							num2 += (long)num3;
							try
							{
								text = this.field_3.cmethod_1544(arg_4, memoryStream);
								long num4;
								if (string.IsNullOrEmpty(text))
								{
									class_2 = Class_227.Ok;
								}
								else if (text.FromBase64().Length != 27 && long.TryParse(text, out num4))
								{
									class_2 = (Class_227)num4;
									break;
								}
							}
							catch (Exception arg_5)
							{
								class_2 = Class_227.RequestFailedRetry;
								EventHandler<Class_222> eventHandler = this.field_10;
								if (eventHandler != null)
								{
									eventHandler(this, new Class_222(arg_4, num, timeSpan, class_2, arg_5));
								}
								break;
							}
						}
					}
					if (class_2 == Class_227.Ok)
					{
						byte[] data = Class_223.kmethod_1477(new Class_254(str_0, stream_, arg_1), class_3.prop_0);
						byte[] array2 = new byte[32];
						for (int j = 0; j < 8; j++)
						{
							array2[j] = (class_3.prop_0[j] ^ class_3.prop_1[j]);
							array2[j + 16] = class_3.prop_1[j];
						}
						for (int k = 8; k < 16; k++)
						{
							array2[k] = (class_3.prop_0[k] ^ class_3.prop_2[k - 8]);
							array2[k + 16] = class_3.prop_2[k - 8];
						}
						byte[] data2 = Class_223.smethod_1470(array2, this.field_7);
						Class_255 arg_6 = Class_255.gmethod_1743(arg_0, data.ToBase64(), data2.ToBase64(), array2, text);
						return this.lmethod_1578<Class_262>(arg_6, this.field_7).prop_0[0];
					}
					EventHandler<Class_222> eventHandler2 = this.field_10;
					if (eventHandler2 != null)
					{
						eventHandler2(this, new Class_222(arg_4, num, timeSpan, class_2, text));
					}
					if (class_2 == Class_227.RequestFailedRetry || class_2 == Class_227.RequestFailedPermanetly || class_2 == Class_227.TooManyRequests)
					{
						this.smethod_1580(timeSpan);
						stream_.Seek(0L, SeekOrigin.Begin);
						continue;
					}
					throw new Class_224(class_2);
				}
				break;
			}
			throw new Class_226(text);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0003AC98 File Offset: 0x00038E98
		public Class_233 gmethod_1573(Class_233 arg_0, Class_233 arg_1)
		{
			Class_239.NClass_6 nclass_ = new Class_239.NClass_6();
			nclass_.field_11 = arg_0;
			if (nclass_.field_11 == null)
			{
				throw new ArgumentNullException("node");
			}
			if (arg_1 == null)
			{
				throw new ArgumentNullException("destinationParentNode");
			}
			if (nclass_.field_11.prop_1 != Class_235.Directory && nclass_.field_11.prop_1 != Class_235.File)
			{
				throw new ArgumentException("Invalid node type");
			}
			if (arg_1.prop_1 == Class_235.File)
			{
				throw new ArgumentException("Invalid destination parent node");
			}
			this.gmethod_1583();
			this.kmethod_1577(new Class_267(nclass_.field_11, arg_1));
			return this.smethod_1560().First(new Func<Class_233, bool>(nclass_.nmethod_24));
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0003AD4C File Offset: 0x00038F4C
		public Class_233 cmethod_1574(Class_233 arg_0, string str_0)
		{
			Class_239.NClass_7 nclass_ = new Class_239.NClass_7();
			nclass_.field_12 = arg_0;
			if (nclass_.field_12 == null)
			{
				throw new ArgumentNullException("node");
			}
			if (nclass_.field_12.prop_1 != Class_235.Directory && nclass_.field_12.prop_1 != Class_235.File)
			{
				throw new ArgumentException("Invalid node type");
			}
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("newName");
			}
			Class_234 class_ = nclass_.field_12 as Class_234;
			if (class_ == null)
			{
				throw new ArgumentException("node must implement INodeCrypto");
			}
			this.gmethod_1583();
			byte[] data = Class_223.kmethod_1477(new Class_254(str_0, ((Class_241)nclass_.field_12).prop_6), class_.prop_0);
			this.kmethod_1577(new Class_271(nclass_.field_12, data.ToBase64()));
			return this.smethod_1560().First(new Func<Class_233, bool>(nclass_.nmethod_26));
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0003AE34 File Offset: 0x00039034
		private static string vmethod_1575(string str_0, byte[] byteDizi_0)
		{
			byte[] array = str_0.ToBytes();
			byte[] array2 = new byte[16];
			for (int i = 0; i < array.Length; i++)
			{
				byte[] array3 = array2;
				int num = i % 16;
				array3[num] ^= array[i];
			}
			using (ICryptoTransform cryptoTransform = Class_223.gmethod_1473(byteDizi_0))
			{
				for (int j = 0; j < 16384; j++)
				{
					array2 = Class_223.cmethod_1474(array2, cryptoTransform);
				}
			}
			byte[] array4 = new byte[8];
			Array.Copy(array2, 0, array4, 0, 4);
			Array.Copy(array2, 8, array4, 4, 4);
			return array4.ToBase64();
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0003AEE0 File Offset: 0x000390E0
		private static byte[] dmethod_1576(byte[] byteDizi_0)
		{
			byte[] array = new byte[]
			{
				147,
				196,
				103,
				227,
				125,
				176,
				199,
				164,
				209,
				190,
				63,
				129,
				1,
				82,
				203,
				86
			};
			for (int i = 0; i < 65536; i++)
			{
				for (int j = 0; j < byteDizi_0.Length; j += 16)
				{
					byte[] byteDizi_ = byteDizi_0.CopySubArray(16, j);
					array = Class_223.vmethod_1475(array, byteDizi_);
				}
			}
			return array;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0003AF38 File Offset: 0x00039138
		private string kmethod_1577(Class_272 arg_0)
		{
			return this.lmethod_1578<string>(arg_0, null);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0003AF44 File Offset: 0x00039144
		private TResponse lmethod_1578<TResponse>(Class_272 arg_0, byte[] byteDizi_0 = null) where TResponse : class
		{
			if (this.field_2.prop_1)
			{
				object obj = this.field_4;
				lock (obj)
				{
					return this.pmethod_1579<TResponse>(arg_0, byteDizi_0);
				}
			}
			return this.pmethod_1579<TResponse>(arg_0, byteDizi_0);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0003AFA8 File Offset: 0x000391A8
		private TResponse pmethod_1579<TResponse>(Class_272 arg_0, byte[] byteDizi_0) where TResponse : class
		{
			string str_ = Class_416.SerializeObject(new object[]
			{
				arg_0
			});
			Uri arg_ = this.xmethod_1581(arg_0.prop_1);
			object obj = null;
			int num = 0;
			TimeSpan timeSpan;
			while (this.field_2.prop_2.nmethod_1(++num, out timeSpan))
			{
				string text = this.field_3.gmethod_1543(arg_, str_);
				if (!string.IsNullOrEmpty(text) && (obj = Class_416.DeserializeObject(text)) != null && !(obj is long) && (!(obj is Class_424) || ((Class_424)obj).lmethod_3358(0).prop_3 != Class_428.Integer))
				{
					break;
				}
				Class_227 class_ = (obj == null) ? Class_227.RequestFailedRetry : ((obj is long) ? ((Class_227)Enum.ToObject(typeof(Class_227), obj)) : ((Class_227)((Class_424)obj).lmethod_3358(0).Value<int>()));
				if (class_ != Class_227.Ok)
				{
					EventHandler<Class_222> eventHandler = this.field_10;
					if (eventHandler != null)
					{
						eventHandler(this, new Class_222(arg_, num, timeSpan, class_, text));
					}
				}
				if (class_ == Class_227.RequestFailedRetry)
				{
					this.smethod_1580(timeSpan);
				}
				else
				{
					if (class_ != Class_227.Ok)
					{
						throw new Class_224(class_);
					}
					break;
				}
			}
			string text2 = ((Class_424)obj).lmethod_3358(0).ToString();
			if (!(typeof(TResponse) == typeof(string)))
			{
				return Class_416.DeserializeObject<TResponse>(text2, new Class_299[]
				{
					new Class_263(byteDizi_0)
				});
			}
			return text2 as TResponse;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0003B132 File Offset: 0x00039332
		private void smethod_1580(TimeSpan arg_0)
		{
			Thread.Sleep(arg_0);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0003B13C File Offset: 0x0003933C
		private Uri xmethod_1581(Dictionary<string, string> arg_0)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>(arg_0);
			Dictionary<string, string> dictionary2 = dictionary;
			string key = "id";
			uint num = this.field_8;
			this.field_8 = num + 1U;
			dictionary2[key] = (num % uint.MaxValue).ToString(CultureInfo.InvariantCulture);
			dictionary["ak"] = this.field_2.prop_0;
			if (!string.IsNullOrEmpty(this.field_6))
			{
				dictionary["sid"] = this.field_6;
			}
			UriBuilder uriBuilder = new UriBuilder(Class_239.field_0);
			string text = "";
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				text = string.Concat(new string[]
				{
					text,
					keyValuePair.Key,
					"=",
					keyValuePair.Value,
					"&"
				});
			}
			text = text.Substring(0, text.Length - 1);
			uriBuilder.Query = text.ToString();
			return uriBuilder.Uri;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0003B25C File Offset: 0x0003945C
		private void tmethod_1582(Stream stream_, string str_0)
		{
			using (FileStream fileStream = new FileStream(str_0, FileMode.CreateNew, FileAccess.Write))
			{
				stream_.CopyTo(fileStream, this.field_2.prop_3);
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0003B2A8 File Offset: 0x000394A8
		private void gmethod_1583()
		{
			if (this.field_6 == null)
			{
				throw new NotSupportedException("Not logged in");
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0003B2C0 File Offset: 0x000394C0
		private void cmethod_1584()
		{
			if (this.field_6 != null)
			{
				throw new NotSupportedException("Already logged in");
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0003B2D8 File Offset: 0x000394D8
		private void vmethod_1585(Uri arg_0, out string arg_1, out byte[] arg_2, out byte[] arg_3, out byte[] arg_4)
		{
			byte[] array;
			bool flag;
			if (!this.dmethod_1586(arg_0, out arg_1, out array, out flag) && !this.kmethod_1587(arg_0, out arg_1, out array, out flag))
			{
				throw new ArgumentException(string.Format("Invalid uri. Unable to extract Id and Key from the uri {0}", arg_0));
			}
			if (flag)
			{
				arg_2 = null;
				arg_3 = null;
				arg_4 = array;
				return;
			}
			Class_223.xmethod_1471(array, out arg_2, out arg_3, out arg_4);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0003B338 File Offset: 0x00039538
		private bool dmethod_1586(Uri arg_0, out string arg_1, out byte[] arg_2, out bool arg_3)
		{
			Match match = new Regex("/(?<type>(file|folder))/(?<id>[^#]+)#(?<key>[^$/]+)").Match(arg_0.PathAndQuery + arg_0.Fragment);
			if (match.Success)
			{
				arg_1 = match.Groups["id"].Value;
				arg_2 = match.Groups["key"].Value.FromBase64();
				arg_3 = (match.Groups["type"].Value == "folder");
				return true;
			}
			arg_1 = null;
			arg_2 = null;
			arg_3 = false;
			return false;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0003B3D4 File Offset: 0x000395D4
		private bool kmethod_1587(Uri arg_0, out string arg_1, out byte[] arg_2, out bool arg_3)
		{
			Match match = new Regex("#(?<type>F?)!(?<id>[^!]+)!(?<key>[^$!\\?]+)").Match(arg_0.Fragment);
			if (match.Success)
			{
				arg_1 = match.Groups["id"].Value;
				arg_2 = match.Groups["key"].Value.FromBase64();
				arg_3 = (match.Groups["type"].Value == "F");
				return true;
			}
			arg_1 = null;
			arg_2 = null;
			arg_3 = false;
			return false;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0003B464 File Offset: 0x00039664
		private IEnumerable<int> lmethod_1588(long[] uıntSayıDizi_0, long sayıUınt_0)
		{
			int num3;
			for (int i = 0; i < uıntSayıDizi_0.Length; i = num3 + 1)
			{
				long num = uıntSayıDizi_0[i];
				long num2 = (i == uıntSayıDizi_0.Length - 1) ? sayıUınt_0 : uıntSayıDizi_0[i + 1];
				while (((int)(num2 - num) < this.field_2.prop_4 || this.field_2.prop_4 == -1) && i < uıntSayıDizi_0.Length - 1)
				{
					num3 = i;
					i = num3 + 1;
					num2 = ((i == uıntSayıDizi_0.Length - 1) ? sayıUınt_0 : uıntSayıDizi_0[i + 1]);
				}
				yield return (int)(num2 - num);
				num3 = i;
			}
			yield break;
		}

		// Token: 0x0400063C RID: 1596
		private static readonly Uri field_0 = new Uri("https://g.api.mega.co.nz/cs");

		// Token: 0x0400063D RID: 1597
		private static readonly Uri field_1 = new Uri("https://mega.nz");

		// Token: 0x0400063E RID: 1598
		private readonly Class_244 field_2;

		// Token: 0x0400063F RID: 1599
		private readonly Class_238 field_3;

		// Token: 0x04000640 RID: 1600
		private readonly object field_4 = new object();

		// Token: 0x04000641 RID: 1601
		private Class_241 field_5;

		// Token: 0x04000642 RID: 1602
		private string field_6;

		// Token: 0x04000643 RID: 1603
		private byte[] field_7;

		// Token: 0x04000644 RID: 1604
		private uint field_8 = (uint)(4294967295.0 * new Random().NextDouble());

		// Token: 0x04000645 RID: 1605
		private bool field_9;

		// Token: 0x04000646 RID: 1606
		[CompilerGenerated]
		private EventHandler<Class_222> field_10;

		// Token: 0x0200013C RID: 316
		public class NClass_0
		{
			// Token: 0x060008FF RID: 2303 RVA: 0x0003B4A2 File Offset: 0x000396A2
			public void nmethod_0(string str_0, string str_1, byte[] byteDizi_0, string str_2 = null)
			{
				base..ctor();
				this.nprop_0 = str_0;
				this.nprop_1 = str_1;
				this.nprop_2 = byteDizi_0;
				this.nprop_3 = str_2;
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x06000900 RID: 2304 RVA: 0x0003B4C7 File Offset: 0x000396C7
			// (set) Token: 0x06000901 RID: 2305 RVA: 0x0003B4CF File Offset: 0x000396CF
			[Class_410]
			public string nprop_0 { get; private set; }

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x06000902 RID: 2306 RVA: 0x0003B4D8 File Offset: 0x000396D8
			// (set) Token: 0x06000903 RID: 2307 RVA: 0x0003B4E0 File Offset: 0x000396E0
			[Class_410]
			public string nprop_1 { get; private set; }

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x06000904 RID: 2308 RVA: 0x0003B4E9 File Offset: 0x000396E9
			// (set) Token: 0x06000905 RID: 2309 RVA: 0x0003B4F1 File Offset: 0x000396F1
			[Class_410]
			public byte[] nprop_2 { get; private set; }

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x06000906 RID: 2310 RVA: 0x0003B4FA File Offset: 0x000396FA
			// (set) Token: 0x06000907 RID: 2311 RVA: 0x0003B502 File Offset: 0x00039702
			[Class_410]
			public string nprop_3 { get; private set; }

			// Token: 0x04000647 RID: 1607
			[CompilerGenerated]
			private string field_0;

			// Token: 0x04000648 RID: 1608
			[CompilerGenerated]
			private string field_1;

			// Token: 0x04000649 RID: 1609
			[CompilerGenerated]
			private byte[] field_2;

			// Token: 0x0400064A RID: 1610
			[CompilerGenerated]
			private string field_3;
		}

		// Token: 0x0200013D RID: 317
		public class NClass_1 : IEquatable<Class_239.NClass_1>
		{
			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06000908 RID: 2312 RVA: 0x0003B50B File Offset: 0x0003970B
			[Class_410]
			public string nprop_0 { get; }

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x06000909 RID: 2313 RVA: 0x0003B513 File Offset: 0x00039713
			[Class_410]
			public byte[] nprop_1 { get; }

			// Token: 0x0600090A RID: 2314 RVA: 0x0000237C File Offset: 0x0000057C
			private void nmethod_11()
			{
				base..ctor();
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x0003B51B File Offset: 0x0003971B
			public void nmethod_12(string str_0, byte[] byteDizi_0)
			{
				base..ctor();
				this.field_4 = str_0;
				this.field_5 = byteDizi_0;
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x0003B534 File Offset: 0x00039734
			public bool nmethod_13(Class_239.NClass_1 arg_0)
			{
				return arg_0 != null && this.nprop_0 != null && arg_0.nprop_0 != null && string.Compare(this.nprop_0, arg_0.nprop_0) == 0 && this.nprop_1 != null && arg_0.nprop_1 != null && this.nprop_1.SequenceEqual(arg_0.nprop_1);
			}

			// Token: 0x0400064B RID: 1611
			[CompilerGenerated]
			private readonly string field_4;

			// Token: 0x0400064C RID: 1612
			[CompilerGenerated]
			private readonly byte[] field_5;
		}

		// Token: 0x0200013E RID: 318
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_2
		{
			// Token: 0x0600090D RID: 2317 RVA: 0x0003B5A6 File Offset: 0x000397A6
			private static void nmethod_14()
			{
				Class_239.NClass_2.field_6 = new Class_239.NClass_2();
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_15()
			{
				base..ctor();
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x0003B5B2 File Offset: 0x000397B2
			internal bool nmethod_16(Class_241 arg_0)
			{
				return arg_0.prop_2 == Class_235.Trash;
			}

			// Token: 0x0400064D RID: 1613
			public static readonly Class_239.NClass_2 field_6;

			// Token: 0x0400064E RID: 1614
			public static Func<Class_241, bool> field_7;
		}

		// Token: 0x0200013F RID: 319
		[CompilerGenerated]
		private sealed class NClass_3
		{
			// Token: 0x06000910 RID: 2320 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_17()
			{
				base..ctor();
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x0003B5BD File Offset: 0x000397BD
			internal bool nmethod_18(Class_233 arg_0)
			{
				return arg_0.prop_0 == this.field_8.prop_0;
			}

			// Token: 0x0400064F RID: 1615
			public Class_233 field_8;
		}

		// Token: 0x02000140 RID: 320
		[CompilerGenerated]
		private sealed class NClass_4
		{
			// Token: 0x06000912 RID: 2322 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_19()
			{
				base..ctor();
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x0003B5D5 File Offset: 0x000397D5
			internal bool nmethod_20(Class_233 arg_0)
			{
				return arg_0.Equals(this.field_9);
			}

			// Token: 0x04000650 RID: 1616
			public Class_233 field_9;
		}

		// Token: 0x02000141 RID: 321
		[CompilerGenerated]
		private sealed class NClass_5
		{
			// Token: 0x06000914 RID: 2324 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_21()
			{
				base..ctor();
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x0003B5E3 File Offset: 0x000397E3
			internal Class_242 nmethod_22(Class_241 arg_0)
			{
				return new Class_242(arg_0, this.field_10);
			}

			// Token: 0x04000651 RID: 1617
			public string field_10;
		}

		// Token: 0x02000142 RID: 322
		[CompilerGenerated]
		private sealed class NClass_6
		{
			// Token: 0x06000916 RID: 2326 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_23()
			{
				base..ctor();
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x0003B5F1 File Offset: 0x000397F1
			internal bool nmethod_24(Class_233 arg_0)
			{
				return arg_0.Equals(this.field_11);
			}

			// Token: 0x04000652 RID: 1618
			public Class_233 field_11;
		}

		// Token: 0x02000143 RID: 323
		[CompilerGenerated]
		private sealed class NClass_7
		{
			// Token: 0x06000918 RID: 2328 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_25()
			{
				base..ctor();
			}

			// Token: 0x06000919 RID: 2329 RVA: 0x0003B5FF File Offset: 0x000397FF
			internal bool nmethod_26(Class_233 arg_0)
			{
				return arg_0.Equals(this.field_12);
			}

			// Token: 0x04000653 RID: 1619
			public Class_233 field_12;
		}
	}
}
