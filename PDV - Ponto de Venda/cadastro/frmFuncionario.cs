using BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace PDV___Ponto_de_Venda
{
    public partial class frmFuncionario : Form
    {
        //varivável conection recebe por herança todos os atributos da classe ConexaoBd.

        ConexaoBD connection = new ConexaoBD();
        string sql;
        MySqlCommand cmd;

        string foto;

        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            connection.dbOpen();
            sql = "INSERT INTO funcionarios(cpf, nome, telefone, endereco, cargo, foto) VALUES(@cpf, @nome, @telefone, @endereco, @cargo, @foto)";

            cmd = new MySqlCommand(sql, connection.conn);
            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text);
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
            cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
            cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text);
            cmd.Parameters.AddWithValue("@cargo", box_cargo.Text);
            cmd.Parameters.AddWithValue("@foto", img());


            cmd.ExecuteNonQuery();
            connection.dbClose();
            MessageBox.Show("Salvo com sucesso");
        }
      



        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png;) | *.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                img_funcionario.ImageLocation = foto;
                // alterouImagem = "sim";
            }
        }
        private byte[] img()
        {
            byte[] imagem_byte;
            if (foto == "")
            {
                return null;
            }

            FileStream fs  = new FileStream(foto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;
        }

        private void limparFoto()
        {
            img_funcionario.Image = Properties.Resources.Horizon;
            foto = "img/Horizon.png";
        }
    }
}
