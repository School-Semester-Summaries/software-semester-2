using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlankoMundo.Models
{
    public class DatabaseController
    {
        string connectionString = @"server=127.0.0.1; user id=root; password=''; database=cgict";

        public List<ReservationType> GetAllMeetingRoomsSexy()
        {
            List<ReservationType> meetingRoomList = new List<ReservationType>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM WorkRoom", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MeetingRoom meetingRoom = new MeetingRoom();

                    meetingRoom.RoomID = reader.GetInt32(0); 
                    meetingRoom.UserID = reader.GetInt32(1); 
                    meetingRoom.Available = reader.GetInt32(2);
                    meetingRoom.Monitors = reader.GetInt32(3);
                    meetingRoom.Seats = reader.GetInt32(4);
                    meetingRoom.Floor = reader.GetInt32(5);
                    meetingRoom.Name = reader.GetString(6);

                    meetingRoomList.Add(meetingRoom);
                }
                return meetingRoomList;
            }
        }

        public List<ReservationType> GetAllWorkSpacesSexy()
        {
            List<ReservationType> workSpaceList = new List<ReservationType>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM workSpace", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    WorkSpace workSpace = new WorkSpace();

                    workSpace.SpotID = reader.GetInt32(0);
                    workSpace.UserID = reader.GetInt32(1);
                    workSpace.WorkroomID= reader.GetInt32(2);
                    workSpace.Floor = reader.GetInt32(3);
                    workSpace.Name = reader.GetString(4);

                    workSpaceList.Add(workSpace);
                }
                    return workSpaceList;
            }
        }
    }
}
