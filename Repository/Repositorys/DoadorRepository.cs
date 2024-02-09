using Dapper;
using Doador.Api.ViewModel;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Repository.Repositorys
{
    public class DoadorRepository: IDoadorRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task create(DoadorCommand command)
        {
            string queryinsert = @"insert into dbo.Doador (NomeCompleto, Idade, Estado,Email,Telefone) values (@NomeCompleto, @Idade , @Estado, @Email , @Telefone)";

           using (SqlConnection sqldoador = new SqlConnection(conexao))
            {
                sqldoador.Execute (queryinsert, new { 
                NomeCompleto=command.NomeCompleto,
                Idade= command.Idade,
                Estado=command.Estado,
                Email=command.Email,
                Telefone=command.Telefone,
                });
            }

        }
        public async Task <IEnumerable<DoadorViewModel>> GetAll()

        {
            String query = "SELECT * FROM Doador WHERE doadorId= @doadorId";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                return con.Query<DoadorViewModel>(query); 
            }
        }
        public async Task <DoadorViewModel> GetById(int doadorId)
        {
            String query = "SELECT * FROM Doador WHERE doadorId= @doadorId";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                return con.QueryFirstOrDefault<DoadorViewModel>(query, new { doadorId });

            }
        }
    }
}
