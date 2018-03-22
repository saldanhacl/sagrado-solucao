namespace Sagrado
{
    partial class pnGerenUser
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnGerenUser));
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Remover Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Editar Usuário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Buscar Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cadastrar Usuário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOutros
            // 
            this.btnOutros.BackColor = System.Drawing.Color.Red;
            this.btnOutros.Image = ((System.Drawing.Image)(resources.GetObject("btnOutros.Image")));
            this.btnOutros.Location = new System.Drawing.Point(269, 170);
            this.btnOutros.Name = "btnOutros";
            this.btnOutros.Size = new System.Drawing.Size(206, 97);
            this.btnOutros.TabIndex = 31;
            this.btnOutros.UseVisualStyleBackColor = false;
            // 
            // btnPorcao
            // 
            this.btnPorcao.BackColor = System.Drawing.Color.Yellow;
            this.btnPorcao.Image = ((System.Drawing.Image)(resources.GetObject("btnPorcao.Image")));
            this.btnPorcao.Location = new System.Drawing.Point(25, 170);
            this.btnPorcao.Name = "btnPorcao";
            this.btnPorcao.Size = new System.Drawing.Size(206, 97);
            this.btnPorcao.TabIndex = 30;
            this.btnPorcao.UseVisualStyleBackColor = false;
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackColor = System.Drawing.Color.Blue;
            this.btnBebidas.Image = ((System.Drawing.Image)(resources.GetObject("btnBebidas.Image")));
            this.btnBebidas.Location = new System.Drawing.Point(269, 10);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(206, 97);
            this.btnBebidas.TabIndex = 29;
            this.btnBebidas.UseVisualStyleBackColor = false;
            // 
            // btnPratos
            // 
            this.btnPratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPratos.Image = ((System.Drawing.Image)(resources.GetObject("btnPratos.Image")));
            this.btnPratos.Location = new System.Drawing.Point(25, 10);
            this.btnPratos.Name = "btnPratos";
            this.btnPratos.Size = new System.Drawing.Size(206, 97);
            this.btnPratos.TabIndex = 28;
            this.btnPratos.UseVisualStyleBackColor = false;
            this.btnPratos.Click += new System.EventHandler(this.btnPratos_Click);
            // 
            // pnGerenUser
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
            this.Name = "pnGerenUser";
            this.Size = new System.Drawing.Size(500, 300);
            this.Load += new System.EventHandler(this.GerenciamentoDeUsuario_Load);
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
