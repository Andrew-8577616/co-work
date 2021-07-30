using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



public class MemberUtility
{
    public static void AddMember(Member member)
    {
        ProjectEntities db = new ProjectEntities();

        db.Members.Add(member);

        db.SaveChanges();
    }

    public static void UpdateMember(Member member)
    {
        ProjectEntities db = new ProjectEntities();

        db.Entry(member).State = System.Data.Entity.EntityState.Modified;

        db.SaveChanges();
    }

    public static void DeleteMember(int id)
    {
        ProjectEntities db = new ProjectEntities();

        Member m = db.Members.SingleOrDefault(member => member.UserID == id);

        db.Members.Remove(m);

        db.SaveChanges();
    }

    public static List<Member> GetMembers()
    {
        ProjectEntities db = new ProjectEntities();

        return db.Members.ToList();
    }

    public static Member GetMemberByID(int id)
    {
        ProjectEntities db = new ProjectEntities();

        return db.Members.SingleOrDefault(member => member.UserID == id);
    }

    public static bool CheckMemberByUserNamePassword(string account, string password)
    {
        
        ProjectEntities db = new ProjectEntities();
        int count = db.Members.Count(m => m.Account == account && m.Password == password);
        return count > 0 ? true : false;

    }
}
