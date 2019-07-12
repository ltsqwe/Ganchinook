using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Chinook.Forms
{
    public partial class CardView : Form
    {
        public CardView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            albumBindingSource.DataSource = DataRepository.Album.GetAll();
        }

        private void BackstageViewControl1_Click(object sender, EventArgs e)
        {

        }

        private void DockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GridControl1_Click(object sender, EventArgs e)
        {
            if (!(sender is GridControl control))
                return;
            if (control.MainView == null) 
                return;

            var item = (BindingSource) control.DataSource;
            
            Album album = item.Current as Album;
            //int id = album.AlbumId;
            int i = 1;

            //(view.IsFocusedView)
        }
    }
}
