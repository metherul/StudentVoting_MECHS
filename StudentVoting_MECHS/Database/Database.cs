using Raven.Client;
using Raven.Client.Document;
using System;

namespace StudentVoting_MECHS
{
    internal class Database
    {
        public IDocumentStore documentStore;
        public IDocumentSession documentSession;

        public string databaseURL = "http://localhost:8080/";
        public string defaultDatabase;

        public void Initialize(string _defaultDatabase)
        {
            defaultDatabase = _defaultDatabase;

            documentStore = new DocumentStore
            {
                Url = databaseURL,
                DefaultDatabase = defaultDatabase
            };

            documentStore.Initialize();
        }

        public bool DoesUserExist()
        {


            return false;
        }
    }
}