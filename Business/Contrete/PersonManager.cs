using Business.Abstract;
using Entities.Concretes;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contrete
{
    public class PersonManager: IApplicantService //iş sınıfı, operasyon tutucu
    {
        public PersonManager()
        { 
            //yapıcı blok
        }

        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) // mernise bağlan ve kişi kontol edilecek
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(person.NationalIdenty, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
