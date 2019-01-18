using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcdlManager.Forms
{
    public partial class TipoEsameForm : Form
    {
        bool createCommand = true;
        string PK;
        
        public TipoEsameForm()
        {
            InitializeComponent();
            btnConfirm.Image = Image.FromFile(@"debug/btnConfirm");
        }

        public TipoEsameForm(List<string> values)
        {
            InitializeComponent();
            createCommand = false;
            PK = values[0];
            textBox1.Text = values[1];
            numericUpDown1.Value = Convert.ToInt32(values[2]);
            textBox2.Text = values[3];
            numericUpDown2.Value = Convert.ToInt32(values[4]);
            numericUpDown3.Value = Convert.ToInt32(values[5]);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {            
            if (checkContent())
            {
                if (createCommand)
                {
                    create();
                }
                else
                {
                    change();
                }

                this.Close();
            }
        }

        private void create()
        {
            string query = "INSERT INTO tipoesame (Materia,PuntiTot,Categoria,PercentualeCorrette,MaxPartecipanti)"+
                           " VALUES ('" + textBox1.Text + "'," + numericUpDown1.Value + ",'"+textBox2.Text+"',"+numericUpDown2.Value+","+numericUpDown3.Value+")";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void change()
        {
            string query = "UPDATE tipoesame SET Materia='" + textBox1.Text + "', PuntiTot=" + numericUpDown1.Value + ", Categoria='"+textBox2.Text+"', PercentualeCorrette="+numericUpDown2.Value+", MaxPartecipanti="+numericUpDown3.Value+
                           " WHERE IDTipoEsame=" + PK;
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkContent()
        {
            if (textBox1.Text.Trim(' ') == "" || textBox2.Text.Trim(' ') == "")
            {
                MessageBox.Show("Contenuti non validi",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                return false;
            }

            return true;
        }
    }
}
