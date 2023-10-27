using SqlViewer.Models;
using System.Data;

namespace SqlViewer.Dal
{
    internal interface IRepository
    {
        DataSet CreateDataSet(DBEntity dbEntity);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        DataSet MakeQuery(String query);
        void LogIn(string server, string username, string password);
    }
}