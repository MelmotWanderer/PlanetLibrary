using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class SearchPresenter : IPresenter
    {
        private readonly ISearchView _view;
        private readonly ISearchModel _module;

        public SearchPresenter(ISearchView view, ISearchModel module)
        {
            _view = view;
            _module = module;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
