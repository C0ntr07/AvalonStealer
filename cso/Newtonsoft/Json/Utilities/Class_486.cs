using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000297 RID: 663
	internal static class Class_486
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x00069F84 File Offset: 0x00068184
		internal static bool IsEndToken(Class_508 token)
		{
			switch (token)
			{
			case Class_508.EndObject:
			case Class_508.EndArray:
			case Class_508.EndConstructor:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00069FB0 File Offset: 0x000681B0
		internal static bool IsStartToken(Class_508 token)
		{
			switch (token)
			{
			case Class_508.StartObject:
			case Class_508.StartArray:
			case Class_508.StartConstructor:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00069FDC File Offset: 0x000681DC
		internal static bool IsPrimitiveToken(Class_508 token)
		{
			switch (token)
			{
			case Class_508.Integer:
			case Class_508.Float:
			case Class_508.String:
			case Class_508.Boolean:
			case Class_508.Null:
			case Class_508.Undefined:
			case Class_508.Date:
			case Class_508.Bytes:
				return true;
			}
			return false;
		}
	}
}
