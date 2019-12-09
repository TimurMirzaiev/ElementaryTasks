namespace _6_HappyTickets.HappyTicketsCore.Model
{
    public class Symbol<T>
    {
        public T Data { get; set; }
        public bool isEven { get; set; }

        public Symbol(T data)
        {
            Data = data;
        }
    }
}
