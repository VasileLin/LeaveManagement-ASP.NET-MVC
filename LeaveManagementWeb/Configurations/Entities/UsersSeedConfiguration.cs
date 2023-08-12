using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UsersSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee{
                    Id = "72a856f4-0797-4d8d-9be6-c10d8d17a93d",
                    Email = "vasile.linga1@gmail.com",
                    
                    NormalizedEmail = "VASILE.LINGA1@GMAIL.COM",
                    UserName = "vasile.linga1@gmail.com",
                    NormalizedUserName = "VASILE.LINGA1@GMAIL.COM",
                    FirstName = "Linga",
                    LastName = "Vasile",
                    PasswordHash = hasher.HashPassword(null, "Vasile123+"),
                    EmailConfirmed=true
                    
                }
               );
        }
    }
}