using System;

namespace WiLinq.LinqProvider
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FieldAttribute : Attribute
    {
    public string ReferenceName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the FieldToIgnoreAttribute class.
        /// </summary>
        public FieldAttribute(string referenceName)
        {
            if (string.IsNullOrEmpty(referenceName))
                throw new ArgumentException("referenceName is null or empty.", nameof(referenceName));
            ReferenceName = referenceName;
        }
    }
}