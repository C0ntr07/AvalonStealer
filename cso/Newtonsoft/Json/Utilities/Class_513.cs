using System;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002C1 RID: 705
	internal static class Class_513
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x0006E8FC File Offset: 0x0006CAFC
		public static bool ValueEquals(object objA, object objB)
		{
			if (objA == null && objB == null)
			{
				return true;
			}
			if (objA != null && objB == null)
			{
				return false;
			}
			if (objA == null && objB != null)
			{
				return false;
			}
			if (!(objA.GetType() != objB.GetType()))
			{
				return objA.Equals(objB);
			}
			if (Class_499.IsInteger(objA) && Class_499.IsInteger(objB))
			{
				return Convert.ToDecimal(objA, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(objB, CultureInfo.CurrentCulture));
			}
			return (objA is double || objA is float || objA is decimal) && (objB is double || objB is float || objB is decimal) && Class_511.ApproxEquals(Convert.ToDouble(objA, CultureInfo.CurrentCulture), Convert.ToDouble(objB, CultureInfo.CurrentCulture));
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0006E9E8 File Offset: 0x0006CBE8
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			string message2 = message + Environment.NewLine + "Actual value was {0}.".FormatWith(CultureInfo.InvariantCulture, actualValue);
			return new ArgumentOutOfRangeException(paramName, message2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0006EA18 File Offset: 0x0006CC18
		public static string ToString(object value)
		{
			if (value == null)
			{
				return "{null}";
			}
			if (!(value is string))
			{
				return value.ToString();
			}
			return "\"" + value.ToString() + "\"";
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0006EA50 File Offset: 0x0006CC50
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			int num = a1.Length.CompareTo(a2.Length);
			if (num != 0)
			{
				return num;
			}
			for (int i = 0; i < a1.Length; i++)
			{
				int num2 = a1[i].CompareTo(a2[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return 0;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		public static string GetPrefix(string qualifiedName)
		{
			string result;
			string text;
			Class_513.GetQualifiedNameParts(qualifiedName, out result, out text);
			return result;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0006EAB8 File Offset: 0x0006CCB8
		public static string GetLocalName(string qualifiedName)
		{
			string text;
			string result;
			Class_513.GetQualifiedNameParts(qualifiedName, out text, out result);
			return result;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			int num = qualifiedName.IndexOf(':');
			if (num == -1 || num == 0 || qualifiedName.Length - 1 == num)
			{
				prefix = null;
				localName = qualifiedName;
				return;
			}
			prefix = qualifiedName.Substring(0, num);
			localName = qualifiedName.Substring(num + 1);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0006EB1D File Offset: 0x0006CD1D
		internal static string FormatValueForPrint(object value)
		{
			if (value == null)
			{
				return "{null}";
			}
			if (value is string)
			{
				return "\"" + value + "\"";
			}
			return value.ToString();
		}
	}
}
