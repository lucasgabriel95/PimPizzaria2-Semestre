using PizzariaPim.Control;
using PizzariaPim.DAL;
using PizzariaPim.Model.Bebidas;
using PizzariaPim.Model.Pedidos;
using PizzariaPim.Model.Vendas;
using PizzariaPim.Model.Vendas.Vendas;
using PizzariaPim.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaPim
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            
            InitializeComponent();
            Maximizar();
            Inicializacao();
           
           

        } 
        int codigo;
        public double valor = 0;
        public double Subtotal;
        public double Total;
        public double contadorMais = 0;
        public double ContadorMenos = 500;
        String Categoria;
        
        public void Maximizar()
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public void Limpar()
        {
            lblCodigoProduto.Text = "";
            txbDescricaoProduto.Text = "";
            lblQuantidade.Text = "0";
            lblValorUnitario.Text = "0,00";
            lblValorTotal.Text = "0,00";            
            txbDescricao.Text = "";
            
        }
        public void LimparVenda()
        {
            lblNomeDocliente.Text = "";
            lblCodigoCliente.Text = "0";
            txbDesconto.Text = "0";
            dgGrideItens.Rows.Clear();
            lblSubTotal.Text = "0";
            Subtotal = 0;
            Total = 0;

        }

        public void Inicializacao()
        {
            ComandosCadVenda comandos = new ComandosCadVenda();
            comandos.Inicializacao();
            if (comandos.CodigoVenda == 1)
            {
                lblCodigoVenda.Text = comandos.CodigoVenda.ToString();
            }
            else
            {
                comandos.verificarCodigoVenda();
                codigo = 1 + comandos.CodigoVenda;
                lblCodigoVenda.Text = codigo.ToString();
            }
        }
        public void LocalizarCliente ()
        {
            ComandosClientes comandos = new ComandosClientes();            
            dgrideCliente.DataSource = comandos.localizar(txbNomeCliente.Text);
        }
        public void localizarProduto ()
        {
            if (cbCategoria.Text == "Bebidas")
            {
                Categoria = "1";
            }
            else if (cbCategoria.Text == "Pizzas")
            {
                Categoria = "2";
            }
            else
            {
                Categoria = "";
            }

            ComandosProdutos cf = new ComandosProdutos();
            dgGride.DataSource = cf.LocalizarDescricao(txbDescricao.Text, Categoria);
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_CategoriasTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Categorias);
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_ProdutosTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Produtos);
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_ClienteTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.tb_intens_venda'. Você pode movê-la ou removê-la conforme necessário.
         
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_ProdutosTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Produtos);
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_CategoriasTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Categorias);

            this.cad_ClienteTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Cliente);
           
           // lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");

        }
        private void dgGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.ColumnIndex >= 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        codigo = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[0].Value);
                    }
                }
                ComandosProdutos comando = new ComandosProdutos();
                DadosProdutos dados = comando.Carregar(codigo);
                txbDescricaoProduto.Text = dados.Nome.ToString();
                lblValorUnitario.Text = dados.Valor.ToString();
                lblCodigoProduto.Text = dados.Codigo.ToString();
                lblValorTotal.Text = lblValorUnitario.Text;
                if (lblQuantidade.Text != "")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }            
        }
       

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
        int ControleIncluirNull = 1;
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            
            if (lblCodigoCliente.Text != "0"  && lblCodigoProduto.Text != "0" && lblQuantidade.Text != "0" && txbDescricaoProduto.Text != "")
            {
                ComandosCadVenda comandos = new ComandosCadVenda();
                if (ControleIncluirNull == 1)
                {
                    comandos.IncluirClienteNull(Convert.ToInt32(lblCodigoCliente.Text));
                    ControleIncluirNull = 2;
                }                
                ControleVendas controle = new ControleVendas();
                controle.CadatrarItens(Convert.ToInt32(lblCodigoProduto.Text), Convert.ToInt32(lblCodigoVenda.Text), Convert.ToInt32(lblQuantidade.Text), Convert.ToDouble(lblValorUnitario.Text));
               
                comandos.ConsultarCodigoItem();                
                valor = Convert.ToDouble(lblValorTotal.Text);
                Subtotal += valor;
                lblSubTotal.Text = Subtotal.ToString();
                valor = 0;               
                dgGrideItens.Rows.Add(Convert.ToString(comandos.codigoItem), lblQuantidade.Text, lblCodigoProduto.Text, txbDescricaoProduto.Text, "R$ " + lblValorUnitario.Text, lblValorTotal.Text);
                Total = Subtotal;
                Limpar();
            }
            else
            {
                MessageBox.Show("Selecione o cliente e um produto na tabela !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            contadorMais = 0;
            ContadorMenos = 500;
            
           
        }

       
        private void btnValorMais_Click(object sender, EventArgs e)
        {
            if (contadorMais != ContadorMenos)
            {
                contadorMais++;
                ContadorMenos++;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigoProduto.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
            if (contadorMais < 1)
            {
                contadorMais = 1;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigoProduto.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
        }
        private void btnValorMenos_Click(object sender, EventArgs e)
        {
            if (contadorMais != ContadorMenos)
            {

                contadorMais--;
                ContadorMenos--;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigoProduto.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
            if (contadorMais < 1)
            {
                contadorMais = 1;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigoProduto.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
        }
        private void lblValorUnitario_TextChanged(object sender, EventArgs e)
        {
            lblValorUnitario.Text = String.Format("{0:#,##0.00}", double.Parse(lblValorUnitario.Text));
        }
        private void lblValorTotal_TextChanged(object sender, EventArgs e)
        {
           lblValorTotal.Text = String.Format("{0:#,##0.00}", double.Parse(lblValorTotal.Text));
        }
        private void lblQuantidade_TextChanged(object sender, EventArgs e)
        {
          lblQuantidade.Text = String.Format("{0:#,##0.00}", double.Parse(lblQuantidade.Text));
        }

        private void lblSubTotal_TextChanged(object sender, EventArgs e)
        {
          lblSubTotal.Text = String.Format("{0:#,##0.00}", double.Parse(lblSubTotal.Text));
        }
        double linha;
        private void dgGrideItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    linha = Convert.ToDouble(dgGrideItens.Rows[e.RowIndex].Cells[5].Value);
                    codigo = Convert.ToInt32(dgGrideItens.Rows[e.RowIndex].Cells[0].Value);
                }
            }            
            Subtotal = Subtotal - linha;
            lblSubTotal.Text = Subtotal.ToString();
            dgGrideItens.Rows.Remove(dgGrideItens.CurrentRow);  
            
            ControleVendas controle = new ControleVendas();
            controle.Excluir(codigo);
        }        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cad_CategoriasTableAdapter.FillBy(this.bDpizzariaDataSet.Cad_Categorias);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }       

        private void cbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Limpar();
            localizarProduto ();
        }

        private void txbDescricao_TextChanged(object sender, EventArgs e)
        {
            localizarProduto();
        }

        private void txbNomeCliente_TextChanged(object sender, EventArgs e)
        {
            LocalizarCliente();
        }

        private void dgrideCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    codigo = Convert.ToInt32(dgrideCliente.Rows[e.RowIndex].Cells[0].Value);
                }
            }            
            ComandosClientes cf = new ComandosClientes();
            DadosClientes dadosClientes = cf.carregar(codigo);   
            lblCodigoCliente.Text = dadosClientes.codigo.ToString();
            lblNomeDocliente.Text = "- " + dadosClientes.nome;
            ComandosElogioReclamacoes comandos = new ComandosElogioReclamacoes();
            comandos.ConsultaUmtimaCompraCliente(Convert.ToInt32 (lblCodigoCliente.Text));
            if (comandos.DataMaxima == "")
            {

            }
            else
            {
                DialogResult mensagemConfirmacao;
                mensagemConfirmacao = MessageBox.Show("A ultima Compra do "+lblNomeDocliente.Text+" foi no dia "+ comandos.DataMaxima +", deseja cadastrar um elogio ou reclamação ?","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (mensagemConfirmacao.ToString() == "Yes")
                {                                     
                    FormSatisfacao form = new FormSatisfacao();   
                    form.ShowDialog();                    
                }
            }
        }
        private void txbDesconto_TextChanged(object sender, EventArgs e)
        {
          
        }
        int V = 1;       

        private void btnIncluirDesconto_Click(object sender, EventArgs e)
        {
            if (V == 1)
            {
                if (txbDesconto.Text != "")
                {
                    if (Subtotal < 0)
                    {
                        Subtotal = 0;
                    }
                    Subtotal -= Convert.ToDouble(txbDesconto.Text);
                    V = 0;
                    btnIncluirDesconto.Text = "DESFAZER";                    
                }
            }
            else if (V == 0)
            {
                Subtotal = Total;
                btnIncluirDesconto.Text = "INCLUIR";
                V = 1;
            }
            lblSubTotal.Text = Subtotal.ToString();
        }
       
        private void btnFinalizarPedido_Click_1(object sender, EventArgs e)
        {
            ControleIncluirNull = 1;
            if (lblSubTotal.Text != "0,00")
            {
                DialogResult mensagemConfirmacao;
                mensagemConfirmacao = MessageBox.Show("Finalizar Pedido ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensagemConfirmacao.ToString() == "Yes")
                {
                    ComandosCadVenda comandos = new ComandosCadVenda();
                    DadosCadVenda dados = new DadosCadVenda();
                    dados.Codigo = Convert.ToInt32(lblCodigoVenda.Text);
                    dados.Valor = Total;
                    dados.Desconto = Convert.ToDouble(txbDesconto.Text);
                    dados.ValorPago = Convert.ToDouble(lblSubTotal.Text);
                    dados.CodigoCliente = Convert.ToInt32(lblCodigoCliente.Text);
                    dados.Status = "Cozinha";
                    
                    dados.obs = txbObs.Text;
                    dados.DataTime = Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:dd"));
                    ControleVendas controle = new ControleVendas();
                    controle.Alterar(dados);
                    MessageBox.Show("Pedido Realizado Com Sucesso !!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparVenda();       
                    comandos.UpDateInicializacao();
                    Inicializacao();

                }
            }
            else
            {
                MessageBox.Show("Selecione 1 CLIENTE e 1 PRODUTO !! ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }    
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ControleIncluirNull = 1;
            DialogResult mensagemConfirmacao;
            if (lblSubTotal.Text != "0,00")
            {
                mensagemConfirmacao = MessageBox.Show("Cancelar Pedido ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensagemConfirmacao.ToString() == "Yes")
                {
                    ComandosCadVenda comandos = new ComandosCadVenda();
                    DadosCadVenda dados = new DadosCadVenda();
                    dados.Codigo = Convert.ToInt32(lblCodigoVenda.Text);
                    dados.Valor = Total;
                    dados.Desconto = Convert.ToDouble(txbDesconto.Text);
                    dados.ValorPago = Convert.ToDouble(lblSubTotal.Text);
                    dados.CodigoCliente = Convert.ToInt32(lblCodigoCliente.Text);
                    dados.Status = "Cancelado";
                    dados.DataTime = Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:dd"));
                    ControleVendas controle = new ControleVendas();
                    controle.Alterar(dados);
                    Inicializacao();
                    LimparVenda();
                    MessageBox.Show("Pedido cancelado com Sucesso !!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.Close();
            }

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            ControleIncluirNull = 1;
            DialogResult mensagemConfirmacao;
            if (lblSubTotal.Text != "0,00")
            {
                mensagemConfirmacao = MessageBox.Show("Cancelar Pedido ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensagemConfirmacao.ToString() == "Yes")
                {
                    ComandosCadVenda comandos = new ComandosCadVenda();
                    DadosCadVenda dados = new DadosCadVenda();
                    dados.Codigo = Convert.ToInt32(lblCodigoVenda.Text);
                    dados.Valor = Total;
                    dados.Desconto = Convert.ToDouble(txbDesconto.Text);
                    dados.ValorPago = Convert.ToDouble(lblSubTotal.Text);
                    dados.CodigoCliente = Convert.ToInt32(lblCodigoCliente.Text);
                    dados.Status = "Cancelado";
                    dados.DataTime = Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:dd"));
                    ControleVendas controle = new ControleVendas();
                    controle.Alterar(dados);
                    Inicializacao();
                    LimparVenda();
                    MessageBox.Show("Pedido cancelado com Sucesso !!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.Show();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            FormProdutos prdoutos = new FormProdutos();
            prdoutos.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void txbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
