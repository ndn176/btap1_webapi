using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models;

public partial class CSDLBanhang : DbContext
{
    public CSDLBanhang()
    {
    }

    public CSDLBanhang(DbContextOptions<CSDLBanhang> options)
        : base(options)
    {
    }

    public virtual DbSet<TblHangHoa> TblHangHoas { get; set; } = null!;

}
