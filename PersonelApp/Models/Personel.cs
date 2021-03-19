using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelApp.Models
{
    public class Personel
    {
        [Key]
        public int ID { get; set; }
        public string Firma { get; set; }
        public string Yetkili { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime Tarih { get; set; }

        
    }
}