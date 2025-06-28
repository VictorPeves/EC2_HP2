using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EC2_HP2.Models;

public partial class IbkDbContext : DbContext
{
    public IbkDbContext()
    {
    }

    public IbkDbContext(DbContextOptions<IbkDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MMAFJE4;Initial Catalog=ibkDB;Integrated Security=SSPI; User ID=sa;Password=12345678;Trust Server Certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC07FD68325B");

            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
