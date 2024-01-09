using UnityEngine;

namespace Sources.Infrastructure.Interfaces.Factories
{
    public interface IViewFactory
    {
        T Create<T>(string path) where T : MonoBehaviour;
    }
}