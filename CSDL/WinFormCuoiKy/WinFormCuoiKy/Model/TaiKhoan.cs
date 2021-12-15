namespace WinFormCuoiKy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Windows.Forms;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [StringLength(15)]
        public string id { get; set; }

        [Required]
        [StringLength(15)]
        public string pass { get; set; }

        [Required]
        [StringLength(25)]
        public string role { get; set; }
    }
   
}
