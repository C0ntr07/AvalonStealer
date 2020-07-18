using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000223 RID: 547
	public static class Class_416
	{
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000551FD File Offset: 0x000533FD
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00055204 File Offset: 0x00053404
		public static Func<Class_380> DefaultSettings { get; set; }

		// Token: 0x060010EB RID: 4331 RVA: 0x0005520C File Offset: 0x0005340C
		public static string ToString(DateTime value)
		{
			return Class_416.ToString(value, Class_319.IsoDateFormat, Class_321.RoundtripKind);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00055218 File Offset: 0x00053418
		public static string ToString(DateTime value, Class_319 format, Class_321 timeZoneHandling)
		{
			DateTime value2 = Class_502.EnsureDateTime(value, timeZoneHandling);
			string result;
			using (StringWriter stringWriter = Class_515.CreateStringWriter(64))
			{
				stringWriter.Write('"');
				Class_502.WriteDateTimeString(stringWriter, value2, format, null, CultureInfo.InvariantCulture);
				stringWriter.Write('"');
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00055280 File Offset: 0x00053480
		public static string ToString(DateTimeOffset value)
		{
			return Class_416.ToString(value, Class_319.IsoDateFormat);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0005528C File Offset: 0x0005348C
		public static string ToString(DateTimeOffset value, Class_319 format)
		{
			string result;
			using (StringWriter stringWriter = Class_515.CreateStringWriter(64))
			{
				stringWriter.Write('"');
				Class_502.WriteDateTimeOffsetString(stringWriter, value, format, null, CultureInfo.InvariantCulture);
				stringWriter.Write('"');
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000552EC File Offset: 0x000534EC
		public static string ToString(bool value)
		{
			if (!value)
			{
				return Class_416.False;
			}
			return Class_416.True;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000552FF File Offset: 0x000534FF
		public static string ToString(char value)
		{
			return Class_416.ToString(char.ToString(value));
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0005530C File Offset: 0x0005350C
		public static string ToString(Enum value)
		{
			return value.ToString("D");
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00055319 File Offset: 0x00053519
		public static string ToString(int value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00055328 File Offset: 0x00053528
		public static string ToString(short value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00055337 File Offset: 0x00053537
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00055346 File Offset: 0x00053546
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00055355 File Offset: 0x00053555
		public static string ToString(long value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00055364 File Offset: 0x00053564
		private static string ToStringInternal(BigInteger value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00055373 File Offset: 0x00053573
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00055382 File Offset: 0x00053582
		public static string ToString(float value)
		{
			return Class_416.EnsureDecimalPlace((double)value, value.ToString("R", CultureInfo.InvariantCulture));
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0005539C File Offset: 0x0005359C
		internal static string ToString(float value, Class_314 floatFormatHandling, char quoteChar, bool nullable)
		{
			return Class_416.EnsureFloatFormat((double)value, Class_416.EnsureDecimalPlace((double)value, value.ToString("R", CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000553C0 File Offset: 0x000535C0
		private static string EnsureFloatFormat(double value, string text, Class_314 floatFormatHandling, char quoteChar, bool nullable)
		{
			if (floatFormatHandling == Class_314.Symbol || (!double.IsInfinity(value) && !double.IsNaN(value)))
			{
				return text;
			}
			if (floatFormatHandling != Class_314.DefaultValue)
			{
				return quoteChar + text + quoteChar;
			}
			if (nullable)
			{
				return Class_416.Null;
			}
			return "0.0";
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00055418 File Offset: 0x00053618
		public static string ToString(double value)
		{
			return Class_416.EnsureDecimalPlace(value, value.ToString("R", CultureInfo.InvariantCulture));
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00055431 File Offset: 0x00053631
		internal static string ToString(double value, Class_314 floatFormatHandling, char quoteChar, bool nullable)
		{
			return Class_416.EnsureFloatFormat(value, Class_416.EnsureDecimalPlace(value, value.ToString("R", CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00055454 File Offset: 0x00053654
		private static string EnsureDecimalPlace(double value, string text)
		{
			if (double.IsNaN(value) || double.IsInfinity(value) || text.IndexOf('.') != -1 || text.IndexOf('E') != -1 || text.IndexOf('e') != -1)
			{
				return text;
			}
			return text + ".0";
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000554AE File Offset: 0x000536AE
		private static string EnsureDecimalPlace(string text)
		{
			if (text.IndexOf('.') != -1)
			{
				return text;
			}
			return text + ".0";
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x000554CB File Offset: 0x000536CB
		public static string ToString(byte value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000554DA File Offset: 0x000536DA
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x000554E9 File Offset: 0x000536E9
		public static string ToString(decimal value)
		{
			return Class_416.EnsureDecimalPlace(value.ToString(null, CultureInfo.InvariantCulture));
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000554FD File Offset: 0x000536FD
		public static string ToString(Guid value)
		{
			return Class_416.ToString(value, '"');
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00055508 File Offset: 0x00053708
		internal static string ToString(Guid value, char quoteChar)
		{
			string str = value.ToString("D", CultureInfo.InvariantCulture);
			string text = quoteChar.ToString(CultureInfo.InvariantCulture);
			return text + str + text;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0005553C File Offset: 0x0005373C
		public static string ToString(TimeSpan value)
		{
			return Class_416.ToString(value, '"');
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00055546 File Offset: 0x00053746
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			return Class_416.ToString(value.ToString(), quoteChar);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0005555B File Offset: 0x0005375B
		public static string ToString(Uri value)
		{
			if (value == null)
			{
				return Class_416.Null;
			}
			return Class_416.ToString(value, '"');
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00055577 File Offset: 0x00053777
		internal static string ToString(Uri value, char quoteChar)
		{
			return Class_416.ToString(value.OriginalString, quoteChar);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00055585 File Offset: 0x00053785
		public static string ToString(string value)
		{
			return Class_416.ToString(value, '"');
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0005558F File Offset: 0x0005378F
		public static string ToString(string value, char delimiter)
		{
			return Class_416.ToString(value, delimiter, Class_356.Default);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00055599 File Offset: 0x00053799
		public static string ToString(string value, char delimiter, Class_356 stringEscapeHandling)
		{
			if (delimiter != '"' && delimiter != '\'')
			{
				throw new ArgumentException("Delimiter must be a single or double quote.", "delimiter");
			}
			return Class_507.ToEscapedJavaScriptString(value, delimiter, true, stringEscapeHandling);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x000555C4 File Offset: 0x000537C4
		public static string ToString(object value)
		{
			if (value == null)
			{
				return Class_416.Null;
			}
			switch (Class_499.GetTypeCode(value.GetType()))
			{
			case Class_496.Char:
				return Class_416.ToString((char)value);
			case Class_496.Boolean:
				return Class_416.ToString((bool)value);
			case Class_496.SByte:
				return Class_416.ToString((sbyte)value);
			case Class_496.Int16:
				return Class_416.ToString((short)value);
			case Class_496.UInt16:
				return Class_416.ToString((ushort)value);
			case Class_496.Int32:
				return Class_416.ToString((int)value);
			case Class_496.Byte:
				return Class_416.ToString((byte)value);
			case Class_496.UInt32:
				return Class_416.ToString((uint)value);
			case Class_496.Int64:
				return Class_416.ToString((long)value);
			case Class_496.UInt64:
				return Class_416.ToString((ulong)value);
			case Class_496.Single:
				return Class_416.ToString((float)value);
			case Class_496.Double:
				return Class_416.ToString((double)value);
			case Class_496.DateTime:
				return Class_416.ToString((DateTime)value);
			case Class_496.DateTimeOffset:
				return Class_416.ToString((DateTimeOffset)value);
			case Class_496.Decimal:
				return Class_416.ToString((decimal)value);
			case Class_496.Guid:
				return Class_416.ToString((Guid)value);
			case Class_496.TimeSpan:
				return Class_416.ToString((TimeSpan)value);
			case Class_496.BigInteger:
				return Class_416.ToStringInternal((BigInteger)value);
			case Class_496.Uri:
				return Class_416.ToString((Uri)value);
			case Class_496.String:
				return Class_416.ToString((string)value);
			case Class_496.DBNull:
				return Class_416.Null;
			}
			throw new ArgumentException("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".FormatWith(CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x000557A8 File Offset: 0x000539A8
		public static string SerializeObject(object value)
		{
			return Class_416.SerializeObject(value, null, null);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x000557B2 File Offset: 0x000539B2
		public static string SerializeObject(object value, Class_322 formatting)
		{
			return Class_416.SerializeObject(value, formatting, null);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x000557BC File Offset: 0x000539BC
		public static string SerializeObject(object value, params Class_299[] converters)
		{
			Class_380 settings = (converters != null && converters.Length > 0) ? new Class_380
			{
				prop_5 = converters
			} : null;
			return Class_416.SerializeObject(value, null, settings);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000557F8 File Offset: 0x000539F8
		public static string SerializeObject(object value, Class_322 formatting, params Class_299[] converters)
		{
			Class_380 settings = (converters != null && converters.Length > 0) ? new Class_380
			{
				prop_5 = converters
			} : null;
			return Class_416.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00055832 File Offset: 0x00053A32
		public static string SerializeObject(object value, Class_380 settings)
		{
			return Class_416.SerializeObject(value, null, settings);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005583C File Offset: 0x00053A3C
		public static string SerializeObject(object value, Type type, Class_380 settings)
		{
			Class_418 jsonSerializer = Class_418.tmethod_3162(settings);
			return Class_416.SerializeObjectInternal(value, type, jsonSerializer);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00055858 File Offset: 0x00053A58
		public static string SerializeObject(object value, Class_322 formatting, Class_380 settings)
		{
			return Class_416.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00055864 File Offset: 0x00053A64
		public static string SerializeObject(object value, Type type, Class_322 formatting, Class_380 settings)
		{
			Class_418 class_ = Class_418.tmethod_3162(settings);
			class_.prop_16 = formatting;
			return Class_416.SerializeObjectInternal(value, type, class_);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00055888 File Offset: 0x00053A88
		private static string SerializeObjectInternal(object value, Type type, Class_418 jsonSerializer)
		{
			StringBuilder sb = new StringBuilder(256);
			StringWriter stringWriter = new StringWriter(sb, CultureInfo.InvariantCulture);
			using (Class_412 class_ = new Class_412(stringWriter))
			{
				class_.prop_5 = jsonSerializer.prop_16;
				jsonSerializer.vmethod_3175(class_, value, type);
			}
			return stringWriter.ToString();
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000558F0 File Offset: 0x00053AF0
		[Obsolete("SerializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to serialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.SerializeObject(value))")]
		public static Task<string> SerializeObjectAsync(object value)
		{
			return Class_416.SerializeObjectAsync(value, Class_322.None, null);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000558FA File Offset: 0x00053AFA
		[Obsolete("SerializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to serialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.SerializeObject(value, formatting))")]
		public static Task<string> SerializeObjectAsync(object value, Class_322 formatting)
		{
			return Class_416.SerializeObjectAsync(value, formatting, null);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00055904 File Offset: 0x00053B04
		[Obsolete("SerializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to serialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.SerializeObject(value, formatting, settings))")]
		public static Task<string> SerializeObjectAsync(object value, Class_322 formatting, Class_380 settings)
		{
			return Task.Factory.StartNew<string>(() => Class_416.SerializeObject(value, formatting, settings));
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00055942 File Offset: 0x00053B42
		public static object DeserializeObject(string value)
		{
			return Class_416.DeserializeObject(value, null, null);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0005594C File Offset: 0x00053B4C
		public static object DeserializeObject(string value, Class_380 settings)
		{
			return Class_416.DeserializeObject(value, null, settings);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00055956 File Offset: 0x00053B56
		public static object DeserializeObject(string value, Type type)
		{
			return Class_416.DeserializeObject(value, type, null);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00055960 File Offset: 0x00053B60
		public static T DeserializeObject<T>(string value)
		{
			return Class_416.DeserializeObject<T>(value, null);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00055969 File Offset: 0x00053B69
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			return Class_416.DeserializeObject<T>(value);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00055971 File Offset: 0x00053B71
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, Class_380 settings)
		{
			return Class_416.DeserializeObject<T>(value, settings);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0005597A File Offset: 0x00053B7A
		public static T DeserializeObject<T>(string value, params Class_299[] converters)
		{
			return (T)((object)Class_416.DeserializeObject(value, typeof(T), converters));
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00055992 File Offset: 0x00053B92
		public static T DeserializeObject<T>(string value, Class_380 settings)
		{
			return (T)((object)Class_416.DeserializeObject(value, typeof(T), settings));
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x000559AC File Offset: 0x00053BAC
		public static object DeserializeObject(string value, Type type, params Class_299[] converters)
		{
			Class_380 settings = (converters != null && converters.Length > 0) ? new Class_380
			{
				prop_5 = converters
			} : null;
			return Class_416.DeserializeObject(value, type, settings);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000559E8 File Offset: 0x00053BE8
		public static object DeserializeObject(string value, Type type, Class_380 settings)
		{
			Class_517.ArgumentNotNull(value, "value");
			Class_418 class_ = Class_418.tmethod_3162(settings);
			if (!class_.pmethod_3159())
			{
				class_.prop_26 = true;
			}
			object result;
			using (Class_409 class_2 = new Class_409(new StringReader(value)))
			{
				result = class_.smethod_3170(class_2, type);
			}
			return result;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00055A54 File Offset: 0x00053C54
		[Obsolete("DeserializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(value))")]
		public static Task<T> DeserializeObjectAsync<T>(string value)
		{
			return Class_416.DeserializeObjectAsync<T>(value, null);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00055A60 File Offset: 0x00053C60
		[Obsolete("DeserializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(value, settings))")]
		public static Task<T> DeserializeObjectAsync<T>(string value, Class_380 settings)
		{
			return Task.Factory.StartNew<T>(() => Class_416.DeserializeObject<T>(value, settings));
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00055A97 File Offset: 0x00053C97
		[Obsolete("DeserializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.DeserializeObject(value))")]
		public static Task<object> DeserializeObjectAsync(string value)
		{
			return Class_416.DeserializeObjectAsync(value, null, null);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00055AA4 File Offset: 0x00053CA4
		[Obsolete("DeserializeObjectAsync is obsolete. Use the Task.Factory.StartNew method to deserialize JSON asynchronously: Task.Factory.StartNew(() => JsonConvert.DeserializeObject(value, type, settings))")]
		public static Task<object> DeserializeObjectAsync(string value, Type type, Class_380 settings)
		{
			return Task.Factory.StartNew<object>(() => Class_416.DeserializeObject(value, type, settings));
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00055AE2 File Offset: 0x00053CE2
		public static void PopulateObject(string value, object target)
		{
			Class_416.PopulateObject(value, target, null);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00055AEC File Offset: 0x00053CEC
		public static void PopulateObject(string value, object target, Class_380 settings)
		{
			Class_418 class_ = Class_418.tmethod_3162(settings);
			using (Class_285 class_2 = new Class_409(new StringReader(value)))
			{
				class_.vmethod_3165(class_2, target);
				if (class_2.vmethod_1885() && class_2.prop_9 != Class_508.Comment)
				{
					throw new Class_417("Additional text found in JSON string after finishing deserializing object.");
				}
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00055B58 File Offset: 0x00053D58
		[Obsolete("PopulateObjectAsync is obsolete. Use the Task.Factory.StartNew method to populate an object with JSON values asynchronously: Task.Factory.StartNew(() => JsonConvert.PopulateObject(value, target, settings))")]
		public static Task PopulateObjectAsync(string value, object target, Class_380 settings)
		{
			return Task.Factory.StartNew(delegate()
			{
				Class_416.PopulateObject(value, target, settings);
			});
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00055B96 File Offset: 0x00053D96
		public static string SerializeXmlNode(XmlNode node)
		{
			return Class_416.SerializeXmlNode(node, Class_322.None);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00055BA0 File Offset: 0x00053DA0
		public static string SerializeXmlNode(XmlNode node, Class_322 formatting)
		{
			Class_407 class_ = new Class_407();
			return Class_416.SerializeObject(node, formatting, new Class_299[]
			{
				class_
			});
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00055BCC File Offset: 0x00053DCC
		public static string SerializeXmlNode(XmlNode node, Class_322 formatting, bool omitRootObject)
		{
			Class_407 class_ = new Class_407
			{
				prop_2 = omitRootObject
			};
			return Class_416.SerializeObject(node, formatting, new Class_299[]
			{
				class_
			});
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00055BFF File Offset: 0x00053DFF
		public static XmlDocument DeserializeXmlNode(string value)
		{
			return Class_416.DeserializeXmlNode(value, null);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00055C08 File Offset: 0x00053E08
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			return Class_416.DeserializeXmlNode(value, deserializeRootElementName, false);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00055C14 File Offset: 0x00053E14
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			Class_407 class_ = new Class_407();
			class_.prop_0 = deserializeRootElementName;
			class_.prop_1 = writeArrayAttribute;
			return (XmlDocument)Class_416.DeserializeObject(value, typeof(XmlDocument), new Class_299[]
			{
				class_
			});
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00055C5A File Offset: 0x00053E5A
		public static string SerializeXNode(XObject node)
		{
			return Class_416.SerializeXNode(node, Class_322.None);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00055C63 File Offset: 0x00053E63
		public static string SerializeXNode(XObject node, Class_322 formatting)
		{
			return Class_416.SerializeXNode(node, formatting, false);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00055C70 File Offset: 0x00053E70
		public static string SerializeXNode(XObject node, Class_322 formatting, bool omitRootObject)
		{
			Class_407 class_ = new Class_407
			{
				prop_2 = omitRootObject
			};
			return Class_416.SerializeObject(node, formatting, new Class_299[]
			{
				class_
			});
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00055CA3 File Offset: 0x00053EA3
		public static XDocument DeserializeXNode(string value)
		{
			return Class_416.DeserializeXNode(value, null);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00055CAC File Offset: 0x00053EAC
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName)
		{
			return Class_416.DeserializeXNode(value, deserializeRootElementName, false);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00055CB8 File Offset: 0x00053EB8
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			Class_407 class_ = new Class_407();
			class_.prop_0 = deserializeRootElementName;
			class_.prop_1 = writeArrayAttribute;
			return (XDocument)Class_416.DeserializeObject(value, typeof(XDocument), new Class_299[]
			{
				class_
			});
		}

		// Token: 0x040009A9 RID: 2473
		public static readonly string True = "true";

		// Token: 0x040009AA RID: 2474
		public static readonly string False = "false";

		// Token: 0x040009AB RID: 2475
		public static readonly string Null = "null";

		// Token: 0x040009AC RID: 2476
		public static readonly string Undefined = "undefined";

		// Token: 0x040009AD RID: 2477
		public static readonly string PositiveInfinity = "Infinity";

		// Token: 0x040009AE RID: 2478
		public static readonly string NegativeInfinity = "-Infinity";

		// Token: 0x040009AF RID: 2479
		public static readonly string NaN = "NaN";
	}
}
