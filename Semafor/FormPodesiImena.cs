using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public delegate void DataSentHandler(String domacin, String gost);
    public partial class FormPodesiImena : Form
    {
        public event DataSentHandler DataSent;


        public FormPodesiImena()
        {
            InitializeComponent();
        }

        private void btnSetuj_Click(object sender, EventArgs e)
        {
            this.DataSent(tbDomacin.Text, tbGost.Text);

            this.Hide();
        }
    }
}
