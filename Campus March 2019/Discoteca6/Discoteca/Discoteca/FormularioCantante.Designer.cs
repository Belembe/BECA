namespace Discoteca
{
    partial class FormularioCantante
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
            this.lFCantante = new System.Windows.Forms.Label();
            this.lNombreCantante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lFCantante
            // 
            this.lFCantante.AutoSize = true;
            this.lFCantante.Location = new System.Drawing.Point(363, 19);
            this.lFCantante.Name = "lFCantante";
            this.lFCantante.Size = new System.Drawing.Size(205, 20);
            this.lFCantante.TabIndex = 0;
            this.lFCantante.Text = "FORMULARIO CANTANTE";
            // 
            // lNombreCantante
            // 
            this.lNombreCantante.AutoSize = true;
            this.lNombreCantante.Location = new System.Drawing.Point(26, 66);
            this.lNombreCantante.Name = "lNombreCantante";
            this.lNombreCantante.Size = new System.Drawing.Size(51, 20);
            this.lNombreCantante.TabIndex = 1;
            this.lNombreCantante.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // FormularioCantante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lNombreCantante);
            this.Controls.Add(this.lFCantante);
            this.Name = "FormularioCantante";
            this.Text = "FormularioCantante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFCantante;
        private System.Windows.Forms.Label lNombreCantante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}