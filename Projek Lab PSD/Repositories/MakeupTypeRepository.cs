using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class MakeupTypeRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<MakeupType> GetMakeupTypes()
        {
            return (from x in db.MakeupTypes select x).ToList();
        }

        public List<String> GetMakeupTypeNames()
        {
            return (from x in db.MakeupTypes 
                    select x.MakeupTypeName).ToList();
        }

        public int GetLastMakeupTypeID()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
        }

        public int GetMakeupTypeIDByName(String name)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeName.Equals(name) 
                    select x.MakeupTypeID).FirstOrDefault();
        }

        public String GetMakeupTypeNameByID(int MakeupTypeID)
        {
            return (from x in db.MakeupTypes
                    where x.MakeupTypeID == MakeupTypeID
                    select x.MakeupTypeName).FirstOrDefault();
        }

        public MakeupType GetMakeupTypeByID(int MakeupTypeID)
        {
            return db.MakeupTypes.Find(MakeupTypeID);
        }

        public void InsertMakeupType(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupType makeupType = MakeupTypeFactory.Create(MakeupTypeID, MakeupTypeName);
            db.MakeupTypes.Add(makeupType);
            db.SaveChanges();
        }

        public void DeleteMakeupTypeByID(int MakeupTypeID)
        {
            MakeupType makeupType = db.MakeupTypes.Find(MakeupTypeID);
            db.MakeupTypes.Remove(makeupType);
            db.SaveChanges();
        }

        public void UpdateMakeupTypeByID(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupType updateMakeupType = GetMakeupTypeByID(MakeupTypeID);
            updateMakeupType.MakeupTypeID = MakeupTypeID;
            updateMakeupType.MakeupTypeName = MakeupTypeName;

            db.SaveChanges();
        }
    }
}