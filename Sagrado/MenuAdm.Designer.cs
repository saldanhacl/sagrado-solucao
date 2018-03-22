namespace Sagrado
{
    partial class MenuAdm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnControle = new Sagrado.Controle();
            this.pnComanda = new Sagrado.Comanda();
            this.pnGerenUser = new Sagrado.pnGerenUser();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(36, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "Trocar Usuário";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(36, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "Painel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(36, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 49);
            this.button4.TabIndex = 24;
            this.button4.Text = "Finalizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pnControle
            // 
            this.pnControle.BackColor = System.Drawing.Color.White;
            this.pnControle.Location = new System.Drawing.Point(259, 35);
            this.pnControle.Name = "pnControle";
            this.pnControle.Size = new System.Drawing.Size(498, 637);
            this.pnControle.TabIndex = 12;
            this.pnControle.Load += new System.EventHandler(this.pnControle_Load);
            // 
            // pnComanda
            // 
            this.pnComanda.BackColor = System.Drawing.Color.White;
            this.pnComanda.Location = new System.Drawing.Point(249, 132);
            this.pnComanda.Name = "pnComanda";
            this.pnComanda.Size = new System.Drawing.Size(498, 299);
            this.pnComanda.TabIndex = 11;
            this.pnComanda.Load += new System.EventHandler(this.pnComanda_Load);
            // 
            // pnGerenUser
            // 
            this.pnGerenUser.BackColor = System.Drawing.Color.White;
            this.pnGerenUser.Location = new System.Drawing.Point(247, 35);
            this.pnGerenUser.Name = "pnGerenUser";
            this.pnGerenUser.Size = new System.Drawing.Size(500, 300);
            this.pnGerenUser.TabIndex = 15;
            // 
            // MenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 692);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnGerenUser);
            this.Controls.Add(this.pnControle);
            this.Controls.Add(this.pnComanda);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Name = "MenuAdm";
            this.Text = "PAINEL ADMINISTRADOR";
            this.Load += new System.EventHandler(this.MenuAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private Comanda pnComanda;
        private Controle pnControle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private pnGerenUser pnGerenUser;
    }
}