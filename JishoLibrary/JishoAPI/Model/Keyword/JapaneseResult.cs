using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JishoAPI.Model.Keyword
{
    public class JapaneseResult
    {
        /// <summary>
        /// hiragana pronounciation
        /// </summary>
        [JsonProperty("reading")]
        public string Reading { get; set; }

        /// <summary>
        /// word
        /// this is not necessarily the keyword entered
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }
    }
}
