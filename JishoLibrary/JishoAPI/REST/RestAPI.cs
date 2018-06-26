using JishoAPI.Model.Keyword;
using System;
using System.Collections.Generic;
using System.Text;

namespace JishoAPI.REST
{
    /// <summary>
    /// call to the jisho.org API
    /// </summary>
    public class RestAPI
    {
        /// <summary>
        /// url of jisho
        /// </summary>
        private string JishoURL = "https://jisho.org/api/v1/search/words?keyword=";
        
        /// <summary>
        /// get results based on a keyword
        /// </summary>
        /// <param name="Keyword"></param>
        /// <returns></returns>
        public KeywordResult GetKeywordResult(string Keyword)
        {

            return new KeywordResult();
        }
    }
}
