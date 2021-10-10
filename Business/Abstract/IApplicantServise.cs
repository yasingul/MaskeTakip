using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantServise
    {
        //İş sınıflarının interfacelerini bu şekilde yazarız. Buna metodun imzası denir.
        void ApplyForMask(Person person);

        List<Person> GetList();

        public bool CheckPerson(Person person);

    }
}
