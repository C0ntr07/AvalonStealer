using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019D RID: 413
	public class Class_302 : Class_299
	{
		// Token: 0x06000BF4 RID: 3060 RVA: 0x00042A2C File Offset: 0x00040C2C
		public virtual void lmethod_2148(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			DataTable dataTable = (DataTable)obje_0;
			Class_441 class_ = arg_1.prop_14 as Class_441;
			arg_0.pmethod_2009();
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				arg_0.kmethod_2007();
				foreach (object obj2 in dataRow.Table.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj2;
					if (arg_1.prop_8 != Class_457.Ignore || (dataRow[dataColumn] != null && dataRow[dataColumn] != DBNull.Value))
					{
						arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590(dataColumn.ColumnName) : dataColumn.ColumnName);
						arg_1.kmethod_3177(arg_0, dataRow[dataColumn]);
					}
				}
				arg_0.lmethod_2008();
			}
			arg_0.smethod_2010();
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00042B70 File Offset: 0x00040D70
		public virtual object pmethod_2149(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			DataTable dataTable = obje_0 as DataTable;
			if (dataTable == null)
			{
				dataTable = ((arg_1 == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(arg_1)));
			}
			if (arg_0.prop_9 == Class_508.PropertyName)
			{
				dataTable.TableName = (string)arg_0.prop_10;
				Class_302.tmethod_2152(arg_0);
			}
			if (arg_0.prop_9 != Class_508.StartArray)
			{
				throw Class_417.xmethod_3101(arg_0, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			Class_302.tmethod_2152(arg_0);
			while (arg_0.prop_9 != Class_508.EndArray)
			{
				Class_302.smethod_2150(arg_0, dataTable);
				Class_302.tmethod_2152(arg_0);
			}
			return dataTable;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00042C28 File Offset: 0x00040E28
		private static void smethod_2150(Class_285 arg_0, DataTable arg_1)
		{
			DataRow dataRow = arg_1.NewRow();
			Class_302.tmethod_2152(arg_0);
			while (arg_0.prop_9 == Class_508.PropertyName)
			{
				string text = (string)arg_0.prop_10;
				Class_302.tmethod_2152(arg_0);
				DataColumn dataColumn = arg_1.Columns[text];
				if (dataColumn == null)
				{
					Type dataType = Class_302.xmethod_2151(arg_0);
					dataColumn = new DataColumn(text, dataType);
					arg_1.Columns.Add(dataColumn);
				}
				if (dataColumn.DataType == typeof(DataTable))
				{
					if (arg_0.prop_9 == Class_508.StartArray)
					{
						Class_302.tmethod_2152(arg_0);
					}
					DataTable dataTable = new DataTable();
					while (arg_0.prop_9 != Class_508.EndArray)
					{
						Class_302.smethod_2150(arg_0, dataTable);
						Class_302.tmethod_2152(arg_0);
					}
					dataRow[text] = dataTable;
				}
				else if (dataColumn.DataType.IsArray && dataColumn.DataType != typeof(byte[]))
				{
					if (arg_0.prop_9 == Class_508.StartArray)
					{
						Class_302.tmethod_2152(arg_0);
					}
					List<object> list = new List<object>();
					while (arg_0.prop_9 != Class_508.EndArray)
					{
						list.Add(arg_0.prop_10);
						Class_302.tmethod_2152(arg_0);
					}
					Array array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
					Array.Copy(list.ToArray(), array, list.Count);
					dataRow[text] = array;
				}
				else
				{
					dataRow[text] = (arg_0.prop_10 ?? DBNull.Value);
				}
				Class_302.tmethod_2152(arg_0);
			}
			dataRow.EndEdit();
			arg_1.Rows.Add(dataRow);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00042DC4 File Offset: 0x00040FC4
		private static Type xmethod_2151(Class_285 arg_0)
		{
			Class_508 class_ = arg_0.prop_9;
			switch (class_)
			{
			case Class_508.StartArray:
			{
				Class_302.tmethod_2152(arg_0);
				if (arg_0.prop_9 == Class_508.StartObject)
				{
					return typeof(DataTable);
				}
				Type type = Class_302.xmethod_2151(arg_0);
				return type.MakeArrayType();
			}
			case Class_508.Integer:
			case Class_508.Float:
			case Class_508.String:
			case Class_508.Boolean:
			case Class_508.Date:
			case Class_508.Bytes:
				return arg_0.prop_11;
			case Class_508.Null:
			case Class_508.Undefined:
				return typeof(string);
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected JSON token when reading DataTable: {0}".FormatWith(CultureInfo.InvariantCulture, class_));
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00042E7F File Offset: 0x0004107F
		private static void tmethod_2152(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading DataTable.");
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00042E98 File Offset: 0x00041098
		public virtual bool gmethod_2153(Type arg_0)
		{
			return typeof(DataTable).IsAssignableFrom(arg_0);
		}
	}
}
