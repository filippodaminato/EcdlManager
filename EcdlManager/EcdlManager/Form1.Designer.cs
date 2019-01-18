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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEsaminando
            // 
            this.btnEsaminando.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEsaminando.Location = new System.Drawing.Point(29, 210);
            this.btnEsaminando.Name = "btnEsaminando";
            this.btnEsaminando.Size = new System.Drawing.Size(159, 55);
            this.btnEsaminando.TabIndex = 1;
            this.btnEsaminando.Text = "Esaminando";
            this.btnEsaminando.UseVisualStyleBackColor = false;
            this.btnEsaminando.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnEsame
            // 
            this.btnEsame.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEsame.Location = new System.Drawing.Point(190, 210);
            this.btnEsame.Name = "btnEsame";
            this.btnEsame.Size = new System.Drawing.Size(159, 55);
            this.btnEsame.TabIndex = 2;
            this.btnEsame.Text = "Esame";
            this.btnEsame.UseVisualStyleBackColor = false;
            this.btnEsame.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnAula
            // 
            this.btnAula.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAula.Location = new System.Drawing.Point(351, 210);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(159, 55);
            this.btnAula.TabIndex = 3;
            this.btnAula.Text = "Aula";
            this.btnAula.UseVisualStyleBackColor = false;
            this.btnAula.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnTipoEsame
            // 
            this.btnTipoEsame.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTipoEsame.Location = new System.Drawing.Point(512, 210);
            this.btnTipoEsame.Name = "btnTipoEsame";
            this.btnTipoEsame.Size = new System.Drawing.Size(159, 55);
            this.btnTipoEsame.TabIndex = 4;
            this.btnTipoEsame.Text = "Tipo Esame";
            this.btnTipoEsame.UseVisualStyleBackColor = false;
            this.btnTipoEsame.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnSkillCard
            // 
            this.btnSkillCard.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSkillCard.Location = new System.Drawing.Point(673, 210);
            this.btnSkillCard.Name = "btnSkillCard";
            this.btnSkillCard.Size = new System.Drawing.Size(159, 55);
            this.btnSkillCard.TabIndex = 5;
            this.btnSkillCard.Text = "Skill Card";
            this.btnSkillCard.UseVisualStyleBackColor = false;
            this.btnSkillCard.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnSessione
            // 
            this.btnSessione.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSessione.Location = new System.Drawing.Point(834, 210);
            this.btnSessione.Name = "btnSessione";
            this.btnSessione.Size = new System.Drawing.Size(159, 55);
            this.btnSessione.TabIndex = 6;
            this.btnSessione.Text = "Sessione";
            this.btnSessione.UseVisualStyleBackColor = false;
            this.btnSessione.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnPartecipazione
            // 
            this.btnPartecipazione.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPartecipazione.Location = new System.Drawing.Point(995, 210);
            this.btnPartecipazione.Name = "btnPartecipazione";
            this.btnPartecipazione.Size = new System.Drawing.Size(201, 55);
            this.btnPartecipazione.TabIndex = 7;
            this.btnPartecipazione.Text = "Partecipazione";
            this.btnPartecipazione.UseVisualStyleBackColor = false;
            this.btnPartecipazione.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Salmon;
            this.btnCreate.Location = new System.Drawing.Point(1241, 382);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 117);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Crea";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.TableBtn_Action);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Location = new System.Drawing.Point(1241, 706);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 117);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.TableBtn_Action);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.BackColor = System.Drawing.Color.Salmon;
            this.btnChange.Location = new System.Drawing.Point(1241, 538);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(143, 117);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.TableBtn_Action);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EcdlManager.Properties.Resources.ECDL_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(555, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 179);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1410, 1010);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnPartecipazione);
            this.Controls.Add(this.btnSessione);
            this.Controls.Add(this.btnSkillCard);
            this.Controls.Add(this.btnTipoEsame);
            this.Controls.Add(this.btnAula);
            this.Controls.Add(this.btnEsame);
            this.Controls.Add(this.btnEsaminando);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ECDL Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

