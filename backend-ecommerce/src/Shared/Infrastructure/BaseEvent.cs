namespace backend_ecommerce.src.Shared.Infrastructure
{
    public abstract class BaseEvent
    {
        public string Type { get; set; }

        protected BaseEvent(string type)
        {
            this.Type = type;
        }
    }
}
