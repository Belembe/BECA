namespace Discoteca
{
    partial class Form1
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.CbCampos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(50, 50);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(216, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Introduce que desea buscar: ";
            this.lblBuscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbCampos
            // 
            this.CbCampos.FormattingEnabled = true;
            this.CbCampos.Items.AddRange(new object[] {
            "Cantante",
            "Disco",
            "Pista"});
            this.CbCampos.Location = new System.Drawing.Point(272, 47);
            this.CbCampos.Name = "CbCampos";
            this.CbCampos.Size = new System.Drawing.Size(121, 28);
            this.CbCampos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbCampos);
            this.Controls.Add(this.lblBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox CbCampos;
    }
}

