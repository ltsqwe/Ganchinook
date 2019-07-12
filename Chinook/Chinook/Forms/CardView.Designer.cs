namespace Chinook.Forms
{
    partial class CardView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colAlbumId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtistId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtistName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dcpBasket = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dcpBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.albumBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(693, 196);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.GridControl1_Click);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Chinook.Data.Album);
            // 
            // cardView1
            // 
            this.cardView1.CardWidth = 175;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAlbumId,
            this.colTitle,
            this.colArtistId,
            this.colArtistName});
            this.cardView1.DetailHeight = 280;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // colAlbumId
            // 
            this.colAlbumId.FieldName = "AlbumId";
            this.colAlbumId.MinWidth = 22;
            this.colAlbumId.Name = "colAlbumId";
            this.colAlbumId.Visible = true;
            this.colAlbumId.VisibleIndex = 0;
            this.colAlbumId.Width = 82;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.MinWidth = 22;
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 82;
            // 
            // colArtistId
            // 
            this.colArtistId.FieldName = "ArtistId";
            this.colArtistId.MinWidth = 22;
            this.colArtistId.Name = "colArtistId";
            this.colArtistId.Visible = true;
            this.colArtistId.VisibleIndex = 2;
            this.colArtistId.Width = 82;
            // 
            // colArtistName
            // 
            this.colArtistName.FieldName = "ArtistName";
            this.colArtistName.MinWidth = 22;
            this.colArtistName.Name = "colArtistName";
            this.colArtistName.Visible = true;
            this.colArtistName.VisibleIndex = 3;
            this.colArtistName.Width = 82;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dcpBasket});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dcpBasket
            // 
            this.dcpBasket.Controls.Add(this.dockPanel1_Container);
            this.dcpBasket.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dcpBasket.ID = new System.Guid("9337ed30-39ec-4c50-839a-a7f6b5efbfab");
            this.dcpBasket.Location = new System.Drawing.Point(0, 345);
            this.dcpBasket.Name = "dcpBasket";
            this.dcpBasket.OriginalSize = new System.Drawing.Size(200, 200);
            this.dcpBasket.Size = new System.Drawing.Size(885, 200);
            this.dcpBasket.Text = "Basket";
            this.dcpBasket.Click += new System.EventHandler(this.DockPanel1_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(877, 172);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(4, 2);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(693, 196);
            this.gridSplitContainer1.TabIndex = 2;
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 545);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.dcpBasket);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardView";
            this.Text = "CardView";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dcpBasket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlbumId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colArtistId;
        private DevExpress.XtraGrid.Columns.GridColumn colArtistName;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dcpBasket;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}