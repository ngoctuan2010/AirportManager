namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenBay")]
    public partial class ChuyenBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenBay()
        {
            CongViecs = new HashSet<CongViec>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int IDChuyenBay { get; set; }

        public int? IDMayBay { get; set; }

        public int? SoHieuChuyenBay { get; set; }

        [StringLength(50)]
        public string NoiKhoiHanh { get; set; }

        [StringLength(50)]
        public string NoiDen { get; set; }

        public DateTime? GioKhoiHanh { get; set; }

        public DateTime? GioDen { get; set; }

        [StringLength(20)]
        public string HangBay { get; set; }

        public virtual MayBay MayBay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongViec> CongViecs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
