namespace Unagi
{
    partial class frGerenciarPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPilha = new System.Windows.Forms.Button();
            this.btnFila = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPilha);
            this.panel1.Controls.Add(this.btnFila);
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 411);
            this.panel1.TabIndex = 20;
            // 
            // btnPilha
            // 
            this.btnPilha.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPilha.FlatAppearance.BorderSize = 0;
            this.btnPilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilha.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilha.ForeColor = System.Drawing.Color.Black;
            this.btnPilha.Location = new System.Drawing.Point(79, 179);
            this.btnPilha.Name = "btnPilha";
            this.btnPilha.Size = new System.Drawing.Size(201, 39);
            this.btnPilha.TabIndex = 23;
            this.btnPilha.Text = "TOCAR POR PILHA";
            this.btnPilha.UseVisualStyleBackColor = false;
            // 
            // btnFila
            // 
            this.btnFila.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFila.FlatAppearance.BorderSize = 0;
            this.btnFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFila.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFila.ForeColor = System.Drawing.Color.Black;
            this.btnFila.Location = new System.Drawing.Point(80, 89);
            this.btnFila.Name = "btnFila";
            this.btnFila.Size = new System.Drawing.Size(201, 39);
            this.btnFila.TabIndex = 22;
            this.btnFila.Text = "TOCAR POR FILA";
            this.btnFila.UseVisualStyleBackColor = false;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.Black;
            this.btnLista.Location = new System.Drawing.Point(80, 134);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(201, 39);
            this.btnLista.TabIndex = 21;
            this.btnLista.Text = "TOCAR POR LISTA";
            this.btnLista.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(79, 285);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(201, 39);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // frGerenciarPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(958, 412);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frGerenciarPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frGerenciarPlaylist";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPilha;
        private System.Windows.Forms.Button btnFila;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnVoltar;
    }
}