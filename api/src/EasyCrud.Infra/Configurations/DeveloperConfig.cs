using EasyCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCrud.Infra.Configurations
{
    public class DeveloperConfig : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.Ignore(P => P.CascadeMode);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Portfolio)
                .HasColumnName("Portfolio")
                .HasMaxLength(50);

            builder.Property(p => p.HourlySalary)
                .HasColumnName("HourlySalary")
                .HasColumnType("decimal(9, 2)")
                .IsRequired();

            builder.OwnsOne(p => p.Contact)
                .Property(p => p.Phone)
                .HasColumnName("Phone")
                .IsRequired();

            builder.OwnsOne(p => p.Contact)
                .Property(p => p.Linkedin)
                .HasColumnName("Linkedin");

            builder.OwnsOne(p => p.Address)
                .Property(p => p.City)
                .HasColumnName("City")
                .IsRequired();

            builder.OwnsOne(p => p.Address)
                .Property(p => p.State)
                .HasColumnName("State")
                .IsRequired();

            builder.ToTable("Developers");
        }
    }
}
