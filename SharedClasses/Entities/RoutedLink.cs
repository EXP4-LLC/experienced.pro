using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.Entities
{
    public enum RoutedLinkType
    {
        Default =       0,
        LinkedIn =      1,
        Resume =        2,
        Business =      3,
        Portfolio =     4,
        Blog =          5,
        GitHub =        6,
        Facebook =      7,
        Instagram =     8,
        Twitter =       9,
        YouTube =       10,
        Indeed =        11,
        Upwork =        12,
        Fivrr =         13,
        Other =         99,
    }
    public class RoutedLink
    {
        private readonly Guid _Id;
        //private Guid _UserId;
        //private RoutedLinkType _LinkType;
        //private string _LinkTypeIcon;
        public string RoutedLinkId { get; set; }
        //{
            //get { return _Id.ToString(); }
            //set { if (!Guid.TryParse(RoutedLinkId, out _Id)) { _Id = Guid.NewGuid(); } }
        //}
        public string AssociatedUserId { get; set; }
        //{ 
            //get { return _UserId.ToString(); }
            //set { 
                // + Need to check against valid users when setting.
                //if (!Guid.TryParse(AssociatedUserId, out _UserId)) { throw new ArgumentException($"{AssociatedUserId} did not parse as a valid Guid."); } 
            //}
        //}
        public string Name { get; set; }
        public string? Description { get; set; }
        public string LinkType { get; set; }
            /*set { 
                switch (LinkType)
                {
                    case "Default": 
                        _LinkType = RoutedLinkType.Default;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    case "Business": 
                        _LinkType = RoutedLinkType.Business; 
                        _LinkTypeIcon = "<i class=\"bi bi-briefcase\"></i>";
                        break;
                    case "Portfolio": 
                        _LinkType = RoutedLinkType.Portfolio;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    case "Resume": 
                        _LinkType = RoutedLinkType.Resume;
                        _LinkTypeIcon = "<i class=\"bi bi-file-earmark-person\"></i>";
                        break;
                    case "Blog": 
                        _LinkType = RoutedLinkType.Blog;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    case "YouTube": 
                        _LinkType = RoutedLinkType.YouTube;
                        _LinkTypeIcon = "<i class=\"bi bi-youtube\"></i>";
                        break;
                    case "Instagram": 
                        _LinkType = RoutedLinkType.Instagram;
                        _LinkTypeIcon = "<i class=\"bi bi-instagram\"></i>";
                        break;
                    case "LinkedIn": 
                        _LinkType = RoutedLinkType.LinkedIn;
                        _LinkTypeIcon = "<i class=\"bi bi-linkedin\"></i>";
                        break;
                    case "Indeed": 
                        _LinkType = RoutedLinkType.Indeed;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    case "Upwork": 
                        _LinkType = RoutedLinkType.Upwork;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    case "Fivrr": 
                        _LinkType = RoutedLinkType.Fivrr;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    case "GitHub": 
                        _LinkType = RoutedLinkType.GitHub;
                        _LinkTypeIcon = "<i class=\"bi bi-github\"></i>";
                        break;
                    case "Twitter": 
                        _LinkType = RoutedLinkType.Twitter;
                        _LinkTypeIcon = "<i class=\"bi bi-twitter\"></i>";
                        break;
                    case "Facebook": 
                        _LinkType = RoutedLinkType.Facebook;
                        _LinkTypeIcon = "<i class=\"bi bi-facebook\"></i>";
                        break;
                    case "Other": 
                        _LinkType = RoutedLinkType.Other;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        break;
                    default: 
                        _LinkType = RoutedLinkType.Other;
                        _LinkTypeIcon = "<i class=\"bi bi-globe\"></i>";
                        Debug.WriteLine($"Invalid RoutedLinkType '{LinkType}' provided. Using 'Other'."); 
                        break;
                }
            }
        }*/
        public string GetLinkTypeIcon()
        { 
            switch (LinkType)
            {
                case "Default":
                    //_LinkType = RoutedLinkType.Default;
                    return "<i class=\"bi bi-globe\"></i>";
                case "Business":
                    //_LinkType = RoutedLinkType.Business;
                    return "<i class=\"bi bi-building\"></i>";
                case "Portfolio":
                    //_LinkType = RoutedLinkType.Portfolio;
                    return "<i class=\"bi bi-briefcase\"></i>";
                case "Resume":
                    //_LinkType = RoutedLinkType.Resume;
                    return "<i class=\"bi bi-file-earmark-person\"></i>";
                case "Blog":
                    //_LinkType = RoutedLinkType.Blog;
                    return "<i class=\"bi bi-collection\"></i>";
                case "YouTube":
                    //_LinkType = RoutedLinkType.YouTube;
                    return "<i class=\"bi bi-youtube\"></i>";
                case "Instagram":
                    //_LinkType = RoutedLinkType.Instagram;
                    return "<i class=\"bi bi-instagram\"></i>";
                case "LinkedIn":
                    //_LinkType = RoutedLinkType.LinkedIn;
                    return "<i class=\"bi bi-linkedin\"></i>";
                case "Indeed":
                    //_LinkType = RoutedLinkType.Indeed;
                    return "<i class=\"bi bi-file-earmark-person\"></i>";
                case "Upwork":
                    //_LinkType = RoutedLinkType.Upwork;
                    return "<i class=\"bi bi-file-earmark-person\"></i>";
                case "Fivrr":
                    //_LinkType = RoutedLinkType.Fivrr;
                    return "<i class=\"bi bi-file-earmark-person\"></i>";
                case "GitHub":
                    //_LinkType = RoutedLinkType.GitHub;
                    return "<i class=\"bi bi-github\"></i>";
                case "Twitter":
                    //_LinkType = RoutedLinkType.Twitter;
                    return "<i class=\"bi bi-twitter\"></i>";
                case "Facebook":
                    //_LinkType = RoutedLinkType.Facebook;
                    return "<i class=\"bi bi-facebook\"></i>";
                case "Other":
                    //_LinkType = RoutedLinkType.Other;
                    return "<i class=\"bi bi-globe\"></i>";
                default:
                    //_LinkType = RoutedLinkType.Other;
                    Debug.WriteLine($"Invalid RoutedLinkType '{LinkType}' provided. Using 'Other'.");
                    return "<i class=\"bi bi-warning\"></i>";
            }
        }
        public bool Active { get; set; }
        public string RedirectToUrl { get; set; }
        public string RelativeRoutePath { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateLastUpdated { get; set; }
        
        public RoutedLink()
        {
            Debug.WriteLine("In RoutedLink default constructor.");
        }
        public RoutedLink(string associatedUserId, string name, string? desc, string linkType, bool active, string? redirectToUrl, string? relativeRoutePath)
        {
            this._Id = Guid.NewGuid();
            //this._UserId = associatedUserId;
            AssociatedUserId = associatedUserId;
            Name = name;
            Description = desc;
            LinkType = linkType;
            Active = active;
            // + If no redirectToUrl is specified, it could be default.
            // + If no redirectToUrl is specified and it is not default, will need to figure out how to handle it.
            // + Check input to see if it matches the intended LinkType.  For example, "[[http|https]://][www.]linkedin.com/in/*" (not valid regex)
            if (redirectToUrl == null) { redirectToUrl = "/"; }
            RedirectToUrl = redirectToUrl;
            // + If no relativeRoutePath is specified, would be best to use LinkType, but only if there isn't an existing relativeRoutePath with the same name.
            if (relativeRoutePath == null) { relativeRoutePath = _Id.ToString(); }
            RelativeRoutePath = relativeRoutePath;
            DateCreated = DateTime.UtcNow;
            DateLastUpdated = DateTime.UtcNow;
        }
    }
}