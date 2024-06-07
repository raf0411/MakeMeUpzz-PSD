using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class TransactionDetailRepository
    {
        private static MakeMeUpzzDatabaseEntities db = new MakeMeUpzzDatabaseEntities();

        public List<TransactionDetail> GetTransactionDetails()
        {
            return (from x in db.TransactionDetails select x).ToList();
        }

        public List<TransactionDetail> GetTransactionDetailsByID(int TransactionID)
        {
            return (from x in db.TransactionDetails
                    where x.TransactionID == TransactionID
                    select x).ToList();
        }

        public void InsertTransactionDetail(int TransactionID, int MakeupID, int quantity)
        {
            TransactionDetail transactionDetail = TransactionDetailFactory.Create(TransactionID, MakeupID, quantity);
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }
    }
}