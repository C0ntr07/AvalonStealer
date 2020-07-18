using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200022A RID: 554
	public static class Class_419
	{
		// Token: 0x06001196 RID: 4502 RVA: 0x0005706A File Offset: 0x0005526A
		public static Class_360<Class_361> Ancestors<T>(this IEnumerable<T> source) where T : Class_361
		{
			Class_517.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.pmethod_2459()).AsJEnumerable<Class_361>();
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0005708E File Offset: 0x0005528E
		public static Class_360<Class_361> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : Class_361
		{
			Class_517.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.smethod_2460()).AsJEnumerable<Class_361>();
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x000570B2 File Offset: 0x000552B2
		public static Class_360<Class_361> Descendants<T>(this IEnumerable<T> source) where T : Class_420
		{
			Class_517.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.xmethod_3201()).AsJEnumerable<Class_361>();
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000570D6 File Offset: 0x000552D6
		public static Class_360<Class_361> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : Class_420
		{
			Class_517.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.tmethod_3202()).AsJEnumerable<Class_361>();
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x000570FA File Offset: 0x000552FA
		public static Class_360<Class_427> Properties(this IEnumerable<Class_423> source)
		{
			Class_517.ArgumentNotNull(source, "source");
			return source.SelectMany((Class_423 d) => d.tmethod_3302()).AsJEnumerable<Class_427>();
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00057132 File Offset: 0x00055332
		public static Class_360<Class_361> Values(this IEnumerable<Class_361> source, object key)
		{
			return source.Values(key).AsJEnumerable<Class_361>();
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00057140 File Offset: 0x00055340
		public static Class_360<Class_361> Values(this IEnumerable<Class_361> source)
		{
			return source.Values(null);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00057149 File Offset: 0x00055349
		public static IEnumerable<U> Values<U>(this IEnumerable<Class_361> source, object key)
		{
			return source.Values(key);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00057152 File Offset: 0x00055352
		public static IEnumerable<U> Values<U>(this IEnumerable<Class_361> source)
		{
			return source.Values(null);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0005715B File Offset: 0x0005535B
		public static U Value<U>(this IEnumerable<Class_361> value)
		{
			return value.Value<Class_361, U>();
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00057164 File Offset: 0x00055364
		public static U Value<T, U>(this IEnumerable<T> value) where T : Class_361
		{
			Class_517.ArgumentNotNull(value, "source");
			Class_361 class_ = value as Class_361;
			if (class_ == null)
			{
				throw new ArgumentException("Source value must be a JToken.");
			}
			return class_.Convert<Class_361, U>();
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0005719C File Offset: 0x0005539C
		internal static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, object key) where T : Class_361
		{
			Class_517.ArgumentNotNull(source, "source");
			foreach (T t2 in source)
			{
				Class_361 token = t2;
				if (key == null)
				{
					if (token is Class_362)
					{
						yield return ((Class_362)token).Convert<Class_362, U>();
					}
					else
					{
						foreach (Class_361 t in token.pmethod_2469())
						{
							yield return t.Convert<Class_361, U>();
						}
					}
				}
				else
				{
					Class_361 value = token.cmethod_2464(key);
					if (value != null)
					{
						yield return value.Convert<Class_361, U>();
					}
				}
			}
			yield break;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000571C0 File Offset: 0x000553C0
		public static Class_360<Class_361> Children<T>(this IEnumerable<T> source) where T : Class_361
		{
			return source.Children<T, Class_361>().AsJEnumerable<Class_361>();
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x000571CD File Offset: 0x000553CD
		public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : Class_361
		{
			Class_517.ArgumentNotNull(source, "source");
			return source.SelectMany((T c) => c.pmethod_2469()).Convert<Class_361, U>();
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000571F4 File Offset: 0x000553F4
		internal static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : Class_361
		{
			Class_517.ArgumentNotNull(source, "source");
			foreach (T token in source)
			{
				yield return token.Convert<Class_361, U>();
			}
			yield break;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00057214 File Offset: 0x00055414
		internal static U Convert<T, U>(this T token) where T : Class_361
		{
			if (token == null)
			{
				return default(U);
			}
			if (token is U && typeof(U) != typeof(IComparable) && typeof(U) != typeof(IFormattable))
			{
				return (U)((object)token);
			}
			Class_362 class_ = token as Class_362;
			if (class_ == null)
			{
				throw new InvalidCastException("Cannot cast {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, token.GetType(), typeof(T)));
			}
			if (class_.prop_2 is U)
			{
				return (U)((object)class_.prop_2);
			}
			Type type = typeof(U);
			if (Class_514.IsNullableType(type))
			{
				if (class_.prop_2 == null)
				{
					return default(U);
				}
				type = Nullable.GetUnderlyingType(type);
			}
			return (U)((object)System.Convert.ChangeType(class_.prop_2, type, CultureInfo.InvariantCulture));
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00057330 File Offset: 0x00055530
		public static Class_360<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : Class_361
		{
			if (source == null)
			{
				return null;
			}
			if (source is Class_360<T>)
			{
				return (Class_360<T>)source;
			}
			return new Class_422<T>(source);
		}
	}
}
