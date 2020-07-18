using System;
using System.Data;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019C RID: 412
	public class Class_301 : Class_299
	{
		// Token: 0x06000BEF RID: 3055 RVA: 0x000428A4 File Offset: 0x00040AA4
		public virtual void cmethod_2144(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			DataSet dataSet = (DataSet)obje_0;
			Class_441 class_ = arg_1.prop_14 as Class_441;
			Class_302 class_2 = new Class_302();
			arg_0.kmethod_2007();
			foreach (object obj in dataSet.Tables)
			{
				DataTable dataTable = (DataTable)obj;
				arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590(dataTable.TableName) : dataTable.TableName);
				class_2.tmethod_2132(arg_0, dataTable, arg_1);
			}
			arg_0.lmethod_2008();
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00042958 File Offset: 0x00040B58
		public virtual object vmethod_2145(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			DataSet dataSet = (arg_1 == typeof(DataSet)) ? new DataSet() : ((DataSet)Activator.CreateInstance(arg_1));
			Class_302 class_ = new Class_302();
			this.kmethod_2147(arg_0);
			while (arg_0.prop_9 == Class_508.PropertyName)
			{
				DataTable dataTable = dataSet.Tables[(string)arg_0.prop_10];
				bool flag = dataTable != null;
				dataTable = (DataTable)class_.gmethod_2133(arg_0, typeof(DataTable), dataTable, arg_2);
				if (!flag)
				{
					dataSet.Tables.Add(dataTable);
				}
				this.kmethod_2147(arg_0);
			}
			return dataSet;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000429FE File Offset: 0x00040BFE
		public virtual bool dmethod_2146(Type arg_0)
		{
			return typeof(DataSet).IsAssignableFrom(arg_0);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00042A10 File Offset: 0x00040C10
		private void kmethod_2147(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading DataSet.");
			}
		}
	}
}
