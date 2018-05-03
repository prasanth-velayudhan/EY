namespace flydubai.Model.Content
{
    using System;

    public enum InflightEntertainmentType
    {
        PayMovies,
        PayTv,
        FreeMusic,
        FreeGames,
        FoodAndDrink,
        DutyFree,
        NewsPaper
    }

    /// <summary>
    /// Inflight Entertainment Cms Type Helper
    /// </summary>
    public static class InflightEntertainmentCmsTypeHelper
    {
        public static string ToDisplayName(this InflightEntertainmentType type)
        {
            switch (type)
            {
                case InflightEntertainmentType.PayMovies:
                    return "Movies";
                case InflightEntertainmentType.PayTv:
                    return "Pay TV";
                case InflightEntertainmentType.FreeMusic:
                    return "Free Music";
                case InflightEntertainmentType.FreeGames:
                    return "Free Games";
                case InflightEntertainmentType.FoodAndDrink:
                    return "Food And Drink";
                case InflightEntertainmentType.DutyFree:
                    return "Buy Duty Free";
                case InflightEntertainmentType.NewsPaper:
                    return "Newspaper";
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }    
    }

    // EF4 enum wrapper workaround
    /// <summary>
    /// Inflight Entertainment Type Wrapper
    /// </summary>
    public class InflightEntertainmentTypeWrapper
    {
        public int Value
        {
            get { return (int) this.EnumValue; }
            set { this.EnumValue = (InflightEntertainmentType) value; }
        }

        public InflightEntertainmentType EnumValue { get; set; }

        public static implicit operator InflightEntertainmentTypeWrapper(InflightEntertainmentType type)
        {
            return new InflightEntertainmentTypeWrapper { EnumValue = type };
        }

        public static implicit operator InflightEntertainmentType(InflightEntertainmentTypeWrapper typeWrapper)
        {
            if (typeWrapper == null)
            {
                return InflightEntertainmentType.PayMovies;
            }
            else
            {
                return typeWrapper.EnumValue;
            } 
        }
    }
}