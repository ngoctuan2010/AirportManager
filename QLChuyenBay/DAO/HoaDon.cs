namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int IDHoaDon { get; set; }

        [StringLength(10)]
        public string MaGhe { get; set; }

        [StringLength(10)]
        public string HangGhe { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDChuyenBay { get; set; }

        public virtual ChuyenBay ChuyenBay { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
