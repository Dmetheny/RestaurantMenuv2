using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project2
{
    public partial class Form1 : Form
    {
        string name;

        const double FRUITSALAD_PRICE = 9.95;
        const double PASTASALAD_PRICE = 12.00;
        const double SMOOTHIE_PRICE = 4.95;
        const double FRUITJUICE_PRICE = 3.95;
        const double CUPCAKE_PRICE = 3.00;
        const double SHORTCAKE_PRICE = 6.00;

        double saladPrice, drinkPrice, dessertsPrice, saladQuantity, drinkQuantity, dessertQuantity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            name = Interaction.InputBox("Please enter your name", "Customer's Name");
        }

        private void FruitSaladradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SaladPricetextBox.Text = string.Format("{0:C}", FRUITSALAD_PRICE);
            SaladQuantitytextbox.Focus();
            Saladslabel.Visible = FruitSaladradioButton.Checked;

            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Saladslabel.Text = string.Format("Salads Selection: Fruit Salad");
                }
            }
 
            saladPrice = FRUITSALAD_PRICE;

        }

        private void PastaSaladradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SaladPricetextBox.Text = string.Format("{0:C}", PASTASALAD_PRICE);
            SaladQuantitytextbox.Focus();
            Saladslabel.Visible = PastaSaladradioButton.Checked;

            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Saladslabel.Text = string.Format("Salads Selection: Pasta Salad");
                }
            }

            saladPrice = PASTASALAD_PRICE;
        }

        private void SaladQuantitytextbox_Click(object sender, EventArgs e)
        {
            SaladQuantitytextbox.SelectionStart = 0;
            SaladQuantitytextbox.SelectionLength = SaladQuantitytextbox.Text.Length;
        }

        private void SmoothieradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DrinkPricetextBox.Text = string.Format("{0:C}", SMOOTHIE_PRICE);
            DrinkQuantitytextBox.Focus();
            Drinkslabel.Visible = SmoothieradioButton.Checked;

            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Drinkslabel.Text = string.Format("Drinks Selection: Smoothie");
                }
            }

            drinkPrice = SMOOTHIE_PRICE;
        }

        private void FruitJuiceradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DrinkPricetextBox.Text = string.Format("{0:C}", FRUITJUICE_PRICE);
            DrinkQuantitytextBox.Focus();
            Drinkslabel.Visible = FruitJuiceradioButton.Checked;

            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Drinkslabel.Text = string.Format("Drinks Selection: Fruit Juice");
                }
            }

            drinkPrice = FRUITJUICE_PRICE;
        }

        private void DrinkQuantitytextBox_Click(object sender, EventArgs e)
        {
            DrinkQuantitytextBox.SelectionStart = 0;
            DrinkQuantitytextBox.SelectionLength = DrinkQuantitytextBox.Text.Length;
        }

        private void CupcakeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DessertPricetextBox.Text = string.Format("{0:C}", CUPCAKE_PRICE);
            DessertQuantitytextBox.Focus();
            Dessertslabel.Visible = CupcakeradioButton.Checked;

            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Dessertslabel.Text = string.Format("Desserts Selection: Cupcake");
                }
            }

            dessertsPrice = CUPCAKE_PRICE;
        }

        private void ShortcakeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DessertPricetextBox.Text = string.Format("{0:C}", SHORTCAKE_PRICE);
            DessertQuantitytextBox.Focus();
            Dessertslabel.Visible = ShortcakeradioButton.Checked;

            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Dessertslabel.Text = string.Format("Desserts Selection: Shortcake");
                }
            }

            dessertsPrice = SHORTCAKE_PRICE;
        }

        private void DessertQuantitytextBox_Click(object sender, EventArgs e)
        {
            DessertQuantitytextBox.SelectionStart = 0;
            DessertQuantitytextBox.SelectionLength = DessertQuantitytextBox.Text.Length;
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            saladQuantity = double.Parse(SaladQuantitytextbox.Text);
            drinkQuantity = double.Parse(DrinkQuantitytextBox.Text);
            dessertQuantity = double.Parse(DessertQuantitytextBox.Text);

            double totalQuantity = saladQuantity + drinkQuantity + dessertQuantity;
            double totalCost = saladPrice * saladQuantity + drinkPrice * drinkQuantity + dessertsPrice * dessertQuantity;

            Messagelabel.Visible = true;
            Messagelabel.BackColor = Color.White;
            Messagelabel.Text = string.Format("The total sale was: {0:C}" + "\nThe total items sold were: {1} " + "\n{2}, thank you for your purchase!", totalCost, totalQuantity, name);
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            FruitSaladradioButton.Checked = false;
            PastaSaladradioButton.Checked = false;
            SaladPricetextBox.Text = "0.00";
            SaladQuantitytextbox.Text = "0.00";
            SmoothieradioButton.Checked = false;
            FruitJuiceradioButton.Checked = false;
            DrinkPricetextBox.Text = "0.00";
            DrinkQuantitytextBox.Text = "0.00";
            CupcakeradioButton.Checked = false;
            ShortcakeradioButton.Checked = false;
            DessertPricetextBox.Text = "0.00";
            DessertQuantitytextBox.Text = "0.00";
            Messagelabel.Text = string.Empty;
            Saladslabel.Text = string.Empty;
            Drinkslabel.Text = string.Empty;
            Dessertslabel.Text = string.Empty;
            Calculatebutton.Focus();
            Messagelabel.Visible = false;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
