using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            
            while(CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                login.ShowDialog();

                if(FormLogin.Cancelar == true)
                {
                    Application.Exit();
                    return;
                }
            }
            labelBoasVindasddd.Text = "Bem vindo(a), \n" + CadastroUsuarios.UsuarioLogado.Name;
            Visible = true;


        }
    }
}
