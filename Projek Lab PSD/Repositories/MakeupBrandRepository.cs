using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class MakeupBrandRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<MakeupBrand> GetMakeupBrands()
        {
            return (from x in db.MakeupBrands select x).ToList();
        }

        public int GetLastMakeupBrandID()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();
        }

        public MakeupBrand GetMakeupBrandByID(int MakeupBrandID)
        {
            return db.MakeupBrands.Find(MakeupBrandID);
        }

        public List<String> GetMakeupBrandNames()
        {
            return (from x in db.MakeupBrands 
                    select x.MakeupBrandName).ToList();
        }

        public int GetMakeupBrandIDByName(String name)
        {
            return (from x in db.MakeupBrands
                    where x.MakeupBrandName.Equals(name)
                    select x.MakeupBrandID).FirstOrDefault();
        }

        public String GetMakeupBrandNameByID(int MakeupBrandID)
        {
            return (from x in db.MakeupBrands
                    where x.MakeupBrandID == MakeupBrandID
                    select x.MakeupBrandName).FirstOrDefault();
        }

        public void InsertMakeupBrand(int MakeupBrandID, String MakeupBrandName, int MakeupRating)
        {
            MakeupBrand makeupBrand = MakeupBrandFactory.Create(MakeupBrandID, MakeupBrandName, MakeupRating);
            db.MakeupBrands.Add(makeupBrand);
            db.SaveChanges();
        }

        public void DeleteMakeupBrandByID(int MakeupBrandID)
        {
            MakeupBrand makeupBrand = db.MakeupBrands.Find(MakeupBrandID);
            db.MakeupBrands.Remove(makeupBrand);
            db.SaveChanges();
        }

        public void UpdateMakeupBrandByID(int MakeupBrandID, String MakeupBrandName, int MakeupBrandRating)
        {
            MakeupBrand updateMakeupBrand = GetMakeupBrandByID(MakeupBrandID);
            updateMakeupBrand.MakeupBrandID = MakeupBrandID;
            updateMakeupBrand.MakeupBrandName = MakeupBrandName;
            updateMakeupBrand.MakeupBrandRating = MakeupBrandRating;

            db.SaveChanges();
        }
    }
}