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
        Default,
        Business,
        Portfolio,
        Resume,
        Blog,
        YouTube,
        Instagram,
        LinkedIn,
        Indeed,
        Upwork,
        Fivrr,
        GitHub,
        Twitter,
        Facebook,
        Other
    }
    public class RoutedLink
    {
        private Guid _Id;
        //private Guid _UserId;
        private RoutedLinkType _LinkType;
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
        public string? LinkType { 
            get { return _LinkType.ToString(); }
            set { 
                switch (LinkType)
                {
                    case "Default": _LinkType = RoutedLinkType.Default; break;
                    case "Business": _LinkType = RoutedLinkType.Business; break;
                    case "Portfolio": _LinkType = RoutedLinkType.Portfolio; break;
                    case "Resume": _LinkType = RoutedLinkType.Resume; break;
                    case "Blog": _LinkType = RoutedLinkType.Blog; break;
                    case "YouTube": _LinkType = RoutedLinkType.YouTube; break;
                    case "Instagram": _LinkType = RoutedLinkType.Instagram; break;
                    case "LinkedIn": _LinkType = RoutedLinkType.LinkedIn; break;
                    case "Indeed": _LinkType = RoutedLinkType.Indeed; break;
                    case "Upwork": _LinkType = RoutedLinkType.Upwork; break;
                    case "Fivrr": _LinkType = RoutedLinkType.Fivrr; break;
                    case "GitHub": _LinkType = RoutedLinkType.GitHub; break;
                    case "Twitter": _LinkType = RoutedLinkType.Twitter; break;
                    case "Facebook": _LinkType = RoutedLinkType.Facebook; break;
                    case "Other": _LinkType = RoutedLinkType.Other; break;
                    default: _LinkType = RoutedLinkType.Other; Debug.WriteLine($"Invalid RoutedLinkType '{LinkType}' provided. Using 'Other'."); break;
                }
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
        public RoutedLink(string associatedUserId, string name, string? desc, string? linkType, bool active, string? redirectToUrl, string? relativeRoutePath)
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