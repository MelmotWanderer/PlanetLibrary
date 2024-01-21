using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class MainPresenter : IPresenter
    {
       
        private readonly IMainView _view;
        private readonly IMainModel _model;
        
        private Library _library;
        public MainPresenter(IMainView view, IMainModel model, Library library)
        {
            _view = view;
            _model = model;
            _library = library;
            _view.OpenedCreatorPlanet +=  OpenCreatorPlanet;
            _view.RemovedPlanet += RemovePlanet;
            _view.OpenedFilterPlanet += OpenFilterPlanet;
            _view.ClearingFilterPlanet += UpdateUIPlanets;
            _view.OpenedSearchPlanet += OpenSearchPlanet;
        }

        public void Run()
        {
            _view.Show();
            
        }

        private void OpenCreatorPlanet()
        {
            var CreatorPresenter = new CreatorPresenter(new Form2(), new CreatorModel(_library));
            CreatorPresenter.CreatedPlanet += UpdateUIPlanets;
            CreatorPresenter.Run();

        }
        private void OpenFilterPlanet()
        {
            var FilterPresenter = new FilterPresenter(new Filter(), new FilterModel(_library));
            FilterPresenter.ShowFiltredPlanets += UpdateUIPlanets;
            FilterPresenter.Run();
        }
        private void OpenSearchPlanet()
        {
            var SearchPresenter = new SearchPresenter(new SearcherPlanet(), new SearchModel());
            SearchPresenter.Run();
        }
        private void UpdateUIPlanets()
        {
            _view.EnableButtonClearFilter(false);
            _view.UpdateListView(_library.Planets);
        }
        private void UpdateUIPlanets(List<Planet> planet)
        {
            _view.UpdateListView(planet);
            _view.EnableButtonClearFilter(true);
        }
        private void RemovePlanet(int index)
        {
            _library.RemovePlanet(_library.Planets[index]);
     
        }
    }
}
