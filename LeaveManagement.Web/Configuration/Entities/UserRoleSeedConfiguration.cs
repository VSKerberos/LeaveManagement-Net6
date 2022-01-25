using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId="408aa945-3d84-4421-8342-7269ec64d949",
                    RoleId="cac43a6e-f7bb-4448-baaf-1add431ccbbf"
                },
               new IdentityUserRole<string>  {
                    
                   UserId = "3f4631bd-f907-4409-b416-ba356312e659",
                    RoleId = "cab83a6e-f9aa-4448-bcaf-1add431erbbf"
                }
                );
        }
    }
}