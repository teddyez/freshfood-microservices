using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Identity.Application.Interfaces;

public interface IIdentityServiceDbContext
{
    DbSet<User> Users { get; }
    DbSet<IdentityRole<Guid>> Roles { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}