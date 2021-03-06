﻿/*flexberryautogenerated="true"*/
namespace IIS.MyTestApplicationEmber
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class TypeL : BaseListForm<Type>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public TypeL() : base(Type.Views.TypeL)
        {
            EditPage = TypeE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Type/TypeL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
