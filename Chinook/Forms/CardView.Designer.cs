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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.albumBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 2);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(792, 245);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Chinook.Data.Album);
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAlbumId,
            this.colTitle,
            this.colArtistId,
            this.colArtistName});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // colAlbumId
            // 
            this.colAlbumId.FieldName = "AlbumId";
            this.colAlbumId.MinWidth = 25;
            this.colAlbumId.Name = "colAlbumId";
            this.colAlbumId.Visible = true;
            this.colAlbumId.VisibleIndex = 0;
            this.colAlbumId.Width = 94;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.MinWidth = 25;
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 94;
            // 
            // colArtistId
            // 
            this.colArtistId.FieldName = "ArtistId";
            this.colArtistId.MinWidth = 25;
            this.colArtistId.Name = "colArtistId";
            this.colArtistId.Visible = true;
            this.colArtistId.VisibleIndex = 2;
            this.colArtistId.Width = 94;
            // 
            // colArtistName
            // 
            this.colArtistName.FieldName = "ArtistName";
            this.colArtistName.MinWidth = 25;
            this.colArtistName.Name = "colArtistName";
            this.colArtistName.Visible = true;
            this.colArtistName.VisibleIndex = 3;
            this.colArtistName.Width = 94;
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "CardView";
            this.Text = "CardView";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
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
    }
}