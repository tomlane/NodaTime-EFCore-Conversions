using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class ZonedDateTimeValueConverter : ValueConverter<ZonedDateTime, DateTimeOffset>
    {
        public ZonedDateTimeValueConverter() : base(v => v.ToDateTimeOffset(), v => ZonedDateTime.FromDateTimeOffset(v))
        { }
    }
}