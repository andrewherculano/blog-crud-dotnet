using Microsoft.Data.SqlClient;

namespace BlogDev
{
    public static class Database
    {
        public static SqlConnection Connection { get; set; }
    }
}