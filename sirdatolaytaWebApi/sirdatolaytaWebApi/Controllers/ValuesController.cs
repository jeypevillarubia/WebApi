using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Data;
using sirdatolaytaWebApi.Models;
namespace sirdatolaytaWebApi.Controllers
{

    public class ValuesController : ApiController
    {
     
       
        // GET api/values 
        private MySqlConnection con;
        private MySqlDataAdapter adpt;
        public IEnumerable<student> Get()
        {

            con = new MySqlConnection(" data source = localhost; initial catalog =practice311; userid = root; password ='' ");
            DataTable tbl = new DataTable();
            var query = "SELECT * FROM `studentinfo`";
            adpt = new MySqlDataAdapter
            {
                SelectCommand = new MySqlCommand(query, con)
            };
            adpt.Fill(tbl);
            List<student> students = new List<Models.student>(tbl.Rows.Count);
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow Srecord in tbl.Rows)
                {
                    students.Add(new readData(Srecord));
                }

            }
            return students;
        }

        // GET api/values/5
        public IEnumerable<student> Get(int id)
        {
            con = new MySqlConnection(" data source = localhost; initial catalog =practice311; userid = root; password ='' ");
            DataTable tbl = new DataTable();
            var query = "SELECT * FROM `studentinfo` WHERE id =" + id;
            adpt = new MySqlDataAdapter
            {
                SelectCommand = new MySqlCommand(query, con)
            };
            adpt.Fill(tbl);
            List<student> students = new List<Models.student>(tbl.Rows.Count);
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow Srecord in tbl.Rows)
                {
                    students.Add(new readData(Srecord));
                }

            }
            return students;
          
        }

        // POST api/values
        public string Post([FromBody]createstudent value)
        {
            student grdeclc = new student();
           
             con = new MySqlConnection(" data source = localhost; initial catalog =practice311; userid = root; password ='' ");
             var query = "INSERT INTO `studentinfo`(`ID`, `fn`, `ln`, `course`) VALUES (@ID, @fn, @ln, @course)";
             MySqlCommand  com = new MySqlCommand(query,con );
             com.Parameters.AddWithValue("ID",value.ID);
             com.Parameters.AddWithValue("fn",value.fn);
             com.Parameters.AddWithValue("ln",value.ln);
             com.Parameters.AddWithValue("course",value.course);
             //com.Parameters.AddWithValue("year",value.yea);
             con.Open();
             int result = com.ExecuteNonQuery();
             if (result > 0)
             {
                 return "Inserted";
             }
             else
             {
                 return "failed to insert";
             }
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]createstudent value)
        {
            
            con = new MySqlConnection(" data source = localhost; initial catalog =practice311; userid = root; password ='' ");
            var query = "UPDATE studentinfo SET  `fn`=@fn, `ln`=@ln, `course`=@course WHERE ID=" + id;
            MySqlCommand com = new MySqlCommand(query, con);
           
            com.Parameters.AddWithValue("fn", value.fn);
            com.Parameters.AddWithValue("ln", value.ln);
            com.Parameters.AddWithValue("course", value.course);
         
            con.Open();
            int result = com.ExecuteNonQuery();
            if (result > 0)
            {
                return "updated";
            }
            else
            {
                return "failed to update";
            }
           
        }

        // DELETE api/values/5
        public string Delete(int id)
            
        {
            con = new MySqlConnection(" data source = localhost; initial catalog =practice311; userid = root; password ='' ");
            var query = "DELETE FROM `studentinfo` WHERE ID =" + id;
            MySqlCommand com = new MySqlCommand(query, con);
            //com.Parameters.AddWithValue("ID", value.ID);
           // com.Parameters.AddWithValue("fn", value.fn);
            //com.Parameters.AddWithValue("ln", value.ln);
            //com.Parameters.AddWithValue("course", value.course);
            //com.Parameters.AddWithValue("year",value.yea);
            con.Open();
            int result = com.ExecuteNonQuery();
            if (result > 0)
            {
                return "deleted";
            }
            else
            {
                return "failed to delete";
            }
        }
    }
}
