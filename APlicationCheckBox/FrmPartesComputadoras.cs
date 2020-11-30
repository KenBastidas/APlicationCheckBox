using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APlicationCheckBox
{
    public partial class FrmPartesComputadoras : Form
    {
        public FrmPartesComputadoras()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string cad = "";
            if(this.radioButton4GB.Checked)
            {
                cad = "Ordenador with 4GB-RAM";
            }
            else if(this.radioButton8GB.Checked)
            {
                cad = "Ordenador with 8GB-RAM";
            }
            else if (this.radioButton12GB.Checked)
            {
                cad = "Ordenador with 12GB-RAM";
            }
            //ALMACENAMIENTO
            string cad2 = "";
            if (this.radioButton80SOLIDO.Checked)
            {
                cad2 = ",with 80GB SOLIDO";
            }
            else if (this.radioButton300SOLIDO.Checked)
            {
                cad2 = ",with 300GB SOLIDO";
            }
            else if (this.radioButton500SOLIDO.Checked)
            {
                cad2 = ",with 500GB SOLIDO";
            }
            //PROCESADOR
            string cad3 = "";
            if (this.radioButtonIP3.Checked)
            {
                cad3 = ",with Intel Pentium i3";
            }
            else if (this.radioButtonIP5.Checked)
            {
                cad3 = ",with Intel Pentium i5";
            }
            else if (this.radioButtonIP7.Checked)
            {
                cad3 = ",with Intel Pentium i7";
            }
            //ACCESORIOS
            string cad4 = "";
            if (this.checkBoxCAMWEB.Checked)
            {
                cad4 = ",with Camera Web";
            }
            string cad5 = "";
            if (this.checkBoxIMPRESORA.Checked)
            {
                cad5 = ",with Impresora";
            }
            string cad6 = "";
            if (this.checkBoxMOUSEGAMING.Checked)
            {
                cad6 = ",with Mouse Gaming";
            }
            this.txtComponenetes.Text = cad + cad2 + cad3 + cad4 + cad5 + cad6 ;
            
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtEnterofour.Text);
            int rever = reverso(number);
            txtReverse.Text = rever.ToString();
        }
        int reverso(int number)
        {
            int inverso = 0;
            while(number > 0)
            {
                inverso = inverso * 10 + number % 10;
                number = number / 10;
            }
            return inverso;
        }
    }
}
