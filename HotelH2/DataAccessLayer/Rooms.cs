using HotelH2.Models;
using System.Data.SqlClient;

namespace HotelH2.DataAccessLayer
{
    public class RoomsDB
    {
        string connectionString = "Data Source=LAPTOP-ILT5P16T\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection DBConnection;


        public RoomsDB()
        {
            DBConnection = new(connectionString);
        }


        public List<Room> getRooms()
        {
            List<Room> rooms = new();

            using (DBConnection)
            {
                DBConnection.Open();

                try
                {
                    using SqlCommand sqlCommand = new("SELECT * FROM HotelH2.dbo.rooms", DBConnection);


                    using SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    {
                        while (sqlReader.Read())
                        {
                            Room temp = new()
                            {
                                id = (int)sqlReader[0],
                                roomType = (String)sqlReader[1],
                                roomNum = (int)sqlReader[2],
                                price = (int)sqlReader[3],
                                beds = (int)sqlReader[4],
                                isOccupied = (bool)sqlReader[5]
                            };

                            rooms.Add(temp);
                        }
                    }
                } catch (SqlException ) { }

                DBConnection.Close();
            }

            return rooms;
        }


    }
}
