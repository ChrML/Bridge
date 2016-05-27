using Bridge;

namespace System
{
    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action();

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T>(T arg);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2>(T1 arg1, T2 arg2);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    [Name("Function")]
    [IgnoreCast, IgnoreGeneric, External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

    [Name("Function")]
    [IgnoreGeneric, External]
    [IgnoreCast]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast, External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast, External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast, External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast]
    [External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast]
    [External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast]
    [External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

    [Name("Function")]
    [IgnoreGeneric]
    [IgnoreCast]
    [External]
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
}