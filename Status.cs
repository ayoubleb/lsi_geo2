using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuissanceStatus
{
    public partial class Status : UserControl
    {
        Color back;
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            back = Color.Cyan;
        }

        public void Afficher(int nb)
        {

           foreach (Control c in this.Controls)
           {
 
               int tg =int.Parse ( c.Tag.ToString());
               c.BackColor = tg <= nb? Color.Red :back;
             
            }




        }
    }
}
