using System;
using Sources.Infrastructure.Interfaces.Services;
using Sources.Presentation.Interfaces.Views.Forms;

namespace Sources.Controllers.Implementation
{
    public class OptionsPresenter : PresenterBase
    {
        private readonly IOptionsFormView _optionsFormView;
        private readonly IFormService _formService;

        public OptionsPresenter(IOptionsFormView optionsFormView, IFormService formService)
        {
            _optionsFormView = optionsFormView ?? throw new ArgumentNullException(nameof(optionsFormView));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public override void Enable() =>
            _optionsFormView.BackButton.AddClickListener(OnBackButtonClick);

        public override void Disable() =>
            _optionsFormView.BackButton.RemoveClickListener(OnBackButtonClick);

        private void OnBackButtonClick() =>
            _formService.Show<MainMenuFormView>();
    }
}