using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Конвертер : Form
    {
        public Конвертер()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rubles_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Dollars.Text = $"{double.Parse(Rubles.Text)/ 72.92}";
                error = "";
                //MessageBox.Show(this.Name);
            }
            catch (FormatException)
            {
                error = "Необходимо ввести число!";
            }
            finally
            {
                label3.Text = error;
            }
        }
        string error;
        private void Dollars_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rubles.Text = $"{double.Parse(Dollars.Text) * 72.92}";
                error = "";
                //MessageBox.Show(this.Name);
            }
            catch (FormatException)
            {
                error = "Необходимо ввести число!";
            }
            finally
            {
                label3.Text = error;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
    

