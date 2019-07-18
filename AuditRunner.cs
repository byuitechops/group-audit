

using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyAudit
{
    public class AuditRunner
    {

        public static async Task ExecuteAuditAsync(string id, int type)
        {
            string bluePrintSubs = await HttpRequestor.MakeSimpleGetRequestAuth("https://byui.instructure.com/api/v1/courses/19272/blueprint_subscriptions");
            List<BluePrintSubscriptions> courses = JsonConvert.DeserializeObject<List<BluePrintSubscriptions>>(bluePrintSubs);
            string bluePrintID = courses[0].blueprint_course.id.ToString();
            System.Console.WriteLine(bluePrintID);
            //build group object for actual course
            List<List<Group>> groupList = await ObjectBuilder.BuildObjects(id, bluePrintID, type);
            System.Console.WriteLine();
        }
    }

}

