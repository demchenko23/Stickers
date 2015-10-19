using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibForStikersDB;

namespace Stikers
{
    public class ToDB
    {
        public List<StikerInfo> GetInfo()
        {
            using (var db = new StikerModel())
            {
                var allStikers = db.StikerInfoes.Select(stikers => stikers).ToList();
                return allStikers;
            };
        }
        public string AddInfo(string text, string uid, string type)
        {
            int uId;
            bool n = Int32.TryParse(uid, out uId);
            
            using (var db = new StikerModel())
            {
                var findStikers = db.StikerInfoes.FirstOrDefault(stiker => stiker.Id == uId);
                if (findStikers == null)
                {
                    var newStiker = new StikerInfo()
                    {
                        StikerType = type,
                        Text = text
                    };
                    db.StikerInfoes.Add(newStiker);
                    db.SaveChanges();
                    if (uId == 0)
                    {
                        uId = db.StikerInfoes.Max(stiker => stiker.Id);
                    }                    
                }
                else
                {
                    findStikers.StikerType = type;
                    findStikers.Text = text;
                    db.SaveChanges();
                }
               return uId.ToString();
            }
        }
        public void DeleteInfo(string uid)
        {
            int uId;
            bool n = Int32.TryParse(uid, out uId);
            
            using (var db = new StikerModel())
            {
                var findStikers = db.StikerInfoes.FirstOrDefault(stiker => stiker.Id == uId);
                if (findStikers != null)
                {
                    db.StikerInfoes.Remove(findStikers);
                    db.SaveChanges();
                }
               
            }
        }
    }
}
