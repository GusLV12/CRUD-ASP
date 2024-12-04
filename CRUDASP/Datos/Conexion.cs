using System.Data.SqlClient;

namespace CRUDASP.Datos
{
    public class Conexion
    {
        private string conexionSQL = string.Empty;

        public Conexion() {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            conexionSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string getCadenaSQL ()
        {
            return conexionSQL;
        }
    }
}
