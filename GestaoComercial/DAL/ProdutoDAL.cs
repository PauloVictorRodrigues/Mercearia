using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"Insert into Produto(Nome, Preco, Estoque
                                    Values(@Nome, @Preco, @Estoque)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"Update Produto(Nome = @Nome, Preco = @Preco, Estoque = @Estoque";
                                   
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"Delete From Produto
                                   Where Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto> BuscarTodos()
        {
            List<Produto> produtoList = new List<Produto>();
            Produto produto;

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Preco, Estoque";
                cmd.CommandType = System.Data.CommandType.Text;


                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = (float) rd["Preco"];
                        produto.Estoque = (float)rd["Estoque"];
                    }
                }
                return produtoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorId(int _id)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Preco, Estoque";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = (float)rd["Preco"];
                        produto.Estoque = (float)rd["Estoque"];
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
