using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000265 RID: 613
	internal static class Class_461
	{
		// Token: 0x04000AFE RID: 2814
		public const string TypePropertyName = "type";

		// Token: 0x04000AFF RID: 2815
		public const string PropertiesPropertyName = "properties";

		// Token: 0x04000B00 RID: 2816
		public const string ItemsPropertyName = "items";

		// Token: 0x04000B01 RID: 2817
		public const string AdditionalItemsPropertyName = "additionalItems";

		// Token: 0x04000B02 RID: 2818
		public const string RequiredPropertyName = "required";

		// Token: 0x04000B03 RID: 2819
		public const string PatternPropertiesPropertyName = "patternProperties";

		// Token: 0x04000B04 RID: 2820
		public const string AdditionalPropertiesPropertyName = "additionalProperties";

		// Token: 0x04000B05 RID: 2821
		public const string RequiresPropertyName = "requires";

		// Token: 0x04000B06 RID: 2822
		public const string MinimumPropertyName = "minimum";

		// Token: 0x04000B07 RID: 2823
		public const string MaximumPropertyName = "maximum";

		// Token: 0x04000B08 RID: 2824
		public const string ExclusiveMinimumPropertyName = "exclusiveMinimum";

		// Token: 0x04000B09 RID: 2825
		public const string ExclusiveMaximumPropertyName = "exclusiveMaximum";

		// Token: 0x04000B0A RID: 2826
		public const string MinimumItemsPropertyName = "minItems";

		// Token: 0x04000B0B RID: 2827
		public const string MaximumItemsPropertyName = "maxItems";

		// Token: 0x04000B0C RID: 2828
		public const string PatternPropertyName = "pattern";

		// Token: 0x04000B0D RID: 2829
		public const string MaximumLengthPropertyName = "maxLength";

		// Token: 0x04000B0E RID: 2830
		public const string MinimumLengthPropertyName = "minLength";

		// Token: 0x04000B0F RID: 2831
		public const string EnumPropertyName = "enum";

		// Token: 0x04000B10 RID: 2832
		public const string ReadOnlyPropertyName = "readonly";

		// Token: 0x04000B11 RID: 2833
		public const string TitlePropertyName = "title";

		// Token: 0x04000B12 RID: 2834
		public const string DescriptionPropertyName = "description";

		// Token: 0x04000B13 RID: 2835
		public const string FormatPropertyName = "format";

		// Token: 0x04000B14 RID: 2836
		public const string DefaultPropertyName = "default";

		// Token: 0x04000B15 RID: 2837
		public const string TransientPropertyName = "transient";

		// Token: 0x04000B16 RID: 2838
		public const string DivisibleByPropertyName = "divisibleBy";

		// Token: 0x04000B17 RID: 2839
		public const string HiddenPropertyName = "hidden";

		// Token: 0x04000B18 RID: 2840
		public const string DisallowPropertyName = "disallow";

		// Token: 0x04000B19 RID: 2841
		public const string ExtendsPropertyName = "extends";

		// Token: 0x04000B1A RID: 2842
		public const string IdPropertyName = "id";

		// Token: 0x04000B1B RID: 2843
		public const string UniqueItemsPropertyName = "uniqueItems";

		// Token: 0x04000B1C RID: 2844
		public const string OptionValuePropertyName = "value";

		// Token: 0x04000B1D RID: 2845
		public const string OptionLabelPropertyName = "label";

		// Token: 0x04000B1E RID: 2846
		public static readonly IDictionary<string, Class_463> JsonSchemaTypeMapping = new Dictionary<string, Class_463>
		{
			{
				"string",
				Class_463.String
			},
			{
				"object",
				Class_463.Object
			},
			{
				"integer",
				Class_463.Integer
			},
			{
				"number",
				Class_463.Float
			},
			{
				"null",
				Class_463.Null
			},
			{
				"boolean",
				Class_463.Boolean
			},
			{
				"array",
				Class_463.Array
			},
			{
				"any",
				Class_463.Any
			}
		};
	}
}
