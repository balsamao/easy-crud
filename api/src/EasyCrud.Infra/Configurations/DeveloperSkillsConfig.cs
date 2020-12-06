using EasyCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCrud.Infra.Configurations
{
    public class DeveloperSkillsConfig : IEntityTypeConfiguration<DeveloperSkills>
    {
        public void Configure(EntityTypeBuilder<DeveloperSkills> builder)
        {
            builder.Ignore(P => P.CascadeMode);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.AditionalInformation)
                .HasColumnName("AditionalInformation");

            builder.Property(p => p.LinkCrud)
                .HasColumnName("LinkCrud");

            builder.Property(p => p.DeveloperId)
                .HasColumnName("DeveloperId")
                .IsRequired();

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Ionic)
                .HasColumnName("Ionic");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.ReactJS)
                .HasColumnName("ReactJS");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.ReactNative)
                .HasColumnName("ReactNative");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Android)
                .HasColumnName("Android");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Flutter)
                .HasColumnName("Flutter");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.SWIFT)
                .HasColumnName("SWIFT");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.IOS)
                .HasColumnName("IOS");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.HTML)
                .HasColumnName("HTML");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.CSS)
                .HasColumnName("CSS");

            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Bootstrap)
                .HasColumnName("Bootstrap");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Jquery)
                .HasColumnName("Jquery");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.AngularJs)
                .HasColumnName("AngularJs");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Angular)
                .HasColumnName("Angular");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Java)
                .HasColumnName("Java");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Python)
                .HasColumnName("Python");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Flask)
                .HasColumnName("Flask");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.AspNetMVC)
                .HasColumnName("AspNetMVC");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.AspNetWebForm)
                .HasColumnName("AspNetWebForm");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.C)
                .HasColumnName("C");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Csharp)
                .HasColumnName("Csharp");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.NodeJS)
                .HasColumnName("NodeJS");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.ExpressNodeJs)
                .HasColumnName("ExpressNodeJs");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Cake)
                .HasColumnName("Cake");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Django)
                .HasColumnName("Django");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Majento)
                .HasColumnName("Majento");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.PHP)
                .HasColumnName("PHP");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Vue)
                .HasColumnName("Vue");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Wordpress)
                .HasColumnName("Wordpress");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Ruby)
                .HasColumnName("Ruby");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.MySQLServer)
                .HasColumnName("MySQLServer");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.MySQL)
                .HasColumnName("MySQL");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Salesforce)
                .HasColumnName("Salesforce");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Photoshop)
                .HasColumnName("Photoshop");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Illustrator)
                .HasColumnName("Illustrator");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.SEO)
                .HasColumnName("SEO");
            
            builder.OwnsOne(p => p.Knowledge)
                .Property(p => p.Laravel)
                .HasColumnName("Laravel");

            builder.HasOne(p => p.Developer)
                .WithOne(p => p.Skills)
                .HasForeignKey<DeveloperSkills>(p => p.DeveloperId);

            builder.ToTable("DevelopersSkills");
        }
    }
}
