using Subrat.Models ;

namespace Subrat.DataAccessLayer
{
    public class Details
    {
        SchoolContext Context = new SchoolContext();

        public List<StudentDetail>   getAllStudentDetails()
        {
           var Details = Context.StudentDetails.ToList();
            return Details ;
        }

        public void AddStudentDetails(StudentDetail studentDetail)
        {
            var detail = Context.StudentDetails.Add(studentDetail);
                Context.SaveChanges();
            
        }

        public List<Marksheet> getAllMarkSheet()
        {
            var mark = Context.Marksheets.ToList();
            return mark;
        }

        public void AddMarkSheet(Marksheet marksheet)
        {
            var detail = Context.Marksheets.Add(marksheet);
            Context.SaveChanges();
        }

        public List<Marksheet> PassStudent()
        {
            var Passed = getAllMarkSheet().
                Where
                (
                a => 
                (a.Subject1 + a.Subject2 + a.Subject3 + a.Subject4 + a.Subject5) >= 300
                ).ToList();
            return Passed;
        }

    }
}
