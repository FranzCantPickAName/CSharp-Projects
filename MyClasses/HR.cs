
namespace HR
{

    namespace Mgr
    {

        public interface IManager : IEmployee
        {

        }

        public class Manager : IManager
        {

        }

        public class AsstManager : IManager
        {

        }


    }

    public interface IEmployee
    {
    }

    public interface IExecutive : IEmployee
    {

    }

    
    public class Executive : IExecutive
    {

    }
}
