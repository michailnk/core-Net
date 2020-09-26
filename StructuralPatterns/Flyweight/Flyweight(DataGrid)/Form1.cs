using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight_DataGrid_ {
    public partial class Form1:Form {
        Image[] images;
        DataGridViewImageCell[] cells;
        public Form1() {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) {
            images = new Image[20]; // chandge to 20

                Image image = Image.FromStream(File.OpenRead(@"zz.jpg"));
                //Image image = Image.FromFile(@"zz.jpg");
            for(int i = 0;i < images.Length;i++)
                images[i] = image;

            dataGridView1.Columns.Add(new DataGridViewImageColumn());
            dataGridView1.Columns[0].HeaderText = "Image";
            dataGridView1.Columns[0].Width = 400;

            cells = new DataGridViewImageCell[images.Length];

            for(int i = 0;i < images.Length;i++) {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 200;
                cells[i] = new DataGridViewImageCell();
                cells[i].ImageLayout = DataGridViewImageCellLayout.Zoom;
                cells[i].Value = images[i];
                dataGridView1.Rows[i].Cells[0] = cells[i];
            }
        }
    }
}
