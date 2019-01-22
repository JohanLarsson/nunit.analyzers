namespace NUnit.Analyzers.Constants
{
    internal static class AnalyzerIdentifiers
    {
        internal const string FalseUsage = "NUNIT_1";
        internal const string IsFalseUsage = "NUNIT_2";
        internal const string IsTrueUsage = "NUNIT_3";
        internal const string TrueUsage = "NUNIT_4";
        internal const string AreEqualUsage = "NUNIT_5";
        internal const string AreNotEqualUsage = "NUNIT_6";
        internal const string TestCaseParameterTypeMismatchUsage = "NUNIT_7";
        internal const string TestCaseNotEnoughArgumentsUsage = "NUNIT_9";
        internal const string TestCaseTooManyArgumentsUsage = "NUNIT_10";
        internal const string TestMethodExpectedResultTypeMismatchUsage = "NUNIT_11";
        internal const string TestMethodSpecifiedExpectedResultForVoidUsage = "NUNIT_12";
        internal const string TestMethodNoExpectedResultButNonVoidReturnType = "NUNIT_13";
        internal const string ParallelScopeSelfNoEffectOnAssemblyUsage = "NUNIT_14";
        internal const string ParallelScopeChildrenOnNonParameterizedTestMethodUsage = "NUNIT_15";
        internal const string ParallelScopeFixturesOnTestMethodUsage = "NUNIT_16";
    }
}
