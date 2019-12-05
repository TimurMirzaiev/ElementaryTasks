namespace Tasks.Interfaces
{
    public interface IParserArguments
    {
        public bool IsValid(string[] args, bool skipFirstArgument = false);
    }
}
