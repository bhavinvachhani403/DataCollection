﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataCollection.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RANK")]
	public partial class DataCollectionModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDept(Dept instance);
    partial void UpdateDept(Dept instance);
    partial void DeleteDept(Dept instance);
    partial void InsertUserRole(UserRole instance);
    partial void UpdateUserRole(UserRole instance);
    partial void DeleteUserRole(UserRole instance);
    partial void InsertUserWork(UserWork instance);
    partial void UpdateUserWork(UserWork instance);
    partial void DeleteUserWork(UserWork instance);
    partial void InsertUserMenu(UserMenu instance);
    partial void UpdateUserMenu(UserMenu instance);
    partial void DeleteUserMenu(UserMenu instance);
    partial void InsertMenuID(MenuID instance);
    partial void UpdateMenuID(MenuID instance);
    partial void DeleteMenuID(MenuID instance);
    partial void InsertRankUser(RankUser instance);
    partial void UpdateRankUser(RankUser instance);
    partial void DeleteRankUser(RankUser instance);
    #endregion
		
		public DataCollectionModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataCollectionModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataCollectionModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataCollectionModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataCollectionModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dept> Depts
		{
			get
			{
				return this.GetTable<Dept>();
			}
		}
		
		public System.Data.Linq.Table<UserRole> UserRoles
		{
			get
			{
				return this.GetTable<UserRole>();
			}
		}
		
		public System.Data.Linq.Table<UserWork> UserWorks
		{
			get
			{
				return this.GetTable<UserWork>();
			}
		}
		
		public System.Data.Linq.Table<UserMenu> UserMenus
		{
			get
			{
				return this.GetTable<UserMenu>();
			}
		}
		
		public System.Data.Linq.Table<RankMesg> RankMesgs
		{
			get
			{
				return this.GetTable<RankMesg>();
			}
		}
		
		public System.Data.Linq.Table<MenuID> MenuIDs
		{
			get
			{
				return this.GetTable<MenuID>();
			}
		}
		
		public System.Data.Linq.Table<RankUser> RankUsers
		{
			get
			{
				return this.GetTable<RankUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Depts")]
	public partial class Dept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<short> _SNo;
		
		private string _DeptID;
		
		private string _DeptName;
		
		private System.Nullable<char> _DeptType;
		
		private System.Nullable<char> _DeptCAT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSNoChanging(System.Nullable<short> value);
    partial void OnSNoChanged();
    partial void OnDeptIDChanging(string value);
    partial void OnDeptIDChanged();
    partial void OnDeptNameChanging(string value);
    partial void OnDeptNameChanged();
    partial void OnDeptTypeChanging(System.Nullable<char> value);
    partial void OnDeptTypeChanged();
    partial void OnDeptCATChanging(System.Nullable<char> value);
    partial void OnDeptCATChanged();
    #endregion
		
		public Dept()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SNo", DbType="SmallInt")]
		public System.Nullable<short> SNo
		{
			get
			{
				return this._SNo;
			}
			set
			{
				if ((this._SNo != value))
				{
					this.OnSNoChanging(value);
					this.SendPropertyChanging();
					this._SNo = value;
					this.SendPropertyChanged("SNo");
					this.OnSNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DeptID
		{
			get
			{
				return this._DeptID;
			}
			set
			{
				if ((this._DeptID != value))
				{
					this.OnDeptIDChanging(value);
					this.SendPropertyChanging();
					this._DeptID = value;
					this.SendPropertyChanged("DeptID");
					this.OnDeptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptName", DbType="NVarChar(50)")]
		public string DeptName
		{
			get
			{
				return this._DeptName;
			}
			set
			{
				if ((this._DeptName != value))
				{
					this.OnDeptNameChanging(value);
					this.SendPropertyChanging();
					this._DeptName = value;
					this.SendPropertyChanged("DeptName");
					this.OnDeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptType", DbType="Char(1)")]
		public System.Nullable<char> DeptType
		{
			get
			{
				return this._DeptType;
			}
			set
			{
				if ((this._DeptType != value))
				{
					this.OnDeptTypeChanging(value);
					this.SendPropertyChanging();
					this._DeptType = value;
					this.SendPropertyChanged("DeptType");
					this.OnDeptTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptCAT", DbType="Char(1)")]
		public System.Nullable<char> DeptCAT
		{
			get
			{
				return this._DeptCAT;
			}
			set
			{
				if ((this._DeptCAT != value))
				{
					this.OnDeptCATChanging(value);
					this.SendPropertyChanging();
					this._DeptCAT = value;
					this.SendPropertyChanged("DeptCAT");
					this.OnDeptCATChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserRole")]
	public partial class UserRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserRole1;
		
		private string _UserRoleDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserRole1Changing(string value);
    partial void OnUserRole1Changed();
    partial void OnUserRoleDetailsChanging(string value);
    partial void OnUserRoleDetailsChanged();
    #endregion
		
		public UserRole()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="UserRole", Storage="_UserRole1", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserRole1
		{
			get
			{
				return this._UserRole1;
			}
			set
			{
				if ((this._UserRole1 != value))
				{
					this.OnUserRole1Changing(value);
					this.SendPropertyChanging();
					this._UserRole1 = value;
					this.SendPropertyChanged("UserRole1");
					this.OnUserRole1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserRoleDetails", DbType="NVarChar(50)")]
		public string UserRoleDetails
		{
			get
			{
				return this._UserRoleDetails;
			}
			set
			{
				if ((this._UserRoleDetails != value))
				{
					this.OnUserRoleDetailsChanging(value);
					this.SendPropertyChanging();
					this._UserRoleDetails = value;
					this.SendPropertyChanged("UserRoleDetails");
					this.OnUserRoleDetailsChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserWork")]
	public partial class UserWork : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserWork1;
		
		private string _UserWorkDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserWork1Changing(string value);
    partial void OnUserWork1Changed();
    partial void OnUserWorkDetailsChanging(string value);
    partial void OnUserWorkDetailsChanged();
    #endregion
		
		public UserWork()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="UserWork", Storage="_UserWork1", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserWork1
		{
			get
			{
				return this._UserWork1;
			}
			set
			{
				if ((this._UserWork1 != value))
				{
					this.OnUserWork1Changing(value);
					this.SendPropertyChanging();
					this._UserWork1 = value;
					this.SendPropertyChanged("UserWork1");
					this.OnUserWork1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserWorkDetails", DbType="NVarChar(50)")]
		public string UserWorkDetails
		{
			get
			{
				return this._UserWorkDetails;
			}
			set
			{
				if ((this._UserWorkDetails != value))
				{
					this.OnUserWorkDetailsChanging(value);
					this.SendPropertyChanging();
					this._UserWorkDetails = value;
					this.SendPropertyChanged("UserWorkDetails");
					this.OnUserWorkDetailsChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserMenu")]
	public partial class UserMenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserMenuID;
		
		private string _UserID;
		
		private string _MenuID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserMenuIDChanging(int value);
    partial void OnUserMenuIDChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnMenuIDChanging(string value);
    partial void OnMenuIDChanged();
    #endregion
		
		public UserMenu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserMenuID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserMenuID
		{
			get
			{
				return this._UserMenuID;
			}
			set
			{
				if ((this._UserMenuID != value))
				{
					this.OnUserMenuIDChanging(value);
					this.SendPropertyChanging();
					this._UserMenuID = value;
					this.SendPropertyChanged("UserMenuID");
					this.OnUserMenuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuID", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MenuID
		{
			get
			{
				return this._MenuID;
			}
			set
			{
				if ((this._MenuID != value))
				{
					this.OnMenuIDChanging(value);
					this.SendPropertyChanging();
					this._MenuID = value;
					this.SendPropertyChanged("MenuID");
					this.OnMenuIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RankMesg")]
	public partial class RankMesg
	{
		
		private string _Message;
		
		public RankMesg()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(MAX)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this._Message = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MenuIDs")]
	public partial class MenuID : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MenuID1;
		
		private string _MenuDetails;
		
		private string _MenuUrl;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMenuID1Changing(string value);
    partial void OnMenuID1Changed();
    partial void OnMenuDetailsChanging(string value);
    partial void OnMenuDetailsChanged();
    partial void OnMenuUrlChanging(string value);
    partial void OnMenuUrlChanged();
    #endregion
		
		public MenuID()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MenuID", Storage="_MenuID1", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MenuID1
		{
			get
			{
				return this._MenuID1;
			}
			set
			{
				if ((this._MenuID1 != value))
				{
					this.OnMenuID1Changing(value);
					this.SendPropertyChanging();
					this._MenuID1 = value;
					this.SendPropertyChanged("MenuID1");
					this.OnMenuID1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuDetails", DbType="NVarChar(100)")]
		public string MenuDetails
		{
			get
			{
				return this._MenuDetails;
			}
			set
			{
				if ((this._MenuDetails != value))
				{
					this.OnMenuDetailsChanging(value);
					this.SendPropertyChanging();
					this._MenuDetails = value;
					this.SendPropertyChanged("MenuDetails");
					this.OnMenuDetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuUrl", DbType="NVarChar(500)")]
		public string MenuUrl
		{
			get
			{
				return this._MenuUrl;
			}
			set
			{
				if ((this._MenuUrl != value))
				{
					this.OnMenuUrlChanging(value);
					this.SendPropertyChanging();
					this._MenuUrl = value;
					this.SendPropertyChanged("MenuUrl");
					this.OnMenuUrlChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RankUsers")]
	public partial class RankUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _UserPassword;
		
		private string _UserEmpNo;
		
		private string _UserName;
		
		private string _DeptID;
		
		private string _UserRole;
		
		private string _UserWork;
		
		private string _UserMob;
		
		private string _UserEmail;
		
		private System.Nullable<char> _UserValid;
		
		private System.Nullable<System.DateTime> _UserCreatedOn;
		
		private System.Nullable<System.DateTime> _UserDisabledOn;
		
		private string _UserRemarks;
		
		private System.Nullable<bool> _IsEmailVerified;
		
		private System.Nullable<System.Guid> _ActivationCode;
		
		private string _ResetPasswordCode;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnUserEmpNoChanging(string value);
    partial void OnUserEmpNoChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnDeptIDChanging(string value);
    partial void OnDeptIDChanged();
    partial void OnUserRoleChanging(string value);
    partial void OnUserRoleChanged();
    partial void OnUserWorkChanging(string value);
    partial void OnUserWorkChanged();
    partial void OnUserMobChanging(string value);
    partial void OnUserMobChanged();
    partial void OnUserEmailChanging(string value);
    partial void OnUserEmailChanged();
    partial void OnUserValidChanging(System.Nullable<char> value);
    partial void OnUserValidChanged();
    partial void OnUserCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUserCreatedOnChanged();
    partial void OnUserDisabledOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUserDisabledOnChanged();
    partial void OnUserRemarksChanging(string value);
    partial void OnUserRemarksChanged();
    partial void OnIsEmailVerifiedChanging(System.Nullable<bool> value);
    partial void OnIsEmailVerifiedChanged();
    partial void OnActivationCodeChanging(System.Nullable<System.Guid> value);
    partial void OnActivationCodeChanged();
    partial void OnResetPasswordCodeChanging(string value);
    partial void OnResetPasswordCodeChanged();
    #endregion
		
		public RankUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="NVarChar(500)")]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmpNo", DbType="NVarChar(10)")]
		public string UserEmpNo
		{
			get
			{
				return this._UserEmpNo;
			}
			set
			{
				if ((this._UserEmpNo != value))
				{
					this.OnUserEmpNoChanging(value);
					this.SendPropertyChanging();
					this._UserEmpNo = value;
					this.SendPropertyChanged("UserEmpNo");
					this.OnUserEmpNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptID", DbType="NVarChar(10)")]
		public string DeptID
		{
			get
			{
				return this._DeptID;
			}
			set
			{
				if ((this._DeptID != value))
				{
					this.OnDeptIDChanging(value);
					this.SendPropertyChanging();
					this._DeptID = value;
					this.SendPropertyChanged("DeptID");
					this.OnDeptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserRole", DbType="NVarChar(20)")]
		public string UserRole
		{
			get
			{
				return this._UserRole;
			}
			set
			{
				if ((this._UserRole != value))
				{
					this.OnUserRoleChanging(value);
					this.SendPropertyChanging();
					this._UserRole = value;
					this.SendPropertyChanged("UserRole");
					this.OnUserRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserWork", DbType="NVarChar(20)")]
		public string UserWork
		{
			get
			{
				return this._UserWork;
			}
			set
			{
				if ((this._UserWork != value))
				{
					this.OnUserWorkChanging(value);
					this.SendPropertyChanging();
					this._UserWork = value;
					this.SendPropertyChanged("UserWork");
					this.OnUserWorkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserMob", DbType="NVarChar(10)")]
		public string UserMob
		{
			get
			{
				return this._UserMob;
			}
			set
			{
				if ((this._UserMob != value))
				{
					this.OnUserMobChanging(value);
					this.SendPropertyChanging();
					this._UserMob = value;
					this.SendPropertyChanged("UserMob");
					this.OnUserMobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmail", DbType="NVarChar(50)")]
		public string UserEmail
		{
			get
			{
				return this._UserEmail;
			}
			set
			{
				if ((this._UserEmail != value))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._UserEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserValid", DbType="Char(1)")]
		public System.Nullable<char> UserValid
		{
			get
			{
				return this._UserValid;
			}
			set
			{
				if ((this._UserValid != value))
				{
					this.OnUserValidChanging(value);
					this.SendPropertyChanging();
					this._UserValid = value;
					this.SendPropertyChanged("UserValid");
					this.OnUserValidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UserCreatedOn
		{
			get
			{
				return this._UserCreatedOn;
			}
			set
			{
				if ((this._UserCreatedOn != value))
				{
					this.OnUserCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._UserCreatedOn = value;
					this.SendPropertyChanged("UserCreatedOn");
					this.OnUserCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserDisabledOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UserDisabledOn
		{
			get
			{
				return this._UserDisabledOn;
			}
			set
			{
				if ((this._UserDisabledOn != value))
				{
					this.OnUserDisabledOnChanging(value);
					this.SendPropertyChanging();
					this._UserDisabledOn = value;
					this.SendPropertyChanged("UserDisabledOn");
					this.OnUserDisabledOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserRemarks", DbType="NVarChar(100)")]
		public string UserRemarks
		{
			get
			{
				return this._UserRemarks;
			}
			set
			{
				if ((this._UserRemarks != value))
				{
					this.OnUserRemarksChanging(value);
					this.SendPropertyChanging();
					this._UserRemarks = value;
					this.SendPropertyChanged("UserRemarks");
					this.OnUserRemarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsEmailVerified", DbType="Bit")]
		public System.Nullable<bool> IsEmailVerified
		{
			get
			{
				return this._IsEmailVerified;
			}
			set
			{
				if ((this._IsEmailVerified != value))
				{
					this.OnIsEmailVerifiedChanging(value);
					this.SendPropertyChanging();
					this._IsEmailVerified = value;
					this.SendPropertyChanged("IsEmailVerified");
					this.OnIsEmailVerifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivationCode", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> ActivationCode
		{
			get
			{
				return this._ActivationCode;
			}
			set
			{
				if ((this._ActivationCode != value))
				{
					this.OnActivationCodeChanging(value);
					this.SendPropertyChanging();
					this._ActivationCode = value;
					this.SendPropertyChanged("ActivationCode");
					this.OnActivationCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResetPasswordCode", DbType="NVarChar(100)")]
		public string ResetPasswordCode
		{
			get
			{
				return this._ResetPasswordCode;
			}
			set
			{
				if ((this._ResetPasswordCode != value))
				{
					this.OnResetPasswordCodeChanging(value);
					this.SendPropertyChanging();
					this._ResetPasswordCode = value;
					this.SendPropertyChanged("ResetPasswordCode");
					this.OnResetPasswordCodeChanged();
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
