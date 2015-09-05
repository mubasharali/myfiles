//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public Answer()
        {
            this.AnswerReplies = new HashSet<AnswerReply>();
            this.AnswerVotes = new HashSet<AnswerVote>();
        }
    
        public int Id { get; set; }
        public int questionId { get; set; }
        public string postedBy { get; set; }
        public System.DateTime time { get; set; }
        public string description { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<AnswerReply> AnswerReplies { get; set; }
        public virtual ICollection<AnswerVote> AnswerVotes { get; set; }
    }
}