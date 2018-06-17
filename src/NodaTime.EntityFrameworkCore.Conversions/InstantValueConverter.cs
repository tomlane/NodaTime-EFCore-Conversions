using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NodaTime.EntityFrameworkCore.Conversions
{
    public class InstantValueConverter : ValueConverter<Instant, long>
    {
        public InstantValueConverter() : base(v => v.ToUnixTimeTicks(), v => Instant.FromUnixTimeTicks(v))
        { }  
    }
}