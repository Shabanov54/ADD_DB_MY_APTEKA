using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ADD_DB_My_Apteka
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Apt> My_Apteka_DB { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=10.32.10.171;UserId=shabanov;Password=ZybrbnfZdfvgbh54;database=My_Apteka;");
        }
    }
}