
namespace PrjNome
{
    partial class Form1
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
            this.lbl_nm = new System.Windows.Forms.Label();
            this.lbl_sn = new System.Windows.Forms.Label();
            this.TXT_nm = new System.Windows.Forms.TextBox();
            this.TXT_sn = new System.Windows.Forms.TextBox();
            this.BTN_nc = new System.Windows.Forms.Button();
            this.BTN_cln = new System.Windows.Forms.Button();
            this.BTN_exit = new System.Windows.Forms.Button();
            this.lbl_nc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nm
            // 
            this.lbl_nm.AutoSize = true;
            this.lbl_nm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_nm.Location = new System.Drawing.Point(301, 67);
            this.lbl_nm.Name = "lbl_nm";
            this.lbl_nm.Size = new System.Drawing.Size(79, 29);
            this.lbl_nm.TabIndex = 0;
            this.lbl_nm.Text = "Nome";
            this.lbl_nm.Click += new System.EventHandler(this.lbl_nm_Click);
            // 
            // lbl_sn
            // 
            this.lbl_sn.AutoSize = true;
            this.lbl_sn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_sn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_sn.Location = new System.Drawing.Point(268, 155);
            this.lbl_sn.Name = "lbl_sn";
            this.lbl_sn.Size = new System.Drawing.Size(140, 29);
            this.lbl_sn.TabIndex = 1;
            this.lbl_sn.Text = "Sobrenome";
            this.lbl_sn.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_nm
            // 
            this.TXT_nm.Location = new System.Drawing.Point(240, 99);
            this.TXT_nm.Name = "TXT_nm";
            this.TXT_nm.Size = new System.Drawing.Size(198, 20);
            this.TXT_nm.TabIndex = 2;
            this.TXT_nm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXT_sn
            // 
            this.TXT_sn.Location = new System.Drawing.Point(240, 187);
            this.TXT_sn.Name = "TXT_sn";
            this.TXT_sn.Size = new System.Drawing.Size(198, 20);
            this.TXT_sn.TabIndex = 3;
            this.TXT_sn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BTN_nc
            // 
            this.BTN_nc.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_nc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BTN_nc.Location = new System.Drawing.Point(240, 282);
            this.BTN_nc.Name = "BTN_nc";
            this.BTN_nc.Size = new System.Drawing.Size(198, 38);
            this.BTN_nc.TabIndex = 4;
            this.BTN_nc.Text = "NomeCompleto";
            this.BTN_nc.UseVisualStyleBackColor = false;
            this.BTN_nc.Click += new System.EventHandler(this.BTN_nc_Click);
            // 
            // BTN_cln
            // 
            this.BTN_cln.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_cln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cln.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BTN_cln.Location = new System.Drawing.Point(240, 326);
            this.BTN_cln.Name = "BTN_cln";
            this.BTN_cln.Size = new System.Drawing.Size(94, 40);
            this.BTN_cln.TabIndex = 5;
            this.BTN_cln.Text = "Limpar";
            this.BTN_cln.UseVisualStyleBackColor = false;
            this.BTN_cln.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_exit
            // 
            this.BTN_exit.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BTN_exit.Location = new System.Drawing.Point(344, 326);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.Size = new System.Drawing.Size(94, 40);
            this.BTN_exit.TabIndex = 6;
            this.BTN_exit.Text = "Sair";
            this.BTN_exit.UseVisualStyleBackColor = false;
            this.BTN_exit.Click += new System.EventHandler(this.button3_Click);
            this.BTN_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_exit_MouseMove);
            // 
            // lbl_nc
            // 
            this.lbl_nc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_nc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_nc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl_nc.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nc.Location = new System.Drawing.Point(12, 231);
            this.lbl_nc.Name = "lbl_nc";
            this.lbl_nc.Size = new System.Drawing.Size(663, 36);
            this.lbl_nc.TabIndex = 7;
            this.lbl_nc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nc.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(687, 395);
            this.Controls.Add(this.lbl_nc);
            this.Controls.Add(this.BTN_exit);
            this.Controls.Add(this.BTN_cln);
            this.Controls.Add(this.BTN_nc);
            this.Controls.Add(this.TXT_sn);
            this.Controls.Add(this.TXT_nm);
            this.Controls.Add(this.lbl_sn);
            this.Controls.Add(this.lbl_nm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nm;
        private System.Windows.Forms.Label lbl_sn;
        private System.Windows.Forms.TextBox TXT_nm;
        private System.Windows.Forms.TextBox TXT_sn;
        private System.Windows.Forms.Button BTN_nc;
        private System.Windows.Forms.Button BTN_cln;
        private System.Windows.Forms.Button BTN_exit;
        private System.Windows.Forms.Label lbl_nc;
    }
}

