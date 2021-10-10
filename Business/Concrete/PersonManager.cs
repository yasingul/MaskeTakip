using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IApplicantServise

    {
        //Bu bizi koruyacak bir ifadedir. Çıplak class kalmasın.
        public void ApplyForMask(Person person) 
        {
            //Bu kısımda person maskeye başvuru yapanların başvurularını kontrol ettiğimiz yer burası.

        }

        public List<Person> GetList()
        {
            //Person'ların şuana kadar kimlerin başvuruda bulunduğunu buradan kontrol edeceğiz.
            //List dediğimiz yapı içerisinde verdiğimiz (person) tipte bir listedir.
            return null;
        }

        public bool CheckPerson(Person person) 
        {
            //CheckPerson ile kişinin TC vatandaşlığını kontrol edeceğiz. Mernis kontrlü yapılacak.
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentitiy, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

    }  
}

