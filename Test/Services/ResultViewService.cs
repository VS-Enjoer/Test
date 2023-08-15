namespace Test.Services
{
    public interface IResultViewService
    {
        string FormatResult(string result);
    }

    public class ResultViewService : IResultViewService
    {
        public string FormatResult(string result)
        {

            return result;
        }
    }
}
