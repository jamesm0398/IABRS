using System;
using System.Collections.Generic;

//Class: CourseUser
//Summary: This class contains the getters/setters for various attributes of a course's user, i.e. what course is the user enrolled in?

namespace IABRS.Models
{
    public partial class CourseUser
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string UserId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
