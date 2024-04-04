namespace Data.Helpers
{
    public class SqlConn
    {
        public SqlConn(string dataSource, string catalog, string userId)
        {
            DataSource = dataSource;
            Catalog = catalog;
            UserId = userId;
        }

        public string DataSource { get; set; }
        public string Catalog { get; set; }
        public string UserId { get; set; }
        public string PassWord { get; set; }

        public override string ToString()
        {
            return string.Format("Data Source={0}; user id={1}; initial catalog={2};", DataSource, UserId, Catalog);
        }
    }
}
