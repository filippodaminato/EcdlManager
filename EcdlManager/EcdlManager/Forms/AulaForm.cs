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
    public partial class AulaForm : Form
    {
        bool createCommand = true;
        string PK;
        public AulaForm()
        {
            InitializeComponent();
        }

        public AulaForm(List<string> values)
        {
            InitializeComponent();
            PK = values[0];
            textBox1.Text = values[1];
            numericUpDown1.Value = Convert.ToInt32(values[2]);
            createCommand = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(checkContent())
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
            string query = "INSERT INTO aula (NomeAula,Capienza) VALUES ('"+textBox1.Text+"',"+numericUpDown1.Value+")";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void change()
        {
            string query = "UPDATE aula SET NomeAula='"+textBox1.Text+"', Capienza="+numericUpDown1.Value+" WHERE IDAula="+PK;
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkContent()
        {
            if (textBox1.Text.Trim(' ') == "")
            {
                MessageBox.Show("Il nome dell'aula non è valido",
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
