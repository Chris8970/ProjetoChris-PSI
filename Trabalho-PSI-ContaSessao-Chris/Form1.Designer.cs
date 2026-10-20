namespace Trabalho_PSI_ContaSessao_Chris
{
    partial class Form_IniciarSessao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Logo = new System.Windows.Forms.Label();
            this.button_Comecar = new System.Windows.Forms.Button();
            this.button_Logo1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logo.Location = new System.Drawing.Point(147, -1);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(514, 125);
            this.label_Logo.TabIndex = 3;
            this.label_Logo.Text = "InstaSpam";
            // 
            // button_Comecar
            // 
            this.button_Comecar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Comecar.Location = new System.Drawing.Point(296, 203);
            this.button_Comecar.Name = "button_Comecar";
            this.button_Comecar.Size = new System.Drawing.Size(194, 52);
            this.button_Comecar.TabIndex = 4;
            this.button_Comecar.Text = "Começar";
            this.button_Comecar.UseVisualStyleBackColor = true;
            this.button_Comecar.Click += new System.EventHandler(this.button_Comecar_Click);
            // 
            // button_Logo1
            // 
            this.button_Logo1.BackgroundImage = global::Trabalho_PSI_ContaSessao_Chris.Properties.Resources._6a398e2bffd61024b7fa8c6eaf6a4e62;
            this.button_Logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Logo1.Location = new System.Drawing.Point(33, 27);
            this.button_Logo1.Name = "button_Logo1";
            this.button_Logo1.Size = new System.Drawing.Size(75, 67);
            this.button_Logo1.TabIndex = 5;
            this.button_Logo1.UseVisualStyleBackColor = true;
            this.button_Logo1.Click += new System.EventHandler(this.button_Logo1_Click);
            // 
            // Form_IniciarSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 411);
            this.Controls.Add(this.button_Logo1);
            this.Controls.Add(this.button_Comecar);
            this.Controls.Add(this.label_Logo);
            this.Name = "Form_IniciarSessao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.Button button_Comecar;
        private System.Windows.Forms.Button button_Logo1;
    }
}

