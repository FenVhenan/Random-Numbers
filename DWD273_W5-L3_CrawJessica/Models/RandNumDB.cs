using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DWD273_W5_L3_CrawJessica.Models
{
    public class RandNumDB : DbContext
    {
        public DbSet<RandNum> RandNums { get; set; }
    }
}