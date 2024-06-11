using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class MakeupBrandController
    {
        public static String checkName(String name)
        {
            String response = "";

            if(name.Equals(""))
            {
                response = "Name must be filled!";
            }
            else if(name.Length < 1 || name.Length > 99)
            {
                response = "Name must be between 1 and 99 characters!";
            }

            return response;
        }

        public static String checkRating(int rating)
        {
            String response = "";

            if(rating < 0 || rating > 100)
            {
                response = "Rating must be between 0 and 100";
            }

            return response;
        }

        public static String validateMakeupBrand(String name, int rating)
        {
            String response = checkName(name);

            if (response.Equals(""))
            {
                response = checkRating(rating);

                if (response.Equals(""))
                {
                    response = "";
                }
            }

            return response;
        }

        public static List<MakeupBrand> GetMakeupBrands()
        {
            return MakeupBrandHandler.GetMakeupBrands();
        }

        public static void DeleteMakeupBrand(int MakeupBrandID)
        {
            MakeupBrandHandler.DeleteMakeupBrand(MakeupBrandID);
        }

        public static List<String> GetMakeupBrandNames()
        {
            return MakeupBrandHandler.GetMakeupBrandNames();
        }

        public static void InsertMakeupBrand(String name, int rating)
        {
            MakeupBrandHandler.InsertMakeupBrand(name, rating);
        }

        public static String GetMakeupBrandNameByID(int MakeupBrandID)
        {
            return MakeupBrandHandler.GetMakeupBrandNameByID(MakeupBrandID);
        }

        public static MakeupBrand GetMakeupBrandByID(int MakeupBrandID)
        {
            return MakeupBrandHandler.GetMakeupBrandByID(MakeupBrandID);
        }

        public static void UpdateMakeupBrand(int updateId, String name, int rating)
        {
            MakeupBrandHandler.UpdateMakeupBrand(updateId, name, rating);
        }
    }
}