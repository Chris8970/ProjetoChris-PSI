namespace Trabalho_PSI_ContaSessao_Chris
{
    partial class Form_IniciarSessaoConta
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
            this.label_info3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_info3
            // 
            this.label_info3.AutoSize = true;
            this.label_info3.Location = new System.Drawing.Point(344, 58);
            this.label_info3.Name = "label_info3";
            this.label_info3.Size = new System.Drawing.Size(110, 13);
            this.label_info3.TabIndex = 0;
            this.label_info3.Text = "Vamos iniciar Sessão!";
            // 
            // Form_IniciarSessaoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_info3);
            this.Name = "Form_IniciarSessaoConta";
            this.Text = "Form_IniciarSessaoConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info3;
    }
}