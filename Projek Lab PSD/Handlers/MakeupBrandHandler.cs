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
        public void DeleteMakeupBrand(int MakeupBrandID)
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
    }
}