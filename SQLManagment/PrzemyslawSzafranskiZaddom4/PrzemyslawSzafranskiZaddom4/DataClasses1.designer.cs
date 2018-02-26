﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrzemyslawSzafranskiZaddom4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PrzemyslawSzafranskiSQLZD4")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEventsPerformance(EventsPerformance instance);
    partial void UpdateEventsPerformance(EventsPerformance instance);
    partial void DeleteEventsPerformance(EventsPerformance instance);
    partial void InsertPlaces(Places instance);
    partial void UpdatePlaces(Places instance);
    partial void DeletePlaces(Places instance);
    partial void InsertEventTypes(EventTypes instance);
    partial void UpdateEventTypes(EventTypes instance);
    partial void DeleteEventTypes(EventTypes instance);
    partial void InsertEvents(Events instance);
    partial void UpdateEvents(Events instance);
    partial void DeleteEvents(Events instance);
    partial void InsertClients(Clients instance);
    partial void UpdateClients(Clients instance);
    partial void DeleteClients(Clients instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::PrzemyslawSzafranskiZaddom4.Properties.Settings.Default.PrzemyslawSzafranskiSQLZD4ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EventsPerformance> EventsPerformance
		{
			get
			{
				return this.GetTable<EventsPerformance>();
			}
		}
		
		public System.Data.Linq.Table<Places> Places
		{
			get
			{
				return this.GetTable<Places>();
			}
		}
		
		public System.Data.Linq.Table<EventTypes> EventTypes
		{
			get
			{
				return this.GetTable<EventTypes>();
			}
		}
		
		public System.Data.Linq.Table<Events> Events
		{
			get
			{
				return this.GetTable<Events>();
			}
		}
		
		public System.Data.Linq.Table<Clients> Clients
		{
			get
			{
				return this.GetTable<Clients>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventsPerformance")]
	public partial class EventsPerformance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _EventID;
		
		private int _ClientID;
		
		private int _PlaceID;
		
		private EntityRef<Places> _Places;
		
		private EntityRef<Events> _Events;
		
		private EntityRef<Clients> _Clients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEventIDChanging(int value);
    partial void OnEventIDChanged();
    partial void OnClientIDChanging(int value);
    partial void OnClientIDChanged();
    partial void OnPlaceIDChanging(int value);
    partial void OnPlaceIDChanged();
    #endregion
		
		public EventsPerformance()
		{
			this._Places = default(EntityRef<Places>);
			this._Events = default(EntityRef<Events>);
			this._Clients = default(EntityRef<Clients>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventID", DbType="Int NOT NULL")]
		public int EventID
		{
			get
			{
				return this._EventID;
			}
			set
			{
				if ((this._EventID != value))
				{
					if (this._Events.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEventIDChanging(value);
					this.SendPropertyChanging();
					this._EventID = value;
					this.SendPropertyChanged("EventID");
					this.OnEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientID", DbType="Int NOT NULL")]
		public int ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					if (this._Clients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClientIDChanging(value);
					this.SendPropertyChanging();
					this._ClientID = value;
					this.SendPropertyChanged("ClientID");
					this.OnClientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaceID", DbType="Int NOT NULL")]
		public int PlaceID
		{
			get
			{
				return this._PlaceID;
			}
			set
			{
				if ((this._PlaceID != value))
				{
					if (this._Places.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlaceIDChanging(value);
					this.SendPropertyChanging();
					this._PlaceID = value;
					this.SendPropertyChanged("PlaceID");
					this.OnPlaceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Places_EventsPerformance", Storage="_Places", ThisKey="PlaceID", OtherKey="Id", IsForeignKey=true)]
		public Places Places
		{
			get
			{
				return this._Places.Entity;
			}
			set
			{
				Places previousValue = this._Places.Entity;
				if (((previousValue != value) 
							|| (this._Places.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Places.Entity = null;
						previousValue.EventsPerformance.Remove(this);
					}
					this._Places.Entity = value;
					if ((value != null))
					{
						value.EventsPerformance.Add(this);
						this._PlaceID = value.Id;
					}
					else
					{
						this._PlaceID = default(int);
					}
					this.SendPropertyChanged("Places");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Events_EventsPerformance", Storage="_Events", ThisKey="EventID", OtherKey="Id", IsForeignKey=true)]
		public Events Events
		{
			get
			{
				return this._Events.Entity;
			}
			set
			{
				Events previousValue = this._Events.Entity;
				if (((previousValue != value) 
							|| (this._Events.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Events.Entity = null;
						previousValue.EventsPerformance.Remove(this);
					}
					this._Events.Entity = value;
					if ((value != null))
					{
						value.EventsPerformance.Add(this);
						this._EventID = value.Id;
					}
					else
					{
						this._EventID = default(int);
					}
					this.SendPropertyChanged("Events");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clients_EventsPerformance", Storage="_Clients", ThisKey="ClientID", OtherKey="Id", IsForeignKey=true)]
		public Clients Clients
		{
			get
			{
				return this._Clients.Entity;
			}
			set
			{
				Clients previousValue = this._Clients.Entity;
				if (((previousValue != value) 
							|| (this._Clients.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Clients.Entity = null;
						previousValue.EventsPerformance.Remove(this);
					}
					this._Clients.Entity = value;
					if ((value != null))
					{
						value.EventsPerformance.Add(this);
						this._ClientID = value.Id;
					}
					else
					{
						this._ClientID = default(int);
					}
					this.SendPropertyChanged("Clients");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Places")]
	public partial class Places : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Street;
		
		private string _City;
		
		private EntitySet<EventsPerformance> _EventsPerformance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    #endregion
		
		public Places()
		{
			this._EventsPerformance = new EntitySet<EventsPerformance>(new Action<EventsPerformance>(this.attach_EventsPerformance), new Action<EventsPerformance>(this.detach_EventsPerformance));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="NVarChar(50)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Places_EventsPerformance", Storage="_EventsPerformance", ThisKey="Id", OtherKey="PlaceID")]
		public EntitySet<EventsPerformance> EventsPerformance
		{
			get
			{
				return this._EventsPerformance;
			}
			set
			{
				this._EventsPerformance.Assign(value);
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
		
		private void attach_EventsPerformance(EventsPerformance entity)
		{
			this.SendPropertyChanging();
			entity.Places = this;
		}
		
		private void detach_EventsPerformance(EventsPerformance entity)
		{
			this.SendPropertyChanging();
			entity.Places = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventTypes")]
	public partial class EventTypes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _EventType;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEventTypeChanging(string value);
    partial void OnEventTypeChanged();
    #endregion
		
		public EventTypes()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EventType
		{
			get
			{
				return this._EventType;
			}
			set
			{
				if ((this._EventType != value))
				{
					this.OnEventTypeChanging(value);
					this.SendPropertyChanging();
					this._EventType = value;
					this.SendPropertyChanged("EventType");
					this.OnEventTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EventTypes_Events", Storage="_Events", ThisKey="Id", OtherKey="EventTypeID")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.EventTypes = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.EventTypes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Events : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _EventTypeID;
		
		private System.Nullable<int> _Distance;
		
		private System.Nullable<int> _FuelCost;
		
		private int _AmoutOfPeople;
		
		private string _EventCost;
		
		private EntitySet<EventsPerformance> _EventsPerformance;
		
		private EntityRef<EventTypes> _EventTypes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEventTypeIDChanging(int value);
    partial void OnEventTypeIDChanged();
    partial void OnDistanceChanging(System.Nullable<int> value);
    partial void OnDistanceChanged();
    partial void OnFuelCostChanging(System.Nullable<int> value);
    partial void OnFuelCostChanged();
    partial void OnAmoutOfPeopleChanging(int value);
    partial void OnAmoutOfPeopleChanged();
    partial void OnEventCostChanging(string value);
    partial void OnEventCostChanged();
    #endregion
		
		public Events()
		{
			this._EventsPerformance = new EntitySet<EventsPerformance>(new Action<EventsPerformance>(this.attach_EventsPerformance), new Action<EventsPerformance>(this.detach_EventsPerformance));
			this._EventTypes = default(EntityRef<EventTypes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventTypeID", DbType="Int NOT NULL")]
		public int EventTypeID
		{
			get
			{
				return this._EventTypeID;
			}
			set
			{
				if ((this._EventTypeID != value))
				{
					if (this._EventTypes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEventTypeIDChanging(value);
					this.SendPropertyChanging();
					this._EventTypeID = value;
					this.SendPropertyChanged("EventTypeID");
					this.OnEventTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distance", DbType="Int")]
		public System.Nullable<int> Distance
		{
			get
			{
				return this._Distance;
			}
			set
			{
				if ((this._Distance != value))
				{
					this.OnDistanceChanging(value);
					this.SendPropertyChanging();
					this._Distance = value;
					this.SendPropertyChanged("Distance");
					this.OnDistanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FuelCost", DbType="Int")]
		public System.Nullable<int> FuelCost
		{
			get
			{
				return this._FuelCost;
			}
			set
			{
				if ((this._FuelCost != value))
				{
					this.OnFuelCostChanging(value);
					this.SendPropertyChanging();
					this._FuelCost = value;
					this.SendPropertyChanged("FuelCost");
					this.OnFuelCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmoutOfPeople", DbType="Int NOT NULL")]
		public int AmoutOfPeople
		{
			get
			{
				return this._AmoutOfPeople;
			}
			set
			{
				if ((this._AmoutOfPeople != value))
				{
					this.OnAmoutOfPeopleChanging(value);
					this.SendPropertyChanging();
					this._AmoutOfPeople = value;
					this.SendPropertyChanged("AmoutOfPeople");
					this.OnAmoutOfPeopleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventCost", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string EventCost
		{
			get
			{
				return this._EventCost;
			}
			set
			{
				if ((this._EventCost != value))
				{
					this.OnEventCostChanging(value);
					this.SendPropertyChanging();
					this._EventCost = value;
					this.SendPropertyChanged("EventCost");
					this.OnEventCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Events_EventsPerformance", Storage="_EventsPerformance", ThisKey="Id", OtherKey="EventID")]
		public EntitySet<EventsPerformance> EventsPerformance
		{
			get
			{
				return this._EventsPerformance;
			}
			set
			{
				this._EventsPerformance.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EventTypes_Events", Storage="_EventTypes", ThisKey="EventTypeID", OtherKey="Id", IsForeignKey=true)]
		public EventTypes EventTypes
		{
			get
			{
				return this._EventTypes.Entity;
			}
			set
			{
				EventTypes previousValue = this._EventTypes.Entity;
				if (((previousValue != value) 
							|| (this._EventTypes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EventTypes.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._EventTypes.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._EventTypeID = value.Id;
					}
					else
					{
						this._EventTypeID = default(int);
					}
					this.SendPropertyChanged("EventTypes");
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
		
		private void attach_EventsPerformance(EventsPerformance entity)
		{
			this.SendPropertyChanging();
			entity.Events = this;
		}
		
		private void detach_EventsPerformance(EventsPerformance entity)
		{
			this.SendPropertyChanging();
			entity.Events = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clients")]
	public partial class Clients : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private string _PESEL;
		
		private string _PhoneNumber;
		
		private string _EMail;
		
		private EntitySet<EventsPerformance> _EventsPerformance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnPESELChanging(string value);
    partial void OnPESELChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnEMailChanging(string value);
    partial void OnEMailChanged();
    #endregion
		
		public Clients()
		{
			this._EventsPerformance = new EntitySet<EventsPerformance>(new Action<EventsPerformance>(this.attach_EventsPerformance), new Action<EventsPerformance>(this.detach_EventsPerformance));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PESEL", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string PESEL
		{
			get
			{
				return this._PESEL;
			}
			set
			{
				if ((this._PESEL != value))
				{
					this.OnPESELChanging(value);
					this.SendPropertyChanging();
					this._PESEL = value;
					this.SendPropertyChanged("PESEL");
					this.OnPESELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(9) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMail", DbType="NVarChar(70)")]
		public string EMail
		{
			get
			{
				return this._EMail;
			}
			set
			{
				if ((this._EMail != value))
				{
					this.OnEMailChanging(value);
					this.SendPropertyChanging();
					this._EMail = value;
					this.SendPropertyChanged("EMail");
					this.OnEMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clients_EventsPerformance", Storage="_EventsPerformance", ThisKey="Id", OtherKey="ClientID")]
		public EntitySet<EventsPerformance> EventsPerformance
		{
			get
			{
				return this._EventsPerformance;
			}
			set
			{
				this._EventsPerformance.Assign(value);
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
		
		private void attach_EventsPerformance(EventsPerformance entity)
		{
			this.SendPropertyChanging();
			entity.Clients = this;
		}
		
		private void detach_EventsPerformance(EventsPerformance entity)
		{
			this.SendPropertyChanging();
			entity.Clients = null;
		}
	}
}
#pragma warning restore 1591