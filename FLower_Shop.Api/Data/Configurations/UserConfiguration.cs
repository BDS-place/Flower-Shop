using Flower_Shop.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flower_Shop.Api.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(u => u.UserId);


            builder.Property(u => u.Login).IsRequired().HasMaxLength(128);
            builder.Property(u => u.PasswordHash).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(128);
            builder.Property(u => u.PhoneNumber).HasMaxLength(50);
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).HasMaxLength(50);
            builder.Property(u => u.MiddleName).HasMaxLength(50);

            builder
                .HasIndex(u => u.Login)
                .IsUnique();
            builder
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
