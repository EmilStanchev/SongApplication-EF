using Services.PrintInterfaces;

namespace Services.HelpingClasses
{
    public class Print : IPrintMessage
    {
        public string Message(int option)
        {
            if (option == 0)
            {
                return "Failed";
            }
            else
            {
                return "Success";
            }
        }
        public string CheckingNullMessage(IEnumerable<Object> objects)
        {
            if (objects == null)
            {
                return "Failed";
            }
            else
            {
                return "Success";
            }
        }
        public string CheckNullMessageForSingleItem(Object item)
        {
            if (item == null)
            {
                return "Invalid song id";
            }
            else
            {
                return "Success";
            }
        }
    }
}
