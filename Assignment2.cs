using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_folder
{
    public class Assignment2
    {
        //Cau 1
        var query = from x in Member
                    where Member.Gender == "Male"  
                    select x;
        foreach (var member in query)
        {
            Console.WriteLine(Member);
        }
        // Cau 5
        var kq = Member.Where
        (
            (x) =>{
                return x.BirthPlace == "Ha Noi";
            }
        );
        
        foreach (var item in kq)
        {
            Console.WriteLine(item);
        }

        // Cau 2
        int[] age ={get; set;};
        Console.WriteLine()

        //cau 3
        var kq = member.

    }
}