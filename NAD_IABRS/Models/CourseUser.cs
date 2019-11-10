namespace NAD_IABRS.Models
{
    public class CourseUser
    {
        [key]
        public int UserId { get; set; }
        [key]
        public int CouseId { get; set; }
        public User User { get; set; }
        public YCourse Course { get; set; }
    }
}