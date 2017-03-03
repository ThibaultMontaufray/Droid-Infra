using System;

namespace Droid_Infra
{
    public static class GetText
    {
        #region Enum
        public enum Language
        {
            FRENCH,
            ENGLISH
        }
        #endregion

        #region Attribute
        public static Language CurrentLanguage = Language.ENGLISH;
        #endregion

        #region Constructor
        static GetText()
        {
            CurrentLanguage = (Language)Enum.Parse(typeof(Language), Properties.Settings.Default.Language.ToUpper());
        }
        #endregion

        #region Methods publice
        public static string Text(string text)
        {
            switch (CurrentLanguage)
            {
                case Language.FRENCH:
                    return Properties.ResourceFrench.ResourceManager.GetString(text);
                case Language.ENGLISH:
                    return Properties.ResourceEnglish.ResourceManager.GetString(text);
                default:
                    return text;
            }
        }
        #endregion
    }
}
