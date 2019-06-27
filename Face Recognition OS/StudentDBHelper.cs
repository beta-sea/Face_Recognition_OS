using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    class StudentDBHelper
    {
        public static int AddStudentEntity(Student student)
        {
            string sql = @"INSERT INTO Student VALUES (?ID,?Name,?Class,?Image,?face_token)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("?ID",student.ID),
                new MySqlParameter("?Name", student.Name),
                new MySqlParameter("?Class", student.Class),
                new MySqlParameter("?Image", student.Image),
                new MySqlParameter("?face_token", student.face_token)
            };

            MysqlHelper dbHelper = new MysqlHelper();
            return dbHelper.getMySqlCom(sql,parameters);
        }

        public static int AddStudentRecode(Recode recode)
        {
            string sql = @"INSERT INTO Recode (date,uid) VALUES (?date,?uid)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("?date",recode.date),
                new MySqlParameter("?uid",recode.uid)
            };

            MysqlHelper dbHelper = new MysqlHelper();
            return dbHelper.getMySqlCom(sql, parameters);
        }

        public static Student FindStudentByFace(string face_token)
        {
            string sql = @"select * from Student where face_token = ?token";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("?token",face_token),
            };
            MysqlHelper dbHelper = new MysqlHelper();
            DataTable dt = dbHelper.getMySqlRead(sql, parameters);
            Student student = DataTableToModel<Student>.ConvertToModel(dt)[0];
            return student;
        }
    }
}

