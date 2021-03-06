﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Billing_System
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class VertexEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new VertexEntities object using the connection string found in the 'VertexEntities' section of the application configuration file.
        /// </summary>
        public VertexEntities() : base("name=VertexEntities", "VertexEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new VertexEntities object.
        /// </summary>
        public VertexEntities(string connectionString) : base(connectionString, "VertexEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new VertexEntities object.
        /// </summary>
        public VertexEntities(EntityConnection connection) : base(connection, "VertexEntities")
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
        public ObjectSet<Ver_Users> Ver_Users
        {
            get
            {
                if ((_Ver_Users == null))
                {
                    _Ver_Users = base.CreateObjectSet<Ver_Users>("Ver_Users");
                }
                return _Ver_Users;
            }
        }
        private ObjectSet<Ver_Users> _Ver_Users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Ver_Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVer_Users(Ver_Users ver_Users)
        {
            base.AddObject("Ver_Users", ver_Users);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VertexModel", Name="Ver_Users")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Ver_Users : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Ver_Users object.
        /// </summary>
        /// <param name="user_ID">Initial value of the User_ID property.</param>
        /// <param name="first_Name">Initial value of the First_Name property.</param>
        /// <param name="second_Name">Initial value of the Second_Name property.</param>
        /// <param name="last_Name">Initial value of the Last_Name property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="group_Id">Initial value of the Group_Id property.</param>
        public static Ver_Users CreateVer_Users(global::System.Int64 user_ID, global::System.String first_Name, global::System.String second_Name, global::System.String last_Name, global::System.String password, global::System.Int32 group_Id)
        {
            Ver_Users ver_Users = new Ver_Users();
            ver_Users.User_ID = user_ID;
            ver_Users.First_Name = first_Name;
            ver_Users.Second_Name = second_Name;
            ver_Users.Last_Name = last_Name;
            ver_Users.Password = password;
            ver_Users.Group_Id = group_Id;
            return ver_Users;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 User_ID
        {
            get
            {
                return _User_ID;
            }
            set
            {
                if (_User_ID != value)
                {
                    OnUser_IDChanging(value);
                    ReportPropertyChanging("User_ID");
                    _User_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("User_ID");
                    OnUser_IDChanged();
                }
            }
        }
        private global::System.Int64 _User_ID;
        partial void OnUser_IDChanging(global::System.Int64 value);
        partial void OnUser_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String First_Name
        {
            get
            {
                return _First_Name;
            }
            set
            {
                OnFirst_NameChanging(value);
                ReportPropertyChanging("First_Name");
                _First_Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("First_Name");
                OnFirst_NameChanged();
            }
        }
        private global::System.String _First_Name;
        partial void OnFirst_NameChanging(global::System.String value);
        partial void OnFirst_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Second_Name
        {
            get
            {
                return _Second_Name;
            }
            set
            {
                OnSecond_NameChanging(value);
                ReportPropertyChanging("Second_Name");
                _Second_Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Second_Name");
                OnSecond_NameChanged();
            }
        }
        private global::System.String _Second_Name;
        partial void OnSecond_NameChanging(global::System.String value);
        partial void OnSecond_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Third_Name
        {
            get
            {
                return _Third_Name;
            }
            set
            {
                OnThird_NameChanging(value);
                ReportPropertyChanging("Third_Name");
                _Third_Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Third_Name");
                OnThird_NameChanged();
            }
        }
        private global::System.String _Third_Name;
        partial void OnThird_NameChanging(global::System.String value);
        partial void OnThird_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Last_Name
        {
            get
            {
                return _Last_Name;
            }
            set
            {
                OnLast_NameChanging(value);
                ReportPropertyChanging("Last_Name");
                _Last_Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Last_Name");
                OnLast_NameChanged();
            }
        }
        private global::System.String _Last_Name;
        partial void OnLast_NameChanging(global::System.String value);
        partial void OnLast_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Group_Id
        {
            get
            {
                return _Group_Id;
            }
            set
            {
                OnGroup_IdChanging(value);
                ReportPropertyChanging("Group_Id");
                _Group_Id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Group_Id");
                OnGroup_IdChanged();
            }
        }
        private global::System.Int32 _Group_Id;
        partial void OnGroup_IdChanging(global::System.Int32 value);
        partial void OnGroup_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Date_Created
        {
            get
            {
                return _Date_Created;
            }
            set
            {
                OnDate_CreatedChanging(value);
                ReportPropertyChanging("Date_Created");
                _Date_Created = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date_Created");
                OnDate_CreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Date_Created;
        partial void OnDate_CreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnDate_CreatedChanged();

        #endregion

    
    }

    #endregion

    
}
