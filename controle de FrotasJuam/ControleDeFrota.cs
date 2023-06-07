using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_FrotasJuam
{
    public partial class ControleDeFrota : Form
    {
        public ControleDeFrota()
        {
            InitializeComponent();
        }


        public class Veiculo
        {
            private string modelo, placa, km; // atributos veículos

            public string propriedadesModelo
            {
                set { modelo = value; }
                get { return modelo; }
            }
            public string propriedadePlaca
            {
                set { placa = value; }
                get { return placa; }
            }

            public string propriedadeKm
            {
                set { km = value; }
                get { return km; }
            }

           /* public void gravaModelo(string modelo)
            {
                this.modelo = modelo; // adiciona o valor ao atributo
            }

            public void gravaPlaca(string placa)
            {
                this.placa = placa; // adiciona o valor ao atributo
            }

            public void gravakm(string km)
            {
                this.Km = Km; // adiciona o valor ao atributo
            }

            //------- Métodos que leêm os atributos do objeto------------
            public string mostraModelo()
            {
                return modelo; // retorna o valor do atributo
            }

            public string mostraPlaca()
            {
                return placa; // retorna o valor do atributo
            }

            public string mostraKm()
            {
                return Km = Km; // retorna o valor do atributo
            }*/
        }


            
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtEixo.Visible == false)
            {
                Veiculo novoCarro = new Veiculo();

                /*novoCarro.gravaModelo(txtModelo.Text);
                novoCarro.gravaPlaca(txtPlaca.Text);
                novoCarro.gravakm(txtkm.Text);*/
                
               /* txtCarros.Text += novoCarro.mostraModelo() + "\t";
                txtCarros.Text += novoCarro.mostraPlaca() + "\t";
                txtCarros.Text += novoCarro.mostraKm() + "\r\n"; */

                novoCarro.propriedadesModelo = txtModelo.Text;
                novoCarro.propriedadePlaca = txtPlaca.Text;
                novoCarro.propriedadeKm = txtKm.Text;

                txtCarros.AppendText(novoCarro.propriedadesModelo + "\t");
                txtCarros.AppendText(novoCarro.propriedadePlaca + "\t");
                txtCarros.AppendText(novoCarro.propriedadeKm + "\n");
            }

            else
            {
                Caminhao novoCaminhao = new Caminhao();

                novoCaminhao.propriedadesModelo = txtModelo.Text;
                novoCaminhao.propriedadePlaca = txtPlaca.Text;
                novoCaminhao.propriedadeKm = txtKm.Text;
                novoCaminhao.propriedadeEixo = txtEixo.Text;

                txtCaminhoes.AppendText(novoCaminhao.propriedadesModelo + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadePlaca + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadeKm + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadeEixo + "\n");
                                 
            }

            Limpar();
        }

        private void btnCaminhoes_Click(object sender, EventArgs e)
        {
            lblEixo.Visible = true;
            txtEixo.Visible = true;
        }
    

     public class Caminhao : Veiculo
        {
            public string propriedadeEixo { set; get; }
        }

     private void btnCarros_Click(object sender, EventArgs e) //Evento de click do botão btnCarros
     {
         lblEixo.Visible = false;//transformou em "invisível" o componente lblEixo
         txtEixo.Visible = false;//transformou em "invisível" o componente txtEixo
     }

     private void Limpar()
     {
         txtModelo.Clear();
         txtPlaca.Clear();
         txtKm.Clear();
         txtEixo.Clear();
     }

         
    }
            

}
    
    