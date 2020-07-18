using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000082 RID: 130
	[DefaultMember("Item")]
	public abstract class Class_103 : IEnumerable
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000274 RID: 628
		public abstract Class_102 prop_0 { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0001353B File Offset: 0x0001173B
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0001353B File Offset: 0x0001173B
		public virtual Class_103 prop_1
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001353B File Offset: 0x0001173B
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0001353B File Offset: 0x0001173B
		public virtual Class_103 prop_2
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001353B File Offset: 0x0001173B
		IEnumerator IEnumerable.cmethod_324()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00013542 File Offset: 0x00011742
		public static Class_103 vmethod_325(TextReader arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("textReader");
			}
			return Class_103.lmethod_328<object>(new Class_97(arg_0).pmethod_269());
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00013565 File Offset: 0x00011765
		private static IEnumerable<KeyValuePair<string, Class_103>> dmethod_326(IEnumerable<KeyValuePair<string, object>> arg_0)
		{
			foreach (KeyValuePair<string, object> keyValuePair in arg_0)
			{
				yield return new KeyValuePair<string, Class_103>(keyValuePair.Key, Class_103.lmethod_328<object>(keyValuePair.Value));
			}
			IEnumerator<KeyValuePair<string, object>> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00013575 File Offset: 0x00011775
		private static IEnumerable<Class_103> kmethod_327(IEnumerable arg_0)
		{
			foreach (object arg_ in arg_0)
			{
				yield return Class_103.lmethod_328<object>(arg_);
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00013588 File Offset: 0x00011788
		public static Class_103 lmethod_328<T>(T arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			T t;
			if ((t = arg_0) is bool)
			{
				return new Class_101((bool)((object)t));
			}
			if ((t = arg_0) is byte)
			{
				return new Class_101((byte)((object)t));
			}
			if ((t = arg_0) is char)
			{
				return new Class_101((char)((object)t));
			}
			if ((t = arg_0) is decimal)
			{
				return new Class_101((decimal)((object)t));
			}
			if ((t = arg_0) is double)
			{
				return new Class_101((double)((object)t));
			}
			if ((t = arg_0) is float)
			{
				return new Class_101((float)((object)t));
			}
			if ((t = arg_0) is int)
			{
				return new Class_101((int)((object)t));
			}
			if ((t = arg_0) is long)
			{
				return new Class_101((long)((object)t));
			}
			if ((t = arg_0) is sbyte)
			{
				return new Class_101((sbyte)((object)t));
			}
			if ((t = arg_0) is short)
			{
				return new Class_101((short)((object)t));
			}
			string str_;
			if ((str_ = (arg_0 as string)) != null)
			{
				return new Class_101(str_);
			}
			if ((t = arg_0) is uint)
			{
				return new Class_101((uint)((object)t));
			}
			if ((t = arg_0) is ulong)
			{
				return new Class_101((ulong)((object)t));
			}
			if ((t = arg_0) is ushort)
			{
				return new Class_101((ushort)((object)t));
			}
			if ((t = arg_0) is DateTime)
			{
				return new Class_101((DateTime)((object)t));
			}
			if ((t = arg_0) is DateTimeOffset)
			{
				return new Class_101((DateTimeOffset)((object)t));
			}
			if ((t = arg_0) is Guid)
			{
				return new Class_101((Guid)((object)t));
			}
			if ((t = arg_0) is TimeSpan)
			{
				return new Class_101((TimeSpan)((object)t));
			}
			Uri arg_;
			if ((arg_ = (arg_0 as Uri)) != null)
			{
				return new Class_101(arg_);
			}
			IEnumerable<KeyValuePair<string, object>> enumerable = arg_0 as IEnumerable<KeyValuePair<string, object>>;
			if (enumerable != null)
			{
				return new Class_100(Class_103.dmethod_326(enumerable));
			}
			IEnumerable enumerable2 = arg_0 as IEnumerable;
			if (enumerable2 != null)
			{
				return new Class_98(Class_103.kmethod_327(enumerable2));
			}
			PropertyInfo[] properties = arg_0.GetType().GetProperties();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (PropertyInfo propertyInfo in properties)
			{
				dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(arg_0, null).IsNull("null"));
			}
			if (dictionary.Count > 0)
			{
				return new Class_100(Class_103.dmethod_326(dictionary));
			}
			throw new NotSupportedException(string.Format("Unexpected parser return type: {0}", arg_0.GetType()));
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001353B File Offset: 0x0001173B
		public virtual bool pmethod_329(string str_0)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000138FE File Offset: 0x00011AFE
		public virtual void smethod_330(Stream stream_, bool bool_0)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.xmethod_331(new StreamWriter(stream_), bool_0);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001391E File Offset: 0x00011B1E
		public virtual void xmethod_331(TextWriter arg_0, bool bool_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("textWriter");
			}
			this.tmethod_332(arg_0, bool_0);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001393C File Offset: 0x00011B3C
		private void tmethod_332(TextWriter arg_0, bool bool_0)
		{
			switch (this.prop_0)
			{
			case Class_102.\u032F\u0020\u0357\u030E\u0345\u0317\u032Ec\u033A\u030D\u0489\u033A\u0E47\u031A\u0489\u034Biuprkicuzyilcxpb\u0020\u0354\u0341\u0342\u0306\u0331\u0363\u0316\u035A\u0345\u0316\u0320\u0324\u035D\u0020\u0359byltzgwaywognczj:
				if (bool_0)
				{
					arg_0.Write('"');
				}
				arg_0.Write(this.vmethod_335(((Class_101)this).lmethod_318()));
				if (bool_0)
				{
					arg_0.Write('"');
					return;
				}
				return;
			case Class_102.\u0317\u0340\u0358\u0347\u0350\u032F\u0020\u0349\u0306\u031C\u035C\u032E\u0331\u0339\u0358\u033Byxxiufgypxhgqoxx\u035D\u034E\u0366h\u0367\u0315\u0E47\u0311\u030D\u032A\u0325\u030B\u0306\u036D\u0347\u036Cjvklzujfhndqipfi:
			{
				arg_0.Write('{');
				bool flag = false;
				using (IEnumerator<KeyValuePair<string, Class_103>> enumerator = ((Class_100)this).tmethod_302())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, Class_103> keyValuePair = enumerator.Current;
						if (flag)
						{
							arg_0.Write(", ");
						}
						arg_0.Write('"');
						arg_0.Write(this.vmethod_335(keyValuePair.Key));
						arg_0.Write("\": ");
						if (keyValuePair.Value == null)
						{
							arg_0.Write("null");
						}
						else
						{
							keyValuePair.Value.tmethod_332(arg_0, bool_0);
						}
						flag = true;
					}
				}
				arg_0.Write('}');
				return;
			}
			case Class_102.\u0320\u0322\u030D\u0322\u0328\u0329\u0326\u033F\u0349\u0346\u032A\u032F\u034D\u0E47\u0363\u035Fwhntkywlfriguado\u0335\u0E47\u0020\u0326\u0322\u0346\u032F\u0313\u034F\u0346\u0358\u033C\u0347\u0020\u0325\u033Dsievsoxohtygiqah:
			{
				arg_0.Write('[');
				bool flag2 = false;
				foreach (Class_103 class_ in ((IEnumerable<Class_103>)((Class_98)this)))
				{
					if (flag2)
					{
						arg_0.Write(", ");
					}
					if (class_ != null)
					{
						class_.tmethod_332(arg_0, bool_0);
					}
					else
					{
						arg_0.Write("null");
					}
					flag2 = true;
				}
				arg_0.Write(']');
				return;
			}
			case Class_102.\u031D\u0320\u033A\u0359\u0020\u032B\u036F\u030E\u034E\u032A\u0020\u0E47\u036D\u035E\u0357\u036Bbuinszyvshdxival\u0331\u033A\u0020t\u0E47\u034D\u033F\u0320\u0020\u0313\u0320\u0324\u034A\u0331\u0317\u0365rdmtbdisonjupbxu:
				arg_0.Write(Class_103.dmethod_356(this) ? "true" : "false");
				return;
			}
			arg_0.Write(((Class_101)this).lmethod_318());
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00013B1C File Offset: 0x00011D1C
		public string gmethod_333(bool bool_0 = true)
		{
			StringWriter stringWriter = new StringWriter();
			this.xmethod_331(stringWriter, bool_0);
			return stringWriter.ToString();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00013B40 File Offset: 0x00011D40
		private bool cmethod_334(string str_0, int sayıInt_0)
		{
			char c = str_0[sayıInt_0];
			return c < ' ' || c == '"' || c == '\\' || (c >= '\ud800' && c <= '\udbff' && (sayıInt_0 == str_0.Length - 1 || str_0[sayıInt_0 + 1] < '\udc00' || str_0[sayıInt_0 + 1] > '\udfff')) || (c >= '\udc00' && c <= '\udfff' && (sayıInt_0 == 0 || str_0[sayıInt_0 - 1] < '\ud800' || str_0[sayıInt_0 - 1] > '\udbff')) || c == '\u2028' || c == '\u2029' || (c == '/' && sayıInt_0 > 0 && str_0[sayıInt_0 - 1] == '<');
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00013C30 File Offset: 0x00011E30
		public string vmethod_335(string str_0)
		{
			if (str_0 == null)
			{
				return null;
			}
			for (int i = 0; i < str_0.Length; i++)
			{
				if (this.cmethod_334(str_0, i))
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (i > 0)
					{
						stringBuilder.Append(str_0, 0, i);
					}
					return this.dmethod_336(stringBuilder, str_0, i);
				}
			}
			return str_0;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00013C88 File Offset: 0x00011E88
		private string dmethod_336(StringBuilder arg_0, string str_0, int sayıInt_0)
		{
			int num = sayıInt_0;
			for (int i = sayıInt_0; i < str_0.Length; i++)
			{
				if (this.cmethod_334(str_0, i))
				{
					arg_0.Append(str_0, num, i - num);
					char c = str_0[i];
					if (c <= '"')
					{
						switch (c)
						{
						case '\b':
							arg_0.Append("\\b");
							break;
						case '\t':
							arg_0.Append("\\t");
							break;
						case '\n':
							arg_0.Append("\\n");
							break;
						case '\v':
							goto IL_FC;
						case '\f':
							arg_0.Append("\\f");
							break;
						case '\r':
							arg_0.Append("\\r");
							break;
						default:
							if (c != '"')
							{
								goto IL_FC;
							}
							arg_0.Append("\\\"");
							break;
						}
					}
					else if (c != '/')
					{
						if (c != '\\')
						{
							goto IL_FC;
						}
						arg_0.Append("\\\\");
					}
					else
					{
						arg_0.Append("\\/");
					}
					IL_123:
					num = i + 1;
					goto IL_127;
					IL_FC:
					arg_0.Append("\\u");
					arg_0.Append(((int)str_0[i]).ToString("x04"));
					goto IL_123;
				}
				IL_127:;
			}
			arg_0.Append(str_0, num, str_0.Length - num);
			return arg_0.ToString();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00013DE3 File Offset: 0x00011FE3
		public static Class_103 kmethod_337(bool bool_0)
		{
			return new Class_101(bool_0);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00013DEB File Offset: 0x00011FEB
		public static Class_103 lmethod_338(byte byte_0)
		{
			return new Class_101(byte_0);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00013DF3 File Offset: 0x00011FF3
		public static Class_103 pmethod_339(char char_0)
		{
			return new Class_101(char_0);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00013DFB File Offset: 0x00011FFB
		public static Class_103 smethod_340(decimal arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00013E03 File Offset: 0x00012003
		public static Class_103 xmethod_341(double double_0)
		{
			return new Class_101(double_0);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00013E0B File Offset: 0x0001200B
		public static Class_103 tmethod_342(float arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00013E13 File Offset: 0x00012013
		public static Class_103 gmethod_343(int sayıInt_0)
		{
			return new Class_101(sayıInt_0);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00013E1B File Offset: 0x0001201B
		public static Class_103 cmethod_344(long sayıUınt_0)
		{
			return new Class_101(sayıUınt_0);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00013E23 File Offset: 0x00012023
		public static Class_103 vmethod_345(sbyte arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00013E2B File Offset: 0x0001202B
		public static Class_103 dmethod_346(short sayıShort_0)
		{
			return new Class_101(sayıShort_0);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00013E33 File Offset: 0x00012033
		public static Class_103 kmethod_347(string str_0)
		{
			return new Class_101(str_0);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00013E3B File Offset: 0x0001203B
		public static Class_103 lmethod_348(uint arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00013E43 File Offset: 0x00012043
		public static Class_103 pmethod_349(ulong arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00013E4B File Offset: 0x0001204B
		public static Class_103 smethod_350(ushort arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00013E53 File Offset: 0x00012053
		public static Class_103 xmethod_351(DateTime arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00013E5B File Offset: 0x0001205B
		public static Class_103 tmethod_352(DateTimeOffset arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00013E63 File Offset: 0x00012063
		public static Class_103 gmethod_353(Guid arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00013E6B File Offset: 0x0001206B
		public static Class_103 cmethod_354(TimeSpan arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00013E73 File Offset: 0x00012073
		public static Class_103 vmethod_355(Uri arg_0)
		{
			return new Class_101(arg_0);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00013E7B File Offset: 0x0001207B
		public static bool dmethod_356(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToBoolean(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00013EA3 File Offset: 0x000120A3
		public static byte kmethod_357(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToByte(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00013ECB File Offset: 0x000120CB
		public static char lmethod_358(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToChar(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00013EF3 File Offset: 0x000120F3
		public static decimal pmethod_359(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToDecimal(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00013F1B File Offset: 0x0001211B
		public static double smethod_360(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToDouble(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00013F43 File Offset: 0x00012143
		public static float xmethod_361(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToSingle(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00013F6B File Offset: 0x0001216B
		public static int tmethod_362(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt32(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00013F93 File Offset: 0x00012193
		public static long gmethod_363(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt64(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00013FBB File Offset: 0x000121BB
		public static sbyte cmethod_364(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToSByte(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00013FE3 File Offset: 0x000121E3
		public static short vmethod_365(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt16(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001400B File Offset: 0x0001220B
		public static string dmethod_366(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			return arg_0.gmethod_333(true);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001401C File Offset: 0x0001221C
		public static uint kmethod_367(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt32(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00014044 File Offset: 0x00012244
		public static ulong lmethod_368(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt64(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0001406C File Offset: 0x0001226C
		public static ushort pmethod_369(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt16(((Class_101)arg_0).prop_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00014094 File Offset: 0x00012294
		public static DateTime smethod_370(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (DateTime)((Class_101)arg_0).prop_0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000140B7 File Offset: 0x000122B7
		public static DateTimeOffset xmethod_371(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (DateTimeOffset)((Class_101)arg_0).prop_0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000140DA File Offset: 0x000122DA
		public static TimeSpan tmethod_372(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (TimeSpan)((Class_101)arg_0).prop_0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000140FD File Offset: 0x000122FD
		public static Guid gmethod_373(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (Guid)((Class_101)arg_0).prop_0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00014120 File Offset: 0x00012320
		public static Uri cmethod_374(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (Uri)((Class_101)arg_0).prop_0;
		}

		// Token: 0x0400018C RID: 396
		public static string field_0 = "Avalon V1.2";
	}
}
