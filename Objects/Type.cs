﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.MyTestApplicationEmber
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Type.
    /// </summary>
    //  *** Start programmer edit section *** (Type CustomAttributes)

    //  *** End programmer edit section *** (Type CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "Name as \'Name\'"})]
    [View("TypeE", new string[] {
            "Name as \'Name\'"})]
    [View("TypeL", new string[] {
            "Name as \'Name\'",
            "CreateTime as \'Создание\'",
            "Creator as \'Создатель\'",
            "EditTime as \'Редактирование\'",
            "Editor as \'Редактор\'"})]
    public class Type : ICSSoft.STORMNET.DataObject, IIS.MyTestApplicationEmber.IName, IDataObjectWithAuditFields
    {
        
        private string fName;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        //  *** Start programmer edit section *** (Type CustomMembers)

        //  *** End programmer edit section *** (Type CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        //  *** Start programmer edit section *** (Type.Name CustomAttributes)

        //  *** End programmer edit section *** (Type.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                //  *** Start programmer edit section *** (Type.Name Get start)

                //  *** End programmer edit section *** (Type.Name Get start)
                string result = this.fName;
                //  *** Start programmer edit section *** (Type.Name Get end)

                //  *** End programmer edit section *** (Type.Name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Type.Name Set start)

                //  *** End programmer edit section *** (Type.Name Set start)
                this.fName = value;
                //  *** Start programmer edit section *** (Type.Name Set end)

                //  *** End programmer edit section *** (Type.Name Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Type.CreateTime CustomAttributes)

        //  *** End programmer edit section *** (Type.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                //  *** Start programmer edit section *** (Type.CreateTime Get start)

                //  *** End programmer edit section *** (Type.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                //  *** Start programmer edit section *** (Type.CreateTime Get end)

                //  *** End programmer edit section *** (Type.CreateTime Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Type.CreateTime Set start)

                //  *** End programmer edit section *** (Type.CreateTime Set start)
                this.fCreateTime = value;
                //  *** Start programmer edit section *** (Type.CreateTime Set end)

                //  *** End programmer edit section *** (Type.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Type.Creator CustomAttributes)

        //  *** End programmer edit section *** (Type.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                //  *** Start programmer edit section *** (Type.Creator Get start)

                //  *** End programmer edit section *** (Type.Creator Get start)
                string result = this.fCreator;
                //  *** Start programmer edit section *** (Type.Creator Get end)

                //  *** End programmer edit section *** (Type.Creator Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Type.Creator Set start)

                //  *** End programmer edit section *** (Type.Creator Set start)
                this.fCreator = value;
                //  *** Start programmer edit section *** (Type.Creator Set end)

                //  *** End programmer edit section *** (Type.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Type.EditTime CustomAttributes)

        //  *** End programmer edit section *** (Type.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                //  *** Start programmer edit section *** (Type.EditTime Get start)

                //  *** End programmer edit section *** (Type.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                //  *** Start programmer edit section *** (Type.EditTime Get end)

                //  *** End programmer edit section *** (Type.EditTime Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Type.EditTime Set start)

                //  *** End programmer edit section *** (Type.EditTime Set start)
                this.fEditTime = value;
                //  *** Start programmer edit section *** (Type.EditTime Set end)

                //  *** End programmer edit section *** (Type.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Type.Editor CustomAttributes)

        //  *** End programmer edit section *** (Type.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                //  *** Start programmer edit section *** (Type.Editor Get start)

                //  *** End programmer edit section *** (Type.Editor Get start)
                string result = this.fEditor;
                //  *** Start programmer edit section *** (Type.Editor Get end)

                //  *** End programmer edit section *** (Type.Editor Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Type.Editor Set start)

                //  *** End programmer edit section *** (Type.Editor Set start)
                this.fEditor = value;
                //  *** Start programmer edit section *** (Type.Editor Set end)

                //  *** End programmer edit section *** (Type.Editor Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.MyTestApplicationEmber.Type));
                }
            }
            
            /// <summary>
            /// "TypeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TypeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TypeE", typeof(IIS.MyTestApplicationEmber.Type));
                }
            }
            
            /// <summary>
            /// "TypeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TypeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TypeL", typeof(IIS.MyTestApplicationEmber.Type));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
}
