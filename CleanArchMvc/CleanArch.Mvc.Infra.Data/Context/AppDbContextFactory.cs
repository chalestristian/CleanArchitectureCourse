using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Infra.Data.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>

    {

        public ApplicationDbContext CreateDbContext(string[] args)

        {

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-L4KVDVA;Initial Catalog=CleanArchMcvDb;Integrated Security=True");

            return new ApplicationDbContext(optionsBuilder.Options);

        }

    }}
