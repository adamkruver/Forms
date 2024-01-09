using Sources.Presentation.Interfaces.Views;
using UnityEngine;

namespace Sources.Presentation.Implementation.Views
{
    public class ContainerView : MonoBehaviour
    {
        public void AppendChild(IView formView) => 
            formView.SetParent(transform);
    }
}