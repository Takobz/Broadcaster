namespace Broadcaster.Models
{
    public class TableNotify
    {
        private string _tableName = default!;
        public string TableName
        {
            get => _tableName;
            set => _tableName = value ?? throw new ArgumentNullException("Table name is required");
        }
    }
}