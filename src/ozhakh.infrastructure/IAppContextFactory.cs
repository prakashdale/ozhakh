using ozhakh.application;

namespace ozhakh.infrastructure
{
    public interface IAppContextFactory
    {
        IAppContext Create();
    }
}