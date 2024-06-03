using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Factories
{
    public class MakeupTypeFactory
    {
        public static MakeupType Create(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupType makeupType = new MakeupType();

            makeupType.MakeupTypeID = MakeupTypeID;
            makeupType.MakeupTypeName = MakeupTypeName;

            return makeupType;
        }
    }
}