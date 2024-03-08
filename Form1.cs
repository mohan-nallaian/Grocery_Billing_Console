using System;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;   

namespace Grocery_Billing_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            double price;
            double qty;
            double cal = 0.0;

            if (check1.Checked)
            {
                String Sugar = check1.Text;
                String mes = comboBox1.SelectedItem.ToString();
                price = 160.0;
                qty = int.Parse(txt1.Text);

                if (mes.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Sugar, price, qty, cal);

                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(Sugar, price, qty, cal);
                }
            }

            if (check2.Checked)
            {
                String Milk = check2.Text;
                String mes = comboBox2.SelectedItem.ToString();
                qty = double.Parse(text2.Text);

                /*1 / 2 Litre
                1 Litre
                2 Litre
                2.5 Litre
                */
                if (mes.Equals("1/2 Litre"))
                {
                    price = 30.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Milk, price, qty, cal);
                }
                else if (mes.Equals("2.5 Litre"))
                {
                    price = 150.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Milk, price, qty, cal);
                }
                else if (mes.Equals("1 Litre"))
                {
                    price = 60.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Milk, price, qty, cal);
                }
                else
                {
                    price = 120.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Milk, price, qty, cal);
                }
            }
            /*
                Chocolate Chip Cookies.
                Shortbread Cookies.
                Macaron Cookies.
                Biscotti Cookies.
                Oatmeal Raisin Cookies.
                Gingerbread Cookies.*/
            if (check3.Checked)
            {
                String Cookies = check3.Text;
                String mes = comboBox3.SelectedItem.ToString();
                qty = int.Parse(text3.Text);

                if (mes.Equals("Chocolate Chip Cookies."))
                {
                    price = 50.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);

                }
                else if (mes.Equals("Shortbread Cookies."))
                {
                    price = 90.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Macaron Cookies."))
                {
                    price = 105.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Biscotti Cookies."))
                {
                    price = 65.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Oatmeal Raisin Cookies."))
                {
                    price = 85.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else
                {
                    price = 95.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
            }
            if (check4.Checked)
            {
                String Chocolate = check4.Text;
                String mes = comboBox4.SelectedItem.ToString();
                qty = int.Parse(text4.Text);

                /*
                Ferrero Rocher.
                Ghirardelli Square.
                Cadbury Dairy Milk.
                Toblerone.
                Valrhona Chocolate.
                */
                if (mes.Equals("Ferrero Rocher."))
                {
                    price = 50.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);

                }
                else if (mes.Equals("Ghirardelli Square."))
                {
                    price = 90.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Cadbury Dairy Milk."))
                {
                    price = 105.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Toblerone."))
                {
                    price = 65.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else
                {
                    price = 95.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
            }
            if (check5.Checked)
            {
                String Rice = check5.Text;
                String mes = comboBox5.SelectedItem.ToString();
                qty = int.Parse(text5.Text);

                /* Basmati rice.
                 Black rice.
                 Brown rice.
                 Brown Basmati rice.
                 Valencia rice.
                 Red cargo rice.*/
                if (mes.Equals("Basmati rice."))
                {
                    price = 110.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);

                }
                else if (mes.Equals("Black rice."))
                {
                    price = 75.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Brown rice."))
                {
                    price = 95.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Brown Basmati rice."))
                {
                    price = 75.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Valencia rice."))
                {
                    price = 155.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else
                {
                    price = 72.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }

            }

            if (check6.Checked)
            {
                String Oil = check6.Text;
                String mes = comboBox6.SelectedItem.ToString();
                qty = int.Parse(text6.Text);

                /*
                Corn Oil.
                Olive Oil.
                Peanut Oil.
                Safflower Oil.
                Soybean Oil.
                Sunflower Oil.
                Vegetable Oil.
                */
                if (mes.Equals("Corn Oil."))
                {
                    price = 125.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);

                }
                else if (mes.Equals("Olive Oil"))
                {
                    price = 75.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Peanut Oil."))
                {
                    price = 95.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Safflower Oil."))
                {
                    price = 75.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Soybean Oil."))
                {
                    price = 155.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else if (mes.Equals("Vegetable Oil."))
                {
                    price = 155.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }
                else
                {
                    price = 125.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mes, price, qty, cal);
                }

            }

            if (check7.Checked)
            {
                String Wheat = check7.Text;
                String mes = comboBox7.SelectedItem.ToString();
                qty = int.Parse(text7.Text);

                /* 1 / 2 KG
                 1 KG
                 1.5 KG
                 2 KG
                 2.5 KG
                 5 KG*/

                if (mes.Equals("1 / 2 KG"))
                {
                    price = 35.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Wheat,price, qty, cal);

                }
                else if (mes.Equals("1 KG"))
                {
                    price = 70.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Wheat, price, qty, cal);
                }
                else if (mes.Equals("1.5 KG"))
                {
                    price = 85.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Wheat, price, qty, cal);
                }
                else if (mes.Equals("2 KG"))
                {
                    price = 140.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Wheat, price, qty, cal);
                }
                else if (mes.Equals("2.5 KG"))
                {
                    price = 157.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Wheat, price, qty, cal);
                }
                else
                {
                    price = 175.0;
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(Wheat, price, qty, cal);
                }
            }
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }
            label5.Text = sum.ToString();
        }
    }

   
}
