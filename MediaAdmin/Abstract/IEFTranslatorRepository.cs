using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Abstract
{
    public interface IEFTranslatorRepository
    {
        IEnumerable<Translator> Translators { get; }

        void SaveTranslator(Translator translator);
    }
}
