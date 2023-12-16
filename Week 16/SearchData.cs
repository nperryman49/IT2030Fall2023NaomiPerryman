using Microsoft.AspNetCore.Mvc.ViewFeatures;


namespace NaomiRetroCloset.Data
{
    public class SearchData
    {
       
            private const string SearchKey = "search";
            private const string TypeKey = "searchtype";

            private ITempDataDictionary tempData { get; set; }
            public SearchData(ITempDataDictionary temp) =>

                tempData = temp;

        public string SearchTerm
        {
            get => tempData.Peek(SearchKey)?.ToString();
            set => tempData[SearchKey] = value;
        }

        public bool HasSearchTerm => !string.IsNullOrEmpty(SearchTerm);
        //public bool IsProduct => Type.FilterName("product");

        public void Clear()
        {
            tempData.Remove(SearchKey);
            tempData.Remove(TypeKey);
        }
    }
    
}
