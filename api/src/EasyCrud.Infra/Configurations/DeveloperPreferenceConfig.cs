using EasyCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCrud.Infra.Configurations
{
    public class DeveloperPreferenceConfig : IEntityTypeConfiguration<DeveloperPreference>
    {
        public void Configure(EntityTypeBuilder<DeveloperPreference> builder)
        {
            builder.Ignore(P => P.CascadeMode);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.DeveloperId)
                .HasColumnName("DeveloperId")
                .IsRequired();

            builder.OwnsOne(p => p.Willingness)
                .Property(p => p.UpToFourHoursPerDay)
                .HasColumnName("UpToFourHoursPerDay");

            builder.OwnsOne(p => p.Willingness)
                .Property(p => p.FourToSixHoursPerDay)
                .HasColumnName("FourToSixHoursPerDay");

            builder.OwnsOne(p => p.Willingness)
                .Property(p => p.SixtoEightHoursPerDay)
                .HasColumnName("sixtoEightHoursPerDay");

            builder.OwnsOne(p => p.Willingness)
                .Property(p => p.UpToEightHoursADay)
                .HasColumnName("UpToEightHoursADay");

            builder.OwnsOne(p => p.Willingness)
                .Property(p => p.OnlyWeekends)
                .HasColumnName("OnlyWeekends");

            builder.OwnsOne(p => p.WorkTime)
                .Property(p => p.Morning)
                .HasColumnName("Morning");

            builder.OwnsOne(p => p.WorkTime)
                .Property(p => p.Afternoon)
                .HasColumnName("Afternoon");

            builder.OwnsOne(p => p.WorkTime)
                .Property(p => p.Night)
                .HasColumnName("Night");

            builder.OwnsOne(p => p.WorkTime)
                .Property(p => p.Dawn)
                .HasColumnName("Dawn");

            builder.OwnsOne(p => p.WorkTime)
                .Property(p => p.Business)
                .HasColumnName("Business");

            builder.HasOne(p => p.Developer)
                .WithOne(p => p.Preference)
                .HasForeignKey<DeveloperPreference>(p => p.DeveloperId);

            builder.ToTable("DevelopersPreferences");
        }
    }
}
