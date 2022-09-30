public delegate void CallbackFunc();
public delegate void CallbackFunc<T>(T param);
public delegate void CallbackFunc<T, X>(T param1, X param2);
public delegate void CallbackFunc<X, Y, Z>(X param1, Y param2, Z param3);
public delegate void CallbackFunc<X, Y, Z, W>(X param1, Y param2, Z param3, W param4);
public delegate void CallbackFunc<X, Y, Z, W, T>(X param1, Y param2, Z param3, W param4, T param5);