using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JishoAPI.Model.Keyword
{
    public class KeywordResult
    {
        //raw json
        public string JsonResult { get; set; }

        /// <summary>
        /// List of data returned matching the keyword
        /// </summary>
        [JsonProperty("data")]
        public List<DataResult> Data { get; set; }
    }
}
