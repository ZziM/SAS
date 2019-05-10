using System;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Web.Models
{
    public abstract class BusinessObjectCollectionViewModel<TOutup> : BaseObjectViewModel where TOutup : class
    {
        protected BusinessObjectCollectionViewModel(PageInfo page) : base(page)
        {
        }
    }
    public class BusinessObjectCollectionViewModel<TInput, TOtput> : BusinessObjectCollectionViewModel<TOtput> where TOtput : class
    {
        public IEnumerable<TOtput> Model { get; private set; }
        public BusinessObjectCollectionViewModel(PageInfo page, TInput[] inputModel) : base(page)
        {
            Model = inputModel.Select(_ => Activator.CreateInstance(typeof(TOtput), _) as TOtput);
        }
    }
}