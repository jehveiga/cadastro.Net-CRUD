﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pessoa.DAO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PIM")]
	public partial class DAODataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEndereco(EnderecoControle instance);
    partial void UpdateEndereco(EnderecoControle instance);
    partial void DeleteEndereco(EnderecoControle instance);
    partial void InsertPessoa(Pessoa instance);
    partial void UpdatePessoa(Pessoa instance);
    partial void DeletePessoa(Pessoa instance);
    partial void InsertPessoa_Telefone(Pessoa_Telefone instance);
    partial void UpdatePessoa_Telefone(Pessoa_Telefone instance);
    partial void DeletePessoa_Telefone(Pessoa_Telefone instance);
    partial void InsertTelefone(Telefone instance);
    partial void UpdateTelefone(Telefone instance);
    partial void DeleteTelefone(Telefone instance);
    partial void InsertTelefone_Tipo(Telefone_Tipo instance);
    partial void UpdateTelefone_Tipo(Telefone_Tipo instance);
    partial void DeleteTelefone_Tipo(Telefone_Tipo instance);
    #endregion
		
		public DAODataContext() : 
				base(global::Pessoa.DAO.Properties.Settings.Default.PIMConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DAODataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DAODataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DAODataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DAODataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EnderecoControle> Endereco
		{
			get
			{
				return this.GetTable<EnderecoControle>();
			}
		}
		
		public System.Data.Linq.Table<Pessoa> Pessoa
		{
			get
			{
				return this.GetTable<Pessoa>();
			}
		}
		
		public System.Data.Linq.Table<Pessoa_Telefone> Pessoa_Telefone
		{
			get
			{
				return this.GetTable<Pessoa_Telefone>();
			}
		}
		
		public System.Data.Linq.Table<Telefone> Telefone
		{
			get
			{
				return this.GetTable<Telefone>();
			}
		}
		
		public System.Data.Linq.Table<Telefone_Tipo> Telefone_Tipo
		{
			get
			{
				return this.GetTable<Telefone_Tipo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.endereco")]
	public partial class EnderecoControle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _logradouro;
		
		private System.Nullable<int> _numero;
		
		private System.Nullable<int> _cep;
		
		private string _bairro;
		
		private string _cidade;
		
		private string _estado;
		
		private EntitySet<Pessoa> _Pessoa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnlogradouroChanging(string value);
    partial void OnlogradouroChanged();
    partial void OnnumeroChanging(System.Nullable<int> value);
    partial void OnnumeroChanged();
    partial void OncepChanging(System.Nullable<int> value);
    partial void OncepChanged();
    partial void OnbairroChanging(string value);
    partial void OnbairroChanged();
    partial void OncidadeChanging(string value);
    partial void OncidadeChanged();
    partial void OnestadoChanging(string value);
    partial void OnestadoChanged();
    #endregion
		
		public EnderecoControle()
		{
			this._Pessoa = new EntitySet<Pessoa>(new Action<Pessoa>(this.attach_Pessoa), new Action<Pessoa>(this.detach_Pessoa));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_logradouro", DbType="VarChar(256)")]
		public string logradouro
		{
			get
			{
				return this._logradouro;
			}
			set
			{
				if ((this._logradouro != value))
				{
					this.OnlogradouroChanging(value);
					this.SendPropertyChanging();
					this._logradouro = value;
					this.SendPropertyChanged("logradouro");
					this.OnlogradouroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero", DbType="Int")]
		public System.Nullable<int> numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				if ((this._numero != value))
				{
					this.OnnumeroChanging(value);
					this.SendPropertyChanging();
					this._numero = value;
					this.SendPropertyChanged("numero");
					this.OnnumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cep", DbType="Int")]
		public System.Nullable<int> cep
		{
			get
			{
				return this._cep;
			}
			set
			{
				if ((this._cep != value))
				{
					this.OncepChanging(value);
					this.SendPropertyChanging();
					this._cep = value;
					this.SendPropertyChanged("cep");
					this.OncepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bairro", DbType="VarChar(50)")]
		public string bairro
		{
			get
			{
				return this._bairro;
			}
			set
			{
				if ((this._bairro != value))
				{
					this.OnbairroChanging(value);
					this.SendPropertyChanging();
					this._bairro = value;
					this.SendPropertyChanged("bairro");
					this.OnbairroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cidade", DbType="VarChar(30)")]
		public string cidade
		{
			get
			{
				return this._cidade;
			}
			set
			{
				if ((this._cidade != value))
				{
					this.OncidadeChanging(value);
					this.SendPropertyChanging();
					this._cidade = value;
					this.SendPropertyChanged("cidade");
					this.OncidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="VarChar(20)")]
		public string estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="endereco_pessoa", Storage="_Pessoa", ThisKey="id", OtherKey="endereco")]
		public EntitySet<Pessoa> Pessoa
		{
			get
			{
				return this._Pessoa;
			}
			set
			{
				this._Pessoa.Assign(value);
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
		
		private void attach_Pessoa(Pessoa entity)
		{
			this.SendPropertyChanging();
			entity.Endereco1 = this;
		}
		
		private void detach_Pessoa(Pessoa entity)
		{
			this.SendPropertyChanging();
			entity.Endereco1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pessoa")]
	public partial class Pessoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private System.Nullable<long> _cpf;
		
		private System.Nullable<int> _endereco;
		
		private EntitySet<Pessoa_Telefone> _Pessoa_Telefone;
		
		private EntityRef<EnderecoControle> _Endereco1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OncpfChanging(System.Nullable<long> value);
    partial void OncpfChanged();
    partial void OnenderecoChanging(System.Nullable<int> value);
    partial void OnenderecoChanged();
    #endregion
		
		public Pessoa()
		{
			this._Pessoa_Telefone = new EntitySet<Pessoa_Telefone>(new Action<Pessoa_Telefone>(this.attach_Pessoa_Telefone), new Action<Pessoa_Telefone>(this.detach_Pessoa_Telefone));
			this._Endereco1 = default(EntityRef<EnderecoControle>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(256)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cpf", DbType="BigInt")]
		public System.Nullable<long> cpf
		{
			get
			{
				return this._cpf;
			}
			set
			{
				if ((this._cpf != value))
				{
					this.OncpfChanging(value);
					this.SendPropertyChanging();
					this._cpf = value;
					this.SendPropertyChanged("cpf");
					this.OncpfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endereco", DbType="Int")]
		public System.Nullable<int> endereco
		{
			get
			{
				return this._endereco;
			}
			set
			{
				if ((this._endereco != value))
				{
					if (this._Endereco1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnenderecoChanging(value);
					this.SendPropertyChanging();
					this._endereco = value;
					this.SendPropertyChanged("endereco");
					this.OnenderecoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pessoa_pessoa_telefone", Storage="_Pessoa_Telefone", ThisKey="id", OtherKey="id_pessoa")]
		public EntitySet<Pessoa_Telefone> Pessoa_Telefone
		{
			get
			{
				return this._Pessoa_Telefone;
			}
			set
			{
				this._Pessoa_Telefone.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="endereco_pessoa", Storage="_Endereco1", ThisKey="endereco", OtherKey="id", IsForeignKey=true)]
		public EnderecoControle Endereco1
		{
			get
			{
				return this._Endereco1.Entity;
			}
			set
			{
				EnderecoControle previousValue = this._Endereco1.Entity;
				if (((previousValue != value) 
							|| (this._Endereco1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Endereco1.Entity = null;
						previousValue.Pessoa.Remove(this);
					}
					this._Endereco1.Entity = value;
					if ((value != null))
					{
						value.Pessoa.Add(this);
						this._endereco = value.id;
					}
					else
					{
						this._endereco = default(Nullable<int>);
					}
					this.SendPropertyChanged("Endereco1");
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
		
		private void attach_Pessoa_Telefone(Pessoa_Telefone entity)
		{
			this.SendPropertyChanging();
			entity.Pessoa = this;
		}
		
		private void detach_Pessoa_Telefone(Pessoa_Telefone entity)
		{
			this.SendPropertyChanging();
			entity.Pessoa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pessoa_telefone")]
	public partial class Pessoa_Telefone : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_pessoa;
		
		private int _id_telefone;
		
		private EntityRef<Pessoa> _Pessoa;
		
		private EntityRef<Telefone> _Telefone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_pessoaChanging(int value);
    partial void Onid_pessoaChanged();
    partial void Onid_telefoneChanging(int value);
    partial void Onid_telefoneChanged();
    #endregion
		
		public Pessoa_Telefone()
		{
			this._Pessoa = default(EntityRef<Pessoa>);
			this._Telefone = default(EntityRef<Telefone>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pessoa", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_pessoa
		{
			get
			{
				return this._id_pessoa;
			}
			set
			{
				if ((this._id_pessoa != value))
				{
					if (this._Pessoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pessoaChanging(value);
					this.SendPropertyChanging();
					this._id_pessoa = value;
					this.SendPropertyChanged("id_pessoa");
					this.Onid_pessoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_telefone", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_telefone
		{
			get
			{
				return this._id_telefone;
			}
			set
			{
				if ((this._id_telefone != value))
				{
					if (this._Telefone.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_telefoneChanging(value);
					this.SendPropertyChanging();
					this._id_telefone = value;
					this.SendPropertyChanged("id_telefone");
					this.Onid_telefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pessoa_pessoa_telefone", Storage="_Pessoa", ThisKey="id_pessoa", OtherKey="id", IsForeignKey=true)]
		public Pessoa Pessoa
		{
			get
			{
				return this._Pessoa.Entity;
			}
			set
			{
				Pessoa previousValue = this._Pessoa.Entity;
				if (((previousValue != value) 
							|| (this._Pessoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pessoa.Entity = null;
						previousValue.Pessoa_Telefone.Remove(this);
					}
					this._Pessoa.Entity = value;
					if ((value != null))
					{
						value.Pessoa_Telefone.Add(this);
						this._id_pessoa = value.id;
					}
					else
					{
						this._id_pessoa = default(int);
					}
					this.SendPropertyChanged("Pessoa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="telefone_pessoa_telefone", Storage="_Telefone", ThisKey="id_telefone", OtherKey="id", IsForeignKey=true)]
		public Telefone Telefone
		{
			get
			{
				return this._Telefone.Entity;
			}
			set
			{
				Telefone previousValue = this._Telefone.Entity;
				if (((previousValue != value) 
							|| (this._Telefone.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Telefone.Entity = null;
						previousValue.Pessoa_Telefone.Remove(this);
					}
					this._Telefone.Entity = value;
					if ((value != null))
					{
						value.Pessoa_Telefone.Add(this);
						this._id_telefone = value.id;
					}
					else
					{
						this._id_telefone = default(int);
					}
					this.SendPropertyChanged("Telefone");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.telefone")]
	public partial class Telefone : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _numero;
		
		private System.Nullable<int> _ddd;
		
		private System.Nullable<int> _tipo;
		
		private EntitySet<Pessoa_Telefone> _Pessoa_Telefone;
		
		private EntityRef<Telefone_Tipo> _Telefone_Tipo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnumeroChanging(System.Nullable<int> value);
    partial void OnnumeroChanged();
    partial void OndddChanging(System.Nullable<int> value);
    partial void OndddChanged();
    partial void OntipoChanging(System.Nullable<int> value);
    partial void OntipoChanged();
    #endregion
		
		public Telefone()
		{
			this._Pessoa_Telefone = new EntitySet<Pessoa_Telefone>(new Action<Pessoa_Telefone>(this.attach_Pessoa_Telefone), new Action<Pessoa_Telefone>(this.detach_Pessoa_Telefone));
			this._Telefone_Tipo = default(EntityRef<Telefone_Tipo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero", DbType="Int")]
		public System.Nullable<int> numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				if ((this._numero != value))
				{
					this.OnnumeroChanging(value);
					this.SendPropertyChanging();
					this._numero = value;
					this.SendPropertyChanged("numero");
					this.OnnumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ddd", DbType="Int")]
		public System.Nullable<int> ddd
		{
			get
			{
				return this._ddd;
			}
			set
			{
				if ((this._ddd != value))
				{
					this.OndddChanging(value);
					this.SendPropertyChanging();
					this._ddd = value;
					this.SendPropertyChanged("ddd");
					this.OndddChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="Int")]
		public System.Nullable<int> tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					if (this._Telefone_Tipo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="telefone_pessoa_telefone", Storage="_Pessoa_Telefone", ThisKey="id", OtherKey="id_telefone")]
		public EntitySet<Pessoa_Telefone> Pessoa_Telefone
		{
			get
			{
				return this._Pessoa_Telefone;
			}
			set
			{
				this._Pessoa_Telefone.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="telefone_tipo_telefone", Storage="_Telefone_Tipo", ThisKey="tipo", OtherKey="id", IsForeignKey=true)]
		public Telefone_Tipo Telefone_Tipo
		{
			get
			{
				return this._Telefone_Tipo.Entity;
			}
			set
			{
				Telefone_Tipo previousValue = this._Telefone_Tipo.Entity;
				if (((previousValue != value) 
							|| (this._Telefone_Tipo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Telefone_Tipo.Entity = null;
						previousValue.Telefone.Remove(this);
					}
					this._Telefone_Tipo.Entity = value;
					if ((value != null))
					{
						value.Telefone.Add(this);
						this._tipo = value.id;
					}
					else
					{
						this._tipo = default(Nullable<int>);
					}
					this.SendPropertyChanged("Telefone_Tipo");
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
		
		private void attach_Pessoa_Telefone(Pessoa_Telefone entity)
		{
			this.SendPropertyChanging();
			entity.Telefone = this;
		}
		
		private void detach_Pessoa_Telefone(Pessoa_Telefone entity)
		{
			this.SendPropertyChanging();
			entity.Telefone = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.telefone_tipo")]
	public partial class Telefone_Tipo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _tipo;
		
		private EntitySet<Telefone> _Telefone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntipoChanging(string value);
    partial void OntipoChanged();
    #endregion
		
		public Telefone_Tipo()
		{
			this._Telefone = new EntitySet<Telefone>(new Action<Telefone>(this.attach_Telefone), new Action<Telefone>(this.detach_Telefone));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="VarChar(10)")]
		public string tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="telefone_tipo_telefone", Storage="_Telefone", ThisKey="id", OtherKey="tipo")]
		public EntitySet<Telefone> Telefone
		{
			get
			{
				return this._Telefone;
			}
			set
			{
				this._Telefone.Assign(value);
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
		
		private void attach_Telefone(Telefone entity)
		{
			this.SendPropertyChanging();
			entity.Telefone_Tipo = this;
		}
		
		private void detach_Telefone(Telefone entity)
		{
			this.SendPropertyChanging();
			entity.Telefone_Tipo = null;
		}
	}
}
#pragma warning restore 1591
