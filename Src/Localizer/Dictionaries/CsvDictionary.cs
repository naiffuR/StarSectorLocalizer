﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localizer.Dictionaries
{
    public class CsvDictionary
    {
        public List<string> TranslatedColumns { get; set; }
        public Dictionary<string, string> Translations { get; set; }
    }
}
