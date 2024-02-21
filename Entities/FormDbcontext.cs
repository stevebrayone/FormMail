using FormMail.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FormMail.Entities
{
    public class FormDbcontext : DbContext
    {
        public FormDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<FormModel> FormTable { get; set; }
    }
}
