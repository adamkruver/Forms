using System;
using Sources.Infrastructure.Interfaces.Services;
using Sources.Presentation.Interfaces.Views.Forms;

namespace Sources.Controllers.Implementation
{
    public class AboutPresenter : PresenterBase
    {
        private readonly IAboutFormView _aboutFormView;
        private readonly IFormService _formService;

        public AboutPresenter(IAboutFormView aboutFormView, IFormService formService)
        {
            _aboutFormView = aboutFormView ?? throw new ArgumentNullException(nameof(aboutFormView));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public override void Enable() =>
            _aboutFormView.BackButton.AddClickListener(OnBackButtonClick);

        public override void Disable() =>
            _aboutFormView.BackButton.RemoveClickListener(OnBackButtonClick);

        private void OnBackButtonClick() =>
            _formService.Show<MainMenuFormView>();
    }
}