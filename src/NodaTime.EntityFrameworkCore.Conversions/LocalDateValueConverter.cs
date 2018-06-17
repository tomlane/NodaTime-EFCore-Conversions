using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class LocalDateValueConverter : ValueConverter<LocalDate, DateTime>
    {
        public LocalDateValueConverter() : base(v => v.ToDateTimeUnspecified(), v => LocalDate.FromDateTime(v))
        { }
    }
}