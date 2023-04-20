using DemoLibrary.Models;

namespace DemoLibrary.DataAcess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}