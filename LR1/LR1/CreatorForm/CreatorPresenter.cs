using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class CreatorPresenter : IPresenter
    {
        public Action CreatedPlanet;

        private readonly ICreatorView _view;
        private readonly ICreatorModel _model;
        
        

        public CreatorPresenter(ICreatorView view, ICreatorModel model)
        {
            _view = view;
            _model = model;
            _view.CreatedPlanet += CreatePlanet;
         
          
        }

        public void Run()
        {
            _view.Show();
        }
        private void CreatePlanet(string name, string equatorialDiameter, string mass, string orbitalRadius, string rotationPeriod, string countSatellites, int typePlanet)
        {

          float[] floatData =  ConvertFloatData(equatorialDiameter, mass, orbitalRadius, rotationPeriod);
            int intData = ConvertIntData(countSatellites);
            if(floatData != null && intData != -1)
            {
                var planet = _model.CreateNewPlanet(name, floatData[0], floatData[1], floatData[2], floatData[3], intData, typePlanet);
                CreatedPlanet.Invoke();
                _view.Close();
            }
        
           
        }

        private float[] ConvertFloatData(string equatorialDiameter, string mass, string orbitalRadius, string rotationPeriod)
        {
            float[] convertFloatData = new float[4];


            try
            {
                convertFloatData[0] = float.Parse(equatorialDiameter);
                convertFloatData[1] = float.Parse(mass);
                convertFloatData[2] = float.Parse(orbitalRadius);
                convertFloatData[3] = float.Parse(rotationPeriod);
                return convertFloatData;
            }
            catch (FormatException)
            {
                _view.ShowModalError();
            }
            return null;
        }
        private int ConvertIntData(string countSatellites)
        {
            int convertCountSatellites = 0;
            try
            {
                convertCountSatellites = int.Parse(countSatellites);

                return convertCountSatellites;
            }
            catch
            {
                _view.ShowModalError();
            }
            return -1;
        }
    }
}
