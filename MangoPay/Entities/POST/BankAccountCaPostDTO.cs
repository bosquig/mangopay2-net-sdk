﻿using MangoPay.Core;
using System;

namespace MangoPay.Entities
{
    /// <summary>CA bank account POST entity.</summary>
    public class BankAccountCaPostDTO : BankAccountPostDTO
    {
        public BankAccountCaPostDTO(String ownerName, String ownerAddress, String bankName, String institutionNumber, String branchCode, String accountNumber)
        {
            Type = BankAccountType.CA;
            OwnerName = ownerName;
            OwnerAddress = ownerAddress;
            BankName = bankName;
            InstitutionNumber = institutionNumber;
            BranchCode = branchCode;
            AccountNumber = accountNumber;
        }

        /// <summary>Bank name.</summary>
        public String BankName { get; set; }

        /// <summary>Institution number.</summary>
        public String InstitutionNumber { get; set; }

        /// <summary>Branch code.</summary>
        public String BranchCode { get; set; }

        /// <summary>Account number.</summary>
        public String AccountNumber { get; set; }
    }
}
