using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace Projek_Lab_PSD.Handlers
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetTransactionHeaders()
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            return thRepo.GetTransactionHeaders();
        }

        public static List<TransactionHeader> GetTransactions()
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            return thRepo.GetTransactionHeaders();
        }

        public static void InsertTransaction(int userId)
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();

            int TransactionID = GenerateTransactionID();
            int UserID = userId;
            DateTime TransactionDate = GenerateTransactionDate();
            String Status = "Unhandled";

            thRepo.InsertTransaction(TransactionID, UserID, TransactionDate, Status);
        }

        public static void UpdateStatusByID(int TransactionID)
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            thRepo.UpdateTransactionStatusByID(TransactionID);
        }

        public static void InsertTransactionDetail(int userId)
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            TransactionDetailRepository tdRepo = new TransactionDetailRepository();
            MakeupRepository makeupRepo = new MakeupRepository();

            int TransactionID = thRepo.GetTransactionIDByUserID(userId);
            int MakeupID = CartRepository.GetMakeupIDByUserID(userId);
            int Quantity = CartRepository.GetQuantityByMakeupID(MakeupID);

            tdRepo.InsertTransactionDetail(TransactionID, MakeupID, Quantity);
        }

        public static List<TransactionHeader> GetTransactionHeadersByUserID(int UserID)
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            return thRepo.GetTransactionHeadersByUserID(UserID);
        }

        public static List<TransactionDetail> GetTransactionDetailsByID(int transactionId)
        {
            TransactionDetailRepository tdRepo = new TransactionDetailRepository();
            return tdRepo.GetTransactionDetailsByID(transactionId);
        }

        public static DateTime GenerateTransactionDate()
        {
            DateTime transactionDate = DateTime.Now;

            return transactionDate;
        }

        public static int GenerateTransactionID()
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();

            int newID = 0;
            int lastID = thRepo.GetLastTransactionID();

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