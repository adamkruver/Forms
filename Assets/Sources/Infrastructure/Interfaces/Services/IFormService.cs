using Sources.Presentation.Interfaces.Views;

namespace Sources.Infrastructure.Interfaces.Services
{
    public interface IFormService
    {
        void Show<T>() where T : IFormView;
        void Show(string formName);
        void Hide<T>() where T : IFormView;
    }
}