using Microsoft.EntityFrameworkCore;
using PrimeiroEF.Models;

namespace PrimeiroEF.Dados
{

    /// <summary>
    /// Construtor (Materializa a classe em Objeto) - Passa o argumento DBContextOptions(Insert,Update,Delete,Select) tipando (***se auto transformando em um contexto***: base(classe Pai)
    /// </summary>
    public class ClienteContexto : DbContext
    {
        public ClienteContexto(DbContextOptions<ClienteContexto> options) : base(options)
        {

        }
        
        /// <summary>
        /// Setar os dados do tipo Cliente no DB Virtual
        /// </summary>        
        public DbSet<Cliente> ClienteBase { get; set; }

    }
}
