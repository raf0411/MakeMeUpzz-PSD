using Projek_Lab_PSD.Repositories;
using Projek_Lab_PSD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Handlers
{
    public class MakeupHandler
    {
        public static void DeleteMakeup(int id)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            makeupRepo.DeleteMakeupByID(id);
        }

        public static void InsertMakeup(String name, int price, int weight, String type, String brand)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            int MakeupID = GenerateMakeupID();
            String MakeupName = name;
            int MakeupPrice = price;
            int MakeupWeight = weight;
            String MakeupTypeName = type;
            String MakeupBrandName = brand;
            int MakeupTypeID = makeupTypeRepo.GetMakeupTypeIDByName(MakeupTypeName);
            int MakeupBrandID = makeupBrandRepo.GetMakeupBrandIDByName(MakeupBrandName);

            makeupRepo.InsertMakeup(MakeupID, MakeupName, MakeupPrice, MakeupWeight, MakeupTypeID, MakeupBrandID);
        }

        public static void UpdateMakeup(int updateId, String name, int price, int weight, String type, String brand)
        {
            MakeupRepository makeupRepo = new MakeupRepository();
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            
            int updateID = updateId;
            String makeupName = name;
            int makeupPrice = price;
            int makeupWeight = weight;
            String makeupTypeName = type;
            String makeupBrandName = brand;
            int makeupTypeID = makeupTypeRepo.GetMakeupTypeIDByName(makeupTypeName);
            int makeupBrandID = makeupBrandRepo.GetMakeupBrandIDByName(makeupBrandName);

            makeupRepo.UpdateMakeupByID(updateID, makeupName, makeupPrice, makeupWeight, makeupTypeID, makeupBrandID);
        }

        public static int GenerateMakeupID()
        {
            MakeupRepository makeupRepo = new MakeupRepository();

            int newID = 0;
            int lastID = makeupRepo.GetLastMakeupID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }

            newID = lastID;

            return newID;
        }
    }
}