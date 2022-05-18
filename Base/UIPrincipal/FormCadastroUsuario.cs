﻿using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuarioBLL.Inserir(usuario);
        }

        private void buttonSalvarCadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("Cadastro realizado com sucesso!");
            usuarioBindingSource.AddNew();
            nomeUsuarioTextBox.Focus();
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
