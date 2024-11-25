namespace Presence.API.Response
{
    public class GroupResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        IEnumerable<StudentResponse> Students { get; set; }
    }
}
