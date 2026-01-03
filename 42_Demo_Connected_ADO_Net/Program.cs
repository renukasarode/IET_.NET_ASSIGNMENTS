using Microsoft.Data.SqlClient;

namespace _42_Demo_Connected_ADO_Net
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //"Data Source=(LocalDB)\\MSSQLLocalDB,Initial Catalog=IETDb Integrated Security=true";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";

            string connectionString = connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            #region select Query
            // string selectQuery = "SELECT * FROM EMPLOYEE";
            // SqlCommand cmd = new SqlCommand();

            // cmd.CommandType = System.Data.CommandType.Text;
            // cmd.CommandText = selectQuery;
            // cmd.Connection  = conn;

            // conn.Open();
            //SqlDataReader reader =  cmd.ExecuteReader();
            // while(reader.Read()) 
            //     {
            //     int id = Convert.ToInt32(reader[0]);
            //     string? name = reader[1].ToString();
            //     string? address = reader[2].ToString();
            //     Console.WriteLine($"id:{id} name:{name} address:{address}");
            //     }
            // conn.Close();

            #endregion

            #region Insert Query
            // Console.WriteLine("Enter the name of emp");
            // string Name = Console.ReadLine();

            // Console.WriteLine("Enter the Address of emp");
            // string Add = Console.ReadLine();

            // string InsertQuery = $"INSERT INTO Employee(Name,Address) values ('{Name}','{Add}')";

            // SqlCommand cmd1 = new SqlCommand();
            // cmd1.CommandType = System.Data.CommandType.Text;
            // cmd1.CommandText=InsertQuery;
            // cmd1.Connection=conn;

            // conn.Open();
            //int NoRowsAffected =  cmd1.ExecuteNonQuery();
            // if(NoRowsAffected > 0 ) 
            //     {
            //     Console.WriteLine("data added successfully");
            //     }
            // else
            // {
            //     Console.WriteLine("not added");
            // }

            //     conn.Close();

            #endregion

            #region  UpdateQuery
            //Console.WriteLine("Enter the id of the employee you want to update");
            //int eid = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter new name employee");
            //string updatedName = Console.ReadLine();

            //Console.WriteLine("Enter new name employee ");
            //string updatedAdd = Console.ReadLine();


            //string updateQuery = $"UPDATE Employee SET Name='{updatedName}',Address='{updatedAdd}' WHERE Id ={eid}";


            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.CommandType = System.Data.CommandType.Text;
            //cmd2.CommandText=updateQuery;
            //cmd2.Connection=conn;

            //conn.Open();
            //int NoRowsUpdated = cmd2.ExecuteNonQuery();
            //if (NoRowsUpdated > 0)
            //{
            //    Console.WriteLine("data updated successfully");
            //}
            //else
            //{
            //    Console.WriteLine("not updated");
            //}

            //conn.Close();
            #endregion

            #region  deleteQuery
            Console.WriteLine("Enter the id of the employee you want to delete");
            int eid = Convert.ToInt32(Console.ReadLine());

            string deleteQuery = $"DELETE FROM Employee WHERE Id ={eid}";


            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText=deleteQuery;
            cmd2.Connection=conn;

            conn.Open();
            int NoRowsDeleted = cmd2.ExecuteNonQuery();
            if (NoRowsDeleted > 0)
            {
                Console.WriteLine("data deleted successfully");
            }
            else
            {
                Console.WriteLine("not deleted");
            }

            conn.Close();

            #endregion
        }
    }
}
