namespace EcdlManager
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEsaminando = new System.Windows.Forms.Button();
            this.btnEsame = new System.Windows.Forms.Button();
            this.btnAula = new System.Windows.Forms.Button();
            this.btnTipoEsame = new System.Windows.Forms.Button();
            this.btnSkillCard = new System.Windows.Forms.Button();
            this.btnSessione = new System.Windows.Forms.Button();
            this.btnPartecipazione = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1580, 836);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEsaminando
            // 
            this.btnEsaminando.Location = new System.Drawing.Point(25, 116);
            this.btnEsaminando.Name = "btnEsaminando";
            this.btnEsaminando.Size = new System.Drawing.Size(155, 37);
            this.btnEsaminando.TabIndex = 1;
            this.btnEsaminando.Text = "Esaminando";
            this.btnEsaminando.UseVisualStyleBackColor = true;
            this.btnEsaminando.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnEsame
            // 
            this.btnEsame.Location = new System.Drawing.Point(186, 116);
            this.btnEsame.Name = "btnEsame";
            this.btnEsame.Size = new System.Drawing.Size(155, 37);
            this.btnEsame.TabIndex = 2;
            this.btnEsame.Text = "Esame";
            this.btnEsame.UseVisualStyleBackColor = true;
            this.btnEsame.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnAula
            // 
            this.btnAula.Location = new System.Drawing.Point(347, 116);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(155, 37);
            this.btnAula.TabIndex = 3;
            this.btnAula.Text = "Aula";
            this.btnAula.UseVisualStyleBackColor = true;
            this.btnAula.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnTipoEsame
            // 
            this.btnTipoEsame.Location = new System.Drawing.Point(508, 116);
            this.btnTipoEsame.Name = "btnTipoEsame";
            this.btnTipoEsame.Size = new System.Drawing.Size(155, 37);
            this.btnTipoEsame.TabIndex = 4;
            this.btnTipoEsame.Text = "Tipo Esame";
            this.btnTipoEsame.UseVisualStyleBackColor = true;
            this.btnTipoEsame.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnSkillCard
            // 
            this.btnSkillCard.Location = new System.Drawing.Point(669, 116);
            this.btnSkillCard.Name = "btnSkillCard";
            this.btnSkillCard.Size = new System.Drawing.Size(155, 37);
            this.btnSkillCard.TabIndex = 5;
            this.btnSkillCard.Text = "Skill Card";
            this.btnSkillCard.UseVisualStyleBackColor = true;
            this.btnSkillCard.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnSessione
            // 
            this.btnSessione.Location = new System.Drawing.Point(830, 116);
            this.btnSessione.Name = "btnSessione";
            this.btnSessione.Size = new System.Drawing.Size(155, 37);
            this.btnSessione.TabIndex = 6;
            this.btnSessione.Text = "Sessione";
            this.btnSessione.UseVisualStyleBackColor = true;
            this.btnSessione.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnPartecipazione
            // 
            this.btnPartecipazione.Location = new System.Drawing.Point(991, 116);
            this.btnPartecipazione.Name = "btnPartecipazione";
            this.btnPartecipazione.Size = new System.Drawing.Size(171, 37);
            this.btnPartecipazione.TabIndex = 7;
            this.btnPartecipazione.Text = "Partecipazione";
            this.btnPartecipazione.UseVisualStyleBackColor = true;
            this.btnPartecipazione.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1980, 1010);
            this.Controls.Add(this.btnPartecipazione);
            this.Controls.Add(this.btnSessione);
            this.Controls.Add(this.btnSkillCard);
            this.Controls.Add(this.btnTipoEsame);
            this.Controls.Add(this.btnAula);
            this.Controls.Add(this.btnEsame);
            this.Controls.Add(this.btnEsaminando);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEsaminando;
        private System.Windows.Forms.Button btnEsame;
        private System.Windows.Forms.Button btnAula;
        private System.Windows.Forms.Button btnTipoEsame;
        private System.Windows.Forms.Button btnSkillCard;
        private System.Windows.Forms.Button btnSessione;
        private System.Windows.Forms.Button btnPartecipazione;
    }
}

