using System;

namespace SAS.Web.Models
{
    public class BusinessObjectViewModel<TInput, TOutput> : BaseObjectViewModel where TOutput: class
    {
        public TOutput Model { get; protected set; }
        public BusinessObjectViewModel(PageInfo page, TInput inputModel) : base(page)
        {
            Model = Activator.CreateInstance(typeof(TOutput), inputModel) as TOutput ?? throw new ArgumentNullException(nameof(Model));
        }
    }
}