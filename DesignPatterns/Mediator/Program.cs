using System;
using System.Collections.Generic;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            Teacher omer = new Teacher(mediator);
            omer.Name = "Ömer";

            mediator.Teacher = omer;
            //
            Student ali = new Student(mediator);
            ali.Name = "Ali";

            Student semih = new Student(mediator);
            semih.Name = "Semih";


            mediator.Students = new List<Student> { ali, semih};

            omer.SendNewImageUrl("slide1.jpg");
            omer.ReciveQestion("is it true?", semih);
        }
    }

    abstract class CourseMember
    {
        protected  Mediator Mediator;
        public CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    class Teacher : CourseMember
    {
        public string Name { get;  set; }

        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public void ReciveQestion(string question, Student student)
        {
            Console.WriteLine("Teacher recieved a question from {0}, {1}",student.Name , question);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide : {0}", url);
            Mediator.UpdateImage(url);
        }
        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Teacher answered question {0}{1} ", student.Name, answer);
        }
    }
    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get; internal set; }

        public void ReciveImage(string url)
        {
            Console.WriteLine("{1} Student recieved image : {0}", url, Name);
        }

        internal void ReciveAnswer(string answer)
        {
            Console.WriteLine("{1}  Stundet recived answer {0}", answer, Name);
        }
    }
    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public void UpdateImage (string url)
        {
            foreach (var student in Students)
            {
                student.ReciveImage(url);
            }
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher.ReciveQestion(question, student);
        }

        public void Sendanswer(string answer, Student student)
        {
            student .ReciveAnswer(answer);
        }
    }
}
