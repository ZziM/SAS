namespace SAS.Web.Models
{
    public abstract class BaseObjectViewModel
    {
        public PageInfo Page { get; set; }
        protected BaseObjectViewModel(PageInfo page)
        {
            Page = page;
        }
    }
}