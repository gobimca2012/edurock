﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
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
	public partial class OnlineExaminationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEXM_Answer(EXM_Answer instance);
    partial void UpdateEXM_Answer(EXM_Answer instance);
    partial void DeleteEXM_Answer(EXM_Answer instance);
    partial void InsertEXM_Question(EXM_Question instance);
    partial void UpdateEXM_Question(EXM_Question instance);
    partial void DeleteEXM_Question(EXM_Question instance);
    partial void InsertEXM_UserAnswer(EXM_UserAnswer instance);
    partial void UpdateEXM_UserAnswer(EXM_UserAnswer instance);
    partial void DeleteEXM_UserAnswer(EXM_UserAnswer instance);
    partial void InsertLoginUser(LoginUser instance);
    partial void UpdateLoginUser(LoginUser instance);
    partial void DeleteLoginUser(LoginUser instance);
    partial void InsertExam(Exam instance);
    partial void UpdateExam(Exam instance);
    partial void DeleteExam(Exam instance);
    #endregion
		
		public OnlineExaminationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineExaminationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineExaminationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineExaminationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EXM_Answer> EXM_Answers
		{
			get
			{
				return this.GetTable<EXM_Answer>();
			}
		}
		
		public System.Data.Linq.Table<EXM_Question> EXM_Questions
		{
			get
			{
				return this.GetTable<EXM_Question>();
			}
		}
		
		public System.Data.Linq.Table<EXM_UserAnswer> EXM_UserAnswers
		{
			get
			{
				return this.GetTable<EXM_UserAnswer>();
			}
		}
		
		public System.Data.Linq.Table<LoginUser> LoginUsers
		{
			get
			{
				return this.GetTable<LoginUser>();
			}
		}
		
		public System.Data.Linq.Table<Exam> Exams
		{
			get
			{
				return this.GetTable<Exam>();
			}
		}
	}
	
	[Table(Name="dbo.EXM_Answer")]
	public partial class EXM_Answer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EXM_AnswerID;
		
		private int _EXM_QuestionID;
		
		private string _Answer;
		
		private bool _IsRight;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<EXM_UserAnswer> _EXM_UserAnswers;
		
		private EntityRef<EXM_Question> _EXM_Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEXM_AnswerIDChanging(int value);
    partial void OnEXM_AnswerIDChanged();
    partial void OnEXM_QuestionIDChanging(int value);
    partial void OnEXM_QuestionIDChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    partial void OnIsRightChanging(bool value);
    partial void OnIsRightChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public EXM_Answer()
		{
			this._EXM_UserAnswers = new EntitySet<EXM_UserAnswer>(new Action<EXM_UserAnswer>(this.attach_EXM_UserAnswers), new Action<EXM_UserAnswer>(this.detach_EXM_UserAnswers));
			this._EXM_Question = default(EntityRef<EXM_Question>);
			OnCreated();
		}
		
		[Column(Storage="_EXM_AnswerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EXM_AnswerID
		{
			get
			{
				return this._EXM_AnswerID;
			}
			set
			{
				if ((this._EXM_AnswerID != value))
				{
					this.OnEXM_AnswerIDChanging(value);
					this.SendPropertyChanging();
					this._EXM_AnswerID = value;
					this.SendPropertyChanged("EXM_AnswerID");
					this.OnEXM_AnswerIDChanged();
				}
			}
		}
		
		[Column(Storage="_EXM_QuestionID", DbType="Int NOT NULL")]
		public int EXM_QuestionID
		{
			get
			{
				return this._EXM_QuestionID;
			}
			set
			{
				if ((this._EXM_QuestionID != value))
				{
					if (this._EXM_Question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEXM_QuestionIDChanging(value);
					this.SendPropertyChanging();
					this._EXM_QuestionID = value;
					this.SendPropertyChanged("EXM_QuestionID");
					this.OnEXM_QuestionIDChanged();
				}
			}
		}
		
		[Column(Storage="_Answer", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this.OnAnswerChanging(value);
					this.SendPropertyChanging();
					this._Answer = value;
					this.SendPropertyChanged("Answer");
					this.OnAnswerChanged();
				}
			}
		}
		
		[Column(Storage="_IsRight", DbType="Bit NOT NULL")]
		public bool IsRight
		{
			get
			{
				return this._IsRight;
			}
			set
			{
				if ((this._IsRight != value))
				{
					this.OnIsRightChanging(value);
					this.SendPropertyChanging();
					this._IsRight = value;
					this.SendPropertyChanged("IsRight");
					this.OnIsRightChanged();
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
		
		[Association(Name="EXM_Answer_EXM_UserAnswer", Storage="_EXM_UserAnswers", OtherKey="EXM_AnswerID")]
		public EntitySet<EXM_UserAnswer> EXM_UserAnswers
		{
			get
			{
				return this._EXM_UserAnswers;
			}
			set
			{
				this._EXM_UserAnswers.Assign(value);
			}
		}
		
		[Association(Name="EXM_Question_EXM_Answer", Storage="_EXM_Question", ThisKey="EXM_QuestionID", IsForeignKey=true)]
		public EXM_Question EXM_Question
		{
			get
			{
				return this._EXM_Question.Entity;
			}
			set
			{
				EXM_Question previousValue = this._EXM_Question.Entity;
				if (((previousValue != value) 
							|| (this._EXM_Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EXM_Question.Entity = null;
						previousValue.EXM_Answers.Remove(this);
					}
					this._EXM_Question.Entity = value;
					if ((value != null))
					{
						value.EXM_Answers.Add(this);
						this._EXM_QuestionID = value.EXM_QuestionID;
					}
					else
					{
						this._EXM_QuestionID = default(int);
					}
					this.SendPropertyChanged("EXM_Question");
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
		
		private void attach_EXM_UserAnswers(EXM_UserAnswer entity)
		{
			this.SendPropertyChanging();
			entity.EXM_Answer = this;
		}
		
		private void detach_EXM_UserAnswers(EXM_UserAnswer entity)
		{
			this.SendPropertyChanging();
			entity.EXM_Answer = null;
		}
	}
	
	[Table(Name="dbo.EXM_Question")]
	public partial class EXM_Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EXM_QuestionID;
		
		private string _Question;
		
		private int _LoginUserID;
		
		private int _ExamID;
		
		private int _Q_Type;
		
		private string _Description;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<EXM_Answer> _EXM_Answers;
		
		private EntityRef<Exam> _Exam;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEXM_QuestionIDChanging(int value);
    partial void OnEXM_QuestionIDChanged();
    partial void OnQuestionChanging(string value);
    partial void OnQuestionChanged();
    partial void OnLoginUserIDChanging(int value);
    partial void OnLoginUserIDChanged();
    partial void OnExamIDChanging(int value);
    partial void OnExamIDChanged();
    partial void OnQ_TypeChanging(int value);
    partial void OnQ_TypeChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public EXM_Question()
		{
			this._EXM_Answers = new EntitySet<EXM_Answer>(new Action<EXM_Answer>(this.attach_EXM_Answers), new Action<EXM_Answer>(this.detach_EXM_Answers));
			this._Exam = default(EntityRef<Exam>);
			OnCreated();
		}
		
		[Column(Storage="_EXM_QuestionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EXM_QuestionID
		{
			get
			{
				return this._EXM_QuestionID;
			}
			set
			{
				if ((this._EXM_QuestionID != value))
				{
					this.OnEXM_QuestionIDChanging(value);
					this.SendPropertyChanging();
					this._EXM_QuestionID = value;
					this.SendPropertyChanged("EXM_QuestionID");
					this.OnEXM_QuestionIDChanged();
				}
			}
		}
		
		[Column(Storage="_Question", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Question
		{
			get
			{
				return this._Question;
			}
			set
			{
				if ((this._Question != value))
				{
					this.OnQuestionChanging(value);
					this.SendPropertyChanging();
					this._Question = value;
					this.SendPropertyChanged("Question");
					this.OnQuestionChanged();
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
		
		[Column(Storage="_ExamID", DbType="Int NOT NULL")]
		public int ExamID
		{
			get
			{
				return this._ExamID;
			}
			set
			{
				if ((this._ExamID != value))
				{
					if (this._Exam.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExamIDChanging(value);
					this.SendPropertyChanging();
					this._ExamID = value;
					this.SendPropertyChanged("ExamID");
					this.OnExamIDChanged();
				}
			}
		}
		
		[Column(Storage="_Q_Type", DbType="Int NOT NULL")]
		public int Q_Type
		{
			get
			{
				return this._Q_Type;
			}
			set
			{
				if ((this._Q_Type != value))
				{
					this.OnQ_TypeChanging(value);
					this.SendPropertyChanging();
					this._Q_Type = value;
					this.SendPropertyChanged("Q_Type");
					this.OnQ_TypeChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
		
		[Association(Name="EXM_Question_EXM_Answer", Storage="_EXM_Answers", OtherKey="EXM_QuestionID")]
		public EntitySet<EXM_Answer> EXM_Answers
		{
			get
			{
				return this._EXM_Answers;
			}
			set
			{
				this._EXM_Answers.Assign(value);
			}
		}
		
		[Association(Name="Exam_EXM_Question", Storage="_Exam", ThisKey="ExamID", IsForeignKey=true)]
		public Exam Exam
		{
			get
			{
				return this._Exam.Entity;
			}
			set
			{
				Exam previousValue = this._Exam.Entity;
				if (((previousValue != value) 
							|| (this._Exam.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Exam.Entity = null;
						previousValue.EXM_Questions.Remove(this);
					}
					this._Exam.Entity = value;
					if ((value != null))
					{
						value.EXM_Questions.Add(this);
						this._ExamID = value.ExamID;
					}
					else
					{
						this._ExamID = default(int);
					}
					this.SendPropertyChanged("Exam");
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
		
		private void attach_EXM_Answers(EXM_Answer entity)
		{
			this.SendPropertyChanging();
			entity.EXM_Question = this;
		}
		
		private void detach_EXM_Answers(EXM_Answer entity)
		{
			this.SendPropertyChanging();
			entity.EXM_Question = null;
		}
	}
	
	[Table(Name="dbo.EXM_UserAnswer")]
	public partial class EXM_UserAnswer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EXM_UserAnswerID;
		
		private int _LoginUserID;
		
		private int _EXM_AnswerID;
		
		private string _EXM_AnswerText;
		
		private System.DateTime _ModifiedDate;
		
		private EntityRef<EXM_Answer> _EXM_Answer;
		
		private EntityRef<LoginUser> _LoginUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEXM_UserAnswerIDChanging(int value);
    partial void OnEXM_UserAnswerIDChanged();
    partial void OnLoginUserIDChanging(int value);
    partial void OnLoginUserIDChanged();
    partial void OnEXM_AnswerIDChanging(int value);
    partial void OnEXM_AnswerIDChanged();
    partial void OnEXM_AnswerTextChanging(string value);
    partial void OnEXM_AnswerTextChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public EXM_UserAnswer()
		{
			this._EXM_Answer = default(EntityRef<EXM_Answer>);
			this._LoginUser = default(EntityRef<LoginUser>);
			OnCreated();
		}
		
		[Column(Storage="_EXM_UserAnswerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EXM_UserAnswerID
		{
			get
			{
				return this._EXM_UserAnswerID;
			}
			set
			{
				if ((this._EXM_UserAnswerID != value))
				{
					this.OnEXM_UserAnswerIDChanging(value);
					this.SendPropertyChanging();
					this._EXM_UserAnswerID = value;
					this.SendPropertyChanged("EXM_UserAnswerID");
					this.OnEXM_UserAnswerIDChanged();
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
					if (this._LoginUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoginUserIDChanging(value);
					this.SendPropertyChanging();
					this._LoginUserID = value;
					this.SendPropertyChanged("LoginUserID");
					this.OnLoginUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_EXM_AnswerID", DbType="Int NOT NULL")]
		public int EXM_AnswerID
		{
			get
			{
				return this._EXM_AnswerID;
			}
			set
			{
				if ((this._EXM_AnswerID != value))
				{
					if (this._EXM_Answer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEXM_AnswerIDChanging(value);
					this.SendPropertyChanging();
					this._EXM_AnswerID = value;
					this.SendPropertyChanged("EXM_AnswerID");
					this.OnEXM_AnswerIDChanged();
				}
			}
		}
		
		[Column(Storage="_EXM_AnswerText", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string EXM_AnswerText
		{
			get
			{
				return this._EXM_AnswerText;
			}
			set
			{
				if ((this._EXM_AnswerText != value))
				{
					this.OnEXM_AnswerTextChanging(value);
					this.SendPropertyChanging();
					this._EXM_AnswerText = value;
					this.SendPropertyChanged("EXM_AnswerText");
					this.OnEXM_AnswerTextChanged();
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
		
		[Association(Name="EXM_Answer_EXM_UserAnswer", Storage="_EXM_Answer", ThisKey="EXM_AnswerID", IsForeignKey=true)]
		public EXM_Answer EXM_Answer
		{
			get
			{
				return this._EXM_Answer.Entity;
			}
			set
			{
				EXM_Answer previousValue = this._EXM_Answer.Entity;
				if (((previousValue != value) 
							|| (this._EXM_Answer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EXM_Answer.Entity = null;
						previousValue.EXM_UserAnswers.Remove(this);
					}
					this._EXM_Answer.Entity = value;
					if ((value != null))
					{
						value.EXM_UserAnswers.Add(this);
						this._EXM_AnswerID = value.EXM_AnswerID;
					}
					else
					{
						this._EXM_AnswerID = default(int);
					}
					this.SendPropertyChanged("EXM_Answer");
				}
			}
		}
		
		[Association(Name="LoginUser_EXM_UserAnswer", Storage="_LoginUser", ThisKey="LoginUserID", IsForeignKey=true)]
		public LoginUser LoginUser
		{
			get
			{
				return this._LoginUser.Entity;
			}
			set
			{
				LoginUser previousValue = this._LoginUser.Entity;
				if (((previousValue != value) 
							|| (this._LoginUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoginUser.Entity = null;
						previousValue.EXM_UserAnswers.Remove(this);
					}
					this._LoginUser.Entity = value;
					if ((value != null))
					{
						value.EXM_UserAnswers.Add(this);
						this._LoginUserID = value.LoginUserID;
					}
					else
					{
						this._LoginUserID = default(int);
					}
					this.SendPropertyChanged("LoginUser");
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
	
	[Table(Name="dbo.LoginUser")]
	public partial class LoginUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LoginUserID;
		
		private string _Username;
		
		private string _Password;
		
		private int _UserType;
		
		private System.Guid _UserId;
		
		private System.DateTime _ModifiedDate;
		
		private System.DateTime _CreatedDate;
		
		private EntitySet<EXM_UserAnswer> _EXM_UserAnswers;
		
		private EntitySet<Exam> _Exams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginUserIDChanging(int value);
    partial void OnLoginUserIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUserTypeChanging(int value);
    partial void OnUserTypeChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    #endregion
		
		public LoginUser()
		{
			this._EXM_UserAnswers = new EntitySet<EXM_UserAnswer>(new Action<EXM_UserAnswer>(this.attach_EXM_UserAnswers), new Action<EXM_UserAnswer>(this.detach_EXM_UserAnswers));
			this._Exams = new EntitySet<Exam>(new Action<Exam>(this.attach_Exams), new Action<Exam>(this.detach_Exams));
			OnCreated();
		}
		
		[Column(Storage="_LoginUserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[Column(Storage="_Username", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[Column(Storage="_Password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_UserType", DbType="Int NOT NULL")]
		public int UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[Column(Storage="_UserId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
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
		
		[Column(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[Association(Name="LoginUser_EXM_UserAnswer", Storage="_EXM_UserAnswers", OtherKey="LoginUserID")]
		public EntitySet<EXM_UserAnswer> EXM_UserAnswers
		{
			get
			{
				return this._EXM_UserAnswers;
			}
			set
			{
				this._EXM_UserAnswers.Assign(value);
			}
		}
		
		[Association(Name="LoginUser_Exam", Storage="_Exams", OtherKey="LoginUserID")]
		public EntitySet<Exam> Exams
		{
			get
			{
				return this._Exams;
			}
			set
			{
				this._Exams.Assign(value);
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
		
		private void attach_EXM_UserAnswers(EXM_UserAnswer entity)
		{
			this.SendPropertyChanging();
			entity.LoginUser = this;
		}
		
		private void detach_EXM_UserAnswers(EXM_UserAnswer entity)
		{
			this.SendPropertyChanging();
			entity.LoginUser = null;
		}
		
		private void attach_Exams(Exam entity)
		{
			this.SendPropertyChanging();
			entity.LoginUser = this;
		}
		
		private void detach_Exams(Exam entity)
		{
			this.SendPropertyChanging();
			entity.LoginUser = null;
		}
	}
	
	[Table(Name="dbo.Exam")]
	public partial class Exam : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExamID;
		
		private string _ExamName;
		
		private string _SubjectName;
		
		private int _LoginUserID;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<EXM_Question> _EXM_Questions;
		
		private EntityRef<LoginUser> _LoginUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExamIDChanging(int value);
    partial void OnExamIDChanged();
    partial void OnExamNameChanging(string value);
    partial void OnExamNameChanged();
    partial void OnSubjectNameChanging(string value);
    partial void OnSubjectNameChanged();
    partial void OnLoginUserIDChanging(int value);
    partial void OnLoginUserIDChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public Exam()
		{
			this._EXM_Questions = new EntitySet<EXM_Question>(new Action<EXM_Question>(this.attach_EXM_Questions), new Action<EXM_Question>(this.detach_EXM_Questions));
			this._LoginUser = default(EntityRef<LoginUser>);
			OnCreated();
		}
		
		[Column(Storage="_ExamID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ExamID
		{
			get
			{
				return this._ExamID;
			}
			set
			{
				if ((this._ExamID != value))
				{
					this.OnExamIDChanging(value);
					this.SendPropertyChanging();
					this._ExamID = value;
					this.SendPropertyChanged("ExamID");
					this.OnExamIDChanged();
				}
			}
		}
		
		[Column(Storage="_ExamName", DbType="VarChar(2000) NOT NULL", CanBeNull=false)]
		public string ExamName
		{
			get
			{
				return this._ExamName;
			}
			set
			{
				if ((this._ExamName != value))
				{
					this.OnExamNameChanging(value);
					this.SendPropertyChanging();
					this._ExamName = value;
					this.SendPropertyChanged("ExamName");
					this.OnExamNameChanged();
				}
			}
		}
		
		[Column(Storage="_SubjectName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this.OnSubjectNameChanging(value);
					this.SendPropertyChanging();
					this._SubjectName = value;
					this.SendPropertyChanged("SubjectName");
					this.OnSubjectNameChanged();
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
					if (this._LoginUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoginUserIDChanging(value);
					this.SendPropertyChanging();
					this._LoginUserID = value;
					this.SendPropertyChanged("LoginUserID");
					this.OnLoginUserIDChanged();
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
		
		[Association(Name="Exam_EXM_Question", Storage="_EXM_Questions", OtherKey="ExamID")]
		public EntitySet<EXM_Question> EXM_Questions
		{
			get
			{
				return this._EXM_Questions;
			}
			set
			{
				this._EXM_Questions.Assign(value);
			}
		}
		
		[Association(Name="LoginUser_Exam", Storage="_LoginUser", ThisKey="LoginUserID", IsForeignKey=true)]
		public LoginUser LoginUser
		{
			get
			{
				return this._LoginUser.Entity;
			}
			set
			{
				LoginUser previousValue = this._LoginUser.Entity;
				if (((previousValue != value) 
							|| (this._LoginUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoginUser.Entity = null;
						previousValue.Exams.Remove(this);
					}
					this._LoginUser.Entity = value;
					if ((value != null))
					{
						value.Exams.Add(this);
						this._LoginUserID = value.LoginUserID;
					}
					else
					{
						this._LoginUserID = default(int);
					}
					this.SendPropertyChanged("LoginUser");
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
		
		private void attach_EXM_Questions(EXM_Question entity)
		{
			this.SendPropertyChanging();
			entity.Exam = this;
		}
		
		private void detach_EXM_Questions(EXM_Question entity)
		{
			this.SendPropertyChanging();
			entity.Exam = null;
		}
	}
}
#pragma warning restore 1591
