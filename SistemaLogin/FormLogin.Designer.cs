
namespace SistemaLogin
{
    partial class FormLogin
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
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(12, 40);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(437, 44);
            this.textUsuario.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(11, 136);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(437, 44);
            this.textSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(11, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(347, 212);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(101, 34);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 258);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLogar;
    }
}