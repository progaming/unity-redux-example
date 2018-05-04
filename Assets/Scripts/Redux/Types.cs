public interface IReducer
{
    void Reduce(dynamic payload);
}

public interface IMiddleware
{
    dynamic Apply(dynamic action);
}