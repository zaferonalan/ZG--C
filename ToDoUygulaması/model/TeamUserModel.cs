
namespace ToDoUygulaması 
{
    public class TeamUserModel
    {
        public TeamUserModel(string username, int id)
        {
            this.Username = username;
            this.İd = id;
        }

        public string Username { get; }
        public int İd { get; }
    }
}