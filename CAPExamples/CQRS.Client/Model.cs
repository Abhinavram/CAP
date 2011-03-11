/**********************************************************************
 * 
 * The CAP Theorem and its Implications
 * 
 * Michael L Perry
 * http://qedcode.com
 * 
 * Copyright 2010
 * Creative Commons Attribution 3.0
 * 
 **********************************************************************/

using UpdateControls;
using System;
using CQRS.Client.QueryServiceReference;
using CQRS.Client.CommandServiceReference;

namespace CQRS.Client
{
    public class Model
    {
        private string _fromAccount;
        private string _toAccount;
        private decimal _accountBalance;
        private decimal _transferAmount;
        private string _lastError;

        private Independent _indTriggerAccountBalance = new Independent();
        private Dependent _depAccountBalance;

        public Model()
        {
            _depAccountBalance = new Dependent(UpdateAccountBalance);
        }

        #region Independent properties
        // Generated by Update Controls --------------------------------
        private Independent _indLastError = new Independent();
        private Independent _indFromAccount = new Independent();
        private Independent _indToAccount = new Independent();
        private Independent _indTransferAmount = new Independent();

        public string FromAccount
        {
            get { _indFromAccount.OnGet(); return _fromAccount; }
            set { _indFromAccount.OnSet(); _fromAccount = value; }
        }

        public string ToAccount
        {
            get { _indToAccount.OnGet(); return _toAccount; }
            set { _indToAccount.OnSet(); _toAccount = value; }
        }

        public decimal TransferAmount
        {
            get { _indTransferAmount.OnGet(); return _transferAmount; }
            set { _indTransferAmount.OnSet(); _transferAmount = value; }
        }

        public string LastError
        {
            get { _indLastError.OnGet(); return _lastError; }
            set { _indLastError.OnSet(); _lastError = value; }
        }
        // End generated code --------------------------------
        #endregion

        public decimal AccountBalance
        {
            get { _depAccountBalance.OnGet(); return _accountBalance; }
        }

        private void UpdateAccountBalance()
        {
            try
            {
                _indTriggerAccountBalance.OnGet();

                var start = DateTime.Now;
                if (string.IsNullOrEmpty(FromAccount))
                    _accountBalance = 0.0m;
                else
                {
                    using (AccountQueryServiceClient service = new AccountQueryServiceClient())
                    {
                        _accountBalance = service.GetAccountBalance(FromAccount);
                    }
                }

                var end = DateTime.Now;
                LastError = (end-start).ToString();
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                    ex = ex.InnerException;
                LastError = ex.Message;
                _accountBalance = 0.0m;
            }
        }

        public void Transfer()
        {
            try
            {
                using (AccountCommandServiceClient service = new AccountCommandServiceClient())
                {
                    service.Transfer(FromAccount, ToAccount, TransferAmount);
                }

                ToAccount = string.Empty;
                TransferAmount = 0.0m;
                LastError = string.Empty;
                Refresh();
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                    ex = ex.InnerException;
                LastError = ex.Message;
            }
        }

        public void Refresh()
        {
            _indTriggerAccountBalance.OnSet();
        }
    }
}
