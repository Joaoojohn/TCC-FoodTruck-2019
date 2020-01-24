namespace food_truck.Telas
{
    partial class FrmWatson
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
            this.Gravar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.txtTste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gravar
            // 
            this.Gravar.Location = new System.Drawing.Point(47, 205);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(93, 40);
            this.Gravar.TabIndex = 0;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(250, 205);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(93, 40);
            this.Parar.TabIndex = 1;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // txtTste
            // 
            this.txtTste.AutoSize = true;
            this.txtTste.Location = new System.Drawing.Point(133, 342);
            this.txtTste.Name = "txtTste";
            this.txtTste.Size = new System.Drawing.Size(35, 13);
            this.txtTste.TabIndex = 2;
            this.txtTste.Text = "label1";
            // 
            // FrmWatson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.txtTste);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Gravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWatson";
            this.Text = "FrmWatson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.Label txtTste;
    }
}