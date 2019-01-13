using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcdlManager.Forms;


namespace EcdlManager
{
    public partial class Form1 : Form
    {
        string currentPage = "esaminando";
        string connection_string = "Server=127.0.0.1;Port=3306;user=root;Database=mydb;Password=root;charset=utf8;";
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.connection(connection_string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM esaminando").Tables[0];
        }

        private void TableBtn_Click(object sender,EventArgs e)
        {
            Button _btn = (Button)sender;
            currentPage = _btn.Text.ToLower().Trim(' ').Replace(" ",String.Empty);
            updateGrid(currentPage);      
        }

        private void updateGrid(string topic)
        {
            switch (topic)
            {
                case "esame":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM esame").Tables[0];
                    break;
                case "esaminando":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM esaminando").Tables[0];
                    break;
                case "sessione":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM sessione").Tables[0];
                    break;
                case "partecipazione":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM partecipazione").Tables[0];
                    break;
                case "aula":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM aula").Tables[0];
                    break;
                case "tipoesame":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM tipoesame").Tables[0];
                    break;
                case "skillcard":
                    dataGridView1.DataSource = DatabaseManager.get("SELECT * FROM skillcard").Tables[0];
                    break;
            }
        }

        private void TableBtn_Action(object sender, EventArgs e)
        {
            Button send = (Button)sender;

            switch (send.Text)
            {
                case "Crea":
                    createSwitchCase();
                    break;
                case "Change":
                    updateSwitchCase();        
                    break;
                case "Delete":
                    deleteSwitchCase();
                    break;
            }
        }

        private void createSwitchCase()
        {
            switch (currentPage)
            {
                case "esaminando":
                    EsaminandoForm action1 = new EsaminandoForm();
                    action1.ShowDialog();
                    break;
                case "esame":
                    EsameForm esm = new EsameForm();
                    esm.ShowDialog();
                    break;
                case "skillcard":
                    SkillCardForm skl = new SkillCardForm();
                    skl.ShowDialog();
                    break;
                case "sessione":
                    SessioneForm ses = new SessioneForm();
                    ses.ShowDialog();
                    break;
                case "aula":
                    AulaForm aul = new AulaForm();
                    aul.ShowDialog();
                    break;
                case "partecipazione":
                    ParteciapzioneForm part = new ParteciapzioneForm();
                    part.ShowDialog();
                    break;
                case "tipoesame":
                    TipoEsameForm tpes = new TipoEsameForm();
                    tpes.ShowDialog();
                    break;
            }

            updateGrid(currentPage);

        }

        private void updateSwitchCase()
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {

                MessageBox.Show("Devi selezionare massimo/minimo una riga!",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

            }
            else
            {
                List<string> values = new List<string>();
                foreach (DataGridViewCell x in dataGridView1.SelectedRows[0].Cells)
                {
                    values.Add(Convert.ToString(x.Value));
                }

                switch (this.currentPage)
                {
                    case "esaminando":
                        EsaminandoForm action2 = new EsaminandoForm(values);
                        action2.ShowDialog();
                        break;
                    case "esame":
                        EsameForm esm = new EsameForm(values);
                        esm.ShowDialog();
                        break;
                    case "skillcard":
                        SkillCardForm skl = new SkillCardForm(values);
                        skl.ShowDialog();
                        break;
                    case "sessione":
                        SessioneForm ses = new SessioneForm(values);
                        ses.ShowDialog();
                        break;
                    case "aula":
                        AulaForm aul = new AulaForm(values);
                        aul.ShowDialog();
                        break;
                    case "partecipazione":
                        ParteciapzioneForm part = new ParteciapzioneForm(values);
                        part.ShowDialog();
                        break;
                    case "tipoesame":
                        TipoEsameForm tpes = new TipoEsameForm(values);
                        tpes.ShowDialog();
                        break;
                }

                updateGrid(currentPage);
            }
            

            

        }

        private void deleteSwitchCase()
        {

            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Devi selezionare massimo/minimo una riga!",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                string query = "";
                string PK = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].FormattedValue);

                switch (currentPage)
                {
                    case "esaminando":
                        query = "DELETE FROM esaminando WHERE CFEsaminando ='"+PK+"'";
                        break;
                    case "esame":
                        query = "DELETE FROM esame WHERE IDEsame =" + PK;
                        break;
                    case "skillcard":
                        query = "DELETE FROM skillcard WHERE IDSkillCard =" + PK ;
                        break;
                    case "sessione":
                        query = "DELETE FROM sessione WHERE IDSessione="+PK;
                        break;
                    case "aula":
                        query = "DELETE FROM aula WHERE IDAula=" + PK;
                        break;
                    case "partecipazione":
                        query = "DELETE FROM partecipazione WHERE IDParteciapzione =" + PK;
                        break;
                    case "tipoesame":
                        query = "DELETE FROM tipoesame WHERE IDTipoEsame=" + PK;
                        break;
                }

                DatabaseManager.post(query);
                DatabaseManager.disconnect();
                updateGrid(currentPage);
            }
        }

            

    }

}
