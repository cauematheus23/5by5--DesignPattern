using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarRepository
    {
        string strConn = "Data Source=127.0.0.1; Initial Catalog=Car; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=true;";  
        SqlConnection conn;
        public CarRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public bool Insert(Car car)
        {
            bool result = false;
            try
            {
               
                SqlCommand cmd = new SqlCommand(Car.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;
            }
            finally { conn.Close(); }
            return result;
        }

        public bool Update(Car car)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand(Car.UPDATE, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.Parameters.Add(new SqlParameter("@id", car.Id));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;
            }
            finally { conn.Close(); }
            return result;
        }
        public bool Delete(int id) 
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand(Car.DELETE, conn);
                cmd.Parameters.Add(new SqlParameter("@id",id));
                return (cmd.ExecuteNonQuery() > 0);
                    
                      
            }
            catch (Exception)
            {
                return result;
            }
            finally { conn.Close(); }
            return result;
        }
        public List<Car> GetAll() 
        {  
            List<Car> cars = new List<Car>();
            /*sb.Append("Select Id,");
            sb.Append("      Name,");
            sb.Append("      Color,");
            sb.Append("      Year,");
            sb.Append(" FROM TB_CAR");*/
            try
            {
                SqlCommand cmd = new SqlCommand(Car.GETALL, conn);
                using(SqlDataReader reader = cmd.ExecuteReader()) 
                    while (reader.Read())
                    {
                        Car car = new Car();

                        car.Id = reader.GetInt32(0);
                        car.Name = reader.GetString(1);
                        car.Color = reader.GetString(2);
                        car.Year = reader.GetInt32(3);

                        cars.Add(car);
                    }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return cars;
        }
        public Car Get(int id) 
        {
           
            /*sb.Append("Select Id,");
            sb.Append("      Name,");
            sb.Append("      Color,");
            sb.Append("      Year,");
            sb.Append(" FROM TB_CAR");*/
            Car car = new();
            try
            {
                SqlCommand cmd = new SqlCommand(Car.GET, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        car.Id = reader.GetInt32(0);
                        car.Name = reader.GetString(1);
                        car.Color = reader.GetString(2);
                        car.Year = reader.GetInt32(3);
                    }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return car;
        }
    }
}
