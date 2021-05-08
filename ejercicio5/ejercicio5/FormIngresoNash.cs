using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class FormIngresoNash : Form
    {
        
        public FormIngresoNash()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            lblcodigo.Text = txtcodigo.Text;
            lblcurso.Text = txtcurso.Text;
            lblatacar2.Text = txtcodigo.Text;
            lbldefender1.Text = txtcurso.Text;
            lbldescansan1.Text = txtdescansan.Text;
            lbldescansan2.Text = txtdescansan.Text;
            lblad1.Text = txtatacadefi.Text;
            lblad2.Text = txtatacadefi.Text;
            lblda1.Text = txtdefiendeata.Text;
            lblda2.Text = txtdefiendeata.Text;
            lblades1.Text = txtatacasdescansa.Text;
            lblades2.Text = txtatacasdescansa.Text;
            lbldesa1.Text = txtdescansaataca.Text;
            lbldesa2.Text = txtdescansaataca.Text;
            lbldd1.Text = txtdefiendedescansa.Text;
            lbldd2.Text = txtdefiendedescansa.Text;
            lbldede1.Text = txtdescansadefiende.Text;
            lbldede2.Text = txtdescansadefiende.Text;


            
            this.Refresh();
        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            //FormIngresoCursos res = new FormIngresoCursos();
            int  pierdes1, ganas1;
            
            pierdes1 = 0;
            ganas1 = 0;
            if (Convert.ToInt32(txtcodigo.Text) > Convert.ToInt32(txtcodigo.Text))
                ganas1++;
            else pierdes1++;
            if (Convert.ToInt32(txtatacadefi.Text) > Convert.ToInt32(txtdefiendeata.Text))
                ganas1++;
            else pierdes1++;
            if (Convert.ToInt32(txtatacasdescansa.Text) > Convert.ToInt32(txtdescansaataca.Text))
                ganas1++;
            else pierdes1++;


            if (pierdes1 >= 2)
            {
                pierdes1 = 0;
                ganas1 = 0;
            } else txtcalcu.Text = "ATACAR";

            if (Convert.ToInt32(txtdefiendeata.Text) > Convert.ToInt32(txtatacadefi.Text))
                ganas1++;
            else pierdes1++;
            if (Convert.ToInt32(txtcurso.Text) > Convert.ToInt32(txtcurso.Text))
                ganas1++;
            else pierdes1++;
            if (Convert.ToInt32(txtdefiendedescansa.Text) > Convert.ToInt32(txtdescansadefiende.Text))
                ganas1++;
            else pierdes1++;

            if (pierdes1 >= 2)
            {
                pierdes1 = 0;
                ganas1 = 0;
            }
            else txtcalcu.Text = "DEFENDER";

            if (Convert.ToInt32(txtdescansaataca.Text) > Convert.ToInt32(txtatacasdescansa.Text))
                ganas1++;
            else pierdes1++;
            if (Convert.ToInt32(txtdescansadefiende.Text) > Convert.ToInt32(txtdefiendedescansa.Text))
                ganas1++;
            else pierdes1++;
            if (Convert.ToInt32(txtdescansan.Text) > Convert.ToInt32(txtdescansan.Text))
                ganas1++;
            else pierdes1++;
            if (pierdes1 >= 2)
            {
                pierdes1 = 0;
                ganas1 = 0;
            }
            else txtcalcu.Text = "DESCANSA";


        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcodigo_Click(object sender, EventArgs e)
        {

        }

        private void lbldd2_Click(object sender, EventArgs e)
        {

        }

        private void FormIngresoCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
