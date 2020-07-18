using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000270 RID: 624
	internal class Class_467 : Class_465
	{
		// Token: 0x06001541 RID: 5441 RVA: 0x00065086 File Offset: 0x00063286
		public Class_467(Class_418 arg_0) : base(arg_0)
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0006509C File Offset: 0x0006329C
		public void tmethod_3902(Class_296 arg_0, object obje_0, Type arg_1)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("jsonWriter");
			}
			this.field_0 = ((arg_1 != null) ? this.field_3.field_11.tmethod_3542(arg_1) : null);
			this.field_1 = this.field_2.Count + 1;
			Class_349 class_ = this.cmethod_3904(obje_0);
			try
			{
				this.dmethod_3906(arg_0, obje_0, class_, null, null, null);
			}
			catch (Exception arg_2)
			{
				if (!base.smethod_3850(null, class_, null, null, arg_0.prop_4, arg_2))
				{
					base.pmethod_3849();
					throw;
				}
				this.dmethod_3936(arg_0, 0);
			}
			finally
			{
				this.field_0 = null;
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0006516C File Offset: 0x0006336C
		private Class_468 gmethod_3903()
		{
			if (this.field_3 == null)
			{
				this.field_3 = new Class_468(this);
			}
			return this.field_3;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0006518B File Offset: 0x0006338B
		private Class_349 cmethod_3904(object obje_0)
		{
			if (obje_0 == null)
			{
				return null;
			}
			return this.field_3.field_11.tmethod_3542(obje_0.GetType());
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000651AC File Offset: 0x000633AC
		private void vmethod_3905(Class_296 arg_0, object obje_0, Class_369 arg_1, Class_454 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			if (arg_1.prop_0 == Class_496.Bytes)
			{
				bool flag = this.gmethod_3933(Class_494.Objects, arg_1, arg_2, arg_3, arg_4);
				if (flag)
				{
					arg_0.kmethod_2007();
					this.xmethod_3921(arg_0, arg_1.prop_1);
					arg_0.cmethod_2014("$value", false);
					Class_296.pmethod_2079(arg_0, arg_1.prop_0, obje_0);
					arg_0.lmethod_2008();
					return;
				}
			}
			Class_296.pmethod_2079(arg_0, arg_1.prop_0, obje_0);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0006521C File Offset: 0x0006341C
		private void dmethod_3906(Class_296 arg_0, object obje_0, Class_349 arg_1, Class_454 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			if (obje_0 == null)
			{
				arg_0.gmethod_2033();
				return;
			}
			Class_299 class_;
			if ((class_ = ((arg_2 != null) ? arg_2.prop_8 : null)) == null && (class_ = ((arg_4 != null) ? arg_4.prop_25 : null)) == null && (class_ = ((arg_3 != null) ? arg_3.prop_2 : null)) == null && (class_ = arg_1.prop_3) == null)
			{
				class_ = (this.field_3.smethod_3180(arg_1.prop_0) ?? arg_1.prop_4);
			}
			Class_299 class_2 = class_;
			if (class_2 != null && class_2.prop_1)
			{
				this.vmethod_3925(arg_0, class_2, obje_0, arg_1, arg_3, arg_4);
				return;
			}
			switch (arg_1.field_5)
			{
			case Class_448.Object:
				this.kmethod_3917(arg_0, obje_0, (Class_464)arg_1, arg_2, arg_3, arg_4);
				return;
			case Class_448.Array:
			{
				Class_447 class_3 = (Class_447)arg_1;
				if (!class_3.prop_1)
				{
					this.dmethod_3926(arg_0, (IEnumerable)obje_0, class_3, arg_2, arg_3, arg_4);
					return;
				}
				this.kmethod_3927(arg_0, (Array)obje_0, class_3, arg_2, arg_3, arg_4);
				return;
			}
			case Class_448.Primitive:
				this.vmethod_3905(arg_0, obje_0, (Class_369)arg_1, arg_2, arg_3, arg_4);
				return;
			case Class_448.String:
				this.cmethod_3914(arg_0, obje_0, (Class_469)arg_1);
				return;
			case Class_448.Dictionary:
			{
				Class_453 class_4 = (Class_453)arg_1;
				this.cmethod_3934(arg_0, (obje_0 is IDictionary) ? ((IDictionary)obje_0) : class_4.pmethod_3639(obje_0), class_4, arg_2, arg_3, arg_4);
				return;
			}
			case Class_448.Dynamic:
				this.xmethod_3931(arg_0, (IDynamicMetaObjectProvider)obje_0, (Class_365)arg_1, arg_2, arg_3, arg_4);
				return;
			case Class_448.Serializable:
				this.smethod_3930(arg_0, (ISerializable)obje_0, (Class_367)arg_1, arg_2, arg_3, arg_4);
				return;
			case Class_448.Linq:
				((Class_361)obje_0).cmethod_2474(arg_0, this.field_3.prop_13.ToArray<Class_299>());
				return;
			default:
				return;
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000653FC File Offset: 0x000635FC
		private bool? kmethod_3907(Class_349 arg_0, Class_454 arg_1, Class_350 arg_2, Class_454 arg_3)
		{
			bool? result = null;
			if (arg_1 != null)
			{
				result = arg_1.prop_16;
			}
			if (result == null && arg_3 != null)
			{
				result = arg_3.prop_26;
			}
			if (result == null && arg_2 != null)
			{
				result = arg_2.prop_3;
			}
			if (result == null)
			{
				result = arg_0.prop_2;
			}
			return result;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00065468 File Offset: 0x00063668
		private bool lmethod_3908(object obje_0, Class_454 arg_0, Class_349 arg_1, Class_350 arg_2, Class_454 arg_3)
		{
			if (obje_0 == null)
			{
				return false;
			}
			if (arg_1.field_5 == Class_448.Primitive || arg_1.field_5 == Class_448.String)
			{
				return false;
			}
			bool? flag = this.kmethod_3907(arg_1, arg_0, arg_2, arg_3);
			if (flag == null)
			{
				if (arg_1.field_5 == Class_448.Array)
				{
					flag = new bool?(this.gmethod_3923(this.field_3.field_2, Class_375.Arrays));
				}
				else
				{
					flag = new bool?(this.gmethod_3923(this.field_3.field_2, Class_375.Objects));
				}
			}
			return flag.Value && this.field_3.pmethod_3179().gmethod_2683(this, obje_0);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00065514 File Offset: 0x00063714
		private bool pmethod_3909(object obje_0, Class_454 arg_0)
		{
			return (arg_0.prop_17.GetValueOrDefault(this.field_3.field_6) != Class_457.Ignore || obje_0 != null) && (!this.tmethod_3922(arg_0.prop_18.GetValueOrDefault(this.field_3.field_7), Class_377.Ignore) || !Class_513.ValueEquals(obje_0, arg_0.xmethod_3671()));
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00065584 File Offset: 0x00063784
		private bool smethod_3910(Class_296 arg_0, object obje_0, Class_454 arg_1, Class_349 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			if (obje_0 == null || arg_2.field_5 == Class_448.Primitive || arg_2.field_5 == Class_448.String)
			{
				return true;
			}
			Class_458? class_ = null;
			if (arg_1 != null)
			{
				class_ = arg_1.prop_19;
			}
			if (class_ == null && arg_4 != null)
			{
				class_ = arg_4.prop_28;
			}
			if (class_ == null && arg_3 != null)
			{
				class_ = arg_3.prop_4;
			}
			if (this.field_2.IndexOf(obje_0) != -1)
			{
				string text = "Self referencing loop detected";
				if (arg_1 != null)
				{
					text += " for property '{0}'".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_1);
				}
				text += " with type '{0}'.".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType());
				switch (class_.GetValueOrDefault(this.field_3.field_3))
				{
				case Class_458.Error:
					throw Class_417.gmethod_3103(null, arg_0.prop_3, text, null);
				case Class_458.Ignore:
					if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
					{
						this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(null, arg_0.prop_4, text + ". Skipping serializing self referenced value."), null);
					}
					return false;
				case Class_458.Serialize:
					if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
					{
						this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(null, arg_0.prop_4, text + ". Serializing self referenced value."), null);
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00065714 File Offset: 0x00063914
		private void xmethod_3911(Class_296 arg_0, object obje_0)
		{
			string text = this.tmethod_3912(arg_0, obje_0);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(null, arg_0.prop_4, "Writing object reference to Id '{0}' for {1}.".FormatWith(CultureInfo.InvariantCulture, text, obje_0.GetType())), null);
			}
			arg_0.kmethod_2007();
			arg_0.cmethod_2014("$ref", false);
			arg_0.kmethod_2037(text);
			arg_0.lmethod_2008();
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00065794 File Offset: 0x00063994
		private string tmethod_3912(Class_296 arg_0, object obje_0)
		{
			string result;
			try
			{
				string text = this.field_3.pmethod_3179().tmethod_2682(this, obje_0);
				result = text;
			}
			catch (Exception arg_)
			{
				throw Class_417.gmethod_3103(null, arg_0.prop_3, "Error writing object reference for '{0}'.".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType()), arg_);
			}
			return result;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000657F0 File Offset: 0x000639F0
		internal static bool gmethod_3913(object obje_0, Type arg_0, out string arg_1)
		{
			TypeConverter typeConverter = Class_470.GetTypeConverter(arg_0);
			if (typeConverter != null && !(typeConverter is ComponentConverter) && typeConverter.GetType() != typeof(TypeConverter) && typeConverter.CanConvertTo(typeof(string)))
			{
				arg_1 = typeConverter.ConvertToInvariantString(obje_0);
				return true;
			}
			if (obje_0 is Type)
			{
				arg_1 = ((Type)obje_0).AssemblyQualifiedName;
				return true;
			}
			arg_1 = null;
			return false;
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00065870 File Offset: 0x00063A70
		private void cmethod_3914(Class_296 arg_0, object obje_0, Class_469 arg_1)
		{
			this.vmethod_3915(arg_0, arg_1, obje_0);
			string str_;
			Class_467.gmethod_3913(obje_0, arg_1.prop_0, out str_);
			arg_0.kmethod_2037(str_);
			this.dmethod_3916(arg_0, arg_1, obje_0);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000658A8 File Offset: 0x00063AA8
		private void vmethod_3915(Class_296 arg_0, Class_349 arg_1, object obje_0)
		{
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(null, arg_0.prop_4, "Started serializing {0}".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0)), null);
			}
			arg_1.gmethod_2343(obje_0, this.field_3.field_14);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00065914 File Offset: 0x00063B14
		private void dmethod_3916(Class_296 arg_0, Class_349 arg_1, object obje_0)
		{
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(null, arg_0.prop_4, "Finished serializing {0}".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0)), null);
			}
			arg_1.cmethod_2344(obje_0, this.field_3.field_14);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00065980 File Offset: 0x00063B80
		private void kmethod_3917(Class_296 arg_0, object obje_0, Class_464 arg_1, Class_454 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			this.vmethod_3915(arg_0, arg_1, obje_0);
			this.field_2.Add(obje_0);
			this.pmethod_3919(arg_0, obje_0, arg_1, arg_2, arg_3, arg_4);
			int sayıInt_ = arg_0.prop_1;
			for (int i = 0; i < arg_1.prop_2.Count; i++)
			{
				Class_454 class_ = arg_1.prop_2[i];
				try
				{
					Class_349 arg_5;
					object obje_;
					if (this.lmethod_3918(arg_0, obje_0, arg_1, arg_2, class_, out arg_5, out obje_))
					{
						class_.xmethod_3701(arg_0);
						this.dmethod_3906(arg_0, obje_, arg_5, class_, arg_1, arg_2);
					}
				}
				catch (Exception arg_6)
				{
					if (!base.smethod_3850(obje_0, arg_1, class_.prop_1, null, arg_0.prop_3, arg_6))
					{
						throw;
					}
					this.dmethod_3936(arg_0, sayıInt_);
				}
			}
			if (arg_1.prop_10 != null)
			{
				IEnumerable<KeyValuePair<object, object>> enumerable = arg_1.prop_10(obje_0);
				if (enumerable != null)
				{
					foreach (KeyValuePair<object, object> keyValuePair in enumerable)
					{
						Class_349 arg_7 = this.cmethod_3904(keyValuePair.Key);
						Class_349 class_2 = this.cmethod_3904(keyValuePair.Value);
						bool flag;
						string str_ = this.vmethod_3935(arg_0, keyValuePair.Key, arg_7, out flag);
						if (this.lmethod_3908(keyValuePair.Value, null, class_2, arg_1, arg_2))
						{
							arg_0.gmethod_2013(str_);
							this.xmethod_3911(arg_0, keyValuePair.Value);
						}
						else if (this.smethod_3910(arg_0, keyValuePair.Value, null, class_2, arg_1, arg_2))
						{
							arg_0.gmethod_2013(str_);
							this.dmethod_3906(arg_0, keyValuePair.Value, class_2, null, arg_1, arg_2);
						}
					}
				}
			}
			arg_0.lmethod_2008();
			this.field_2.RemoveAt(this.field_2.Count - 1);
			this.dmethod_3916(arg_0, arg_1, obje_0);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00065B7C File Offset: 0x00063D7C
		private bool lmethod_3918(Class_296 arg_0, object obje_0, Class_350 arg_1, Class_454 arg_2, Class_454 arg_3, out Class_349 arg_4, out object arg_5)
		{
			if (!arg_3.prop_10 && arg_3.prop_11 && this.kmethod_3937(arg_0, arg_3, obje_0) && this.lmethod_3938(arg_0, arg_3, obje_0))
			{
				if (arg_3.prop_0 == null)
				{
					arg_3.prop_0 = this.field_3.field_11.tmethod_3542(arg_3.prop_7);
				}
				arg_5 = arg_3.prop_5.pmethod_2309(obje_0);
				arg_4 = (arg_3.prop_0.field_7 ? arg_3.prop_0 : this.cmethod_3904(arg_5));
				if (this.pmethod_3909(arg_5, arg_3))
				{
					if (this.lmethod_3908(arg_5, arg_3, arg_4, arg_1, arg_2))
					{
						arg_3.xmethod_3701(arg_0);
						this.xmethod_3911(arg_0, arg_5);
						return false;
					}
					if (!this.smethod_3910(arg_0, arg_5, arg_3, arg_4, arg_1, arg_2))
					{
						return false;
					}
					if (arg_5 == null)
					{
						Class_464 class_ = arg_1 as Class_464;
						Class_364 class_2 = arg_3.field_0 ?? (((class_ != null) ? class_.prop_1 : null) ?? Class_364.Default);
						if (class_2 == Class_364.Always)
						{
							throw Class_417.gmethod_3103(null, arg_0.prop_3, "Cannot write a null value for property '{0}'. Property requires a value.".FormatWith(CultureInfo.InvariantCulture, arg_3.prop_1), null);
						}
					}
					return true;
				}
			}
			arg_4 = null;
			arg_5 = null;
			return false;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00065D14 File Offset: 0x00063F14
		private void pmethod_3919(Class_296 arg_0, object obje_0, Class_349 arg_1, Class_454 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			arg_0.kmethod_2007();
			bool flag = this.kmethod_3907(arg_1, arg_2, arg_3, arg_4) ?? this.gmethod_3923(this.field_3.field_2, Class_375.Objects);
			if (flag)
			{
				this.smethod_3920(arg_0, arg_1.prop_0, obje_0);
			}
			if (this.gmethod_3933(Class_494.Objects, arg_1, arg_2, arg_3, arg_4))
			{
				this.xmethod_3921(arg_0, arg_1.prop_0);
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00065D94 File Offset: 0x00063F94
		private void smethod_3920(Class_296 arg_0, Type arg_1, object obje_0)
		{
			string text = this.tmethod_3912(arg_0, obje_0);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
			{
				this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(null, arg_0.prop_4, "Writing object reference Id '{0}' for {1}.".FormatWith(CultureInfo.InvariantCulture, text, arg_1)), null);
			}
			arg_0.cmethod_2014("$id", false);
			arg_0.kmethod_2037(text);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00065E04 File Offset: 0x00064004
		private void xmethod_3921(Class_296 arg_0, Type arg_1)
		{
			string typeName = Class_514.GetTypeName(arg_1, this.field_3.field_1, this.field_3.field_13);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
			{
				this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(null, arg_0.prop_4, "Writing type name '{0}' for {1}.".FormatWith(CultureInfo.InvariantCulture, typeName, arg_1)), null);
			}
			arg_0.cmethod_2014("$type", false);
			arg_0.kmethod_2037(typeName);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00043B2F File Offset: 0x00041D2F
		private bool tmethod_3922(Class_377 arg_0, Class_377 arg_1)
		{
			return (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00043B2F File Offset: 0x00041D2F
		private bool gmethod_3923(Class_375 arg_0, Class_375 arg_1)
		{
			return (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00043B2F File Offset: 0x00041D2F
		private bool cmethod_3924(Class_494 arg_0, Class_494 arg_1)
		{
			return (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00065E88 File Offset: 0x00064088
		private void vmethod_3925(Class_296 arg_0, Class_299 arg_1, object obje_0, Class_349 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			if (this.lmethod_3908(obje_0, null, arg_2, arg_3, arg_4))
			{
				this.xmethod_3911(arg_0, obje_0);
				return;
			}
			if (!this.smethod_3910(arg_0, obje_0, null, arg_2, arg_3, arg_4))
			{
				return;
			}
			this.field_2.Add(obje_0);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(null, arg_0.prop_4, "Started serializing {0} with converter {1}.".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType(), arg_1.GetType())), null);
			}
			arg_1.tmethod_2132(arg_0, obje_0, this.gmethod_3903());
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(null, arg_0.prop_4, "Finished serializing {0} with converter {1}.".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType(), arg_1.GetType())), null);
			}
			this.field_2.RemoveAt(this.field_2.Count - 1);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00065F98 File Offset: 0x00064198
		private void dmethod_3926(Class_296 arg_0, IEnumerable arg_1, Class_447 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5)
		{
			Class_500 class_ = arg_1 as Class_500;
			object obj = (class_ != null) ? class_.prop_0 : arg_1;
			this.vmethod_3915(arg_0, arg_2, obj);
			this.field_2.Add(obj);
			bool flag = this.pmethod_3929(arg_0, obj, arg_2, arg_3, arg_4, arg_5);
			arg_0.pmethod_2009();
			int sayıInt_ = arg_0.prop_1;
			int num = 0;
			foreach (object obje_ in arg_1)
			{
				try
				{
					Class_349 class_2 = arg_2.prop_1 ?? this.cmethod_3904(obje_);
					if (this.lmethod_3908(obje_, null, class_2, arg_2, arg_3))
					{
						this.xmethod_3911(arg_0, obje_);
					}
					else if (this.smethod_3910(arg_0, obje_, null, class_2, arg_2, arg_3))
					{
						this.dmethod_3906(arg_0, obje_, class_2, null, arg_2, arg_3);
					}
				}
				catch (Exception arg_6)
				{
					if (!base.smethod_3850(obj, arg_2, num, null, arg_0.prop_3, arg_6))
					{
						throw;
					}
					this.dmethod_3936(arg_0, sayıInt_);
				}
				finally
				{
					num++;
				}
			}
			arg_0.smethod_2010();
			if (flag)
			{
				arg_0.lmethod_2008();
			}
			this.field_2.RemoveAt(this.field_2.Count - 1);
			this.dmethod_3916(arg_0, arg_2, obj);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00066130 File Offset: 0x00064330
		private void kmethod_3927(Class_296 arg_0, Array arg_1, Class_447 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5)
		{
			this.vmethod_3915(arg_0, arg_2, arg_1);
			this.field_2.Add(arg_1);
			bool flag = this.pmethod_3929(arg_0, arg_1, arg_2, arg_3, arg_4, arg_5);
			this.lmethod_3928(arg_0, arg_1, arg_2, arg_3, arg_0.prop_1, new int[0]);
			if (flag)
			{
				arg_0.lmethod_2008();
			}
			this.field_2.RemoveAt(this.field_2.Count - 1);
			this.dmethod_3916(arg_0, arg_2, arg_1);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000661A8 File Offset: 0x000643A8
		private void lmethod_3928(Class_296 arg_0, Array arg_1, Class_447 arg_2, Class_454 arg_3, int sayıInt_0, int[] ıntSayıDizi_0)
		{
			int num = ıntSayıDizi_0.Length;
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = ıntSayıDizi_0[i];
			}
			arg_0.pmethod_2009();
			int j = 0;
			while (j < arg_1.GetLength(num))
			{
				array[num] = j;
				bool flag = array.Length == arg_1.Rank;
				if (flag)
				{
					object value = arg_1.GetValue(array);
					try
					{
						Class_349 class_ = arg_2.prop_1 ?? this.cmethod_3904(value);
						if (this.lmethod_3908(value, null, class_, arg_2, arg_3))
						{
							this.xmethod_3911(arg_0, value);
						}
						else if (this.smethod_3910(arg_0, value, null, class_, arg_2, arg_3))
						{
							this.dmethod_3906(arg_0, value, class_, null, arg_2, arg_3);
						}
						goto IL_F7;
					}
					catch (Exception arg_4)
					{
						if (base.smethod_3850(arg_1, arg_2, j, null, arg_0.prop_3, arg_4))
						{
							this.dmethod_3936(arg_0, sayıInt_0 + 1);
							goto IL_F7;
						}
						throw;
					}
					goto IL_E7;
				}
				goto IL_E7;
				IL_F7:
				j++;
				continue;
				IL_E7:
				this.lmethod_3928(arg_0, arg_1, arg_2, arg_3, sayıInt_0 + 1, array);
				goto IL_F7;
			}
			arg_0.smethod_2010();
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000662D4 File Offset: 0x000644D4
		private bool pmethod_3929(Class_296 arg_0, object obje_0, Class_447 arg_1, Class_454 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			bool flag = this.kmethod_3907(arg_1, arg_2, arg_3, arg_4) ?? this.gmethod_3923(this.field_3.field_2, Class_375.Arrays);
			bool flag2 = this.gmethod_3933(Class_494.Arrays, arg_1, arg_2, arg_3, arg_4);
			bool flag3 = flag || flag2;
			if (flag3)
			{
				arg_0.kmethod_2007();
				if (flag)
				{
					this.smethod_3920(arg_0, arg_1.prop_0, obje_0);
				}
				if (flag2)
				{
					this.xmethod_3921(arg_0, obje_0.GetType());
				}
				arg_0.cmethod_2014("$values", false);
			}
			if (arg_1.prop_0 == null)
			{
				arg_1.prop_0 = this.field_3.field_11.tmethod_3542(arg_1.prop_0 ?? typeof(object));
			}
			return flag3;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000663B0 File Offset: 0x000645B0
		[SecuritySafeCritical]
		private void smethod_3930(Class_296 arg_0, ISerializable arg_1, Class_367 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5)
		{
			if (!Class_470.FullyTrusted)
			{
				string text = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
				text = text.FormatWith(CultureInfo.InvariantCulture, arg_1.GetType());
				throw Class_417.gmethod_3103(null, arg_0.prop_3, text, null);
			}
			this.vmethod_3915(arg_0, arg_2, arg_1);
			this.field_2.Add(arg_1);
			this.pmethod_3919(arg_0, arg_1, arg_2, arg_3, arg_4, arg_5);
			SerializationInfo serializationInfo = new SerializationInfo(arg_2.prop_0, new FormatterConverter());
			arg_1.GetObjectData(serializationInfo, this.field_3.field_14);
			foreach (SerializationEntry serializationEntry in serializationInfo)
			{
				Class_349 class_ = this.cmethod_3904(serializationEntry.Value);
				if (this.lmethod_3908(serializationEntry.Value, null, class_, arg_2, arg_3))
				{
					arg_0.gmethod_2013(serializationEntry.Name);
					this.xmethod_3911(arg_0, serializationEntry.Value);
				}
				else if (this.smethod_3910(arg_0, serializationEntry.Value, null, class_, arg_2, arg_3))
				{
					arg_0.gmethod_2013(serializationEntry.Name);
					this.dmethod_3906(arg_0, serializationEntry.Value, class_, null, arg_2, arg_3);
				}
			}
			arg_0.lmethod_2008();
			this.field_2.RemoveAt(this.field_2.Count - 1);
			this.dmethod_3916(arg_0, arg_2, arg_1);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00066510 File Offset: 0x00064710
		private void xmethod_3931(Class_296 arg_0, IDynamicMetaObjectProvider arg_1, Class_365 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5)
		{
			this.vmethod_3915(arg_0, arg_2, arg_1);
			this.field_2.Add(arg_1);
			this.pmethod_3919(arg_0, arg_1, arg_2, arg_3, arg_4, arg_5);
			int sayıInt_ = arg_0.prop_1;
			for (int i = 0; i < arg_2.prop_0.Count; i++)
			{
				Class_454 class_ = arg_2.prop_0[i];
				if (class_.prop_13)
				{
					try
					{
						Class_349 arg_6;
						object obje_;
						if (this.lmethod_3918(arg_0, arg_1, arg_2, arg_3, class_, out arg_6, out obje_))
						{
							class_.xmethod_3701(arg_0);
							this.dmethod_3906(arg_0, obje_, arg_6, class_, arg_2, arg_3);
						}
					}
					catch (Exception arg_7)
					{
						if (!base.smethod_3850(arg_1, arg_2, class_.prop_1, null, arg_0.prop_3, arg_7))
						{
							throw;
						}
						this.dmethod_3936(arg_0, sayıInt_);
					}
				}
			}
			foreach (string text in arg_1.GetDynamicMemberNames())
			{
				object obje_2;
				if (arg_2.xmethod_2641(arg_1, text, out obje_2))
				{
					try
					{
						Class_349 class_2 = this.cmethod_3904(obje_2);
						if (this.tmethod_3932(obje_2))
						{
							if (this.smethod_3910(arg_0, obje_2, null, class_2, arg_2, arg_3))
							{
								string str_ = (arg_2.prop_1 != null) ? arg_2.prop_1(text) : text;
								arg_0.gmethod_2013(str_);
								this.dmethod_3906(arg_0, obje_2, class_2, null, arg_2, arg_3);
							}
						}
					}
					catch (Exception arg_8)
					{
						if (!base.smethod_3850(arg_1, arg_2, text, null, arg_0.prop_3, arg_8))
						{
							throw;
						}
						this.dmethod_3936(arg_0, sayıInt_);
					}
				}
			}
			arg_0.lmethod_2008();
			this.field_2.RemoveAt(this.field_2.Count - 1);
			this.dmethod_3916(arg_0, arg_2, arg_1);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00066718 File Offset: 0x00064918
		private bool tmethod_3932(object obje_0)
		{
			return (this.field_3.field_6 != Class_457.Ignore || obje_0 != null) && (!this.tmethod_3922(this.field_3.field_7, Class_377.Ignore) || (obje_0 != null && !Class_513.ValueEquals(obje_0, Class_514.GetDefaultValue(obje_0.GetType()))));
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00066774 File Offset: 0x00064974
		private bool gmethod_3933(Class_494 arg_0, Class_349 arg_1, Class_454 arg_2, Class_350 arg_3, Class_454 arg_4)
		{
			Class_494 arg_5 = ((arg_2 != null) ? arg_2.prop_21 : null) ?? (((arg_4 != null) ? arg_4.prop_27 : null) ?? (((arg_3 != null) ? arg_3.prop_5 : null) ?? this.field_3.field_0));
			if (this.cmethod_3924(arg_5, arg_0))
			{
				return true;
			}
			if (this.cmethod_3924(arg_5, Class_494.Auto))
			{
				if (arg_2 != null)
				{
					if (arg_1.prop_0 != arg_2.prop_0.prop_1)
					{
						return true;
					}
				}
				else if (arg_3 != null)
				{
					if (arg_3.prop_0 == null || arg_1.prop_0 != arg_3.prop_0.prop_1)
					{
						return true;
					}
				}
				else if (this.field_0 != null && this.field_2.Count == this.field_1 && arg_1.prop_0 != this.field_0.prop_1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000668E0 File Offset: 0x00064AE0
		private void cmethod_3934(Class_296 arg_0, IDictionary arg_1, Class_453 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5)
		{
			Class_503 class_ = arg_1 as Class_503;
			object obj = (class_ != null) ? class_.prop_0 : arg_1;
			this.vmethod_3915(arg_0, arg_2, obj);
			this.field_2.Add(obj);
			this.pmethod_3919(arg_0, obj, arg_2, arg_3, arg_4, arg_5);
			if (arg_2.prop_0 == null)
			{
				arg_2.prop_0 = this.field_3.field_11.tmethod_3542(arg_2.prop_2 ?? typeof(object));
			}
			if (arg_2.prop_3 == null)
			{
				arg_2.prop_3 = this.field_3.field_11.tmethod_3542(arg_2.prop_1 ?? typeof(object));
			}
			int sayıInt_ = arg_0.prop_1;
			foreach (object obj2 in arg_1)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
				bool bool_;
				string text = this.vmethod_3935(arg_0, dictionaryEntry.Key, arg_2.prop_3, out bool_);
				text = ((arg_2.prop_0 != null) ? arg_2.prop_0(text) : text);
				try
				{
					object value = dictionaryEntry.Value;
					Class_349 class_2 = arg_2.prop_1 ?? this.cmethod_3904(value);
					if (this.lmethod_3908(value, null, class_2, arg_2, arg_3))
					{
						arg_0.cmethod_2014(text, bool_);
						this.xmethod_3911(arg_0, value);
					}
					else if (this.smethod_3910(arg_0, value, null, class_2, arg_2, arg_3))
					{
						arg_0.cmethod_2014(text, bool_);
						this.dmethod_3906(arg_0, value, class_2, null, arg_2, arg_3);
					}
				}
				catch (Exception arg_6)
				{
					if (!base.smethod_3850(obj, arg_2, text, null, arg_0.prop_3, arg_6))
					{
						throw;
					}
					this.dmethod_3936(arg_0, sayıInt_);
				}
			}
			arg_0.lmethod_2008();
			this.field_2.RemoveAt(this.field_2.Count - 1);
			this.dmethod_3916(arg_0, arg_2, obj);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00066B28 File Offset: 0x00064D28
		private string vmethod_3935(Class_296 arg_0, object obje_0, Class_349 arg_1, out bool arg_2)
		{
			if (arg_1.field_5 == Class_448.Primitive)
			{
				Class_369 class_ = (Class_369)arg_1;
				if (class_.prop_0 == Class_496.DateTime || class_.prop_0 == Class_496.DateTimeNullable)
				{
					arg_2 = false;
					StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
					Class_502.WriteDateTimeString(stringWriter, (DateTime)obje_0, arg_0.prop_6, arg_0.prop_10, arg_0.prop_11);
					return stringWriter.ToString();
				}
				if (class_.prop_0 == Class_496.DateTimeOffset || class_.prop_0 == Class_496.DateTimeOffsetNullable)
				{
					arg_2 = false;
					StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
					Class_502.WriteDateTimeOffsetString(stringWriter2, (DateTimeOffset)obje_0, arg_0.prop_6, arg_0.prop_10, arg_0.prop_11);
					return stringWriter2.ToString();
				}
				arg_2 = true;
				return Convert.ToString(obje_0, CultureInfo.InvariantCulture);
			}
			else
			{
				string result;
				if (Class_467.gmethod_3913(obje_0, obje_0.GetType(), out result))
				{
					arg_2 = true;
					return result;
				}
				arg_2 = true;
				return obje_0.ToString();
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00066C17 File Offset: 0x00064E17
		private void dmethod_3936(Class_296 arg_0, int sayıInt_0)
		{
			base.pmethod_3849();
			if (arg_0.prop_2 == Class_518.Property)
			{
				arg_0.gmethod_2033();
			}
			while (arg_0.prop_1 > sayıInt_0)
			{
				arg_0.vmethod_2015();
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00066C48 File Offset: 0x00064E48
		private bool kmethod_3937(Class_296 arg_0, Class_454 arg_1, object obje_0)
		{
			if (arg_1.prop_22 == null)
			{
				return true;
			}
			bool flag = arg_1.prop_22(obje_0);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
			{
				this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(null, arg_0.prop_4, "ShouldSerialize result for property '{0}' on {1}: {2}".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_1, arg_1.prop_2, flag)), null);
			}
			return flag;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00066CC8 File Offset: 0x00064EC8
		private bool lmethod_3938(Class_296 arg_0, Class_454 arg_1, object obje_0)
		{
			if (arg_1.prop_23 == null)
			{
				return true;
			}
			bool flag = arg_1.prop_23(obje_0);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
			{
				this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(null, arg_0.prop_4, "IsSpecified result for property '{0}' on {1}: {2}".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_1, arg_1.prop_2, flag)), null);
			}
			return flag;
		}

		// Token: 0x04000B4D RID: 2893
		private Class_349 field_0;

		// Token: 0x04000B4E RID: 2894
		private int field_1;

		// Token: 0x04000B4F RID: 2895
		private readonly List<object> field_2 = new List<object>();

		// Token: 0x04000B50 RID: 2896
		private new Class_468 field_3;
	}
}
