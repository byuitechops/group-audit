

namespace MyAudit
{
      public class BlueprintCourse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string course_code { get; set; }
        public string sis_course_id { get; set; }
        public string term_name { get; set; }
    }

    public class BluePrintSubscriptions
    {
        public int id { get; set; }
        public int template_id { get; set; }
        public BlueprintCourse blueprint_course { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public bool is_public { get; set; }
        public bool followed_by_user { get; set; }
        public string join_level { get; set; }
        public int members_count { get; set; }
        public string avatar_url { get; set; }
        public string context_type { get; set; }
        public int course_id { get; set; }
        public object role { get; set; }
        public int group_category_id { get; set; }
        public string sis_group_id { get; set; }
        public int sis_import_id { get; set; }
        public int storage_quota_mb { get; set; }
        public Permissions permissions { get; set; }
    }
    public class Permissions
    {
        public bool create_discussion_topic { get; set; }
        public bool create_announcement { get; set; }
    }


}

