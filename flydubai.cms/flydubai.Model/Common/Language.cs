namespace flydubai.Model.Common
{
    /// <summary>
    /// Language
    /// </summary>
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        //FR006 A-5583//
        public string LocalisedLanguageName { get; set; }
        //FR006 A-5583//

        public bool IsLive { get; set; }

        public bool IsRightToLeft { get; set; }

        public string DefaultLocale { get; set; }
    }
}
