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
    public partial class ParteciapzioneForm : Form
    {
        bool createCommand = true;
        string PK;
        public ParteciapzioneForm()
        {
            InitializeComponent();
            fillEsameBox();
            fillSkillCardBox();
        }
        public ParteciapzioneForm(List<string> values)
        {
            InitializeComponent();
            fillEsameBox();
            fillSkillCardBox();
            createCommand = false;
            PK = values[0];
            comboBox1.SelectedIndex = comboBox1.FindStringExact(values[1]);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(values[2]);
            comboBox3.SelectedIndex = comboBox3.FindStringExact(values[4]);
            numericUpDown1.Value = Convert.ToInt32(values[3]);
        }

        private void fillSkillCardBox()
        {
            string query = "SELECT IDSkillCard FROM skillcard";
            DataSet resp = DatabaseManager.get(query);
            DatabaseManager.disconnect();

            foreach (DataRow item in resp.Tables[0].Rows)
            {
                comboBox1.Items.Add(Convert.ToString(item["IDSkillCard"]));
            }
        }

        private void fillEsameBox()
        {
            string query = "SELECT IDEsame FROM esame";
            DataSet resp = DatabaseManager.get(query);
            DatabaseManager.disconnect();

            foreach (DataRow item in resp.Tables[0].Rows)
            {
                comboBox2.Items.Add(Convert.ToString(item["IDEsame"]));
            }
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
            string query = "INSERT INTO partecipazione (IDSkillCard,IDEsame,Esito,Promosso)" +
                           "VALUES ("+comboBox1.Text+","+comboBox2.Text+","+numericUpDown1.Value+",'"+comboBox3.Text+"')";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void change()
        {
            string query = "UPDATE partecipazione SET IDSkillCard=" + comboBox1.Text + ",IDEsame=" + comboBox2.Text + ",Esito=" + numericUpDown1.Value + ",Promosso='" + comboBox3.Text +
                           "' WHERE IDPartecipazione=" + PK;
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkContent()
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0)
            {
                MessageBox.Show("I campi compilati non sono corretti",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            

            return true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
