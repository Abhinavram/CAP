﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("CAP_CQRSModel", "FK_Transfer_From", "AccountBalance", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CQRS.Service.AccountBalance), "Transfer", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CQRS.Service.Transfer), true)]
[assembly: EdmRelationshipAttribute("CAP_CQRSModel", "FK_Transfer_To", "AccountBalance", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CQRS.Service.AccountBalance), "Transfer", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CQRS.Service.Transfer), true)]

#endregion

namespace CQRS.Service
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CAP_CQRSEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CAP_CQRSEntities object using the connection string found in the 'CAP_CQRSEntities' section of the application configuration file.
        /// </summary>
        public CAP_CQRSEntities() : base("name=CAP_CQRSEntities", "CAP_CQRSEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CAP_CQRSEntities object.
        /// </summary>
        public CAP_CQRSEntities(string connectionString) : base(connectionString, "CAP_CQRSEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CAP_CQRSEntities object.
        /// </summary>
        public CAP_CQRSEntities(EntityConnection connection) : base(connection, "CAP_CQRSEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AccountBalance> AccountBalances
        {
            get
            {
                if ((_AccountBalances == null))
                {
                    _AccountBalances = base.CreateObjectSet<AccountBalance>("AccountBalances");
                }
                return _AccountBalances;
            }
        }
        private ObjectSet<AccountBalance> _AccountBalances;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Transfer> Transfers
        {
            get
            {
                if ((_Transfers == null))
                {
                    _Transfers = base.CreateObjectSet<Transfer>("Transfers");
                }
                return _Transfers;
            }
        }
        private ObjectSet<Transfer> _Transfers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AccountBalances EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAccountBalances(AccountBalance accountBalance)
        {
            base.AddObject("AccountBalances", accountBalance);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Transfers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTransfers(Transfer transfer)
        {
            base.AddObject("Transfers", transfer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CAP_CQRSModel", Name="AccountBalance")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AccountBalance : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AccountBalance object.
        /// </summary>
        /// <param name="account">Initial value of the Account property.</param>
        /// <param name="balance">Initial value of the Balance property.</param>
        public static AccountBalance CreateAccountBalance(global::System.String account, global::System.Decimal balance)
        {
            AccountBalance accountBalance = new AccountBalance();
            accountBalance.Account = account;
            accountBalance.Balance = balance;
            return accountBalance;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Account
        {
            get
            {
                return _Account;
            }
            set
            {
                if (_Account != value)
                {
                    OnAccountChanging(value);
                    ReportPropertyChanging("Account");
                    _Account = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Account");
                    OnAccountChanged();
                }
            }
        }
        private global::System.String _Account;
        partial void OnAccountChanging(global::System.String value);
        partial void OnAccountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                OnBalanceChanging(value);
                ReportPropertyChanging("Balance");
                _Balance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Balance");
                OnBalanceChanged();
            }
        }
        private global::System.Decimal _Balance;
        partial void OnBalanceChanging(global::System.Decimal value);
        partial void OnBalanceChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CAP_CQRSModel", "FK_Transfer_From", "Transfer")]
        public EntityCollection<Transfer> TransfersFrom
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Transfer>("CAP_CQRSModel.FK_Transfer_From", "Transfer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Transfer>("CAP_CQRSModel.FK_Transfer_From", "Transfer", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CAP_CQRSModel", "FK_Transfer_To", "Transfer")]
        public EntityCollection<Transfer> TransfersTo
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Transfer>("CAP_CQRSModel.FK_Transfer_To", "Transfer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Transfer>("CAP_CQRSModel.FK_Transfer_To", "Transfer", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CAP_CQRSModel", Name="Transfer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Transfer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Transfer object.
        /// </summary>
        /// <param name="transferID">Initial value of the TransferID property.</param>
        /// <param name="from">Initial value of the From property.</param>
        /// <param name="to">Initial value of the To property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        public static Transfer CreateTransfer(global::System.Int32 transferID, global::System.String from, global::System.String to, global::System.Decimal amount)
        {
            Transfer transfer = new Transfer();
            transfer.TransferID = transferID;
            transfer.From = from;
            transfer.To = to;
            transfer.Amount = amount;
            return transfer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TransferID
        {
            get
            {
                return _TransferID;
            }
            set
            {
                if (_TransferID != value)
                {
                    OnTransferIDChanging(value);
                    ReportPropertyChanging("TransferID");
                    _TransferID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TransferID");
                    OnTransferIDChanged();
                }
            }
        }
        private global::System.Int32 _TransferID;
        partial void OnTransferIDChanging(global::System.Int32 value);
        partial void OnTransferIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String From
        {
            get
            {
                return _From;
            }
            set
            {
                OnFromChanging(value);
                ReportPropertyChanging("From");
                _From = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("From");
                OnFromChanged();
            }
        }
        private global::System.String _From;
        partial void OnFromChanging(global::System.String value);
        partial void OnFromChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String To
        {
            get
            {
                return _To;
            }
            set
            {
                OnToChanging(value);
                ReportPropertyChanging("To");
                _To = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("To");
                OnToChanged();
            }
        }
        private global::System.String _To;
        partial void OnToChanging(global::System.String value);
        partial void OnToChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CAP_CQRSModel", "FK_Transfer_From", "AccountBalance")]
        public AccountBalance FromAccountBalance
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_From", "AccountBalance").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_From", "AccountBalance").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<AccountBalance> FromAccountBalanceReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_From", "AccountBalance");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_From", "AccountBalance", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CAP_CQRSModel", "FK_Transfer_To", "AccountBalance")]
        public AccountBalance ToAccountBalance
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_To", "AccountBalance").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_To", "AccountBalance").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<AccountBalance> ToAccountBalanceReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_To", "AccountBalance");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<AccountBalance>("CAP_CQRSModel.FK_Transfer_To", "AccountBalance", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
