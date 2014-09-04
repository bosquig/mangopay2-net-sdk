﻿using MangoPay.Core;
using MangoPay.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MangoPay.Tests
{
    [TestClass]
    public class ApiWalletsTest : BaseTest
    {
        [TestMethod]
        public void Test_Wallets_Create()
        {
            UserNaturalDTO john = this.GetJohn();
            WalletDTO wallet = this.GetJohnsWallet();

            Assert.IsTrue(wallet.Id.Length > 0);
            Assert.IsTrue(wallet.Owners.Contains(john.Id));
        }

        [TestMethod]
        public void Test_Wallets_Get()
        {
            UserNaturalDTO john = this.GetJohn();
            WalletDTO wallet = this.GetJohnsWallet();

            WalletDTO getWallet = this.Api.Wallets.Get(wallet.Id);

            Assert.AreEqual(wallet.Id, getWallet.Id);
            Assert.IsTrue(wallet.Owners.Contains(john.Id));
        }

        [TestMethod]
        public void Test_Wallets_Save()
        {
            WalletDTO wallet = this.GetJohnsWallet();
            WalletPutDTO walletPut = new WalletPutDTO();
            walletPut.Description = wallet.Description;
            walletPut.Owners = wallet.Owners;
            walletPut.Tag = wallet.Tag;

            WalletDTO saveWallet = this.Api.Wallets.Update(walletPut, wallet.Id);

            Assert.AreEqual(wallet.Id, saveWallet.Id);
            Assert.AreEqual("New description to test", saveWallet.Description);
        }

        [TestMethod]
        public void Test_Wallets_Transactions()
        {
            UserNaturalDTO john = this.GetJohn();
            WalletDTO wallet = this.GetJohnsWallet();
            PayInDTO payIn = this.GetJohnsPayInCardWeb();

            Pagination pagination = new Pagination(1, 1);
            FilterTransactions filter = new FilterTransactions();
            filter.Type = TransactionType.PAYIN;
            List<TransactionDTO> transactions = this.Api.Wallets.GetTransactions(wallet.Id, pagination, filter);

            Assert.IsTrue(transactions.Count == 1);
            Assert.IsTrue(transactions[0] is TransactionDTO);
            Assert.AreEqual(transactions[0].AuthorId, john.Id);
            AssertEqualInputProps(transactions[0], payIn);
        }
    }
}
