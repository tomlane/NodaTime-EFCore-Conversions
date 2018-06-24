using Microsoft.EntityFrameworkCore;

namespace NodaTime.EntityFrameworkCore.Conversions.Sample
{
    partial class Program
    {
        internal class NodaTimeContext : DbContext
        {
            public NodaTimeContext()
            { }

            public NodaTimeContext(DbContextOptions<NodaTimeContext> contextOptions)
            : base(contextOptions)
            { }

            public DbSet<TimeData> TimeData { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseInMemoryDatabase("NodaTimeSample");

                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.Duration)
                    .HasConversion(new DurationValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.Instant)
                    .HasConversion(new InstantValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.LocalDateTime)
                    .HasConversion(new LocalDateTimeValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.LocalDate)
                    .HasConversion(new LocalDateValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.LocalTime)
                    .HasConversion(new LocalTimeValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.OffsetDateTime)
                    .HasConversion(new OffsetDateTimeValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.Offset)
                    .HasConversion(new OffsetValueConverter());

                modelBuilder
                    .Entity<TimeData>()
                    .Property(p => p.ZonedDateTime)
                    .HasConversion(new ZonedDateTimeValueConverter());

                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
