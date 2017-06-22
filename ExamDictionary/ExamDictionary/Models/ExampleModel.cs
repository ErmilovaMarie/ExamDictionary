using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDictionary.Models
{
    public class ExampleModel
    {
        public string text { get; set; }
        public ObservableCollection<SimpleTranslateModel> tr { get; set; }
        public string num { get; set; }
        public string pos { get; set; }
        public string gen { get; set; }
    }
}
