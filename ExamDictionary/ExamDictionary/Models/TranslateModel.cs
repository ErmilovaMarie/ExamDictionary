using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDictionary.Models
{
    public class TranslateModel
    {
        public string text { get; set; }
        public string pos { get; set; }
        public ObservableCollection<SynMeanModel> syn { get; set; }
        public ObservableCollection<SynMeanModel> mean { get; set; }
        public ObservableCollection<ExampleModel> ex { get; set; }
    }
}
