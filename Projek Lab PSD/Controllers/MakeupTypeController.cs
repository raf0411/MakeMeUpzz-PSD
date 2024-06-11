using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class MakeupTypeController
    {
        public static String checkName(String name)
        {
            String response = "";

            if (name.Equals(""))
            {
                response = "Name must be filled!";
            }
            else if(name.Length < 1 || name.Length > 99)
            {
                response = "Makeup Type must be between 1 and 99 characters!";
            }

            return response;
        }

        public static String validateMakeupType(String name)
        {
            String response = checkName(name);

            if (response.Equals(""))
            {
                response = "";
            }

            return response;
        }

        public static List<MakeupType> GetMakeupTypes()
        {
            return MakeupTypeHandler.GetMakeupTypes();
        }

        public static void DeleteMakeupType(int MakeupTypeID)
        {
            MakeupTypeHandler.DeleteMakeupType(MakeupTypeID);
        }

        public static List<String> GetMakeupTypeNames()
        {
            return MakeupTypeHandler.GetMakeupTypeNames();
        }

        public static void InsertMakeupType(String name)
        {
            MakeupTypeHandler.InsertMakeupType(name);
        }

        public static String GetMakeupTypeNameByID(int MakeupTypeID)
        {
            return MakeupTypeHandler.GetMakeupTypeNameByID(MakeupTypeID);
        }

        public static MakeupType GetMakeupTypeByID(int MakeupTypeID)
        {
            return MakeupTypeHandler.GetMakeupTypeByID(MakeupTypeID);
        }

        public static void UpdateMakeupType(int updateId, String name)
        {
            MakeupTypeHandler.UpdateMakeupType(updateId, name);
        }
    }
}