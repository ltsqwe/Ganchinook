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

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartListView cartView = new CartListView();
            cartView.Show();
        }

        private void GridControl1_Click_1(object sender, EventArgs e)
        {
            Album album = (Album)cardView1.GetFocusedRow();
            txtAddToCart.Text = album.AlbumId + $"번 앨범이 추가되었습니다.\n"
                + $"Title : " + album.ToString();
        }
    }
}
