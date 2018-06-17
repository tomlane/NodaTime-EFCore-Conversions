using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class LocalDateTimeValueConverter : ValueConverter<LocalDateTime, DateTime>
    {
        public LocalDateTimeValueConverter() : base(v => v.ToDateTimeUnspecified(), v => LocalDateTime.FromDateTime(v))
        { }
    }
}