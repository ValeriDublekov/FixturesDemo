using System.Collections.Concurrent;

namespace FixturesDemo._7.AdvancedDependentFixtures.Common;

public class GlobalFixtureRegistry
{
    private static readonly ConcurrentDictionary<Type, TaskCompletionSource<AutoRegisteringFixture>> Fixtures = new();

    public static void RegisterFixture<T>(T instance)
        where T : AutoRegisteringFixture
    {
        var taskCompletionSource = GetTaskCompletionSource(instance.GetType());
        taskCompletionSource.TrySetResult(instance);
    }

    public static async Task<T> GetFixtureAsync<T>()
        where T : AutoRegisteringFixture
    {
        var taskCompletionSource = GetTaskCompletionSource(typeof(T));
        var fixture = await taskCompletionSource.Task;

        return (T)fixture;
    }

    private static TaskCompletionSource<AutoRegisteringFixture> GetTaskCompletionSource(Type fixtureType)
    {
        return Fixtures.GetOrAdd(fixtureType, new TaskCompletionSource<AutoRegisteringFixture>());
    }

    public static void SetFailure<T>(T instance, Exception exception)
        where T : AutoRegisteringFixture
    {
        var taskCompletionSource = GetTaskCompletionSource(instance.GetType());
        taskCompletionSource.SetException(exception);
    }
}