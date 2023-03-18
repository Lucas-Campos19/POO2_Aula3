using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO2_Aula3
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        Form tela;

        private void btnCliente_Click(object sender, EventArgs e) // criando a lógica do botão cliente em que quando o usuario clicar no botão clienta da tela principal ira aparecer a tela cilente no panel da tela principal.
        {
            tela = new TelaCliente // instanciamento do tela cliente. 
            {
              TopLevel = false, // define se o formulario sera exibido na parte de cima como uma janela de nível superior // o false diz que não ira exibir o formulario na parte superior.
              FormBorderStyle = FormBorderStyle.None, // define o estilo de borda de um formulario. // FormBorderStyle.None especifica o estilo de borda de um usuario, none siguinifica sem borda ou seja este formulario não tem nenhuma borda estilizada.
              Dock = DockStyle.Fill, // define quais bordas de controle são encaixadas no controle pai e determina como o controle é redimensionado com seu pai.
            };
            plPrincipal.Controls.Add(tela); // esta adicionando controle do tela cliente fazendo o chamado do botão cliente para aparecer no painel.
            tela.Show(); // exibe o formulario para o usuario.

        }
    }
}
