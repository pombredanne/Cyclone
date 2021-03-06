//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cyclone.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class webHook
    {
        public webHook()
        {
            this.webHookCommits = new HashSet<webHookCommit>();
            this.webHookFiles = new HashSet<webHookFile>();
        }
    
        public long webHookRefId { get; set; }
        public string before { get; set; }
        public string after { get; set; }
        public string headCommitId { get; set; }
        public string headCommitUrl { get; set; }
        public string headCommitMessage { get; set; }
        public string headCommitAdded { get; set; }
        public string headCommitRemoved { get; set; }
        public string headCommitModified { get; set; }
        public string repositoryId { get; set; }
        public string repositoryUrl { get; set; }
        public Nullable<System.DateTime> entryTime { get; set; }
        public Nullable<bool> isSync { get; set; }
        public Nullable<System.DateTime> TimeSync { get; set; }
    
        public virtual ICollection<webHookCommit> webHookCommits { get; set; }
        public virtual ICollection<webHookFile> webHookFiles { get; set; }
    }
}
