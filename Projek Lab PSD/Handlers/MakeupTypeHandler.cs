using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Handlers
{
    public class MakeupTypeHandler
    {
        public void DeleteMakeupType(int MakeupTypeID)
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            MakeupRepository makeupRepo = new MakeupRepository();

            MakeupType makeupType = makeupTypeRepo.GetMakeupTypeByID(MakeupTypeID);

            if (makeupType == null)
            {
                return;
            }

            if (makeupType.Makeups.Count > 0)
            {
                makeupRepo.DeleteMakeup(makeupType.Makeups.ToList());
            }

            makeupTypeRepo.DeleteMakeupTypeByID(MakeupTypeID);
        }
        public static void InsertMakeupType(String name)
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();

            int MakeupTypeID = GenerateMakeupTypeID();
            String MakeupTypeName = name;

            makeupTypeRepo.InsertMakeupType(MakeupTypeID, MakeupTypeName);
        }

        public static void UpdateMakeupType(int updateId, String name)
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();
            
            int updateID = updateId;
            String makeupTypeName = name;

            makeupTypeRepo.UpdateMakeupTypeByID(updateID, makeupTypeName);
        }

        public static int GenerateMakeupTypeID()
        {
            MakeupTypeRepository makeupTypeRepo = new MakeupTypeRepository();

            int newID = 0;
            int lastID = makeupTypeRepo.GetLastMakeupTypeID();

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