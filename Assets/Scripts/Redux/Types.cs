public interface IReducer
{
    void Reduce(object payload);
}

public interface IMiddleware
{
    object Apply(object action);
}