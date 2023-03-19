namespace Biblioteca
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rBtnCliente = new System.Windows.Forms.RadioButton();
            this.rBtnFuncionario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCabecalho.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCabecalho.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCabecalho.Location = new System.Drawing.Point(0, 0);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(800, 92);
            this.lblCabecalho.TabIndex = 0;
            this.lblCabecalho.Text = "Login";
            this.lblCabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(244, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(244, 194);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 21);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(309, 196);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(205, 23);
            this.txtSenha.TabIndex = 7;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEntrar.Location = new System.Drawing.Point(347, 285);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(133, 32);
            this.BtnEntrar.TabIndex = 8;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(347, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rBtnCliente
            // 
            this.rBtnCliente.AutoSize = true;
            this.rBtnCliente.Checked = true;
            this.rBtnCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBtnCliente.Location = new System.Drawing.Point(309, 240);
            this.rBtnCliente.Name = "rBtnCliente";
            this.rBtnCliente.Size = new System.Drawing.Size(82, 25);
            this.rBtnCliente.TabIndex = 10;
            this.rBtnCliente.Text = "Cliente";
            this.rBtnCliente.UseVisualStyleBackColor = true;
            // 
            // rBtnFuncionario
            // 
            this.rBtnFuncionario.AutoSize = true;
            this.rBtnFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBtnFuncionario.Location = new System.Drawing.Point(419, 240);
            this.rBtnFuncionario.Name = "rBtnFuncionario";
            this.rBtnFuncionario.Size = new System.Drawing.Size(119, 25);
            this.rBtnFuncionario.TabIndex = 11;
            this.rBtnFuncionario.Text = "Funcionario";
            this.rBtnFuncionario.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtnFuncionario);
            this.Controls.Add(this.rBtnCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCabecalho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCabecalho;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button BtnEntrar;
        private Button btnCancelar;
        private RadioButton rBtnCliente;
        private RadioButton rBtnFuncionario;
    }
}