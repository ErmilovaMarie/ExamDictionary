using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDictionary.Models
{
    public class DefModel
    {
        public string text { get; set; }
        public string pos { get; set; }
        public string ts { get; set; }
        public ObservableCollection<TranslateModel> tr { get; set; }
    }
}
