﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataEntity
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="edu")]
	public partial class WidgetDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHTMLWidget(HTMLWidget instance);
    partial void UpdateHTMLWidget(HTMLWidget instance);
    partial void DeleteHTMLWidget(HTMLWidget instance);
    partial void InsertWidgetPage(WidgetPage instance);
    partial void UpdateWidgetPage(WidgetPage instance);
    partial void DeleteWidgetPage(WidgetPage instance);
    partial void InsertWidget(Widget instance);
    partial void UpdateWidget(Widget instance);
    partial void DeleteWidget(Widget instance);
    #endregion
		
		public WidgetDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WidgetDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WidgetDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WidgetDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HTMLWidget> HTMLWidgets
		{
			get
			{
				return this.GetTable<HTMLWidget>();
			}
		}
		
		public System.Data.Linq.Table<WidgetPage> WidgetPages
		{
			get
			{
				return this.GetTable<WidgetPage>();
			}
		}
		
		public System.Data.Linq.Table<Widget> Widgets
		{
			get
			{
				return this.GetTable<Widget>();
			}
		}
	}
	
	[Table(Name="dbo.HTMLWidget")]
	public partial class HTMLWidget : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _HTMLWidgetID;
		
		private string _HTMLDATA;
		
		private System.DateTime _ModifiedDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHTMLWidgetIDChanging(System.Guid value);
    partial void OnHTMLWidgetIDChanged();
    partial void OnHTMLDATAChanging(string value);
    partial void OnHTMLDATAChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public HTMLWidget()
		{
			OnCreated();
		}
		
		[Column(Storage="_HTMLWidgetID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid HTMLWidgetID
		{
			get
			{
				return this._HTMLWidgetID;
			}
			set
			{
				if ((this._HTMLWidgetID != value))
				{
					this.OnHTMLWidgetIDChanging(value);
					this.SendPropertyChanging();
					this._HTMLWidgetID = value;
					this.SendPropertyChanged("HTMLWidgetID");
					this.OnHTMLWidgetIDChanged();
				}
			}
		}
		
		[Column(Storage="_HTMLDATA", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string HTMLDATA
		{
			get
			{
				return this._HTMLDATA;
			}
			set
			{
				if ((this._HTMLDATA != value))
				{
					this.OnHTMLDATAChanging(value);
					this.SendPropertyChanging();
					this._HTMLDATA = value;
					this.SendPropertyChanged("HTMLDATA");
					this.OnHTMLDATAChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
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
	
	[Table(Name="dbo.WidgetPage")]
	public partial class WidgetPage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _PageID;
		
		private int _LoginUserID;
		
		private int _PageType;
		
		private string _Title;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<Widget> _Widgets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPageIDChanging(System.Guid value);
    partial void OnPageIDChanged();
    partial void OnLoginUserIDChanging(int value);
    partial void OnLoginUserIDChanged();
    partial void OnPageTypeChanging(int value);
    partial void OnPageTypeChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public WidgetPage()
		{
			this._Widgets = new EntitySet<Widget>(new Action<Widget>(this.attach_Widgets), new Action<Widget>(this.detach_Widgets));
			OnCreated();
		}
		
		[Column(Storage="_PageID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid PageID
		{
			get
			{
				return this._PageID;
			}
			set
			{
				if ((this._PageID != value))
				{
					this.OnPageIDChanging(value);
					this.SendPropertyChanging();
					this._PageID = value;
					this.SendPropertyChanged("PageID");
					this.OnPageIDChanged();
				}
			}
		}
		
		[Column(Storage="_LoginUserID", DbType="Int NOT NULL")]
		public int LoginUserID
		{
			get
			{
				return this._LoginUserID;
			}
			set
			{
				if ((this._LoginUserID != value))
				{
					this.OnLoginUserIDChanging(value);
					this.SendPropertyChanging();
					this._LoginUserID = value;
					this.SendPropertyChanged("LoginUserID");
					this.OnLoginUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_PageType", DbType="Int NOT NULL")]
		public int PageType
		{
			get
			{
				return this._PageType;
			}
			set
			{
				if ((this._PageType != value))
				{
					this.OnPageTypeChanging(value);
					this.SendPropertyChanging();
					this._PageType = value;
					this.SendPropertyChanged("PageType");
					this.OnPageTypeChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[Association(Name="WidgetPage_Widget", Storage="_Widgets", OtherKey="PageID")]
		public EntitySet<Widget> Widgets
		{
			get
			{
				return this._Widgets;
			}
			set
			{
				this._Widgets.Assign(value);
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
		
		private void attach_Widgets(Widget entity)
		{
			this.SendPropertyChanging();
			entity.WidgetPage = this;
		}
		
		private void detach_Widgets(Widget entity)
		{
			this.SendPropertyChanging();
			entity.WidgetPage = null;
		}
	}
	
	[Table(Name="dbo.Widget")]
	public partial class Widget : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _WidgetID;
		
		private System.Guid _PageID;
		
		private string _Title;
		
		private int _ContentType;
		
		private string _ContentID;
		
		private int _WidgetOrder;
		
		private int _WidgetColumn;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private EntityRef<WidgetPage> _WidgetPage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWidgetIDChanging(System.Guid value);
    partial void OnWidgetIDChanged();
    partial void OnPageIDChanging(System.Guid value);
    partial void OnPageIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnContentTypeChanging(int value);
    partial void OnContentTypeChanged();
    partial void OnContentIDChanging(string value);
    partial void OnContentIDChanged();
    partial void OnWidgetOrderChanging(int value);
    partial void OnWidgetOrderChanged();
    partial void OnWidgetColumnChanging(int value);
    partial void OnWidgetColumnChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public Widget()
		{
			this._WidgetPage = default(EntityRef<WidgetPage>);
			OnCreated();
		}
		
		[Column(Storage="_WidgetID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid WidgetID
		{
			get
			{
				return this._WidgetID;
			}
			set
			{
				if ((this._WidgetID != value))
				{
					this.OnWidgetIDChanging(value);
					this.SendPropertyChanging();
					this._WidgetID = value;
					this.SendPropertyChanged("WidgetID");
					this.OnWidgetIDChanged();
				}
			}
		}
		
		[Column(Storage="_PageID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid PageID
		{
			get
			{
				return this._PageID;
			}
			set
			{
				if ((this._PageID != value))
				{
					if (this._WidgetPage.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPageIDChanging(value);
					this.SendPropertyChanging();
					this._PageID = value;
					this.SendPropertyChanged("PageID");
					this.OnPageIDChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_ContentType", DbType="Int NOT NULL")]
		public int ContentType
		{
			get
			{
				return this._ContentType;
			}
			set
			{
				if ((this._ContentType != value))
				{
					this.OnContentTypeChanging(value);
					this.SendPropertyChanging();
					this._ContentType = value;
					this.SendPropertyChanged("ContentType");
					this.OnContentTypeChanged();
				}
			}
		}
		
		[Column(Storage="_ContentID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ContentID
		{
			get
			{
				return this._ContentID;
			}
			set
			{
				if ((this._ContentID != value))
				{
					this.OnContentIDChanging(value);
					this.SendPropertyChanging();
					this._ContentID = value;
					this.SendPropertyChanged("ContentID");
					this.OnContentIDChanged();
				}
			}
		}
		
		[Column(Storage="_WidgetOrder", DbType="Int NOT NULL")]
		public int WidgetOrder
		{
			get
			{
				return this._WidgetOrder;
			}
			set
			{
				if ((this._WidgetOrder != value))
				{
					this.OnWidgetOrderChanging(value);
					this.SendPropertyChanging();
					this._WidgetOrder = value;
					this.SendPropertyChanged("WidgetOrder");
					this.OnWidgetOrderChanged();
				}
			}
		}
		
		[Column(Storage="_WidgetColumn", DbType="Int NOT NULL")]
		public int WidgetColumn
		{
			get
			{
				return this._WidgetColumn;
			}
			set
			{
				if ((this._WidgetColumn != value))
				{
					this.OnWidgetColumnChanging(value);
					this.SendPropertyChanging();
					this._WidgetColumn = value;
					this.SendPropertyChanged("WidgetColumn");
					this.OnWidgetColumnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[Association(Name="WidgetPage_Widget", Storage="_WidgetPage", ThisKey="PageID", IsForeignKey=true)]
		public WidgetPage WidgetPage
		{
			get
			{
				return this._WidgetPage.Entity;
			}
			set
			{
				WidgetPage previousValue = this._WidgetPage.Entity;
				if (((previousValue != value) 
							|| (this._WidgetPage.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._WidgetPage.Entity = null;
						previousValue.Widgets.Remove(this);
					}
					this._WidgetPage.Entity = value;
					if ((value != null))
					{
						value.Widgets.Add(this);
						this._PageID = value.PageID;
					}
					else
					{
						this._PageID = default(System.Guid);
					}
					this.SendPropertyChanged("WidgetPage");
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
