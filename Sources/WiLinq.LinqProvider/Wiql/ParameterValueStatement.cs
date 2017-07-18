namespace WiLinq.LinqProvider.Wiql
{
    public sealed class ParameterValueStatement : ValueStatement
    {
        private readonly string _parameterName;

        internal ParameterValueStatement(string parameterName)
        {
            _parameterName = parameterName;
        }
         

        protected internal override string ConvertToQueryValue() => $"@{_parameterName}";


        public override ValueStatement Copy() => new ParameterValueStatement(_parameterName);
    }
}
