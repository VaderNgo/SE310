using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Data.Repositories;

namespace Week1.Presentation
{
    public class PresentationManager
    {
        private static PresentationManager _instance = null;

        public AnimalManager _animalManager;
        public AnimalDetail _animalDetail;

        public static PresentationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PresentationManager();
                    _instance._animalManager = new AnimalManager();
                    _instance._animalDetail = new AnimalDetail();
                }
                return _instance;
            }
        }

        public void OpenAddModel()
        {
            _animalManager.Hide();
            _animalDetail.Show();
        }

        public void CloseAddModel() { 
            _animalDetail.Hide();
            _animalManager.Show();
        }


    }
}
