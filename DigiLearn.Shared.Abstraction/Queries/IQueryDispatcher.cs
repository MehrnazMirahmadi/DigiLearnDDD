namespace DigiLearn.Shared.Abstraction.Queries;

public interface IQueryDispatcher
{
    Task<TResult> FetchAsync<TResult>(IQuery<TResult> query);
}

