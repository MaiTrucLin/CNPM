using System.Data.SqlClient;

namespace XDPMQL_CuahangPKGaming.Database
{
    internal class BuildComand
    {
        private SqlParameter[] parameters;
        private string procedureName;

        public BuildComand(string procedureName, SqlParameter[] parameters)
        {
            this.procedureName = procedureName;
            this.parameters = parameters;
        }

        public object Parameters { get; internal set; }
    }
}