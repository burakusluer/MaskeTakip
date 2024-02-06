using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IApplicantService
{
    /// <summary>
    /// Checks the person is get a mask before then return a code if not
    /// </summary>
    /// <param name="person"></param>
    void ApplyForMask(Person person);
    /// <summary>
    /// gets the list of Person
    /// </summary>
    /// <returns>Person List</returns>
    List<Person> GetList();
    /// <summary>
    /// Checks the Person through mernis API
    /// </summary>
    /// <returns></returns>
    bool CheckPerson(Person person);
}
