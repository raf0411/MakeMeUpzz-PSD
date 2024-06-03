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

            if(makeupType == null )
            {
                return;
            }

            if (makeupType.Makeups.Count > 0)
            {
                makeupRepo.DeleteMakeup(makeupType.Makeups.ToList());
            }

            makeupTypeRepo.DeleteMakeupTypeByID(MakeupTypeID);
        }
    }
}