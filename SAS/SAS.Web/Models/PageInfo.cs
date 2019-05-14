namespace SAS.Web.Models
{
    public class PageInfo
    {
        public string Controller { get; private set; }
        public string Action { get; private set; }
        public string Title { get; private set; }
        public PageInfo(string controller, string action, string title)
        {
            Controller = controller;
            Action = action;
            Title = title;
        }
    }
}