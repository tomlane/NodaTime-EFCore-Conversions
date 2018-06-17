using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class OffsetValueConverter : ValueConverter<Offset, long>
    {
        public OffsetValueConverter() : base(v => v.Nanoseconds, v => Offset.FromNanoseconds(v))
        { }
    }
}