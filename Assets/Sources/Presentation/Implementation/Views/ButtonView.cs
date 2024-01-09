using Sources.Presentation.Interfaces.Views;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sources.Presentation.Implementation.Views
{
    public class ButtonView : MonoBehaviour, IButtonView
    {
        [SerializeField] private Button _button;
        
        public void AddClickListener(UnityAction onClick) => 
            _button.onClick.AddListener(onClick);

        public void RemoveClickListener(UnityAction onClick) => 
            _button.onClick.RemoveListener(onClick);
    }
}