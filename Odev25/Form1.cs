using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev25
{
    public partial class Form1 : Form
    {
        
        private List<string> kelimeler = new List<string>();
        private List<string> tekrarlıKelimeler = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Liste.Text = "";

            KelimeOlustur test = new KelimeOlustur(Alfabe.Text, inputBox.Text);
            kelimeler = test.Dil_Agaci();

            List<string> distinct = kelimeler.Distinct().ToList();
            distinct.Sort();

            foreach (var i in distinct)
            {
                Liste.AppendText(i);
                Liste.AppendText(Environment.NewLine);
            }
        }
    }
}