using UnityEngine;

namespace Sources.Presentation.Interfaces.Views
{
    public interface IView
    {
        void Show();
        void Hide();
        void SetParent(Transform transform);
    }
}