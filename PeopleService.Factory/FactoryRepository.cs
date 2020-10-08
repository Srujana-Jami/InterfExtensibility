using PeopleService.SQL;
using PersonRepository.Service;
using PersonRepositoty.Interface;
using System;
using System.Collections.Generic;

namespace PeopleService.Factory
{
    public static class FactoryRepository
    {
        
        public static IPersonReader GetRepository(string repositoryType)
        {
            IPersonReader personRepository;

            switch (repositoryType)
            {
                case "Service":
                    personRepository = new ServiceRepository();
                    break;
                case "CSV":
                    personRepository = new CsvRepository();
                    break;
                case "SQL":
                    personRepository = new SQLRepository();
                    break;
                default:
                    throw new ArgumentException("Argument not valid");
            }

            return personRepository;
        }
    }
}

namespace PeopleService.Factory
{
    class CsvRepository : IPersonReader
    {
        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}