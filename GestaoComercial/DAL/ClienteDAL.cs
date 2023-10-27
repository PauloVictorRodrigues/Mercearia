using Models;
using System.Data.Common;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Transactions;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("Insert into Cliente(Nome, Fone Values(@Nome, @Fone"))
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                        cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar inserir o cliente no banco de dados.", ex);
                    }
            }
        }
        public void Alterar(Cliente _cliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("Update Cliente Set Nome = @Nome, Fone = @Fone Where Id = @Id"))
                {

                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                        cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                        cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar atualizar o cliente no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("Delete From Cliente Where Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _id);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar excluir o cliente no banco de dados.", ex);
                    }
                }
            }
        }
        public List<Cliente> BuscarTodos()
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Fone FROM Cliente";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os clietes no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorId(int _id)
        {
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Fone FROM Cliente";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    if (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente por id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Cliente> BuscaPorNome(string _nome)
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Fone From Cliente Where Nome Like @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuário por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorFone(string _fone)
        {
            Cliente cliente;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Id, Nome, Fone From Cliente Where Fone = @Fone";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Fone", _fone);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cliente = new Cliente();
                    if (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente por telefone no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
