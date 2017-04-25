using System;

namespace WiLinq.LinqProvider.Wiql
{
    public sealed class DateValueStatement : ValueStatement
    {
        public DateTime Value { get; private set; }
        /// <summary>
        /// Initializes a new instance of the DateValue class.
        /// </summary>
        internal DateValueStatement(DateTime date)
        {
            Value = date;
        }

        protected internal override string ConvertToQueryValue()
        {
            return $"'{Value:u}'";
        }

        public override ValueStatement Copy()
        {
            return new DateValueStatement(Value);
        }
    }
}
