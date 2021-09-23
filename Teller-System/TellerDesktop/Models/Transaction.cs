using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class Transaction: BaseModel
    {
        #region BasicInfo       
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User Editor { get; set; }
        public string Notes { get; set; }
        public string Destination { get; set; }
        #endregion

        #region SendingInfo
        public IFinancialAccountOwner SendingAccountOwner { get; set; }
        public Currency SendingCurrency { get; set; }
        public decimal SendingMoney { get; set; }
        public decimal SendingExchangeRate { get; set; }
        public decimal SendingCompanyProfit { get; set; }
        public decimal SendingOtherProfit { get; set; }

        public Person Sender { get; set; }

        public bool SendingIsCut { get; set; }
        public Currency SendingCutCurrency { get; set; }
        public decimal SendingCutExchageRate { get; set; }
        public decimal SendingCutMoney { get; set; }
        #endregion

        #region ReceivingInfo
        public IFinancialAccountOwner ReceivingAccountOwner { get; set; }
        public Currency ReceivingCurrency { get; set; }
        public decimal ReceivingMoney { get; set; }
        public decimal ReceivingExchangeRate { get; set; }
        public decimal ReceivingCompanyProfit { get; set; }
        public decimal ReceivingOtherProfit { get; set; }

        public Person Receiver { get; set; }

        public bool ReceivingIsCut { get; set; }
        public Currency ReceivingCutCurrency { get; set; }
        public decimal ReceivingCutExchageRate { get; set; }
        public decimal ReceivingCutMoney { get; set; }
        #endregion

    }
}
