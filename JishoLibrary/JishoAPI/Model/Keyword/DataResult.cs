using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JishoAPI.Model.Keyword
{
    public class DataResult
    {
        /// <summary>
        /// source of result
        /// </summary>
        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        /// <summary>
        /// common word marker
        /// </summary>
        [JsonProperty("is_common")]
        public bool IsCommon { get; set; }

        /// <summary>
        /// Japanese definitions and readings
        /// </summary>
        [JsonProperty("japanese")]
        public List<JapaneseResult> Japanese { get; set; }
    }
}
