using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheFinalProduct_FYP_.db_fypManagement
{
    public class tblStudentScore
    {
        [Key]
        public int SSid { get; set; }
        public string studentFname { get; set; }
        public int studentScore { get; set; }
        public string studentGroup { get; set; }
    }
}