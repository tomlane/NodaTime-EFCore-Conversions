using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class DurationValueConverter : ValueConverter<Duration, TimeSpan>
    {
        public DurationValueConverter() : base(v => v.ToTimeSpan(), v => Duration.FromTimeSpan(v))
        { }
    }
}