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
    public partial class EsameForm : Form
    {
        bool createCommand = true;
        string PK;
        public EsameForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;

            fillAulaBox();
            fillSessioneBox();
            fillTipoBox();
        }

        public EsameForm(List<string> values)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;

            fillAulaBox();
            fillSessioneBox();
            fillTipoBox();

            createCommand = false;
            PK = values[0];
            comboBox1.SelectedIndex = comboBox1.FindStringExact(values[1]);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(values[2]);
            numericUpDown1.Value = Convert.ToInt32(values[3]);
            dateTimePicker1.Text = values[4];
            dateTimePicker2.Text = values[5];
            comboBox3.SelectedIndex = comboBox3.FindStringExact(values[6]);


        }

        private void fillSessioneBox()
        {
            string query = "SELECT IDSessione FROM sessione";
            DataSet resp = DatabaseManager.get(query);
            DatabaseManager.disconnect();

            foreach (DataRow item in resp.Tables[0].Rows)
            {
                comboBox1.Items.Add(Convert.ToString(item["IDSessione"]));
            }
        }

        private void fillTipoBox()
        {
            string query = "SELECT IDTipoEsame FROM tipoesame";
            DataSet resp = DatabaseManager.get(query);
            DatabaseManager.disconnect();

            foreach (DataRow item in resp.Tables[0].Rows)
            {
                comboBox2.Items.Add(Convert.ToString(item["IDTipoEsame"]));
            }
        }

        private void fillAulaBox()
        {
            string query = "SELECT IDAula FROM aula";
            DataSet resp = DatabaseManager.get(query);
            DatabaseManager.disconnect();

            foreach (DataRow item in resp.Tables[0].Rows)
            {
                comboBox3.Items.Add(Convert.ToString(item["IDAula"]));
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
            string date1 = dateTimePicker1.Value.ToString().Split(' ')[1];
            string date2 = dateTimePicker2.Value.ToString().Split(' ')[1];
            string query = "INSERT INTO esame (IDSessione,IDTipoEsame,PostiLiberi,OraInizio,OraFine,IDAula)" +
                           " VALUES (" + comboBox1.Text + "," + comboBox2.Text + "," + numericUpDown1.Value + ",'" + date1 + "','" + date2 + "'," + comboBox3.Text + ")";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void change()
        {
            string date1 = dateTimePicker1.Value.ToString().Split(' ')[1];
            string date2 = dateTimePicker2.Value.ToString().Split(' ')[1];
            string query = "UPDATE esame SET IDSessione="+comboBox1.Text+ ", IDTipoEsame=" + comboBox2.Text+", PostiLiberi="+numericUpDown1.Value+", OraInizio='"+date1+"', OraFine='"+date2+"', IDAula="+comboBox3.Text +
                           " WHERE IDEsame="+PK;
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkContent()
        {
            if(comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0)
            {
                MessageBox.Show("I campi compilati non sono corretti",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                return false;
            }

            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Durata dell'esame non è valido",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                return false;
            }

            return true;

        }

        private void EsameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
