using System;
using System.Collections.Generic;
using System.Linq;
using Sources.Infrastructure.Interfaces.Services;
using Sources.Presentation.Implementation.Views;
using Sources.Presentation.Interfaces.Views;

namespace Sources.Infrastructure.Implementation.Services
{
    public class FormService : IFormService
    {
        private readonly ContainerView _container;
        private readonly Dictionary<string, IForm> _forms = new Dictionary<string, IForm>();

        public FormService(ContainerView container) => 
            _container = container ? container : throw new ArgumentNullException(nameof(container));

        public void Add(IForm form, string? name = null)
        {
            _container.AppendChild(form); 
            _forms.Add(name ?? form.Name, form);
            form.Hide();
        }

        public void Show<T>() where T : IFormView
        {
            Show(typeof(T).Name);
        }
        
        public void Show(string name)
        {
            if(_forms.ContainsKey(name) == false)
                return;
            
            var activeForm = _forms[name];
            
            _forms.Values
                .Except(new List<IForm>() { activeForm })
                .ToList()
                .ForEach(form => form.Hide());
            
            activeForm.Show();
        }

        public void Hide<T>() where T : IFormView
        {
            var name = typeof(T).Name;
            
            if(_forms.ContainsKey(name) == false)
                return;
            
            var activeForm = _forms[name];
            
            activeForm.Hide();
        }
    }
}