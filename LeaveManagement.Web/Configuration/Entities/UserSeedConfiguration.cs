using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "408aa945-3d84-4421-8342-7269ec64d949",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    TaxId = string.Empty,
                    PasswordHash = hasher.HashPassword(null, "P@$$w0rd"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "3f4631bd-f907-4409-b416-ba356312e659",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName= "user@localhost.com",
                    Firstname = "System",
                    Lastname = "User",
                    TaxId = string.Empty,
                    PasswordHash = hasher.HashPassword(null, "P@$$w0rd"),
                    EmailConfirmed = true
                }

                );
        }
    }
}