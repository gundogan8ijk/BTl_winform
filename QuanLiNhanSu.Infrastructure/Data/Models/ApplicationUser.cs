using System;
using Microsoft.AspNetCore.Identity;

namespace QuanLiNhanSu.Infrastructure.Data.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    public DateTime LastModified { get; set; }
    public DateTime ActivatedAt { get; set; }
    public string? ReasonLock { get; set; }
}

public class ApplicationRole : IdentityRole<Guid>
{
    public int ValueRole { get; set; }
}
