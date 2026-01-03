using _31_demo_BvsAttribute;
using _34_demo_CustomizedAttribute;

namespace _33_Demo_EmpLib
{
    [BoventureSystems(CompanyName = "BVS", DeveloperName = "Renuka")]
    [Serializable]
    [Table(_tableName = "Employee")]
    internal class Emp
    {
        private int id;

        [Column(columnName = "id", columnType = "int")]
        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        [Column(columnName = "name", columnType = "varchar(20)")]
        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        [Column(columnName = "address", columnType = "varchar(20)")]
        public string _address
        {
            get { return address; }
            set { address = value; }
        }
    }

}


