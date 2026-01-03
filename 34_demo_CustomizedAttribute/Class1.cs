namespace _34_demo_CustomizedAttribute
{
	[AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute:Attribute
    {

		private string Table_name;

		public string _tableName
		{
			get { return Table_name; }
			set { Table_name = value; }
		}

	}

	[AttributeUsage (AttributeTargets.Property)]
	public class ColumnAttribute:Attribute
	{
		private string _columnName;

		public string columnName
        {
			get { return _columnName; }
			set { _columnName = value; }
		}

		private string _columnType;

        public string columnType
        {
            get { return _columnType; }
            set { _columnType = value; }
        }

    }
}
