﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYKHO.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYKHOEntities : DbContext
    {
        public QUANLYKHOEntities()
            : base("name=QUANLYKHOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DanhMucThietBi> DanhMucThietBi { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHang { get; set; }
        public virtual DbSet<PhieuXuatHang> PhieuXuatHang { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThongTinThietBi> ThongTinThietBi { get; set; }
        public virtual DbSet<VaiTro> VaiTro { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuat { get; set; }
    }
}