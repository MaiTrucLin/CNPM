using System.Data.SqlClient;

namespace XDPMQL_CuahangPKGaming.Database
{
    internal class BuildCommand
    {
        private SqlParameter[] parameters;
        private string procedureName;

        public BuildCommand(string procedureName, SqlParameter[] parameters)
        {
            this.procedureName = procedureName;
            this.parameters = parameters;
        }

        public object Parameters { get; internal set; }
    }
}