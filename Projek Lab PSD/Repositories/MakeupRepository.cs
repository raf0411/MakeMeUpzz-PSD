using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class MakeupRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<Makeup> GetMakeups()
        {
            return (from x in db.Makeups select x).ToList();
        }

        public int GetLastMakeupID()
        {
            return (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
        }

        public void InsertMakeup(int MakeupID, String MakeupName, int MakeupPrice, int MakeupWeight, int MakeupTypeID, int MakeupBrandID)
        {
            Makeup makeup = MakeupFactory.Create(MakeupID, MakeupName, MakeupPrice, MakeupWeight, MakeupTypeID, MakeupBrandID);
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public void DeleteMakeupByID(int MakeupID)
        {
            Makeup makeup = db.Makeups.Find(MakeupID);
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }

        public Makeup GetMakeupByID(int MakeupID)
        {
            return db.Makeups.Find(MakeupID);
        }

        public void UpdateMakeupByID(int MakeupID, String MakeupName, int MakeupPrice, int MakeupWeight, int MakeupTypeID, int MakeupBrandID)
        {
            Makeup updateMakeup = GetMakeupByID(MakeupID);
            updateMakeup.MakeupID = MakeupID;
            updateMakeup.MakeupName = MakeupName;
            updateMakeup.MakeupPrice = MakeupPrice;
            updateMakeup.MakeupWeight= MakeupWeight;
            updateMakeup.MakeupTypeID = MakeupTypeID;
            updateMakeup.MakeupBrandID = MakeupBrandID;

            db.SaveChanges();
        }
    }


}