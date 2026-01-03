using _43_Demo_Connected_ADO.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Demo_Connected_ADO.DAL
{
    internal class IetDbContext
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True";
        internal int addEmployee(Emp? emp)
        {
            SqlConnection conn = new SqlConnection(connectionString);



            string insertQuery = $"INSERT INTO Emp(name,address) values('{emp.name}','{emp.address}')";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText=insertQuery;
            cmd.Connection= conn;
            conn.Open();

           int records =  cmd.ExecuteNonQuery();
            conn.Close();
            return records;

        }

        internal int deleteEmployee(int eid)
        {
            SqlConnection conn = new SqlConnection(connectionString);



            string deleteQuery = $"DELETE FROM EMP WHERE ID={eid}";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText=deleteQuery;
            cmd.Connection= conn;
            conn.Open();

            int records = cmd.ExecuteNonQuery();
            conn.Close();
            return records;
        }

        internal Emp getEmpByID(int id)
        {
            Emp emp= new Emp();

            SqlConnection conn = new SqlConnection(connectionString);

            string selectQuery = $"SELECT * FROM Emp WHERE ID={id}";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText=selectQuery;
            cmd.Connection= conn;
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int eid = Convert.ToInt32(reader[0]);
                string name = reader[1].ToString();
                string address = reader[2].ToString();
                emp.eid=eid;
                emp.name=name;
                emp.address=address;
            }
            conn.Close();
            return emp;
        }

        internal List<Emp> readAllEmployees()
        {
            List<Emp> eList = new List<Emp> ();

            SqlConnection conn = new SqlConnection(connectionString);



            string insertQuery = "SELECT * FROM Emp";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText=insertQuery;
            cmd.Connection= conn;
            conn.Open();

            SqlDataReader reader  = cmd.ExecuteReader();
            while (reader.Read()) 
                {
                  int id = Convert.ToInt32(reader[0]);
                  string name = reader[1].ToString();
                  string address = reader[2].ToString();
                eList.Add(new Emp() {eid=id,name=name,address=address});
            }
            conn.Close();

            return eList;
        }

        internal int updateEmployee(Emp emp)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string updateQuery = $"UPDATE EMP SET name='{emp.name}',address='{emp.address}' where id={emp.eid}";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText=updateQuery;
            cmd.Connection= conn;
            conn.Open();

            int records = cmd.ExecuteNonQuery();
            conn.Close();
            return records;
        }
    }
}
