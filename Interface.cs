using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_folder
{
    public interface IBai2
    {
    public List<Member> SeedingData();
    public void PrintTitle(string title);
    public void PrintOneData(Member member);
    public void PrintListData(List<Member> members);
    public List<Member> GetMaleMembers(List<Member> members);
    public Member GetOldestMember(List<Member> members);
    public List<string> GetFullnameMembers(List<Member> members);
    public List<Member> GetMembersAround2000(List<Member> members, string condition);
    public Member GetFirstHanoiMember(List<Member> members);
    }   
}
