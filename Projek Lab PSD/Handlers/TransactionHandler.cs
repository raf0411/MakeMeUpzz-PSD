﻿using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Handlers
{
    public class TransactionHandler
    {
        public static void InsertTransaction(int userId)
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();

            int TransactionID = GenerateTransactionID();
            int UserID = userId;
            DateTime TransactionDate = GenerateTransactionDate();
            String Status = "Unhandled";

            thRepo.InsertTransaction(TransactionID, UserID, TransactionDate, Status);
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