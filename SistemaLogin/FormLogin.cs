using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string name = textUsuario.Text;
            string senha = textSenha.Text;

            if(CadastroUsuarios.Login(name, senha))
            {
                Close();

            }
            else
            {
                MessageBox.Show("Usuário não cadastrado");
                textUsuario.Text = "";
                textSenha.Text = "";
                textUsuario.Focus();
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
