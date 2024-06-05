using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class TransactionHeaderRepository
    {
        private static MakeMeUpzzDatabaseEntities db = new MakeMeUpzzDatabaseEntities();

        public List<TransactionHeader> GetTransactionHeaders()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public int GetLastTransactionID()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }

        public int GetTransactionIDByUserID(int UserID)
        {
            return (from x in db.TransactionHeaders 
                    where x.UserID == UserID 
                    select x.TransactionID)
                    .FirstOrDefault();
        }

        public void InsertTransaction(int TransactionID, int UserID, DateTime TransactionDate, String Status)
        {
            TransactionHeader transactionHeader = TransactionHeaderFactory.Create(TransactionID, UserID, TransactionDate, Status);
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }
    }
}