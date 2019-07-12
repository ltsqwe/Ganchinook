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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardView));
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colAlbumId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtistId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtistName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btnCart = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddToCart = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.albumBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 2);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(672, 245);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.GridControl1_Click_1);
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.ImageOptions.Image")));
            this.btnCart.Location = new System.Drawing.Point(589, 264);
            this.btnCart.Name = "btnCart";
            this.btnCart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCart.Size = new System.Drawing.Size(88, 50);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // txtAddToCart
            // 
            this.txtAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddToCart.Location = new System.Drawing.Point(5, 264);
            this.txtAddToCart.Name = "txtAddToCart";
            this.txtAddToCart.Size = new System.Drawing.Size(578, 50);
            this.txtAddToCart.TabIndex = 3;
            this.txtAddToCart.Text = "";
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 429);
            this.Controls.Add(this.txtAddToCart);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.gridControl1);
            this.Name = "CardView";
            this.RightToLeftLayout = true;
            this.Text = "CardView";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlbumId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colArtistId;
        private DevExpress.XtraGrid.Columns.GridColumn colArtistName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnCart;
        private System.Windows.Forms.RichTextBox txtAddToCart;
    }
}