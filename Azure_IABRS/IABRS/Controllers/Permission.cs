using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IABRS.ModelsFromDB;
namespace IABRS.Controllers
{
    public class Permission
    {


        public static List<GroupPermission> Permissions = new List<GroupPermission>(); 


    }

    public class PermissionController
    {
       public static void LoadPermissions()
        {
            testsForNADContext db = new testsForNADContext();
            //from u in db.Group select u;
          System.Linq.IQueryable<  GroupPermission> groupPermission = from u in db.GroupPermission select u;

            foreach (GroupPermission perm in groupPermission)
            {
                perm.Group = (Group)(from u in db.Group where u.Id == perm.GroupId select u).First();
                perm.Permission = (ModelsFromDB.Permission)(from u in db.Permission where u.Id == perm.PermissionId select u).First();
                Permission.Permissions.Add(perm);
            }

        }
    }
}