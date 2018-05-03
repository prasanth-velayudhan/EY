namespace flydubai.Common.Exceptions
{
    using System.Collections.Generic;

    /// <summary>
    /// FlyDubai Entity Exception
    /// </summary>
    public class FlyDubaiEntityException
    {
        public FlyDubaiEntityException(string entityName)
        {
            this.EntityName = entityName;
            this.EntityPropertyExceptions = new List<FlyDubaiEntityPropertyException>();
        }

        public string EntityName { get; set; }

        public List<FlyDubaiEntityPropertyException> EntityPropertyExceptions { get; set; }
    }
}
