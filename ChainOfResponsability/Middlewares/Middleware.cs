namespace ChainOfResponsability.Midllewares
{
    public abstract class Middleware
    {
        private Middleware next;

        public Middleware LinkWith(Middleware next)
        {
            this.next = next;

            return next;
        }

        public abstract Boolean Check(string email, string password);

        public Boolean CheckNext(string email, string password)
        {
            if (next is null)
                return true;

            return Check(email, password);
        }
    }
}
