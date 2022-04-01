
namespace TesteMSDTC
{
    partial class Form1
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
            this.btnTestarTransactionScope = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grpConexao1 = new System.Windows.Forms.GroupBox();
            this.txtSql1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestarConexao1 = new System.Windows.Forms.Button();
            this.txtConexao1 = new System.Windows.Forms.TextBox();
            this.grpConexao2 = new System.Windows.Forms.GroupBox();
            this.txtSql2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestarConexao2 = new System.Windows.Forms.Button();
            this.txtConexao2 = new System.Windows.Forms.TextBox();
            this.grpConexao3 = new System.Windows.Forms.GroupBox();
            this.txtSql3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestarConexao3 = new System.Windows.Forms.Button();
            this.txtConexao3 = new System.Windows.Forms.TextBox();
            this.chkConexao1 = new System.Windows.Forms.CheckBox();
            this.chkConexao2 = new System.Windows.Forms.CheckBox();
            this.chkConexao3 = new System.Windows.Forms.CheckBox();
            this.grpConexao1.SuspendLayout();
            this.grpConexao2.SuspendLayout();
            this.grpConexao3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestarTransactionScope
            // 
            this.btnTestarTransactionScope.Location = new System.Drawing.Point(12, 342);
            this.btnTestarTransactionScope.Name = "btnTestarTransactionScope";
            this.btnTestarTransactionScope.Size = new System.Drawing.Size(1014, 34);
            this.btnTestarTransactionScope.TabIndex = 18;
            this.btnTestarTransactionScope.Text = "Testar Transação usando TransactionScope";
            this.btnTestarTransactionScope.UseVisualStyleBackColor = true;
            this.btnTestarTransactionScope.Click += new System.EventHandler(this.btnTestarTransactionScope_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtResultado.Location = new System.Drawing.Point(12, 382);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(1014, 314);
            this.txtResultado.TabIndex = 19;
            // 
            // grpConexao1
            // 
            this.grpConexao1.Controls.Add(this.txtSql1);
            this.grpConexao1.Controls.Add(this.label1);
            this.grpConexao1.Controls.Add(this.btnTestarConexao1);
            this.grpConexao1.Controls.Add(this.txtConexao1);
            this.grpConexao1.Location = new System.Drawing.Point(12, 12);
            this.grpConexao1.Name = "grpConexao1";
            this.grpConexao1.Size = new System.Drawing.Size(1014, 104);
            this.grpConexao1.TabIndex = 1;
            this.grpConexao1.TabStop = false;
            // 
            // txtSql1
            // 
            this.txtSql1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtSql1.Location = new System.Drawing.Point(6, 73);
            this.txtSql1.Name = "txtSql1";
            this.txtSql1.Size = new System.Drawing.Size(1002, 20);
            this.txtSql1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL 1";
            // 
            // btnTestarConexao1
            // 
            this.btnTestarConexao1.Location = new System.Drawing.Point(912, 21);
            this.btnTestarConexao1.Name = "btnTestarConexao1";
            this.btnTestarConexao1.Size = new System.Drawing.Size(96, 23);
            this.btnTestarConexao1.TabIndex = 3;
            this.btnTestarConexao1.Text = "Testar Conexão";
            this.btnTestarConexao1.UseVisualStyleBackColor = true;
            this.btnTestarConexao1.Click += new System.EventHandler(this.btnTestarConexao1_Click);
            // 
            // txtConexao1
            // 
            this.txtConexao1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtConexao1.Location = new System.Drawing.Point(6, 23);
            this.txtConexao1.Name = "txtConexao1";
            this.txtConexao1.Size = new System.Drawing.Size(900, 20);
            this.txtConexao1.TabIndex = 2;
            // 
            // grpConexao2
            // 
            this.grpConexao2.Controls.Add(this.txtSql2);
            this.grpConexao2.Controls.Add(this.label2);
            this.grpConexao2.Controls.Add(this.btnTestarConexao2);
            this.grpConexao2.Controls.Add(this.txtConexao2);
            this.grpConexao2.Location = new System.Drawing.Point(12, 122);
            this.grpConexao2.Name = "grpConexao2";
            this.grpConexao2.Size = new System.Drawing.Size(1014, 104);
            this.grpConexao2.TabIndex = 7;
            this.grpConexao2.TabStop = false;
            // 
            // txtSql2
            // 
            this.txtSql2.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtSql2.Location = new System.Drawing.Point(6, 73);
            this.txtSql2.Name = "txtSql2";
            this.txtSql2.Size = new System.Drawing.Size(1002, 20);
            this.txtSql2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SQL 2";
            // 
            // btnTestarConexao2
            // 
            this.btnTestarConexao2.Location = new System.Drawing.Point(912, 21);
            this.btnTestarConexao2.Name = "btnTestarConexao2";
            this.btnTestarConexao2.Size = new System.Drawing.Size(96, 23);
            this.btnTestarConexao2.TabIndex = 9;
            this.btnTestarConexao2.Text = "Testar Conexão";
            this.btnTestarConexao2.UseVisualStyleBackColor = true;
            this.btnTestarConexao2.Click += new System.EventHandler(this.btnTestarConexao2_Click);
            // 
            // txtConexao2
            // 
            this.txtConexao2.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtConexao2.Location = new System.Drawing.Point(6, 23);
            this.txtConexao2.Name = "txtConexao2";
            this.txtConexao2.Size = new System.Drawing.Size(900, 20);
            this.txtConexao2.TabIndex = 8;
            // 
            // grpConexao3
            // 
            this.grpConexao3.Controls.Add(this.txtSql3);
            this.grpConexao3.Controls.Add(this.label3);
            this.grpConexao3.Controls.Add(this.btnTestarConexao3);
            this.grpConexao3.Controls.Add(this.txtConexao3);
            this.grpConexao3.Location = new System.Drawing.Point(12, 232);
            this.grpConexao3.Name = "grpConexao3";
            this.grpConexao3.Size = new System.Drawing.Size(1014, 104);
            this.grpConexao3.TabIndex = 13;
            this.grpConexao3.TabStop = false;
            // 
            // txtSql3
            // 
            this.txtSql3.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtSql3.Location = new System.Drawing.Point(6, 73);
            this.txtSql3.Name = "txtSql3";
            this.txtSql3.Size = new System.Drawing.Size(1002, 20);
            this.txtSql3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "SQL 3";
            // 
            // btnTestarConexao3
            // 
            this.btnTestarConexao3.Location = new System.Drawing.Point(912, 21);
            this.btnTestarConexao3.Name = "btnTestarConexao3";
            this.btnTestarConexao3.Size = new System.Drawing.Size(96, 23);
            this.btnTestarConexao3.TabIndex = 15;
            this.btnTestarConexao3.Text = "Testar Conexão";
            this.btnTestarConexao3.UseVisualStyleBackColor = true;
            this.btnTestarConexao3.Click += new System.EventHandler(this.btnTestarConexao3_Click);
            // 
            // txtConexao3
            // 
            this.txtConexao3.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtConexao3.Location = new System.Drawing.Point(6, 23);
            this.txtConexao3.Name = "txtConexao3";
            this.txtConexao3.Size = new System.Drawing.Size(900, 20);
            this.txtConexao3.TabIndex = 14;
            // 
            // chkConexao1
            // 
            this.chkConexao1.AutoSize = true;
            this.chkConexao1.Location = new System.Drawing.Point(12, 12);
            this.chkConexao1.Name = "chkConexao1";
            this.chkConexao1.Size = new System.Drawing.Size(102, 17);
            this.chkConexao1.TabIndex = 0;
            this.chkConexao1.Text = "Usar Conexão 1";
            this.chkConexao1.UseVisualStyleBackColor = true;
            this.chkConexao1.Click += new System.EventHandler(this.chkConexao1_Click);
            // 
            // chkConexao2
            // 
            this.chkConexao2.AutoSize = true;
            this.chkConexao2.Location = new System.Drawing.Point(12, 122);
            this.chkConexao2.Name = "chkConexao2";
            this.chkConexao2.Size = new System.Drawing.Size(102, 17);
            this.chkConexao2.TabIndex = 6;
            this.chkConexao2.Text = "Usar Conexão 2";
            this.chkConexao2.UseVisualStyleBackColor = true;
            this.chkConexao2.Click += new System.EventHandler(this.chkConexao2_Click);
            // 
            // chkConexao3
            // 
            this.chkConexao3.AutoSize = true;
            this.chkConexao3.Location = new System.Drawing.Point(12, 232);
            this.chkConexao3.Name = "chkConexao3";
            this.chkConexao3.Size = new System.Drawing.Size(102, 17);
            this.chkConexao3.TabIndex = 12;
            this.chkConexao3.Text = "Usar Conexão 3";
            this.chkConexao3.UseVisualStyleBackColor = true;
            this.chkConexao3.Click += new System.EventHandler(this.chkConexao3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 708);
            this.Controls.Add(this.chkConexao3);
            this.Controls.Add(this.chkConexao2);
            this.Controls.Add(this.chkConexao1);
            this.Controls.Add(this.grpConexao3);
            this.Controls.Add(this.grpConexao2);
            this.Controls.Add(this.grpConexao1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnTestarTransactionScope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testes de Conexão e uso do TransactionScope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpConexao1.ResumeLayout(false);
            this.grpConexao1.PerformLayout();
            this.grpConexao2.ResumeLayout(false);
            this.grpConexao2.PerformLayout();
            this.grpConexao3.ResumeLayout(false);
            this.grpConexao3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestarTransactionScope;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox grpConexao1;
        private System.Windows.Forms.TextBox txtSql1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestarConexao1;
        private System.Windows.Forms.TextBox txtConexao1;
        private System.Windows.Forms.GroupBox grpConexao2;
        private System.Windows.Forms.TextBox txtSql2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestarConexao2;
        private System.Windows.Forms.TextBox txtConexao2;
        private System.Windows.Forms.GroupBox grpConexao3;
        private System.Windows.Forms.TextBox txtSql3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestarConexao3;
        private System.Windows.Forms.TextBox txtConexao3;
        private System.Windows.Forms.CheckBox chkConexao1;
        private System.Windows.Forms.CheckBox chkConexao2;
        private System.Windows.Forms.CheckBox chkConexao3;
    }
}

