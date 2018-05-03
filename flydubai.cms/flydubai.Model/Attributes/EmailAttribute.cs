using flydubai.Common;
using flydubai.Model.Attributes.Bases;

namespace flydubai.Model.Attributes
{
    /// <summary>
    /// Email Attribute
    /// </summary>
    public class EmailAttribute : RegularExpressionAttributeBase
    {
        public EmailAttribute() : base(Constants.EmailRegex)
        {
        }

    }
}
