using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker
{
    public enum DataType
    {
        dec,
        integer,
        datetime,
        primarykey,
        varchar
    }
    public class DbColumn : GlobalEventHandler
    {
        public DbColumn(string columnName, DataType dataType, int? length, int? precision, int? scale, bool canBeNull)
        {
            ColumnName = columnName;
            DataType = dataType;
            Length = length;
            Precision = precision;
            Scale = scale;
            CanBeNull = canBeNull;
        }
        public string ColumnName { get; set; }

        public DataType DataType { get; set; }

        public int? Length { get; set; }

        public int? Precision { get; set; }

        public int? Scale { get; set; }

        public bool CanBeNull
        {
            get
            {
                return true;
            }
            set
            {
                RaisePropertyChanged(nameof(NullStatus));
            }
        }
        private string _NullStatus { get; set; }

        public string NullStatus
        {
            get
            {
                if (CanBeNull)
                {
                    _NullStatus = "NULL";
                }
                else
                    _NullStatus = "NOT NULL";

                return _NullStatus;
            }
            set
            {
                if (_NullStatus == value)
                    return;

                _NullStatus = value;
                RaisePropertyChanged(_NullStatus);
            }
        }
    }

    public class SQLWorker
    {
        private string _ConnectionString = "Data Source=PTracker.sqlite;Version=3";
        private SQLiteConnection sqliteConnection;

        public SQLWorker()
        {

        }

        public string CreateTable(string name, List<DbColumn> columns)
        {
            StringBuilder sqlText = new StringBuilder("CREATE TABLE ");
            sqlText.AppendFormat(name);
            sqlText.AppendFormat(" (");

            int c = 0;
            foreach (var column in columns)
            {
                if (c > 0)
                    sqlText.AppendFormat(", ");

                switch (column.DataType)
                {
                    case DataType.primarykey:
                        sqlText.AppendFormat(column.ColumnName);
                        sqlText.AppendFormat(" integer primary key autoincrement");
                        c++;
                        continue;

                    case DataType.integer:
                        sqlText.AppendFormat(column.ColumnName);
                        sqlText.AppendFormat(" int ");
                        sqlText.AppendFormat(column.NullStatus);
                        c++;
                        continue;

                    case DataType.datetime:
                        sqlText.AppendFormat(column.ColumnName);
                        sqlText.AppendFormat(" date ");
                        sqlText.AppendFormat(column.NullStatus);
                        c++;
                        continue;

                    case DataType.dec:
                        sqlText.AppendFormat(column.ColumnName);
                        sqlText.AppendFormat(" decimal(");
                        sqlText.AppendFormat(column.Precision.Value.ToString());
                        sqlText.AppendFormat(",");
                        sqlText.AppendFormat(column.Scale.Value.ToString());
                        sqlText.AppendFormat(") ");
                        sqlText.AppendFormat(column.NullStatus);
                        c++;
                        continue;

                    case DataType.varchar:
                        sqlText.AppendFormat(column.ColumnName);
                        sqlText.AppendFormat(" varchar(");
                        sqlText.AppendFormat(column.Length.Value.ToString());
                        sqlText.AppendFormat(") ");
                        sqlText.AppendFormat(column.NullStatus);
                        c++;
                        continue;
                }
            }
            sqlText.AppendFormat(");");
            return sqlText.ToString();
        }

        public void CreateProductTable()
        {
            try
            {
                List<DbColumn> columns = new List<DbColumn>();
                columns.Add(new DbColumn("ProductId", DataType.primarykey, null, null, null, false));
                columns.Add(new DbColumn("EntryDate", DataType.datetime, null, null, null, true));
                columns.Add(new DbColumn("ProductName", DataType.varchar, 100, null, null, true));
                columns.Add(new DbColumn("Keyword", DataType.varchar, 50, null, null, true));
                columns.Add(new DbColumn("Category", DataType.varchar, 30, null, null, true));
                columns.Add(new DbColumn("Rank", DataType.integer, null, null, null, true));
                columns.Add(new DbColumn("ReviewCount", DataType.dec, null, 2, 18, true));
                columns.Add(new DbColumn("Description", DataType.varchar, 255, null, null, true));
                columns.Add(new DbColumn("Portal", DataType.varchar, 50, null, null, true));

                SQLiteCommand sqliteCommand = new SQLiteCommand(CreateTable("PRODUCT", columns), sqliteConnection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }

        public void CreateProductHistoryTable()
        {
            try
            {
                List<DbColumn> columns = new List<DbColumn>();
                columns.Add(new DbColumn("ProductHistoryId", DataType.primarykey, null, null, null, false));
                columns.Add(new DbColumn("ProductId", DataType.integer, null, null, null, false));
                columns.Add(new DbColumn("Portal", DataType.varchar, 50, null, null, true));
                columns.Add(new DbColumn("ProductName", DataType.varchar, 100, null, null, true));
                columns.Add(new DbColumn("DateModified", DataType.datetime, null, null, null, true));
                columns.Add(new DbColumn("Keyword", DataType.varchar, 50, null, null, true));
                columns.Add(new DbColumn("Rank", DataType.integer, null, null, null, true));
                columns.Add(new DbColumn("Review", DataType.varchar, 256, null, null, true));
                columns.Add(new DbColumn("Note", DataType.varchar, 256, null, null, true));

                SQLiteCommand sqliteCommand = new SQLiteCommand(CreateTable("PRODUCTHISTORY", columns), sqliteConnection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                
            }
        }

        public void CreateKeywordHistoryTable()
        {
            try
            {
                List<DbColumn> columns = new List<DbColumn>();
                columns.Add(new DbColumn("KeywordHistoryId", DataType.primarykey, null, null, null, false));
                columns.Add(new DbColumn("DateModified", DataType.datetime, null, null, null, true));
                columns.Add(new DbColumn("ProductId", DataType.integer, null, null, null, false));
                columns.Add(new DbColumn("Keyword", DataType.varchar, 50, null, null, false));

                SQLiteCommand sqliteCommand = new SQLiteCommand(CreateTable("KEYWORDHISTORY", columns), sqliteConnection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {

            }
        }

        public SQLWorker(SQLiteConnection sqliteConnection)
        {
            this.sqliteConnection = sqliteConnection;
        }

        public void Initialize()
        {
            try
            {
                sqliteConnection = new SQLiteConnection(_ConnectionString);
            }
            catch (Exception e)
            {

            }
        }

        public void Open()
        {
            try
            {
                sqliteConnection.Open();
            }
            catch (Exception e)
            {

            }
        }

        public void Close()
        {
            try
            {
                sqliteConnection.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
