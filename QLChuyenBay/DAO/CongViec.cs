namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongViec")]
    public partial class CongViec
    {
        [Key]
        public DateTime NgayGiaoViec { get; set; }

        [StringLength(50)]
        public string MoTaCongViec { get; set; }

        [StringLength(50)]
        public string TinhTrangCongViec { get; set; }

        public int? IDNhanVien { get; set; }

        public int? IDChuyenBay { get; set; }

        public virtual ChuyenBay ChuyenBay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
