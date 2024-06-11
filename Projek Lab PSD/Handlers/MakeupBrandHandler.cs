using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Handlers
{
    public class MakeupBrandHandler
    {
        public static List<String> GetMakeupBrandNames()
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            return makeupBrandRepo.GetMakeupBrandNames();
        }

        public static void DeleteMakeupBrand(int MakeupBrandID)
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            MakeupRepository makeupRepo = new MakeupRepository();

            MakeupBrand makeupBrand = makeupBrandRepo.GetMakeupBrandByID(MakeupBrandID);

            if (makeupBrand == null)
            {
                return;
            }

            if (makeupBrand.Makeups.Count > 0)
            {
                makeupRepo.DeleteMakeup(makeupBrand.Makeups.ToList());
            }

            makeupBrandRepo.DeleteMakeupBrandByID(MakeupBrandID);
        }

        public static void InsertMakeupBrand(String name, int rating)
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            int MakeupBrandID = GenerateMakeupBrandID();
            String MakeupBrandName = name;
            int MakeupBrandRating = rating;

            makeupBrandRepo.InsertMakeupBrand(MakeupBrandID, MakeupBrandName, Convert.ToInt32(MakeupBrandRating));
        }

        public static void UpdateMakeupBrand(int updateId, String name, int rating) 
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            
            int updateID = updateId;
            String makeupBrandName = name;
            int makeupBrandRating = rating;

            makeupBrandRepo.UpdateMakeupBrandByID(updateID, makeupBrandName, makeupBrandRating);
        }

        public static int GenerateMakeupBrandID()
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();

            int newID = 0;
            int lastID = makeupBrandRepo.GetLastMakeupBrandID();

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

        public static List<MakeupBrand> GetMakeupBrands()
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            return makeupBrandRepo.GetMakeupBrands();
        }

        public static String GetMakeupBrandNameByID(int MakeupBrandID)
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            return makeupBrandRepo.GetMakeupBrandNameByID(MakeupBrandID);
        }

        public static MakeupBrand GetMakeupBrandByID(int MakeupBrandID)
        {
            MakeupBrandRepository makeupBrandRepo = new MakeupBrandRepository();
            return makeupBrandRepo.GetMakeupBrandByID(MakeupBrandID);
        }
    }
}