namespace ShimandFackes
    {
    public class StudentRepo
        {
        public bool SaveStudent (Student std)
            {
            return false;
            }
        public bool EditStudent (Student std)
            {
            return false;
            }
        public class DbService
            {
            private readonly StudentRepo studentRepo;

            public DbService (StudentRepo studentRepo)
                {
                this.studentRepo = studentRepo;
                }
            public bool SaveStudentTodb (Student std)
                {
                if (studentRepo.SaveStudent (std))
                    {
                    return true;
                    }
                else
                    {
                    return true;
                    }
                }
            }
        }

    public class Student
        {
        public int id
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }
        public string Age
            {
            get; set;
            }
        }
    }
