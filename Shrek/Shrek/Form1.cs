using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shrek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Automatico()
        {
            String nome = txtBox_nome.Text;

            double valor_base = 0;
            int ano_nascimento = 0;
            double total = 0, desconto = 0;

            //impedir que haja valores vazios
            try
            {
                valor_base = Convert.ToInt16(txtBox_valor_base.Text);
                ano_nascimento = Convert.ToInt16(txtBox_ano_nascimento.Text);
                lbl_warning.Text = "";
            }
            catch { lbl_warning.Text = "Valores em falta ou inválidos!"; }

            if (ano_nascimento >= 2019) { lbl_warning.Text = "Ano fora do intervalo!"; }

            //desconto para pessoas nascidas após o ano 2000
            if (ano_nascimento >= 2000)
            {
                desconto = valor_base * 0.1;
                total += valor_base - desconto;
            }

            //condicionais para verificar as checkboxes para descontos e/ ou agravamentos
            if (chkBox_escalao.Checked) { total -= (valor_base * 0.1); }
            if (chkBox_socio.Checked) { total -= (valor_base * 0.05); }
            if (chkBox_agravamento.Checked) { total += 12; }

            //verifica o radioButton e os concelhos selecionados
            if (rdBtn_sim.Checked) { total -= (valor_base * 0.01); }
            if (cmbBox_concelhos.Text == "Amares") { total -= (valor_base * 0.20); }
            txtBox_resultado.Text = Convert.ToString(total);
        }

        //botão para calcular a avença
        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            Automatico();
        }
        
        //txtBox para o ano nascimento
        private void TxtBox_ano_nascimento_TextChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //txtBox para o valor base
        private void TxtBox_valor_base_TextChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //checkbox para o escalão
        private void ChkBox_escalao_CheckedChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //checkbox para o sócio
        private void ChkBox_socio_CheckedChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //checkbox para o agravamento
        private void ChkBox_agravamento_CheckedChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //radiobutton sim
        private void RdBtn_sim_CheckedChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //radiobutton não
        private void RdBtn_nao_CheckedChanged(object sender, EventArgs e)
        {
            Automatico();
        }
        //combobox com concelhos 
        private void CmbBox_concelhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automatico();
        }
    }
}
