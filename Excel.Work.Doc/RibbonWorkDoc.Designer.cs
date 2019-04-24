namespace Excel.Work.Doc
{
    partial class RibbonWorkDoc : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonWorkDoc()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.gallery1 = this.Factory.CreateRibbonGallery();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // menu1
            // 
            this.menu1.Label = "menu1";
            this.menu1.Name = "menu1";
            this.menu1.ShowImage = true;
            // 
            // group1
            // 
            this.group1.Items.Add(this.gallery1);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // gallery1
            // 
            this.gallery1.Label = "gallery1";
            this.gallery1.Name = "gallery1";
            // 
            // RibbonWorkDoc
            // 
            this.Name = "RibbonWorkDoc";
            // 
            // RibbonWorkDoc.OfficeMenu
            // 
            this.OfficeMenu.Items.Add(this.menu1);
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonWorkDoc_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery gallery1;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonWorkDoc RibbonWorkDoc
        {
            get { return this.GetRibbon<RibbonWorkDoc>(); }
        }
    }
}
