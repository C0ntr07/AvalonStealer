using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200023C RID: 572
	public static class Class_429
	{
		// Token: 0x06001317 RID: 4887 RVA: 0x0005ACDC File Offset: 0x00058EDC
		public static bool IsValid(this Class_361 source, Class_459 schema)
		{
			bool valid = true;
			source.Validate(schema, delegate(object sender, Class_438 args)
			{
				valid = false;
			});
			return valid;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0005AD10 File Offset: 0x00058F10
		public static bool IsValid(this Class_361 source, Class_459 schema, out IList<string> errorMessages)
		{
			IList<string> errors = new List<string>();
			source.Validate(schema, delegate(object sender, Class_438 args)
			{
				errors.Add(args.prop_2);
			});
			errorMessages = errors;
			return errorMessages.Count == 0;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0005AD53 File Offset: 0x00058F53
		public static void Validate(this Class_361 source, Class_459 schema)
		{
			source.Validate(schema, null);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0005AD60 File Offset: 0x00058F60
		public static void Validate(this Class_361 source, Class_459 schema, Class_439 validationEventHandler)
		{
			Class_517.ArgumentNotNull(source, "source");
			Class_517.ArgumentNotNull(schema, "schema");
			using (Class_381 class_ = new Class_381(source.lmethod_2558()))
			{
				class_.prop_8 = schema;
				if (validationEventHandler != null)
				{
					class_.ValidationEventHandler += validationEventHandler;
				}
				while (class_.vmethod_1885())
				{
				}
			}
		}
	}
}
