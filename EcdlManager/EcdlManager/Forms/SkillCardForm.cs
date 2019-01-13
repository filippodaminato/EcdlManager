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
    public partial class SkillCardForm : Form
    {
        private bool createCommand = true;
        private string PK;
        public SkillCardForm()
        {
            InitializeComponent();
            fillCFEcomboBox();
        }

        public SkillCardForm(List<string> values)
        {
            InitializeComponent();
            createCommand = false;
            fillCFEcomboBox();
            PK = values[0];
            dateTimePicker1.Text = values[1];
            dateTimePicker2.Text = values[2];
            comboBox2.SelectedIndex = comboBox2.FindStringExact(values[3]);
            CFEcomboBox.SelectedIndex = CFEcomboBox.FindStringExact(values[4]);
            CFEcomboBox.Enabled = false;
        }

        private void fillCFEcomboBox()
        {
            string query = "SELECT CFEsaminando FROM esaminando";
            DataSet resp = DatabaseManager.get(query);
            DatabaseManager.disconnect();

            foreach (DataRow item in resp.Tables[0].Rows)
            {
                CFEcomboBox.Items.Add(Convert.ToString(item["CFEsaminando"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkDate())
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
            string date1 = dateTimePicker1.Value.ToString().Split(' ')[0];
            string date2 = dateTimePicker2.Value.ToString().Split(' ')[0];

            string query = "INSERT INTO skillcard (DataEmissione,DataScadenza,Scaduta,CFEsaminando)" +
                           "VALUES ('"+date1+"','"+date2+"','"+comboBox2.Text+"','"+CFEcomboBox.Text+"')";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void change()
        {
            string date1 = dateTimePicker1.Value.ToString().Split(' ')[0];
            string date2 = dateTimePicker2.Value.ToString().Split(' ')[0];

            string query = @"UPDATE skillcard SET DataEmissione='" + date1 + "', DataScadenza='" + date2 + "', Scaduta='" + comboBox2.Text + "'" +
                            " WHERE IDSkillCard=" + PK;
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkDate()
        {
            if(comboBox2.Text != "N" && comboBox2.Text != "S")
            {
                MessageBox.Show("Lo stato della skill card non è corretto",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                return false;
            }

            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("La durata della skill card non è valida!",
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
