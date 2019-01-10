using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EcdlManager
{
    public partial class Form1 : Form
    {
        string currentPage = "Esame";
        string connection_string = "Server=127.0.0.1;Port=3306;user=root;Database=mydb;Password=root;charset=utf8;";
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.connection(connection_string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM esaminando").Tables[0];

            //DataRow c = asd.Tables[0].Rows[0];
            //Esaminando a = new Esaminando(c);
        }

        private void TableBtn_Click(object sender,EventArgs e)
        {
            Button _btn = (Button)sender;
            currentPage = _btn.Text;

            switch (_btn.Text)
            {
                case "Esame":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM esame").Tables[0];
                    break;
                case "Esaminando":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM esaminando").Tables[0];
                    break;
                case "Sessione":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM sessione").Tables[0];
                    break;
                case "Partecipazione":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM partecipazione").Tables[0];
                    break;
                case "Aula":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM aula").Tables[0];
                    break;
                case "Tipo Esame":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM tipoesame").Tables[0];
                    break;
                case "Skill Card":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM skillcard").Tables[0];
                    break;
            }
            
        }
    }
}
