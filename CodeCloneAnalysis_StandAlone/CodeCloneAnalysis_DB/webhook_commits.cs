//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeCloneAnalysis_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class webhook_commits
    {
        public Nullable<long> icommit_id { get; set; }
        public Nullable<long> webhook_ref_id { get; set; }
        public string git_commit_id { get; set; }
        public string message { get; set; }
        public string timestamp { get; set; }
        public string url { get; set; }
        public string author_name { get; set; }
        public string author_user_name { get; set; }
        public string committer_name { get; set; }
        public string committer_user_name { get; set; }
        public string added { get; set; }
        public string removed { get; set; }
        public string modified { get; set; }
        public int unique_id { get; set; }
    }
}
