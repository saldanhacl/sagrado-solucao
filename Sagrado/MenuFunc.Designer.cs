namespace Sagrado
{
    partial class MenuFunc
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
            this.btnControle = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnGerencia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGerenUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnControle
            // 
            this.btnControle.BackColor = System.Drawing.Color.White;
            this.btnControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControle.ForeColor = System.Drawing.Color.Black;
            this.btnControle.Location = new System.Drawing.Point(37, 87);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(179, 49);
            this.btnControle.TabIndex = 21;
            this.btnControle.Text = "Finalizar";
            this.btnControle.UseVisualStyleBackColor = false;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.BackColor = System.Drawing.Color.White;
            this.btnComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.ForeColor = System.Drawing.Color.Black;
            this.btnComanda.Location = new System.Drawing.Point(37, 32);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(179, 49);
            this.btnComanda.TabIndex = 20;
            this.btnComanda.Text = "Trocar Usuário";
            this.btnComanda.UseVisualStyleBackColor = false;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnGerencia
            // 
            this.btnGerencia.BackgroundImage = global::Sagrado.Properties.Resources.if_check_49827;
            this.btnGerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerencia.Location = new System.Drawing.Point(171, 203);
            this.btnGerencia.Name = "btnGerencia";
            this.btnGerencia.Size = new System.Drawing.Size(206, 97);
            this.btnGerencia.TabIndex = 44;
            this.btnGerencia.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Registrar Venda";
            // 
            // btnGerenUser
            // 
            this.btnGerenUser.Image = global::Sagrado.Properties.Resources.cadastrofuniconario;
            this.btnGerenUser.Location = new System.Drawing.Point(415, 203);
            this.btnGerenUser.Name = "btnGerenUser";
            this.btnGerenUser.Size = new System.Drawing.Size(206, 97);
            this.btnGerenUser.TabIndex = 42;
            this.btnGerenUser.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Cadastrar Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // MenuFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnGerencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGerenUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.btnComanda);
            this.Name = "MenuFunc";
            this.Text = "FUNCIONÁRIO";
            this.Load += new System.EventHandler(this.MenuFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnGerencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGerenUser;
        private System.Windows.Forms.Label label8;
    }
}