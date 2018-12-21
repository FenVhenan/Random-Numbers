using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWD273_W5_L3_CrawJessica.Models
{
    public class RandNumDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<RandNumDB>
    {
        protected override void Seed(RandNumDB context)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            rnd1.Next(1, 69);
            rnd2.Next(1, 21);

            context.RandNums.Add(new RandNum
            {
                
                LgRandNumA = rnd1.Next(1, 69),
                LgRandNumB = rnd1.Next(1, 69),
                LgRandNumC = rnd1.Next(1, 69),
                LgRandNumD = rnd1.Next(1, 69),
                LgRandNumE = rnd1.Next(1, 69),
                SmRandNum = rnd2.Next(1, 21)
            });

            base.Seed(context);
        }
    }
}