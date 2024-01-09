using System;
using Sources.Controllers.Interfaces;
using Sources.Infrastructure.Interfaces.Factories;
using Sources.Presentation.Implementation.Views.Forms;
using Sources.Presentation.Interfaces.Views;
using UnityEngine;

namespace Sources.Presentation.Implementation.Views
{
    public class Form<TFormView, T> : IForm
        where TFormView : FormBase<T>
        where T : IPresenter
    {
        private readonly TFormView _formView;
        private const string FormPath = "Views/Forms";

        public Form(Func<TFormView, T> presenterFactory, IViewFactory viewFactory)
        {
            if (presenterFactory == null)
                throw new ArgumentNullException(nameof(presenterFactory));

            if (viewFactory == null)
                throw new ArgumentNullException(nameof(viewFactory));

            _formView = viewFactory.Create<TFormView>(FormPath);
            T presenter = presenterFactory.Invoke(_formView);

            _formView.Construct(presenter);
            Name = _formView.GetType().Name;
        }

        public string Name { get; }
        
        public void Show() =>
            _formView.Show();

        public void Hide() =>
            _formView.Hide();

        public void SetParent(Transform parent) =>
            _formView.SetParent(parent);

    }
}