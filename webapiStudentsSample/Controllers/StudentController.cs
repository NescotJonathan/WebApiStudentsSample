using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiStudentsSample.Models;

namespace WebApiStudentsSample.Controllers
{
    public class StudentController : ApiController
    {
        IList<Students> Students = new List<Students>() /* list of all students edit the URL as https://localhost:44329/api/student
                                                         * To fetch the details of a single student, Edit the URL as: https://localhost:44329/api/student/2 */
        {
            new Students()
                {
                    StudentId = 1, StudentName = "Mukesh Kumar", Address = "New Delhi", Course = "IT"
                },
                new Students()
                {
                    StudentId = 2, StudentName = "Banky Chamber", Address = "London", Course = "HR"
                },
                new Students()
                {
                    StudentId = 3, StudentName = "Rahul Rathor", Address = "Laxmi Nagar", Course = "IT"
                },
                new Students()
                {
                    StudentId = 4, StudentName = "YaduVeer Singh", Address = "Goa", Course = "Sales"
                },
                new Students()
                {
                    StudentId = 5, StudentName = "Manish Sharma", Address = "New Delhi", Course = "HR"
                },
        };
        public IList<Students> GetAllStudents()
        {
            //Return list of all employees    
            return Students;
        }
        public Students GetStudentDetails(int id)
        {
            //Return a single employee detail    
            var Student = Students.FirstOrDefault(e => e.StudentId == id);
            if (Student == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Student;
        }
    }
}