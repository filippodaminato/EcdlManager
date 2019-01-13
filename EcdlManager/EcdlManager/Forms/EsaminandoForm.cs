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
    public partial class EsaminandoForm : Form
    {
        bool createCommand = true;
        public EsaminandoForm()
        {
            
            InitializeComponent();
        }

        public EsaminandoForm(List<string> values)
        {

            this.createCommand = false;
            InitializeComponent();
            textBox1.Text = values[1];
            textBox3.Enabled = false;
            textBox2.Text = values[2];
            textBox3.Text = values[0];
            comboBox1.SelectedIndex = comboBox1.FindStringExact(values[3]);
            dateTimePicker1.Text = values[4];
            textBox6.Text = values[5];

        }

        private void EsaminandoForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (checkData())
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

        private void change()
        {
            string date = dateTimePicker1.Value.ToString().Split(' ')[0];
            string query = @"UPDATE esaminando 
                            SET Nome='"+textBox1.Text+"',Cognome='"+textBox2.Text+"', Sesso='"+comboBox1.Text+"', DataNascita='"+date+"', LuogoNascita='"+textBox6.Text+"'" +
                            "WHERE CFEsaminando='"+textBox3.Text+"'";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void create()
        {
            string date = dateTimePicker1.Value.ToString().Split(' ')[0];
            string query = @"INSERT INTO esaminando ( CFEsaminando, Nome, Cognome, Sesso, DataNascita, LuogoNascita, BoolStudente )
                            VALUES ('"+textBox3.Text+"','"+ textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + date + "','" + textBox6.Text+"','S')";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkData()
        {
            if (textBox1.Text.Trim(' ') == "" || textBox2.Text.Trim(' ') == ""|| textBox3.Text.Trim(' ') == "" || textBox6.Text.Trim(' ') == "" || comboBox1.Text == "")
            {
                MessageBox.Show("I campi non sono stati compilati correttamente!",
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
