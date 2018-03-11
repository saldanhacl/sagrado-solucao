namespace Sagrado
{
    partial class TipoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.White;
            this.btnAdm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.Black;
            this.btnAdm.Location = new System.Drawing.Point(174, 233);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(202, 109);
            this.btnAdm.TabIndex = 1;
            this.btnAdm.Text = "Adminstrador";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.White;
            this.btnFunc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.Black;
            this.btnFunc.Location = new System.Drawing.Point(425, 233);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(202, 109);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = "Funcionário";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // TipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.label1);
            this.Name = "TipoUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnFunc;
    }
}

