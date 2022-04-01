using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace TesteMSDTC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkConexao1.Checked = true;
            txtConexao1.Text = "Data Source=PLANTDEV.funcional.local; Initial Catalog=FuncionalPlant; User ID=appFuncPlant; Password=@Plant2017; MultipleActiveResultSets=True;";
            txtSql1.Text = "update FuncionalPlant.dbo.Parentesco set NomeParentesco = 'A' + NomeParentesco where Id = 99";

            chkConexao2.Checked = true;
            txtConexao2.Text = "Data Source=DBSERVERDEV.funcional.local; Initial Catalog=NetCardPJ; User ID=appFuncPlant; Password=@Plant2017; MultipleActiveResultSets=True;";
            txtSql2.Text = "update NetCardPJ.dbo.USUARIO set NOMUSU = 'A' + NOMUSU where CODCLI = 1 and CPF = '12147570818' and NUMDEP = 0";

            chkConexao3.Checked = true;
            txtConexao3.Text = "Data Source=BENEFITDEV.funcional.local; Initial Catalog=benefit; User ID=appFuncPlant; Password=@Plant2017; MultipleActiveResultSets=True;";
            txtSql3.Text = "update benefit.dbo.Feriados set Descricao = 'A' + Descricao where id = 11";
        }

        private void chkConexao1_Click(object sender, EventArgs e)
        {
            grpConexao1.Enabled = chkConexao1.Checked;
        }

        private void chkConexao2_Click(object sender, EventArgs e)
        {
            grpConexao2.Enabled = chkConexao2.Checked;
        }

        private void chkConexao3_Click(object sender, EventArgs e)
        {
            grpConexao3.Enabled = chkConexao3.Checked;
        }

        private void btnTestarConexao1_Click(object sender, EventArgs e)
        {
            TestarConexao(txtConexao1.Text);
        }

        private void btnTestarConexao2_Click(object sender, EventArgs e)
        {
            TestarConexao(txtConexao2.Text);
        }

        private void btnTestarConexao3_Click(object sender, EventArgs e)
        {
            TestarConexao(txtConexao3.Text);
        }

        private void TestarConexao(string connectionString)
        {
            var result = TestarConexaoDb(connectionString);

            if (result)
                MessageBox.Show("Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro na conexão com o Banco de Dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool TestarConexaoDb(string connectionString)
        {
            var result = false;

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                }

                result = true;
            }
            catch
            {

            }

            return result;
        }

        private void btnTestarTransactionScope_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            try
            {
                using (var transactionScope = new TransactionScope())
                {
                    if (chkConexao1.Checked)
                    {
                        using (var conn = new SqlConnection(txtConexao1.Text))
                        {
                            conn.Open();
                            using (var command = conn.CreateCommand())
                            {
                                command.CommandText = txtSql1.Text;
                                command.ExecuteNonQuery();

                                txtResultado.Text += "SQL 1 executado com sucesso" + Environment.NewLine + Environment.NewLine;
                            }
                        }
                    }

                    if (chkConexao2.Checked)
                    {
                        using (var conn = new SqlConnection(txtConexao2.Text))
                        {
                            conn.Open();
                            using (var command = conn.CreateCommand())
                            {
                                command.CommandText = txtSql2.Text;
                                command.ExecuteNonQuery();

                                txtResultado.Text += "SQL 2 executado com sucesso" + Environment.NewLine + Environment.NewLine;
                            }
                        }
                    }

                    if (chkConexao3.Checked)
                    {
                        using (var conn = new SqlConnection(txtConexao3.Text))
                        {
                            conn.Open();
                            using (var command = conn.CreateCommand())
                            {
                                command.CommandText = txtSql3.Text;
                                command.ExecuteNonQuery();

                                txtResultado.Text += "SQL 3 executado com sucesso" + Environment.NewLine + Environment.NewLine;
                            }
                        }
                    }

                    transactionScope.Complete();
                }

                MessageBox.Show("Transação usando TransactionScope realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtResultado.Text += "Message: " + ex.Message + Environment.NewLine + Environment.NewLine + "InnerException: " + ex.InnerException;

                MessageBox.Show("Erro na transação usando TransactionScope.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
