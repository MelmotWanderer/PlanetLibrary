using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    public class FilterPresenter : IPresenter
    {
        private readonly IFilterView _view;
        private readonly IFilterModel _model;
        public Action<List<Planet>> ShowFiltredPlanets;
      
        public FilterPresenter(IFilterView view, IFilterModel model)
        {
            _view = view;
            _model = model;
            _view.FilteredPlanets += FilterPlanets;
        
        }
                
        public void Run()
        {
            _view.Show();
            
        }
        private void FilterPlanets(int index)
        {
            
            ShowFiltredPlanets?.Invoke(_model.Filter(index));
        }
    }
}
