using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibForStikersDB;

namespace Stikers
{
    class LoadFromDB
    {
        public void LoadInfo()
        {
            var toDb = new ToDB();
            var getStikers = toDb.GetInfo();
            if (getStikers.Count() > 0)
            {
                foreach (var stiker in getStikers)
                {
                    if (stiker.StikerType == "standart")
                    {
                        WindowStandart standart = new WindowStandart();
                        standart.textFirst.Text = stiker.Text;
                        standart.textFirst.Tag = stiker.StikerType;
                        standart.textFirst.Uid = Convert.ToString(stiker.Id);
                        standart.Show();
                    }
                    else if (stiker.StikerType == "cloud")
                    {
                        WindowCloud cloud = new WindowCloud();
                        cloud.textCloud.Text = stiker.Text;
                        cloud.textCloud.Tag = stiker.StikerType;
                        cloud.textCloud.Uid = Convert.ToString(stiker.Id);
                        cloud.Show();
                    }
                    else if (stiker.StikerType == "heart")
                    {
                        WindowHeart heart = new WindowHeart();
                        heart.textHeart.Text = stiker.Text;
                        heart.textHeart.Tag = stiker.StikerType;
                        heart.textHeart.Uid = Convert.ToString(stiker.Id);
                        heart.Show();
                    }
                }
            }
        }
    }
}
