using Models;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"Insert into Produto(Nome, Preco, Estoque,CodigoDeBarras
                                    Values(@Nome, @Preco, @Estoque, @CodigoDeBarras)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);
                cmd.Parameters.AddWithValue("@CodigoDeBarras", _produto.CodigoDeBarras);

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
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"Update Produto(Nome = @Nome, Preco = @Preco, Estoque = @Estoque, @CodigoDeBarras = CodigoDeBarras";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Estoque", _produto.Estoque);
                cmd.Parameters.AddWithValue("@CodigoDeBarras", _produto.CodigoDeBarras);

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
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

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

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Preco, Estoque, CodigoDeBarras From Produto";
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
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Estoque = Convert.ToDouble(rd["Estoque"]);
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                        produtoList.Add(produto);
                    }
                }
                return produtoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os produtos no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorId(int _id)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Preco, Estoque,CodigoDeBarras From Produto Where Id = @Id";
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
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto por id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto> BuscaPorNome(string _nome)
        {
            List<Produto> produtoList = new List<Produto>();
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Preco, Estoque, CodigoDeBarras From Produto Where Nome Like @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Estoque = Convert.ToDouble(rd["Estoque"]);
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                        produtoList.Add(produto);
                    }
                }
                return produtoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorCodigoDeBarras(string _codigoDeBarras)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "Select Id, Nome, Preco, Estoque, CodigoDeBarras From Produto Where CodigoDeBarras = @CodigoDeBarras";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@CodigoDeBarras", _codigoDeBarras);

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
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto por código de barras no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
