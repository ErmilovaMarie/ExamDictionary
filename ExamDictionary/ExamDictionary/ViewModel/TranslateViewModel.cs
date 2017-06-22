using ExamDictionary.Models;
using ExamDictionary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamDictionary.ViewModel
{
    public class TranslateViewModel
    {
        public string Word { get; set; }
        public string TranslatedString { get; set; }
        public string PartOfSpeech { get; set; }

        private readonly Page _page;
        public TranslateViewModel(Page page)
        {
            _page = page;
        }

        public async Task<ObservableCollection<DefModel>> Translate(string lang)
        {
            Word = Word.Trim();
            if (Word == "")
            {
                await _page.DisplayAlert("Ошибка", "Введите слово", "Ок");
                return new ObservableCollection<DefModel>();
            }
            else
            {
                string[] words = Word.Split(new Char[] { ' ' });
                if (words.Length > 1)
                {
                    await _page.DisplayAlert("Ошибка", "Введите только одно слово", "Ок");
                    return new ObservableCollection<DefModel>();
                }
                else
                {
                    var dataService = DataService.GetInstance();
                    var response = await dataService.TranslateAsync(lang, Word);

                    if (response.def.Count == 0)
                    {
                        await _page.DisplayAlert("Ошибка", "Перевода не существует в базе", "Ок");
                        return new ObservableCollection<DefModel>();
                    }
                    else
                    {
                        TranslatedString = $"{response.def[0].text} [{response.def[0].ts}] - {response.def[0].tr[0].text}";
                        PartOfSpeech = response.def[0].pos;
                        return response.def;
                    }
                }
            }
        }
    }
}
