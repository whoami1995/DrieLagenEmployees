using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrieLagenEmployeesBusiness
{
    public static class EmployeeDB
    {
        private static SqlConnection connection = null;
        private static SqlCommand command = null;
        private static SqlDataReader reader = null;
        private static SqlTransaction transaction = null;
        public static void InsertEmployee(Employee emp)
        {
            try
            {  
                connection = DBConnection.GetDBConnection();
                connection.Open();
                transaction = connection.BeginTransaction("InsertTransaction");
                command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "INSERT employees(emp_no,birth_date,first_name,last_name,gender,hire_date) VALUES(@emp_no,@birth_date,@first_name,@last_name,@gender,@hire_date)";
                command.Parameters.AddWithValue("@emp_no", emp.emp_no);
                command.Parameters.AddWithValue("@birth_date", emp.birth_date);
                command.Parameters.AddWithValue("@first_name", emp.first_name);
                command.Parameters.AddWithValue("@last_name", emp.last_name);
                command.Parameters.AddWithValue("@gender", emp.gender);
                command.Parameters.AddWithValue("@hire_date", emp.hire_date);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                    throw ex;
                }
                catch(Exception ex2)
                {
                    // Vangt overige exceptions op
                    throw ex2;
                }
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            try
            {
                command = new SqlCommand();
                command.CommandText = "SELECT * FROM Employees";
                connection = DBConnection.GetDBConnection();
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Employee emp = new Employee();
                    emp.emp_no = int.Parse(reader[0].ToString());
                    emp.birth_date = DateTime.Parse(reader[1].ToString());
                    emp.first_name = reader["first_name"].ToString();
                    emp.last_name = reader[3].ToString();
                    emp.gender = reader["gender"].ToString();
                    emp.hire_date = DateTime.Parse(reader["hire_date"].ToString());
                    employeeList.Add(emp);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if(reader != null)
                {
                   reader.Close();
                }
                if(connection != null)
                {
                   connection.Close();
                }
            }     
            return employeeList;
        }

        public static int GetNextID()
        {
            int number;
            try
            {
                connection = DBConnection.GetDBConnection();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(emp_no) FROM employees";
                number = (int)command.ExecuteScalar()+1;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if(connection != null)
                {
                   connection.Close();
                }
                if(command != null)
                {
                    command = null;
                }
            }
            return number;
        }

        public static void UpdateEmployee(Employee emp)
        {
            try
            {
                connection = DBConnection.GetDBConnection();
                connection.Open();
                transaction = connection.BeginTransaction("UpdateEmployee");
                command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "UPDATE employees SET " +
                    "birth_date = @birth_date,"+
                    "first_name = @first_name,"+
                    "last_name = @last_name,"+
                    "gender = @gender,"+
                    "hire_date = @hire_date WHERE emp_no = @emp_no";
                command.Parameters.AddWithValue("@emp_no", emp.emp_no);
                command.Parameters.AddWithValue("@birth_date", emp.birth_date);
                command.Parameters.AddWithValue("@first_name", emp.first_name);
                command.Parameters.AddWithValue("@last_name", emp.last_name);
                command.Parameters.AddWithValue("@gender", emp.gender);
                command.Parameters.AddWithValue("@hire_date", emp.hire_date);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    Console.WriteLine(ex.StackTrace);
                    transaction.Rollback();
                    throw ex;
                }
                catch(Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }

            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static void DeleteEmployee(Employee emp)
        {
            try
            {
                connection = DBConnection.GetDBConnection();
                connection.Open();
                transaction = connection.BeginTransaction("DeleteEmployee");
                command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM employees WHERE emp_no = @emp_no";
                command.Parameters.AddWithValue("@emp_no", emp.emp_no);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch(SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                    throw ex;
                }
                catch(Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                
            }
            finally
            {
                if(connection != null)
                {
                   connection.Close();
                }
            }
            
        }

       



    }
}
