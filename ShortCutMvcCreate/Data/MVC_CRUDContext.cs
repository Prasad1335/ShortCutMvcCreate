using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShortCutMvcCreate.Models;

namespace ShortCutMvcCreate.Data
{
    public class MVC_CRUDContext : DbContext
    {
        public MVC_CRUDContext()
        {

        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public MVC_CRUDContext(DbContextOptions<MVC_CRUDContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=WAIANGDESK13\\MSSQLSERVER01;Initial Catalog=MVC_CRUD;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300");
            }
        }

      
      
    }
}
