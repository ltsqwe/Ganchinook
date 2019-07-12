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
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colTrackId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlbumId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMediaTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenreId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComposer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMilliseconds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBytes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dcpCart = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.invoiceLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvInvoiceLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.colInvoiceLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrackId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dcpCart.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInvoiceLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.trackBindingSource;
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
            // trackBindingSource
            // 
            this.trackBindingSource.DataSource = typeof(Chinook.Data.Track);
            // 
            // cardView1
            // 
            this.cardView1.CardWidth = 175;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrackId,
            this.colName,
            this.colAlbumId,
            this.colMediaTypeId,
            this.colGenreId,
            this.colComposer,
            this.colMilliseconds,
            this.colBytes,
            this.colUnitPrice1});
            this.cardView1.DetailHeight = 280;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // colTrackId
            // 
            this.colTrackId.FieldName = "TrackId";
            this.colTrackId.Name = "colTrackId";
            this.colTrackId.Visible = true;
            this.colTrackId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colAlbumId
            // 
            this.colAlbumId.FieldName = "AlbumId";
            this.colAlbumId.Name = "colAlbumId";
            this.colAlbumId.Visible = true;
            this.colAlbumId.VisibleIndex = 2;
            // 
            // colMediaTypeId
            // 
            this.colMediaTypeId.FieldName = "MediaTypeId";
            this.colMediaTypeId.Name = "colMediaTypeId";
            this.colMediaTypeId.Visible = true;
            this.colMediaTypeId.VisibleIndex = 3;
            // 
            // colGenreId
            // 
            this.colGenreId.FieldName = "GenreId";
            this.colGenreId.Name = "colGenreId";
            this.colGenreId.Visible = true;
            this.colGenreId.VisibleIndex = 4;
            // 
            // colComposer
            // 
            this.colComposer.FieldName = "Composer";
            this.colComposer.Name = "colComposer";
            this.colComposer.Visible = true;
            this.colComposer.VisibleIndex = 5;
            // 
            // colMilliseconds
            // 
            this.colMilliseconds.FieldName = "Milliseconds";
            this.colMilliseconds.Name = "colMilliseconds";
            this.colMilliseconds.Visible = true;
            this.colMilliseconds.VisibleIndex = 6;
            // 
            // colBytes
            // 
            this.colBytes.FieldName = "Bytes";
            this.colBytes.Name = "colBytes";
            this.colBytes.Visible = true;
            this.colBytes.VisibleIndex = 7;
            // 
            // colUnitPrice1
            // 
            this.colUnitPrice1.FieldName = "UnitPrice";
            this.colUnitPrice1.Name = "colUnitPrice1";
            this.colUnitPrice1.Visible = true;
            this.colUnitPrice1.VisibleIndex = 8;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Chinook.Data.Album);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dcpCart});
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
            // dcpCart
            // 
            this.dcpCart.Controls.Add(this.dockPanel1_Container);
            this.dcpCart.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dcpCart.ID = new System.Guid("9337ed30-39ec-4c50-839a-a7f6b5efbfab");
            this.dcpCart.Location = new System.Drawing.Point(0, 345);
            this.dcpCart.Name = "dcpCart";
            this.dcpCart.OriginalSize = new System.Drawing.Size(200, 200);
            this.dcpCart.Size = new System.Drawing.Size(885, 200);
            this.dcpCart.Text = "Cart";
            this.dcpCart.Click += new System.EventHandler(this.DockPanel1_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gridControl2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(877, 172);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.invoiceLineBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gdvInvoiceLine;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(877, 172);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvInvoiceLine});
            // 
            // invoiceLineBindingSource
            // 
            this.invoiceLineBindingSource.DataSource = typeof(Chinook.Data.InvoiceLine);
            // 
            // gdvInvoiceLine
            // 
            this.gdvInvoiceLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceLineId,
            this.colInvoiceId,
            this.colTrackId1,
            this.colUnitPrice,
            this.colQuantity,
            this.colInvoice,
            this.colTrack,
            this.gridColumn1});
            this.gdvInvoiceLine.GridControl = this.gridControl2;
            this.gdvInvoiceLine.Name = "gdvInvoiceLine";
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
            // colInvoiceLineId
            // 
            this.colInvoiceLineId.FieldName = "InvoiceLineId";
            this.colInvoiceLineId.Name = "colInvoiceLineId";
            this.colInvoiceLineId.Visible = true;
            this.colInvoiceLineId.VisibleIndex = 0;
            // 
            // colInvoiceId
            // 
            this.colInvoiceId.FieldName = "InvoiceId";
            this.colInvoiceId.Name = "colInvoiceId";
            this.colInvoiceId.Visible = true;
            this.colInvoiceId.VisibleIndex = 1;
            // 
            // colTrackId1
            // 
            this.colTrackId1.FieldName = "TrackId";
            this.colTrackId1.Name = "colTrackId1";
            this.colTrackId1.Visible = true;
            this.colTrackId1.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            // 
            // colInvoice
            // 
            this.colInvoice.FieldName = "Invoice";
            this.colInvoice.Name = "colInvoice";
            this.colInvoice.Visible = true;
            this.colInvoice.VisibleIndex = 5;
            // 
            // colTrack
            // 
            this.colTrack.FieldName = "Track";
            this.colTrack.Name = "colTrack";
            this.colTrack.Visible = true;
            this.colTrack.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Track.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 545);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.dcpCart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardView";
            this.Text = "CardView";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dcpCart.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInvoiceLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dcpCart;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvInvoiceLine;
        private System.Windows.Forms.BindingSource invoiceLineBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrackId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAlbumId;
        private DevExpress.XtraGrid.Columns.GridColumn colMediaTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colGenreId;
        private DevExpress.XtraGrid.Columns.GridColumn colComposer;
        private DevExpress.XtraGrid.Columns.GridColumn colMilliseconds;
        private DevExpress.XtraGrid.Columns.GridColumn colBytes;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceId;
        private DevExpress.XtraGrid.Columns.GridColumn colTrackId1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colTrack;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}