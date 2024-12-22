#nullable disable
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebApi.Models
{
    [Table("tblHangHoa")]
    public partial class TblHangHoa
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("MA")]
        public string Ma { get; set; }

        [Column("TEN")]
        public string Ten { get; set; }

        [Column("DONVI")]
        public string Donvi { get; set; }

        [Column("GIANHAP")]
        public float Gianhap { get; set; }

        [Column("GIABAN")]
        public float Giaban { get; set; }

        [Column("NGUOITAO")]
        public string Nguoitao { get; set; }

        [Column("NGAYTAO")]
        public DateTime? Ngaytao { get; set; }
        [NotMapped]
        [JsonIgnore] 
        public string[] DonviArray
        {
            get => Donvi?.Split(',') ?? new string[0]; 
            set => Donvi = value != null ? string.Join(",", value) : "";
        }
    }
}

