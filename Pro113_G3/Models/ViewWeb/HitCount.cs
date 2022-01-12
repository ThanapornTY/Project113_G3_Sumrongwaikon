using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace Pro113_G3.Models.ViewWeb
{
    public class HitCount
    {
        public void AddCount(HitCounter HC)
        {
            using (ViewWebEntities dc = new ViewWebEntities())
            {
                DateTime today = DateTime.Now.Date;
                // This code is for check unique ip per day only
                var v = dc.HitCounters.Where(a => a.IPAddress.Equals(HC.IPAddress) && EntityFunctions.TruncateTime(a.CreateDate) == today).FirstOrDefault();
                if (v == null)
                {
                    dc.HitCounters.Add(HC);
                    dc.SaveChanges();
                }
            }

        }

        public object[] GetCount()
        {
            object[] o = new object[2];
            using (ViewWebEntities dc = new ViewWebEntities())
            {
                DateTime today = DateTime.Now.Date;
                //รับค่าเฉพาะวัน
                o[0] = dc.HitCounters.Where(a => EntityFunctions.TruncateTime(a.CreateDate) == today).Count();

                // รับค่ารวม
                o[1] = dc.HitCounters.Count();
            }
            return o;
        }
    }
}