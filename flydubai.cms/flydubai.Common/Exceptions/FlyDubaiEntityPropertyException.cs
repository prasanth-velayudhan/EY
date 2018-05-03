namespace flydubai.Common.Exceptions
{
    /// <summary>
    /// FlyDubai Entity Property Exception
    /// </summary>
    public class FlyDubaiEntityPropertyException
    {
        private readonly string propertyName;
        private readonly string propertError;
        private readonly string propertyValue;


        public FlyDubaiEntityPropertyException(string propertyName, string propertyValue, string propertError)
        {
            this.propertyValue = propertyValue;
            this.propertyName = propertyName;
            this.propertError = propertError;
        }

        public string PropertyName
        {
            get { return this.propertyName; }
        }

        public string PropertyValue
        {
            get { return this.propertyValue; }
        }

        public string PropertyError
        {
            get { return this.propertError; }
        }
    }
}
