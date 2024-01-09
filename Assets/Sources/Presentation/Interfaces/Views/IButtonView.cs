using UnityEngine.Events;

namespace Sources.Presentation.Interfaces.Views
{
    public interface IButtonView
    {
        void AddClickListener(UnityAction onClick);
        void RemoveClickListener(UnityAction onClick);
    }
}