using Business.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); 
            // eğer bir sınıf başka bir sınıfı kullanırken (veri erişim sınıfı, iş sınıfı için geçerli)
            // new kullanıyorsa ileriye dönük sıkıntı yaşanacaktır.
            // uygulama direnç gösterecektir.
            // PttManager class'ı PersonManager' a bağlı kalacaktır.
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi...");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ!!!!");
            }
        }
    }
}
