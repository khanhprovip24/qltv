//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.CHITIETMUONs = new HashSet<CHITIETMUON>();
        }
    
        public int MASACH { get; set; }
        public string TENSACH { get; set; }
        public string MOTA { get; set; }
        public string MATL { get; set; }
        public Nullable<int> MANXB { get; set; }
        public Nullable<int> MATACGIA { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<double> DONGIA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONs { get; set; }
        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        public virtual TACGIA TACGIA { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}