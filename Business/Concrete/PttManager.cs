using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager
{

    private IApplicantService _appicantService;//Dependency Injection(Person Manager & Foreigner Manager)

    /// <summary>
    ///  DI to instanciate _applicantService 
    /// </summary>
    /// <param name="applicantService">instanciate _applicantService as PM or FM</param>
    public PttManager(IApplicantService applicantService)
    {
        _appicantService = applicantService;
    }

    
    public void GiveMask(Person person)
    {
        
        if (_appicantService.CheckPerson(person))
        {
            Console.WriteLine($"{person.FirstName} için maske verildi");
        }
    }
}