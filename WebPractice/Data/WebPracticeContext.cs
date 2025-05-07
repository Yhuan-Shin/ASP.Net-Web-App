using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPractice.Models;

namespace WebPractice.Data
{
    public class WebPracticeContext : DbContext
    {
        public WebPracticeContext (DbContextOptions<WebPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<WebPractice.Models.Account> Account { get; set; } = default!;
    }
}
