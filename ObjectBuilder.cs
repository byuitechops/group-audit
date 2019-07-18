using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyAudit
{
    internal class ObjectBuilder
    {
        public static async Task<List<List<Group>>> BuildObjects(string copyCourseID, string bpID, int type)
        {
            //lets get the information for the copy course 
            string ccGroupsStr = await HttpRequestor.MakeSimpleGetRequestAuth("https://byui.instructure.com/api/v1/courses/" + copyCourseID +"/groups");
            List<Group> ccGroups = JsonConvert.DeserializeObject<List<Group>>(ccGroupsStr);

             //lets get the information for the copy course 
            string bpGroupsStr = await HttpRequestor.MakeSimpleGetRequestAuth("https://byui.instructure.com/api/v1/courses/" + bpID +"/groups");
            List<Group> BPGroups = JsonConvert.DeserializeObject<List<Group>>(bpGroupsStr);

            System.Console.WriteLine("Number of groups for CC = {0} and Number of groups for BPC = {1}", ccGroups.Count, BPGroups.Count);
            return new List<List<Group>>() {ccGroups, BPGroups};
        }
    }
}