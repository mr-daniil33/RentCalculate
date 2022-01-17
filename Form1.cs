using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace DaniilGevorg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Employee employee1 = new Employee(textBox4.Text, textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            //label1.Text = employee1.GetSurnameAndFirstLetterOfNameAndFirstLetterOfPatronimic();
            string type = Convert.ToString(textBox1.Text);
            int time = Convert.ToInt32(textBox2.Text);
            

            if (type == "SimpleCar")
            {
                Car car1 = new Car(time);
                string cost = Convert.ToString(car1.CalculateSalary(time));
                label1.Text = cost;
            }

            if (type == "Truck")
            {
                int weight = Convert.ToInt32(textBox3.Text);
                Truck truck1 = new Truck(time);
                string cost = Convert.ToString(truck1.CalculateSalary(time, weight));
                label1.Text = cost;
            }

            if (type == "Municipal")
            {
                Municipal municipal1 = new Municipal (time);
                string cost = Convert.ToString(municipal1.CalculateSalary(time));
                label1.Text = cost;
            }

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
