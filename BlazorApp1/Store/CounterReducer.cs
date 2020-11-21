using Fluxor;

namespace BlazorApp1.Store
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(
            CounterState state,
            AddCounter action)
        {
            return state with
            {
                Count = state.Count + action.Step
            };
        }
    }
}