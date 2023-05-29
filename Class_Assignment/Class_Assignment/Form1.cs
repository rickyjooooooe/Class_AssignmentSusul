using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assignment
{
    public partial class Form1 : Form
    {
        DataTable tabel = new DataTable();
        private Bitmap[] gambartrain;
        private Bitmap[] gambarjeans;
        private Bitmap[] gambarshirt;
        private Bitmap[] gambartshirt;
        private Bitmap[] gambarshoes;
        private Bitmap[] gambarbag;
        decimal[] pricetraining = new decimal[] { 199.000m, 219.000m, 199.000m };
        decimal[] pricejeans = new decimal[] { 299.000m, 319.000m, 349.000m };
        decimal[] priceshirt = new decimal[] { 199.000m, 199.000m, 239.000m };
        decimal[] pricetshirt = new decimal[] { 259.000m, 179.000m, 259.000m };
        decimal[] priceshoes = new decimal[] { 359.000m, 499.000m, 459.000m };
        decimal[] pricebag = new decimal[] { 239.000m, 249.000m, 369.000m };
        string[] training = new string[] { "Sweatpants", "Training", "Sweatpants" };
        string[] jeans = new string[] { "Baggy Jeans", "Straight Jeans", "Ripped Jeans" };
        string[] shirt = new string[] { "Basic Shirt", "Basic Shirt", "Long Arm Shirt" };
        string[] tshirt = new string[] { "Oversized T-Shirt", "Basic T-Shirt", "Oversized T-Shirt" };
        string[] shoes = new string[] { "White Sneaker", "Formal Shoes", "Woman's Shoes"};
        string[] bag = new string[] { "Sling Bag", "Shoulder Bag", "Backpack" };
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) 
            {
                DataGridViewCell quantityCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int quantity = Convert.ToInt32(quantityCell.Value);

                if (quantity == 0)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    DataGridViewCell priceCell = dataGridView1.Rows[e.RowIndex].Cells[2]; // Price column
                    decimal price = Convert.ToDecimal(priceCell.Value);

                    decimal totalPrice = quantity * price;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = totalPrice.ToString("0.000"); // Total column

                    totalPrice = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        decimal rowTotal = Convert.ToDecimal(row.Cells[3].Value);
                        totalPrice += rowTotal;
                    }

                    labelsubtot.Text = totalPrice.ToString("0.000");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            tabel.Columns.Add("Item");
            tabel.Columns.Add("Quantity");
            tabel.Columns.Add("Price");
            tabel.Columns.Add("Total");
            dataGridView1.DataSource = tabel;

            paneltraining.Visible = false;
            paneljeans.Visible = false;
            panelshirt.Visible = false;
            paneltshirt.Visible = false;
            panelshoes.Visible = false;
            panelbag.Visible = false;

            gambartrain = new Bitmap[3];
            gambartrain[0] = Properties.Resources.training;
            gambartrain[1] = Properties.Resources.sweatpants;
            gambartrain[2] = Properties.Resources.grey_sweat;

            gambarjeans = new Bitmap[3];
            gambarjeans[0] = Properties.Resources.jeans;
            gambarjeans[1] = Properties.Resources.jeansstraight;
            gambarjeans[2] = Properties.Resources.rippedjean;

            gambartshirt = new Bitmap[3];
            gambartshirt[0] = Properties.Resources.tshirt;
            gambartshirt[1] = Properties.Resources.tshirtrelaxed;
            gambartshirt[2] = Properties.Resources.tshirtnirvana;

            gambarshirt = new Bitmap[3];
            gambarshirt[0] = Properties.Resources.shirt;
            gambarshirt[1] = Properties.Resources.shirtgreen;
            gambarshirt[2] = Properties.Resources.shirtlong;

            gambarshoes = new Bitmap[3];
            gambarshoes[0] = Properties.Resources.shoe;
            gambarshoes[1] = Properties.Resources.shoe2;
            gambarshoes[2] = Properties.Resources.shoe3;

            gambarbag = new Bitmap[3];
            gambarbag[0] = Properties.Resources.bag;
            gambarbag[1] = Properties.Resources.bag2;
            gambarbag[2] = Properties.Resources.bag3;

            LoadPictureBoxes(paneltraining, gambartrain,pricetraining,training);
            LoadPictureBoxes(paneljeans, gambarjeans,pricejeans,jeans);
            LoadPictureBoxes(panelshirt, gambarshirt,priceshirt,shirt);
            LoadPictureBoxes(paneltshirt, gambartshirt, pricetshirt,tshirt);
            LoadPictureBoxes(panelshoes, gambarshoes, priceshoes, shoes);
            LoadPictureBoxes(panelbag, gambarbag,pricebag,bag);
        }

        private void LoadPictureBoxes(Panel panel, Bitmap[] images, decimal[] prices, string[] kategori)
        {
            panel.Controls.Clear();

            for (int i = 0; i < images.Length; i++)
            {
                PictureBox pictureBoxTop = new PictureBox();
                pictureBoxTop.Size = new Size(100, 150);
                pictureBoxTop.BorderStyle = BorderStyle.FixedSingle;
                pictureBoxTop.Location = new Point(i * 120 + 10, 10);
                pictureBoxTop.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxTop.Image = images[i];

                Label label = new Label();
                label.Size = new Size(100, 20);
                label.Location = new Point(i * 120 + 10, 170);
                label.Text = kategori[i];

                Label priceLabel = new Label();
                priceLabel.Size = new Size(100, 20);
                priceLabel.Location = new Point(i * 120 + 10, 195);
                priceLabel.Text = "Rp. " + prices[i].ToString("0.000");

                Button button = new Button();
                button.Size = new Size(100, 30);
                button.Location = new Point(i * 120 + 10, 220);
                button.Text = "Add";

                button.Click += (sender, e) =>
                {
                    int buttonIndex = Array.IndexOf(panel.Controls.OfType<Button>().ToArray(), button);

                    string selectedItem = kategori[buttonIndex];
                    decimal selectedPrice = prices[buttonIndex];

                    DataRow[] existingRows = tabel.Select($"Item = '{selectedItem}'");
                    if (existingRows.Length > 0)
                    {
                        DataRow existingRow = existingRows[0];
                        int quantity = Convert.ToInt32(existingRow["Quantity"]) + 1;
                        decimal totalPricee = quantity * selectedPrice;
                        existingRow["Quantity"] = quantity.ToString();
                        existingRow["Total"] = totalPricee.ToString("0.000");
                    }
                    else
                    {
                        DataRow newRow = tabel.NewRow();
                        newRow["Item"] = selectedItem;
                        newRow["Quantity"] = "1";
                        newRow["Price"] = selectedPrice.ToString("0.000");
                        newRow["Total"] = selectedPrice.ToString("0.000");
                        tabel.Rows.Add(newRow);
                    }

                    decimal totalPrice = tabel.AsEnumerable()
                        .Sum(row => Convert.ToDecimal(row["Total"]));

                    labelsubtot.Text = totalPrice.ToString("0.000");
                    decimal totall = totalPrice + totalPrice * 10 / 100;
                    labeltotal.Text = totall.ToString("0.000");
                };

                panel.Controls.Add(pictureBoxTop);
                panel.Controls.Add(label);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(button);
            }
        }


        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneljeans.Visible = false;
            paneltraining.Visible = true;
            panelshirt.Visible = false;
            paneltshirt.Visible = false;
            panelshoes.Visible = false;
            panelbag.Visible = false;
        }

        private void jeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneljeans.Visible = true;
            paneltraining.Visible = false;
            panelshirt.Visible = false;
            paneltshirt.Visible = false;
            panelshoes.Visible = false;
            panelbag.Visible = false;
        }

        private void tshirtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paneljeans.Visible = false;
            paneltraining.Visible = false;
            panelshirt.Visible = false;
            paneltshirt.Visible = true;
            panelshoes.Visible = false;
            panelbag.Visible = false;

        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneljeans.Visible = false;
            paneltraining.Visible = false;
            panelshirt.Visible = true;
            paneltshirt.Visible = false;
            panelshoes.Visible = false;
            panelbag.Visible = false;

        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneljeans.Visible = false;
            paneltraining.Visible = false;
            panelshirt.Visible = false;
            paneltshirt.Visible = false;
            panelshoes.Visible = true;
            panelbag.Visible = false;
        }

        private void bagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneljeans.Visible = false;
            paneltraining.Visible = false;
            panelshirt.Visible = false;
            paneltshirt.Visible = false;
            panelshoes.Visible = false;
            panelbag.Visible = true;
        }
    }
}
