﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kvadro
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Kvadro")]
	public partial class KvadroDataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertCustomerInfo(CustomerInfo instance);
    partial void UpdateCustomerInfo(CustomerInfo instance);
    partial void DeleteCustomerInfo(CustomerInfo instance);
    partial void InsertEmployeeInfo(EmployeeInfo instance);
    partial void UpdateEmployeeInfo(EmployeeInfo instance);
    partial void DeleteEmployeeInfo(EmployeeInfo instance);
    partial void InsertProjectInfo(ProjectInfo instance);
    partial void UpdateProjectInfo(ProjectInfo instance);
    partial void DeleteProjectInfo(ProjectInfo instance);
    partial void InsertSalaryInfo(SalaryInfo instance);
    partial void UpdateSalaryInfo(SalaryInfo instance);
    partial void DeleteSalaryInfo(SalaryInfo instance);
    #endregion
		
		public KvadroDataBaseDataContext() : 
				base(global::Kvadro.Properties.Settings.Default.KvadroConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public KvadroDataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KvadroDataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KvadroDataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KvadroDataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CustomerInfo> CustomerInfo
		{
			get
			{
				return this.GetTable<CustomerInfo>();
			}
		}
		
		public System.Data.Linq.Table<EmployeeInfo> EmployeeInfo
		{
			get
			{
				return this.GetTable<EmployeeInfo>();
			}
		}
		
		public System.Data.Linq.Table<ProjectInfo> ProjectInfo
		{
			get
			{
				return this.GetTable<ProjectInfo>();
			}
		}
		
		public System.Data.Linq.Table<SalaryInfo> SalaryInfo
		{
			get
			{
				return this.GetTable<SalaryInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerInfo")]
	public partial class CustomerInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Customer;
		
		private string _Phone;
		
		private string _Bank;
		
		private string _Account;
		
		private string _INN;
		
		private string _AdressCost;
		
		private string _FioWorker;
		
		private System.Nullable<int> _PhoneWorker;
		
		private EntitySet<ProjectInfo> _ProjectInfo;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerChanging(string value);
    partial void OnCustomerChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnBankChanging(string value);
    partial void OnBankChanged();
    partial void OnAccountChanging(string value);
    partial void OnAccountChanged();
    partial void OnINNChanging(string value);
    partial void OnINNChanged();
    partial void OnAdressCostChanging(string value);
    partial void OnAdressCostChanged();
    partial void OnFioWorkerChanging(string value);
    partial void OnFioWorkerChanged();
    partial void OnPhoneWorkerChanging(System.Nullable<int> value);
    partial void OnPhoneWorkerChanged();
    #endregion
		
		public CustomerInfo()
		{
			this._ProjectInfo = new EntitySet<ProjectInfo>(new Action<ProjectInfo>(this.attach_ProjectInfo), new Action<ProjectInfo>(this.detach_ProjectInfo));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Customer
		{
			get
			{
				return this._Customer;
			}
			set
			{
				if ((this._Customer != value))
				{
					this.OnCustomerChanging(value);
					this.SendPropertyChanging();
					this._Customer = value;
					this.SendPropertyChanged("Customer");
					this.OnCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bank", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Bank
		{
			get
			{
				return this._Bank;
			}
			set
			{
				if ((this._Bank != value))
				{
					this.OnBankChanging(value);
					this.SendPropertyChanging();
					this._Bank = value;
					this.SendPropertyChanged("Bank");
					this.OnBankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Account
		{
			get
			{
				return this._Account;
			}
			set
			{
				if ((this._Account != value))
				{
					this.OnAccountChanging(value);
					this.SendPropertyChanging();
					this._Account = value;
					this.SendPropertyChanged("Account");
					this.OnAccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INN", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string INN
		{
			get
			{
				return this._INN;
			}
			set
			{
				if ((this._INN != value))
				{
					this.OnINNChanging(value);
					this.SendPropertyChanging();
					this._INN = value;
					this.SendPropertyChanged("INN");
					this.OnINNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdressCost", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AdressCost
		{
			get
			{
				return this._AdressCost;
			}
			set
			{
				if ((this._AdressCost != value))
				{
					this.OnAdressCostChanging(value);
					this.SendPropertyChanging();
					this._AdressCost = value;
					this.SendPropertyChanged("AdressCost");
					this.OnAdressCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FioWorker", DbType="VarChar(50)")]
		public string FioWorker
		{
			get
			{
				return this._FioWorker;
			}
			set
			{
				if ((this._FioWorker != value))
				{
					this.OnFioWorkerChanging(value);
					this.SendPropertyChanging();
					this._FioWorker = value;
					this.SendPropertyChanged("FioWorker");
					this.OnFioWorkerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneWorker", DbType="Int")]
		public System.Nullable<int> PhoneWorker
		{
			get
			{
				return this._PhoneWorker;
			}
			set
			{
				if ((this._PhoneWorker != value))
				{
					this.OnPhoneWorkerChanging(value);
					this.SendPropertyChanging();
					this._PhoneWorker = value;
					this.SendPropertyChanged("PhoneWorker");
					this.OnPhoneWorkerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerInfo_ProjectInfo", Storage="_ProjectInfo", ThisKey="INN", OtherKey="INN")]
		public EntitySet<ProjectInfo> ProjectInfo
		{
			get
			{
				return this._ProjectInfo;
			}
			set
			{
				this._ProjectInfo.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ProjectInfo(ProjectInfo entity)
		{
			this.SendPropertyChanging();
			entity.CustomerInfo = this;
		}
		
		private void detach_ProjectInfo(ProjectInfo entity)
		{
			this.SendPropertyChanging();
			entity.CustomerInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeInfo")]
	public partial class EmployeeInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _EmployeeID;
		
		private string _EmployeeName;
		
		private string _Adress;
		
		private string _District;
		
		private int _Experiance;
		
		private System.DateTime _Year;
		
		private string _Language;
		
		private string _Base;
		
		private string _Comment;
		
		private System.Data.Linq.Binary _Picture;
		
		private System.Nullable<int> _BonusAll;
		
		private System.Nullable<System.DateTime> _EmployeeStart;
		
		private System.Nullable<System.DateTime> _EmployeeStop;
		
		private System.Nullable<long> _ProjectID;
		
		private EntityRef<ProjectInfo> _ProjectInfo;
		
		private EntityRef<SalaryInfo> _SalaryInfo;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(long value);
    partial void OnEmployeeIDChanged();
    partial void OnEmployeeNameChanging(string value);
    partial void OnEmployeeNameChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnDistrictChanging(string value);
    partial void OnDistrictChanged();
    partial void OnExperianceChanging(int value);
    partial void OnExperianceChanged();
    partial void OnYearChanging(System.DateTime value);
    partial void OnYearChanged();
    partial void OnLanguageChanging(string value);
    partial void OnLanguageChanged();
    partial void OnBaseChanging(string value);
    partial void OnBaseChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnBonusAllChanging(System.Nullable<int> value);
    partial void OnBonusAllChanged();
    partial void OnEmployeeStartChanging(System.Nullable<System.DateTime> value);
    partial void OnEmployeeStartChanged();
    partial void OnEmployeeStopChanging(System.Nullable<System.DateTime> value);
    partial void OnEmployeeStopChanged();
    partial void OnProjectIDChanging(System.Nullable<long> value);
    partial void OnProjectIDChanged();
    #endregion
		
		public EmployeeInfo()
		{
			this._ProjectInfo = default(EntityRef<ProjectInfo>);
			this._SalaryInfo = default(EntityRef<SalaryInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._SalaryInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmployeeName
		{
			get
			{
				return this._EmployeeName;
			}
			set
			{
				if ((this._EmployeeName != value))
				{
					this.OnEmployeeNameChanging(value);
					this.SendPropertyChanging();
					this._EmployeeName = value;
					this.SendPropertyChanged("EmployeeName");
					this.OnEmployeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_District", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string District
		{
			get
			{
				return this._District;
			}
			set
			{
				if ((this._District != value))
				{
					this.OnDistrictChanging(value);
					this.SendPropertyChanging();
					this._District = value;
					this.SendPropertyChanged("District");
					this.OnDistrictChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Experiance", DbType="Int NOT NULL")]
		public int Experiance
		{
			get
			{
				return this._Experiance;
			}
			set
			{
				if ((this._Experiance != value))
				{
					this.OnExperianceChanging(value);
					this.SendPropertyChanging();
					this._Experiance = value;
					this.SendPropertyChanged("Experiance");
					this.OnExperianceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Date NOT NULL")]
		public System.DateTime Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Language", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Language
		{
			get
			{
				return this._Language;
			}
			set
			{
				if ((this._Language != value))
				{
					this.OnLanguageChanging(value);
					this.SendPropertyChanging();
					this._Language = value;
					this.SendPropertyChanged("Language");
					this.OnLanguageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Base
		{
			get
			{
				return this._Base;
			}
			set
			{
				if ((this._Base != value))
				{
					this.OnBaseChanging(value);
					this.SendPropertyChanging();
					this._Base = value;
					this.SendPropertyChanged("Base");
					this.OnBaseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BonusAll", DbType="Int")]
		public System.Nullable<int> BonusAll
		{
			get
			{
				return this._BonusAll;
			}
			set
			{
				if ((this._BonusAll != value))
				{
					this.OnBonusAllChanging(value);
					this.SendPropertyChanging();
					this._BonusAll = value;
					this.SendPropertyChanged("BonusAll");
					this.OnBonusAllChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeStart", DbType="Date")]
		public System.Nullable<System.DateTime> EmployeeStart
		{
			get
			{
				return this._EmployeeStart;
			}
			set
			{
				if ((this._EmployeeStart != value))
				{
					this.OnEmployeeStartChanging(value);
					this.SendPropertyChanging();
					this._EmployeeStart = value;
					this.SendPropertyChanged("EmployeeStart");
					this.OnEmployeeStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeStop", DbType="Date")]
		public System.Nullable<System.DateTime> EmployeeStop
		{
			get
			{
				return this._EmployeeStop;
			}
			set
			{
				if ((this._EmployeeStop != value))
				{
					this.OnEmployeeStopChanging(value);
					this.SendPropertyChanging();
					this._EmployeeStop = value;
					this.SendPropertyChanged("EmployeeStop");
					this.OnEmployeeStopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="BigInt")]
		public System.Nullable<long> ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					if (this._ProjectInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIDChanging(value);
					this.SendPropertyChanging();
					this._ProjectID = value;
					this.SendPropertyChanged("ProjectID");
					this.OnProjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProjectInfo_EmployeeInfo", Storage="_ProjectInfo", ThisKey="ProjectID", OtherKey="ProjectID", IsForeignKey=true)]
		public ProjectInfo ProjectInfo
		{
			get
			{
				return this._ProjectInfo.Entity;
			}
			set
			{
				ProjectInfo previousValue = this._ProjectInfo.Entity;
				if (((previousValue != value) 
							|| (this._ProjectInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProjectInfo.Entity = null;
						previousValue.EmployeeInfo.Remove(this);
					}
					this._ProjectInfo.Entity = value;
					if ((value != null))
					{
						value.EmployeeInfo.Add(this);
						this._ProjectID = value.ProjectID;
					}
					else
					{
						this._ProjectID = default(Nullable<long>);
					}
					this.SendPropertyChanged("ProjectInfo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SalaryInfo_EmployeeInfo", Storage="_SalaryInfo", ThisKey="EmployeeID", OtherKey="EmployeeId", IsForeignKey=true)]
		public SalaryInfo SalaryInfo
		{
			get
			{
				return this._SalaryInfo.Entity;
			}
			set
			{
				SalaryInfo previousValue = this._SalaryInfo.Entity;
				if (((previousValue != value) 
							|| (this._SalaryInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SalaryInfo.Entity = null;
						previousValue.EmployeeInfo = null;
					}
					this._SalaryInfo.Entity = value;
					if ((value != null))
					{
						value.EmployeeInfo = this;
						this._EmployeeID = value.EmployeeId;
					}
					else
					{
						this._EmployeeID = default(long);
					}
					this.SendPropertyChanged("SalaryInfo");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProjectInfo")]
	public partial class ProjectInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ProjectID;
		
		private string _ProjectName;
		
		private System.Nullable<System.DateTime> _ProjectStart;
		
		private System.Nullable<System.DateTime> _ProjectStop;
		
		private string _Chief;
		
		private System.Nullable<decimal> _Cost;
		
		private string _INN;
		
		private EntitySet<EmployeeInfo> _EmployeeInfo;
		
		private EntityRef<CustomerInfo> _CustomerInfo;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProjectIDChanging(long value);
    partial void OnProjectIDChanged();
    partial void OnProjectNameChanging(string value);
    partial void OnProjectNameChanged();
    partial void OnProjectStartChanging(System.Nullable<System.DateTime> value);
    partial void OnProjectStartChanged();
    partial void OnProjectStopChanging(System.Nullable<System.DateTime> value);
    partial void OnProjectStopChanged();
    partial void OnChiefChanging(string value);
    partial void OnChiefChanged();
    partial void OnCostChanging(System.Nullable<decimal> value);
    partial void OnCostChanged();
    partial void OnINNChanging(string value);
    partial void OnINNChanged();
    #endregion
		
		public ProjectInfo()
		{
			this._EmployeeInfo = new EntitySet<EmployeeInfo>(new Action<EmployeeInfo>(this.attach_EmployeeInfo), new Action<EmployeeInfo>(this.detach_EmployeeInfo));
			this._CustomerInfo = default(EntityRef<CustomerInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this.OnProjectIDChanging(value);
					this.SendPropertyChanging();
					this._ProjectID = value;
					this.SendPropertyChanged("ProjectID");
					this.OnProjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProjectName
		{
			get
			{
				return this._ProjectName;
			}
			set
			{
				if ((this._ProjectName != value))
				{
					this.OnProjectNameChanging(value);
					this.SendPropertyChanging();
					this._ProjectName = value;
					this.SendPropertyChanged("ProjectName");
					this.OnProjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectStart", DbType="Date")]
		public System.Nullable<System.DateTime> ProjectStart
		{
			get
			{
				return this._ProjectStart;
			}
			set
			{
				if ((this._ProjectStart != value))
				{
					this.OnProjectStartChanging(value);
					this.SendPropertyChanging();
					this._ProjectStart = value;
					this.SendPropertyChanged("ProjectStart");
					this.OnProjectStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectStop", DbType="Date")]
		public System.Nullable<System.DateTime> ProjectStop
		{
			get
			{
				return this._ProjectStop;
			}
			set
			{
				if ((this._ProjectStop != value))
				{
					this.OnProjectStopChanging(value);
					this.SendPropertyChanging();
					this._ProjectStop = value;
					this.SendPropertyChanged("ProjectStop");
					this.OnProjectStopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chief", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Chief
		{
			get
			{
				return this._Chief;
			}
			set
			{
				if ((this._Chief != value))
				{
					this.OnChiefChanging(value);
					this.SendPropertyChanging();
					this._Chief = value;
					this.SendPropertyChanged("Chief");
					this.OnChiefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Money")]
		public System.Nullable<decimal> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INN", DbType="VarChar(10)")]
		public string INN
		{
			get
			{
				return this._INN;
			}
			set
			{
				if ((this._INN != value))
				{
					if (this._CustomerInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnINNChanging(value);
					this.SendPropertyChanging();
					this._INN = value;
					this.SendPropertyChanged("INN");
					this.OnINNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProjectInfo_EmployeeInfo", Storage="_EmployeeInfo", ThisKey="ProjectID", OtherKey="ProjectID")]
		public EntitySet<EmployeeInfo> EmployeeInfo
		{
			get
			{
				return this._EmployeeInfo;
			}
			set
			{
				this._EmployeeInfo.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerInfo_ProjectInfo", Storage="_CustomerInfo", ThisKey="INN", OtherKey="INN", IsForeignKey=true)]
		public CustomerInfo CustomerInfo
		{
			get
			{
				return this._CustomerInfo.Entity;
			}
			set
			{
				CustomerInfo previousValue = this._CustomerInfo.Entity;
				if (((previousValue != value) 
							|| (this._CustomerInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomerInfo.Entity = null;
						previousValue.ProjectInfo.Remove(this);
					}
					this._CustomerInfo.Entity = value;
					if ((value != null))
					{
						value.ProjectInfo.Add(this);
						this._INN = value.INN;
					}
					else
					{
						this._INN = default(string);
					}
					this.SendPropertyChanged("CustomerInfo");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_EmployeeInfo(EmployeeInfo entity)
		{
			this.SendPropertyChanging();
			entity.ProjectInfo = this;
		}
		
		private void detach_EmployeeInfo(EmployeeInfo entity)
		{
			this.SendPropertyChanging();
			entity.ProjectInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SalaryInfo")]
	public partial class SalaryInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _Salary;
		
		private System.Nullable<decimal> _Bonus;
		
		private System.Nullable<decimal> _GrossSalary;
		
		private System.Nullable<decimal> _Exempt;
		
		private long _EmployeeId;
		
		private EntityRef<EmployeeInfo> _EmployeeInfo;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalaryChanging(decimal value);
    partial void OnSalaryChanged();
    partial void OnBonusChanging(System.Nullable<decimal> value);
    partial void OnBonusChanged();
    partial void OnGrossSalaryChanging(System.Nullable<decimal> value);
    partial void OnGrossSalaryChanged();
    partial void OnExemptChanging(System.Nullable<decimal> value);
    partial void OnExemptChanged();
    partial void OnEmployeeIdChanging(long value);
    partial void OnEmployeeIdChanged();
    #endregion
		
		public SalaryInfo()
		{
			this._EmployeeInfo = default(EntityRef<EmployeeInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money NOT NULL")]
		public decimal Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bonus", DbType="Money")]
		public System.Nullable<decimal> Bonus
		{
			get
			{
				return this._Bonus;
			}
			set
			{
				if ((this._Bonus != value))
				{
					this.OnBonusChanging(value);
					this.SendPropertyChanging();
					this._Bonus = value;
					this.SendPropertyChanged("Bonus");
					this.OnBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrossSalary", DbType="Money")]
		public System.Nullable<decimal> GrossSalary
		{
			get
			{
				return this._GrossSalary;
			}
			set
			{
				if ((this._GrossSalary != value))
				{
					this.OnGrossSalaryChanging(value);
					this.SendPropertyChanging();
					this._GrossSalary = value;
					this.SendPropertyChanged("GrossSalary");
					this.OnGrossSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Exempt", DbType="Money")]
		public System.Nullable<decimal> Exempt
		{
			get
			{
				return this._Exempt;
			}
			set
			{
				if ((this._Exempt != value))
				{
					this.OnExemptChanging(value);
					this.SendPropertyChanging();
					this._Exempt = value;
					this.SendPropertyChanged("Exempt");
					this.OnExemptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SalaryInfo_EmployeeInfo", Storage="_EmployeeInfo", ThisKey="EmployeeId", OtherKey="EmployeeID", IsUnique=true, IsForeignKey=false)]
		public EmployeeInfo EmployeeInfo
		{
			get
			{
				return this._EmployeeInfo.Entity;
			}
			set
			{
				EmployeeInfo previousValue = this._EmployeeInfo.Entity;
				if (((previousValue != value) 
							|| (this._EmployeeInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EmployeeInfo.Entity = null;
						previousValue.SalaryInfo = null;
					}
					this._EmployeeInfo.Entity = value;
					if ((value != null))
					{
						value.SalaryInfo = this;
					}
					this.SendPropertyChanged("EmployeeInfo");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591