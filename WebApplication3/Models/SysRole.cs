namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysRole")]
    public partial class SysRole
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string RoleNum { get; set; }
    }
}
