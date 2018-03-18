namespace Sagrado
{
    partial class Comanda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comanda));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutros = new System.Windows.Forms.Button();
            this.btnPorcao = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnPratos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Outros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Porções";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bebidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pratos";
            // 
            // btnOutros
            // 
            this.btnOutros.Image = ((System.Drawing.Image)(resources.GetObject("btnOutros.Image")));
            this.btnOutros.Location = new System.Drawing.Point(273, 169);
            this.btnOutros.Name = "btnOutros";
            this.btnOutros.Size = new System.Drawing.Size(206, 97);
            this.btnOutros.TabIndex = 23;
            this.btnOutros.UseVisualStyleBackColor = true;
            // 
            // btnPorcao
            // 
            this.btnPorcao.Image = ((System.Drawing.Image)(resources.GetObject("btnPorcao.Image")));
            this.btnPorcao.Location = new System.Drawing.Point(29, 169);
            this.btnPorcao.Name = "btnPorcao";
            this.btnPorcao.Size = new System.Drawing.Size(206, 97);
            this.btnPorcao.TabIndex = 22;
            this.btnPorcao.UseVisualStyleBackColor = true;
            // 
            // btnBebidas
            // 
            this.btnBebidas.Image = ((System.Drawing.Image)(resources.GetObject("btnBebidas.Image")));
            this.btnBebidas.Location = new System.Drawing.Point(273, 9);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(206, 97);
            this.btnBebidas.TabIndex = 21;
            this.btnBebidas.UseVisualStyleBackColor = true;
            // 
            // btnPratos
            // 
            this.btnPratos.Image = ((System.Drawing.Image)(resources.GetObject("btnPratos.Image")));
            this.btnPratos.Location = new System.Drawing.Point(29, 9);
            this.btnPratos.Name = "btnPratos";
            this.btnPratos.Size = new System.Drawing.Size(206, 97);
            this.btnPratos.TabIndex = 20;
            this.btnPratos.UseVisualStyleBackColor = true;
            // 
            // Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutros);
            this.Controls.Add(this.btnPorcao);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.btnPratos);
            this.Name = "Comanda";
            this.Size = new System.Drawing.Size(498, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutros;
        private System.Windows.Forms.Button btnPorcao;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnPratos;
    }
}
