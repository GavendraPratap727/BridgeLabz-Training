using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class Learner
    {
        public string FullName { get; set; }
        private List<Subject> subjectList = new List<Subject>();
        public Learner(string nameInput)
        {
            FullName = nameInput;
        }
        public void RegisterSubject(Subject sub)
        {
            if (!subjectList.Contains(sub))
            {
                subjectList.Add(sub);
                sub.AddLearner(this);
                Console.WriteLine(FullName + " registered for " + sub.SubjectTitle);
            }
        }
        public void ViewSubjects()
        {
            Console.WriteLine("Subjects registered by " + FullName);
            foreach (Subject s in subjectList)
            {
                Console.WriteLine("- " + s.SubjectTitle);
            }
            Console.WriteLine();
        }
    }

    class Instructor
    {
        public string InstructorName { get; set; }
        public Instructor(string nameInput)
        {
            InstructorName = nameInput;
        }
        public void ShowInstructor()
        {
            Console.WriteLine("Instructor: " + InstructorName);
        }
    }

    class Subject
    {
        public string SubjectTitle { get; set; }
        private List<Learner> learnerList = new List<Learner>();
        private Instructor assignedInstructor;
        public Subject(string subjectInput)
        {
            SubjectTitle = subjectInput;
        }
        public void AddLearner(Learner lrn)
        {
            if (!learnerList.Contains(lrn))
            {
                learnerList.Add(lrn);
            }
        }
        public void AllocateInstructor(Instructor inst)
        {
            assignedInstructor = inst;
            Console.WriteLine(inst.InstructorName + " assigned to " + SubjectTitle);
        }
        public void ShowSubjectDetails()
        {
            Console.WriteLine("Subject: " + SubjectTitle);
            if (assignedInstructor != null)
                Console.WriteLine("Instructor: " + assignedInstructor.InstructorName);
            Console.WriteLine("Learners:");
            foreach (Learner l in learnerList)
            {
                Console.WriteLine(l.FullName);
            }
            Console.WriteLine();
        }
    }

    class Campus
    {
        public string CampusName { get; set; }
        private List<Learner> learnerData = new List<Learner>();
        private List<Instructor> instructorData = new List<Instructor>();
        private List<Subject> subjectData = new List<Subject>();
        public Campus(string campusInput)
        {
            CampusName = campusInput;
        }
        public void AddLearner(Learner l) => learnerData.Add(l);
        public void AddInstructor(Instructor i) => instructorData.Add(i);
        public void AddSubject(Subject s) => subjectData.Add(s);
        public void ShowCampusDetails()
        {
            Console.WriteLine("University: " + CampusName);
            Console.WriteLine("Learners:");
            foreach (Learner l in learnerData)
                Console.WriteLine(l.FullName);
            Console.WriteLine("Instructors:");
            foreach (Instructor i in instructorData)
                Console.WriteLine(i.InstructorName);
            Console.WriteLine("Subjects:");
            foreach (Subject s in subjectData)
                Console.WriteLine(s.SubjectTitle);
            Console.WriteLine();
        }
    }

    class University
    {
        public static void Main(string[] args)
        {
            Campus campus = new Campus("GLA University");
            Learner l1 = new Learner("gavendra");
            Learner l2 = new Learner("gitika");
            Instructor i1 = new Instructor("Shail Kumar");
            Instructor i2 = new Instructor("Chirag Patil");
            Subject s1 = new Subject("Science");
            Subject s2 = new Subject("Electronics");
            campus.AddLearner(l1);
            campus.AddLearner(l2);
            campus.AddInstructor(i1);
            campus.AddInstructor(i2);
            campus.AddSubject(s1);
            campus.AddSubject(s2);
            campus.ShowCampusDetails();
            l1.RegisterSubject(s1);
            l2.RegisterSubject(s1);
            l2.RegisterSubject(s2);
            s1.AllocateInstructor(i1);
            s2.AllocateInstructor(i2);
            Console.WriteLine();
            l1.ViewSubjects();
            l2.ViewSubjects();
            s1.ShowSubjectDetails();
            s2.ShowSubjectDetails();
        }
    }
}
