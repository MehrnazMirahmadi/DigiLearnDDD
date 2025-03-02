namespace DigiLearn.Shared.Abstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get;protected set; }
        public int Version { get; protected set; }

        private bool _isIncremented;

        protected void IncrementVersion()
        {
            if (_isIncremented) return;

            Version++;
            _isIncremented = true;
        }

        private List<IDomanEvent> _events = new();
        public IEnumerable<IDomanEvent> Events => _events;

        protected void RaiseDomainEvent(IDomanEvent @event)
        {
            if (!_events.Any() && !_isIncremented)
            {
                Version++;
                _isIncremented = true;
            }
            _events.Add(@event);
        }
    }
}
