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
    public partial class SessioneForm : Form
    {
        bool createCommand = true;
        private string PK; 
        public SessioneForm()
        {
            InitializeComponent();

            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker3.ShowUpDown = true;
        }

        public SessioneForm(List<string> values)
        {
            InitializeComponent();
            
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker3.ShowUpDown = true;

            PK = values[0];
            dateTimePicker1.Text = values[1];
            dateTimePicker2.Text = values[2];
            dateTimePicker3.Text = values[3];

            createCommand = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SessioneForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (checkHours())
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
            string date2 = dateTimePicker2.Value.ToString().Split(' ')[1];
            string date3 = dateTimePicker3.Value.ToString().Split(' ')[1];

            string query = @"INSERT INTO sessione (DataSessione, OraInizio, OraFine)" +
                            "VALUES ('"+date1+"','"+date2+"','"+date3+"')";
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private void change()
        {
            string date1 = dateTimePicker1.Value.ToString().Split(' ')[0];
            string date2 = dateTimePicker2.Value.ToString().Split(' ')[1];
            string date3 = dateTimePicker3.Value.ToString().Split(' ')[1];

            string query = @"UPDATE sessione SET DataSessione='" + date1 + "', OraInizio='" + date2+ "', OraFine='" + date3 + "'" +
                            "WHERE IDSessione="+PK;
            DatabaseManager.post(query);
            DatabaseManager.disconnect();
        }

        private bool checkHours()
        {
            if (dateTimePicker2.Value >= dateTimePicker3.Value)
            {
                MessageBox.Show("La durata della sessione non è valida!",
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
