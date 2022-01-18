using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_folder
{
    public class Assignment2
    {
    
        
        public static void Malemember(List<Member> listmembers)
        {
            List<Member> malemembers = (from member in listmembers
                            where member.Gender == "Male"  
                            select member).ToList();

            for (int i = 0; i < malemembers.Count;i++)
            {
                Console.WriteLine(malemembers[i].FirstName + malemembers[i].LastName);
            }            
        }
        
        static List<Member> showOldest(List<Member> listmembers)
        {
            var oldest = (from member in listmembers
                        orderby member.Age descending
                        select member).ToList();
           // return oldest.FirstOrDefault() == null ? new Member(): oldest.First();
        }

         public List<String> showFullName(List<Member> listmembers){
            List<String> fullName = (from member in listmembers
                                    select member.LastName + " " + member.FirstName).ToList();
            return fullName;
        }

         public List<Member>[] showAgeGroup(List<Member> listmembers)
        {
            List<Member> is2000 = (from member in listmembers
                        where member.YearOfBirth == 2000
                        select member).ToList();
            List<Member> above2000 = (from member in listmembers
                        where member.YearOfBirth > 2000
                        select member).ToList();
            List<Member> below2000 = (from member in listmembers
                        where member.YearOfBirth < 2000
                        select member).ToList();
            return new List<Member>[]{
                is2000,
                above2000,
                below2000
            };
        }

        public Member showFirstHanoi(List<Member> listmembers)
        {
            var hanoier = (from member in listmembers
                        where member.BirthPlace == "Ha noi"
                        select member).ToList();
            Member firstHanoier = hanoier.First();
            return firstHanoier == null ? new Member(){BirthPlace = ""} : firstHanoier;
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
   


        
    
        
