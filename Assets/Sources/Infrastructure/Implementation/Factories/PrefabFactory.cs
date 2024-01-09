using System.IO;
using Sources.Infrastructure.Interfaces.Factories;
using UnityEngine;

namespace Sources.Infrastructure.Implementation.Factories
{
    public class PrefabFactory : IViewFactory
    {
        public T Create<T>(string path) where T : MonoBehaviour =>
            Object.Instantiate(Resources.Load<T>(Path.Combine(path, typeof(T).Name)));
    }
}