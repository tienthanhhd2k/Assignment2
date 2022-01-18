using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_folder
{
    class Program
    {
        public static IEnumerable<object> members;

        static void Main(string[] args)
        {
            List<Member> IsMember =  SeedingData();
            WhoMale(IsMember);

            //Full names
            var fullnames = GetFullNames();
            foreach(var fullname in fullnames)
            {
                Console.WriteLine(fullname);
            }
            //Chia nam sinh 
            var result = ChiaNamSinh();
            Console.WriteLine(result);

           
        }
        static void WhoMale(List<Member> members)
        {
            foreach (var member in members)
            {
                if(member.Gender == "Male")
                {
                    Console.WriteLine(member.FirstName + member.LastName);
                }
            }
        }
        static void MaxAge(List<Member> members)
        {
            Member oldestage = members[0] ;
            foreach(var member in members)
            {
                  if(oldestage.Age < member.Age)
                  {
                    oldestage = member;
                  }
            }
            Console.WriteLine(oldestage.FirstName + oldestage.LastName);
        }
        static List<String> GetFullNames()
        {   
            var result = new List<String>();
            foreach(var member in members)
            {
                result.Add("{member.FirstName} {member.LastName}");
            }
           return result;
        }
        static Tuple<List<Member>, List<Member>, List<Member>> ChiaNamSinh()
        {
            var list1 = new List<Member>();
            var list2 = new List<Member>();
            var list3 = new List<Member>();

            foreach (var member in members)
            {
                var birthYear = (member.DateOfBirth.Year);
                switch(birthYear)
                {
                    case 2000:
                    list1.Add((Member)member);
                        break;
                    case < 2000:
                    list2.Add((Member)member);
                        break;
                    case > 2000:
                    list3.Add((Member)member);
                    break;

                }
            }
            return Tuple.Create(list1, list2, list3);
        }
        public static List<Member> SeedingData()
        {
            List<Member> members = new List<Member>();
            members.Add(new Member()
            {FirstName="Do",
            LastName="Tien Thanh",
            Gender="Male",
            DateOfBirth= new DateTime(13,2,2000),
            PhoneNumber="0585032360",
            BirthPlace="Hai Duong",
            Age=22, 
            IsGraduated=true});

            members.Add(new Member()
            {FirstName="Nguyen",
            LastName="Tien Thanh",
            Gender="Male",
            DateOfBirth= new DateTime(12,2,2001),
            PhoneNumber="0585032360",
            BirthPlace="Ha Noi",
            Age=21, 
            IsGraduated=true});

            members.Add(new Member()
            {FirstName="Nguyen",
            LastName="Thai Hoc",
            Gender="Male",
            DateOfBirth= new DateTime(12,2,2001),
            PhoneNumber="0585032360",
            BirthPlace="Thai Binh",
            Age=21, 
            IsGraduated=true});

            members.Add(new Member()
            {FirstName="Nguyen",
            LastName="Van Thai",
            Gender="Male",
            DateOfBirth= new DateTime(19,9,1999),
            PhoneNumber="0585032360",
            BirthPlace="Ha Noi",
            Age=23, 
            IsGraduated=true});

            members.Add(new Member()
            {FirstName="Pham",
            LastName="Dinh Quan",
            Gender="Male",
            DateOfBirth= new DateTime(12,3,1997),
            PhoneNumber="0585032360",
            BirthPlace="Hai Duong",
            Age=25, 
            IsGraduated=true});

            members.Add(new Member()
            {FirstName="Nguyen",
            LastName="Van Truong",
            Gender="Male",
            DateOfBirth= new DateTime(14,7,1996),
            PhoneNumber="0585032360",
            BirthPlace="Ha Noi",
            Age=26, 
            IsGraduated=true});
            
            return members;        
        }

        
    }
        
}