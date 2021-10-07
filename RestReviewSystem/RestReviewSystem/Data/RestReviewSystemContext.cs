using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestReviewSystem.Models;

namespace RestReviewSystem.Data
{
    public class RestReviewSystemContext : DbContext
    {
        public RestReviewSystemContext (DbContextOptions<RestReviewSystemContext> options)
            : base(options)
        {
        }

        public DbSet<RestReviewSystem.Models.Customer> Customer { get; set; }

        public DbSet<RestReviewSystem.Models.CustomerReview> CustomerReview { get; set; }

        public DbSet<RestReviewSystem.Models.Restaurant> Restaurant { get; set; }

        public DbSet<RestReviewSystem.Models.ReviewCategory> ReviewCategory { get; set; }
    }
}
