using Sources.Controllers.Interfaces;
using Sources.Presentation.Interfaces.Views;
using UnityEngine;

namespace Sources.Presentation.Implementation.Views
{
    public abstract class PresentableView<T> : MonoBehaviour, IView where T : IPresenter
    {
        protected T Presenter { get; private set; }

        private void OnEnable()
        {
            Presenter?.Enable();
            OnAfterEnable();
        }

        private void OnDisable()
        {
            Presenter?.Disable();
            OnAfterDisable();
        }

        public void Construct(T presenter)
        {
            Hide();
            Presenter = presenter;
            Show();
        }

        public void Show() => 
            gameObject.SetActive(true);

        public void Hide() => 
            gameObject.SetActive(false);

        public void SetParent(Transform parent) =>
            transform.SetParent(parent, false);

        protected virtual void OnAfterEnable()
        {
        }

        protected virtual void OnAfterDisable()
        {
        }
    }
}