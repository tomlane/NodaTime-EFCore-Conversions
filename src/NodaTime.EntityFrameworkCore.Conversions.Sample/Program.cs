using System;
using System.Linq;

namespace NodaTime.EntityFrameworkCore.Conversions.Sample
{
    partial class Program
    {
        static void Main()
        {
            var timeData = new TimeData
            {
                Duration = Duration.FromMinutes(1),
                Offset = Offset.FromHours(1),
                ZonedDateTime = new ZonedDateTime(Instant.FromDateTimeUtc(DateTime.UtcNow), DateTimeZone.Utc),
                LocalDateTime = LocalDateTime.FromDateTime(DateTime.Today),
                OffsetDateTime = OffsetDateTime.FromDateTimeOffset(DateTimeOffset.UtcNow),
                LocalDate = LocalDate.FromDateTime(DateTime.Today),
                Instant = Instant.FromDateTimeUtc(DateTime.UtcNow),
                LocalTime = new LocalTime(18, 6),
                Id = Guid.NewGuid()
            };

            var context = new NodaTimeContext();

            context.TimeData.Add(timeData);
            context.SaveChanges();

            var newData = context.TimeData.FirstOrDefault(x => x.Id == timeData.Id);

            Console.WriteLine($"Duration: {newData.Duration}. Offset: {newData.Offset}. ZonedDateTime: {newData.ZonedDateTime}. " +
                              $"LocalDateTime: {newData.LocalDateTime}. OffsetDateTime: {newData.LocalDateTime}. LocalDate: {newData.LocalDate}. " +
                              $"LocalTime: {newData.LocalTime}. Id: {newData.Id}.");
            Console.ReadLine();
        }
    }
}
