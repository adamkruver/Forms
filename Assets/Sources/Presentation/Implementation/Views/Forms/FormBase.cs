using Sources.Controllers.Interfaces;
using Sources.Presentation.Interfaces.Views;
using UnityEngine;

namespace Sources.Presentation.Implementation.Views.Forms
{
    public abstract class FormBase<T> : PresentableView<T>, IFormView where T : IPresenter
    {
    }
}