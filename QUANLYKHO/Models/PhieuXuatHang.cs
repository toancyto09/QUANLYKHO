//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PhieuXuatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatHang()
        {
            this.ChiTietPhieuXuat = new HashSet<ChiTietPhieuXuat>();
        }
    
        public string maPhieuXuat { get; set; }
        public string maNguoiDung { get; set; }
        public System.DateTime ngayXuat { get; set; }
        public string trangThai { get; set; }
        public string ghiChu { get; set; }
        public string nhanVienXuat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuXuat> ChiTietPhieuXuat { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
