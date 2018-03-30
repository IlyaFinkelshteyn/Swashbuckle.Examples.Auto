﻿using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Swashbuckle.Examples.Auto.Builders
{
	public class DateTimeOffsetBuilder : SampleBuilderBase
	{
		protected override bool CanHandle(CustomAttributeData attribute, PropertyInfo property)
		{
			bool canHandle = property.PropertyType == typeof(DateTimeOffset);
			return canHandle;
		}

		protected override object GetSampleValue(CustomAttributeData attribute, PropertyInfo property)
		{
			string sortableDate = (string)attribute.ConstructorArguments.First().Value;
			DateTimeOffset value = DateTimeOffset.ParseExact(sortableDate, "s", CultureInfo.InvariantCulture);
			return value;
		}
	}
}