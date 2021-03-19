using PersonelApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonelApp.Data
{
    public class VeriTabaniContext : DbContext
    {
        //public VeriTabaniContext() : base("name = PersonelApp")
        //{

        //}
        public DbSet <Personel> Personeller { get; set; }

       
    }
}