using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_folder
{
    public class Member
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Gender{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string PhoneNumber{get;set;}
        public string BirthPlace{get; set;}
        public int Age{get; set;}
        public Boolean IsGraduated{get; set;}
        public string FullName{get; set;}
    
        public Member() { }
        public Member(
            string FirstName,
            string LastName,
            string Gender,
            DateTime DateOfBirth,
            string PhoneNumber,
            string BirthPlace,
            int Age,
            bool IsGraduated
            )
            
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.BirthPlace = BirthPlace;
            this.Age = Age;
            this.IsGraduated = IsGraduated;
        }    
    }
}