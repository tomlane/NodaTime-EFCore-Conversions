using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class LocalTimeValueConverter : ValueConverter<LocalTime, long>
    {
        public LocalTimeValueConverter() : base(v => v.TickOfDay, v => LocalTime.FromTicksSinceMidnight(v))
        { }
    }
}