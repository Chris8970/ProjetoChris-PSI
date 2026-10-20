namespace Trabalho_PSI_ContaSessao_Chris
{
    partial class Form_Inicial
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
            this.label_info1 = new System.Windows.Forms.Label();
            this.label_BoasVindas = new System.Windows.Forms.Label();
            this.button_IniciarSessao = new System.Windows.Forms.Button();
            this.button_CriarConta = new System.Windows.Forms.Button();
            this.label_info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_info1
            // 
            this.label_info1.AutoSize = true;
            this.label_info1.Location = new System.Drawing.Point(611, 368);
            this.label_info1.Name = "label_info1";
            this.label_info1.Size = new System.Drawing.Size(0, 13);
            this.label_info1.TabIndex = 1;
            // 
            // label_BoasVindas
            // 
            this.label_BoasVindas.AutoSize = true;
            this.label_BoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BoasVindas.Location = new System.Drawing.Point(235, 48);
            this.label_BoasVindas.Name = "label_BoasVindas";
            this.label_BoasVindas.Size = new System.Drawing.Size(349, 55);
            this.label_BoasVindas.TabIndex = 2;
            this.label_BoasVindas.Text = "Bem vindo (a) !";
            // 
            // button_IniciarSessao
            // 
            this.button_IniciarSessao.BackgroundImage = global::Trabalho_PSI_ContaSessao_Chris.Properties.Resources.pngtree_watercolor_green_background_abstract_green_digital_paper_with_texture_picture_image_15268582;
            this.button_IniciarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IniciarSessao.Location = new System.Drawing.Point(282, 155);
            this.button_IniciarSessao.Name = "button_IniciarSessao";
            this.button_IniciarSessao.Size = new System.Drawing.Size(233, 50);
            this.button_IniciarSessao.TabIndex = 3;
            this.button_IniciarSessao.Text = "Iniciar Sessão";
            this.button_IniciarSessao.UseVisualStyleBackColor = true;
            // 
            // button_CriarConta
            // 
            this.button_CriarConta.Location = new System.Drawing.Point(282, 237);
            this.button_CriarConta.Name = "button_CriarConta";
            this.button_CriarConta.Size = new System.Drawing.Size(233, 48);
            this.button_CriarConta.TabIndex = 4;
            this.button_CriarConta.Text = "Criar Conta";
            this.button_CriarConta.UseVisualStyleBackColor = true;
            // 
            // label_info2
            // 
            this.label_info2.AutoSize = true;
            this.label_info2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info2.Location = new System.Drawing.Point(578, 87);
            this.label_info2.Name = "label_info2";
            this.label_info2.Size = new System.Drawing.Size(68, 16);
            this.label_info2.TabIndex = 5;
            this.label_info2.Text = "InstaSpam";
            // 
            // Form_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_info2);
            this.Controls.Add(this.button_CriarConta);
            this.Controls.Add(this.button_IniciarSessao);
            this.Controls.Add(this.label_BoasVindas);
            this.Controls.Add(this.label_info1);
            this.Name = "Form_Inicial";
            this.Text = "Form_Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_info1;
        private System.Windows.Forms.Label label_BoasVindas;
        private System.Windows.Forms.Button button_IniciarSessao;
        private System.Windows.Forms.Button button_CriarConta;
        private System.Windows.Forms.Label label_info2;
    }
}