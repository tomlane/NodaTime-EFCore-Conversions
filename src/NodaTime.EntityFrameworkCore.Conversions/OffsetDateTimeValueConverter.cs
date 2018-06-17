using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class OffsetDateTimeValueConverter : ValueConverter<OffsetDateTime, DateTimeOffset>
    {
        public OffsetDateTimeValueConverter() : base(v => v.ToDateTimeOffset(), v => OffsetDateTime.FromDateTimeOffset(v))
        { }
    }
}