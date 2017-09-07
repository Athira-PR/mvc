using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("new_connection")
        {
            
        }

       public  DbSet<Student> Students { get; set; }
    }
    
}