using System;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001ED RID: 493
	internal class Class_366 : IFormatterConverter
	{
		// Token: 0x06000EA9 RID: 3753 RVA: 0x0004D5F6 File Offset: 0x0004B7F6
		public Class_366(Class_466 arg_0, Class_367 arg_1, Class_454 arg_2)
		{
			Class_517.ArgumentNotNull(arg_0, "serializer");
			Class_517.ArgumentNotNull(arg_1, "contract");
			this.field_0 = arg_0;
			this.field_1 = arg_1;
			this.field_2 = arg_2;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0004D62C File Offset: 0x0004B82C
		private T gmethod_2643<T>(object obje_0)
		{
			Class_517.ArgumentNotNull(obje_0, "value");
			Class_362 class_ = (Class_362)obje_0;
			return (T)((object)Convert.ChangeType(class_.prop_2, typeof(T), CultureInfo.InvariantCulture));
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0004D66C File Offset: 0x0004B86C
		public object cmethod_2644(object obje_0, Type arg_0)
		{
			Class_517.ArgumentNotNull(obje_0, "value");
			Class_361 class_ = obje_0 as Class_361;
			if (class_ == null)
			{
				throw new ArgumentException("Value is not a JToken.", "value");
			}
			return this.field_0.gmethod_3883(class_, arg_0, this.field_1, this.field_2);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0004D6BA File Offset: 0x0004B8BA
		public object vmethod_2645(object obje_0, TypeCode arg_0)
		{
			Class_517.ArgumentNotNull(obje_0, "value");
			if (obje_0 is Class_362)
			{
				obje_0 = ((Class_362)obje_0).prop_2;
			}
			return Convert.ChangeType(obje_0, arg_0, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0004D6EB File Offset: 0x0004B8EB
		public bool dmethod_2646(object obje_0)
		{
			return this.gmethod_2643<bool>(obje_0);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0004D6F4 File Offset: 0x0004B8F4
		public byte kmethod_2647(object obje_0)
		{
			return this.gmethod_2643<byte>(obje_0);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0004D6FD File Offset: 0x0004B8FD
		public char lmethod_2648(object obje_0)
		{
			return this.gmethod_2643<char>(obje_0);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0004D706 File Offset: 0x0004B906
		public DateTime pmethod_2649(object obje_0)
		{
			return this.gmethod_2643<DateTime>(obje_0);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0004D70F File Offset: 0x0004B90F
		public decimal smethod_2650(object obje_0)
		{
			return this.gmethod_2643<decimal>(obje_0);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0004D718 File Offset: 0x0004B918
		public double xmethod_2651(object obje_0)
		{
			return this.gmethod_2643<double>(obje_0);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0004D721 File Offset: 0x0004B921
		public short tmethod_2652(object obje_0)
		{
			return this.gmethod_2643<short>(obje_0);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004D72A File Offset: 0x0004B92A
		public int gmethod_2653(object obje_0)
		{
			return this.gmethod_2643<int>(obje_0);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0004D733 File Offset: 0x0004B933
		public long cmethod_2654(object obje_0)
		{
			return this.gmethod_2643<long>(obje_0);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0004D73C File Offset: 0x0004B93C
		public sbyte vmethod_2655(object obje_0)
		{
			return this.gmethod_2643<sbyte>(obje_0);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0004D745 File Offset: 0x0004B945
		public float dmethod_2656(object obje_0)
		{
			return this.gmethod_2643<float>(obje_0);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0004D74E File Offset: 0x0004B94E
		public string kmethod_2657(object obje_0)
		{
			return this.gmethod_2643<string>(obje_0);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0004D757 File Offset: 0x0004B957
		public ushort lmethod_2658(object obje_0)
		{
			return this.gmethod_2643<ushort>(obje_0);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0004D760 File Offset: 0x0004B960
		public uint pmethod_2659(object obje_0)
		{
			return this.gmethod_2643<uint>(obje_0);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0004D769 File Offset: 0x0004B969
		public ulong smethod_2660(object obje_0)
		{
			return this.gmethod_2643<ulong>(obje_0);
		}

		// Token: 0x040008ED RID: 2285
		private readonly Class_466 field_0;

		// Token: 0x040008EE RID: 2286
		private readonly Class_367 field_1;

		// Token: 0x040008EF RID: 2287
		private readonly Class_454 field_2;
	}
}
