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
    
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            this.DOCGIAs = new HashSet<DOCGIA>();
        }
    
        public int MATK { get; set; }
        public string TENDN { get; set; }
        public string MATKHAU { get; set; }
        public Nullable<System.DateTime> NGAYDANGKY { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public string MALOAITK { get; set; }
        public string HOTEN { get; set; }
        public string EMAIL { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCGIA> DOCGIAs { get; set; }
        public virtual LOAITAIKHOAN LOAITAIKHOAN { get; set; }
    }
}
