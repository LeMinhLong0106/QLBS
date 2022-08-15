//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BT_NHOM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.ChiTietHDs = new HashSet<ChiTietHD>();
            this.ChiTietPNs = new HashSet<ChiTietPN>();
            this.Sach_TG = new HashSet<Sach_TG>();
        }
    
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TenTG { get; set; }
        public System.DateTime NgayXB { get; set; }
        public int SoLuongTon { get; set; }
        public string MoTa { get; set; }
        public string AnhBia { get; set; }
        [Required(ErrorMessage = "Chưa nhập giá sách")]
        [Range(0, 9999999999999999.99)]
        public decimal GiaSach { get; set; }
        public string MaTL { get; set; }
        public string MaNXB { get; set; }
        public string MaNN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPN> ChiTietPNs { get; set; }
        public virtual NgonNgu NgonNgu { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach_TG> Sach_TG { get; set; }
    }
}