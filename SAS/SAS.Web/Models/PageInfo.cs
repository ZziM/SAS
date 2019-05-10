namespace SAS.Web.Models
{
    public class PageInfo
    {
        public string Controller { get; private set; }
        public PageInfo(string controller)
        {
            Controller = controller;
        }
    }
}