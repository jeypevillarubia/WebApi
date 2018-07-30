using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace sirdatolaytaWebApi.Models
{
    public class student
    {
        public string ID
        { get; set; }
        public string fn
        { get; set; }
        public string ln
        { get; set; }
        public string course
        { get; set; }
     
     //   public string prelim
      //  { get; set; }
     //public double midterm
      //  { get; set; }
        //public double ave
        //{ get; set; }
       
    }
    public class createstudent : student
    {
    }
    public class readData : student
    {
        public readData(DataRow row)
        {
            ID = row["ID"].ToString();
            fn = row["fn"].ToString();
            ln = row["ln"].ToString();
            course = row["course"].ToString();
          //  course = row["prelim"].ToString();
            //course = row["midterm"].ToString();
            //course = row["ave"].ToString();
        }

        public string ID
        { get; set; }
        public string fn
        { get; set; }
        public string ln
        { get; set; }
        public string course
        { get; set; }
        //public double prelim
        //{ get; set; }
        //public double midterm
        //{ get; set; }
        //public double ave
        //{ get; set; }
       
    }
}