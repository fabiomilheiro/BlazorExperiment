using Fluxor;

namespace BlazorApp1.Store
{
    public record CounterState
    {
        public int Count { get; set; }

        public int Step { get; set; }
    }

    public class CounterFeatureState : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState()
        {
            return new CounterState
            {
                Count = 0,
                Step = 1
            };
        }

    }
}
