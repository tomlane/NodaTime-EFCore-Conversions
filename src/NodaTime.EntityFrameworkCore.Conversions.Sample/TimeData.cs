using System;

namespace NodaTime.EntityFrameworkCore.Conversions.Sample
{
    internal class TimeData
    {
        public Guid Id { get; set; }

        public Duration Duration { get; set; }
        public Instant Instant { get; set; }
        public LocalDateTime LocalDateTime { get; set; }
        public LocalDate LocalDate { get; set; }
        public LocalTime LocalTime { get; set; }
        public OffsetDateTime OffsetDateTime { get; set; }
        public Offset Offset { get; set; }
        public ZonedDateTime ZonedDateTime { get; set; }
    }
}