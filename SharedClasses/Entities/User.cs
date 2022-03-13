using System.Diagnostics;

namespace SharedClasses.Entities
{
    public class User
    {
        //private Guid _Id;
        public string UserId { get; set; }
        //{
            //get { return _Id.ToString(); }
            //set { if (!Guid.TryParse(UserId, out _Id)) { _Id = Guid.NewGuid(); } }
        //}
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public bool Active { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName { 
            get
            {
                string fullName = "";
                if (FirstName != null) { fullName = FirstName + " "; }
                if (MiddleName != null) { fullName += MiddleName + " "; }
                if (LastName != null) { fullName += LastName; }
                return fullName.Trim();
            }
        }
        public string UserRoutePath { get; set; }
        public string? DateCreated { get; set; }
        public string? DateLastUpdated { get; set; }

        public User()
        {
            Debug.WriteLine("In User default constructor.");
        }
        public User(string userId, string userName, string emailAddress, bool active, 
            string? firstName, string? middleName, string? lastName, string? userRoutePath)
        {
            // + Need to add validation of inputs
            //this._Id = Guid.NewGuid();
            UserId = userId;
            UserName = userName.Trim();
            EmailAddress = emailAddress;
            Active = active;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            if (userRoutePath == null) { userRoutePath = UserName.ToLower().Trim(); }
            UserRoutePath = userRoutePath;

        }
    }
}

/* ROADMAP
 * - Site could be available through multiple domains and the user may opt into multiple.
 *      - Would the UserRoute property be unique per site or would it be static across all.
 *      - $$$ Monetization idea:  custom UserRoute and multiple domains
 */