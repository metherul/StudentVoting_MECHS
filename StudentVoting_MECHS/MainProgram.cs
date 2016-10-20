using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentVoting_MECHS
{
    internal class MainProgram
    {
        private static void Main(string[] args)
        {
            //using (IDocumentStore store = new DocumentStore
            //{
            //    Url = "http://localhost:8080/", // server URL
            //    DefaultDatabase = "Candidates"   // default database
            //})
            //{
            //    store.Initialize(); // initializes document store, by connecting to server and downloading various configurations

            //    using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'DefaultDatabase'
            //    {
            //        Student student = new Student("Ethan Green", "866980", false);

            //        session.Store(student); // stores employee in session, assigning it to a collection `Employees`
            //        string employeeId = student.ID; // Session.Store will assign Id to employee, if it is not set

            //        session.SaveChanges(); // sends all changes to server

            //        IList<Student> results = session.Query<Student>().ToList();

            //        foreach (var item in results)
            //            Console.WriteLine(item.Name.ToString());
            //    }
            //}

            Database database = new Database();
            database.Initialize("Candidates");
        }
    }
}