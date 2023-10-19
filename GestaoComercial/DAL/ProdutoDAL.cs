using Models;
using System.Data.SqlClient;

namespace DAL
{
    internal class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = cn.CreateCommand();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o usuário no banco de dados.", ex);
            }
        }
        public void Alterar(Produto _produto)
        {

        }
        public List<Produto> BuscarTodos()
        {
            throw new NotImplementedException();
        }
        public void Excluir(int _id)
        {

        }
    }
}
