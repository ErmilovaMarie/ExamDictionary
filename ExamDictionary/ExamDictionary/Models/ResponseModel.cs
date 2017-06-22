using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDictionary.Models
{
    public class ResponseModel
    {
        public HeadModel head { get; set; }
        public ObservableCollection<DefModel> def { get; set; }
    }
}
