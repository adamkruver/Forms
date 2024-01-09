using Sources.Controllers.Implementation;
using Sources.Presentation.Implementation.Views;
using Sources.Presentation.Implementation.Views.Forms;
using Sources.Presentation.Interfaces.Views;
using Sources.Presentation.Interfaces.Views.Forms;
using UnityEngine;

public class MainMenuFormView : FormBase<MainMenuPresenter>, IMainMenuFormView
{
    [SerializeField] private ButtonView _optionsButton;
    [SerializeField] private ButtonView _aboutButton;

    public IButtonView OptionsButton => _optionsButton;
    public IButtonView AboutButton => _aboutButton;
}