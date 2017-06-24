using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Concrete
{
    public class EFTranslatorRepository : IEFTranslatorRepository
    {
        private EFDbMediaTranslations context = new EFDbMediaTranslations();

        public IEnumerable<Translator> Translators
        {
            get
            {
                return context.Translators;
            }
        }

        public void SaveTranslator(Translator translator)
        {
            if (translator.TranslatorID == 0)
            {
                context.Translators.Add(translator);
            }
            else
            {
                Translator dbEntry = context.Translators.Find(translator.TranslatorID);
                {
                    if (dbEntry != null)
                    {
                        dbEntry.Name = translator.Name;
                        dbEntry.LastName = translator.LastName;
                        dbEntry.Address = translator.Address;
                        dbEntry.City = translator.City;
                        dbEntry.ZIP = translator.ZIP;
                        dbEntry.Country = translator.Country;
                        dbEntry.Email = translator.Email;
                        dbEntry.FirstLanguage = translator.FirstLanguage;
                        dbEntry.SecondLanguage = translator.SecondLanguage;
                        dbEntry.ThirdLanguage = translator.ThirdLanguage;
                        dbEntry.FourthLanguage = translator.FourthLanguage;
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
