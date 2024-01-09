using System;
using Sources.Infrastructure.Interfaces.Services;
using Sources.Presentation.Implementation.Views.Forms;
using Sources.Presentation.Interfaces.Views.Forms;
using UnityEngine;

namespace Sources.Controllers.Implementation
{
    public class MainMenuPresenter : PresenterBase
    {
        private readonly IMainMenuFormView _view;
        private readonly IFormService _formService;

        public MainMenuPresenter(IMainMenuFormView view, IFormService formService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public override void Enable()
        {
            _view.AboutButton.AddClickListener(OnAboutButtonClick);
            _view.OptionsButton.AddClickListener(OnOptionsButtonClick);
        }

        public override void Disable()
        {
            _view.AboutButton.RemoveClickListener(OnAboutButtonClick);
            _view.OptionsButton.RemoveClickListener(OnOptionsButtonClick);
        }

        private void OnAboutButtonClick()
        {
            // _formService.Show<AboutFormView>();
            _formService.Show(nameof(AboutFormView));
        }

        private void OnOptionsButtonClick() => 
            _formService.Show<OptionsFormView>();
    }
}