using Sources.Controllers.Implementation;
using Sources.Presentation.Interfaces.Views;
using Sources.Presentation.Interfaces.Views.Forms;
using UnityEngine;

namespace Sources.Presentation.Implementation.Views.Forms
{
    public class OptionsFormView : FormBase<OptionsPresenter>, IOptionsFormView
    {
        [SerializeField] private ButtonView _backButton;

        public IButtonView BackButton => _backButton;
    }
}