namespace flydubai.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Code Type Category
    /// </summary>
    [Serializable]
    public class CodeTypeCategory
    {
        public int CodeTypeCategoryId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CodeType> CodeTypes { get; set; }
    }
}