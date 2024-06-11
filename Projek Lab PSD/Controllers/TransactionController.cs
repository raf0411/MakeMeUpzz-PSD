using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class TransactionController
    {
        public static void UpdateStatusByID(int TransactionID)
        {
            TransactionHandler.UpdateStatusByID(TransactionID);
        }

        public static List<TransactionHeader> GetTransactionHeaders()
        {
            return TransactionHandler.GetTransactionHeaders();
        }

        public static void InsertTransaction(int userId)
        {
            TransactionHandler.InsertTransaction(userId);
        }

        public static void InsertTransactionDetail(int userId)
        {
            TransactionHandler.InsertTransactionDetail(userId);
        }

        public static List<TransactionDetail> GetTransactionDetailsByID(int transactionId)
        {
            return TransactionHandler.GetTransactionDetailsByID(transactionId);
        }

        public static List<TransactionHeader> GetTransactionHeadersByUserID(int UserID)
        {
            return TransactionHandler.GetTransactionHeadersByUserID(UserID);
        }

        public static List<TransactionHeader> GetTransactions()
        {
            return TransactionHandler.GetTransactions();
        }
    }
}