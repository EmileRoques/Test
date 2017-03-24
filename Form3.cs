using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Design
{
    public partial class Form3 : Form
    {
        public string weapon = "";
        public string armour = "";
        public string item = "";
        
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonMove1_Click(object sender, EventArgs e)
        {
            int pin = 1;
            databaseDataSet1.UserEquipment.AddUserEquipmentRow(pin, weapon, armour, item);


        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            weapon = "Diamond Spear";
            button14.Text = weapon;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            weapon = "Master Sword";
            button14.Text = weapon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weapon = "Platnium Axe";
            button14.Text = weapon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weapon = "Ruby Staff";
            button14.Text = weapon;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            weapon = "Wood Wand";
            button14.Text = weapon;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            item = "Healing Potion";
            button9.Text = item;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            item = "Regeneration Potion";
            button9.Text = item;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            item = "Physical DMG Potion";
            button9.Text = item;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            item = "Magic DMG Potion";
            button9.Text = item;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            item = "Resistance Potion";
            button9.Text = item;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            armour = "Silver Breastplate";
            button8.Text = armour;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            armour = "Brass Helmet";
            button8.Text = armour;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            armour = "Magic Gauntlets";
            button8.Text = armour;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            armour = "Special Glasses";
            button8.Text = armour;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            armour = "Full Plate";
            button8.Text = armour;
        }
    }
}
