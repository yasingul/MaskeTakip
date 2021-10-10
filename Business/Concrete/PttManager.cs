using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager:ISuplierService
    {
        private IApplicantServise _applicantService;
        //Burada PttManager başka bir class'a ihtiyaç duyuyor. Bu class'ı new'lemek yerine onun Interface'ini bu classın başlangıcında yazarız.
        //diğer kod bloklarında da ulaşalım diye bunu global yere yazarız.

        public PttManager(IApplicantServise applicantService) //Constrctor new yapıldığında çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person) 
        {
            if (_applicantService.CheckPerson(person))
            {
               
                Console.WriteLine(person.FirstName + "için maske verildi!");
                //burada eğer vatandaş doğru bir vatandaş ise bu kişiye maske ver demektir.
                //bir sınıfı direkt new ile kullanıyorsak bu kod bağımıdır ve temiz yazılmamış demektir.
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi!");
            }
        }
    }
}
