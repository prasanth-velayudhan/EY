namespace flydubai.Common.Exceptions
{
    using System;

    /// <summary>
    /// Flydubai commit summary exception
    /// </summary>
    public class FlydubaiCommitSummaryException : ApplicationException
    {
        public FlydubaiCommitSummaryException(string message)
            : base(message)
        {
        }

    }
}
