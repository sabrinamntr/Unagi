namespace Unagi
{
    partial class frLista
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
            this.listaMidia = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listaMidia
            // 
            this.listaMidia.Location = new System.Drawing.Point(1, 1);
            this.listaMidia.Name = "listaMidia";
            this.listaMidia.Size = new System.Drawing.Size(282, 257);
            this.listaMidia.TabIndex = 0;
            this.listaMidia.UseCompatibleStateImageBehavior = false;
            this.listaMidia.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // frLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listaMidia);
            this.Name = "frLista";
            this.Text = "frLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaMidia;
    }
}