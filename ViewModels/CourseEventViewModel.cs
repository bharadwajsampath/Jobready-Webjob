using Models;
using Newtonsoft.Json;

namespace Models.ViewModels
{
    public class CourseEventViewModel
    {
        [JsonProperty("course-event")]
        public CourseEventRoot CourseEventRoot { get; set; }

    }

    public class CourseEventRoot
    {
        public Course Course { get; set; }
        public Event Event { get; set; }
    }
}
