namespace SAS.Web.Models
{
    public abstract class BaseObjectViewModel
    {
        public PageInfo Page { get; protected set; }
        protected BaseObjectViewModel(PageInfo page)
        {
            Page = page;
        }
    }
}