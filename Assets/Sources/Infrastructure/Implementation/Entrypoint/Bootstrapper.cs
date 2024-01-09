using Sources.Controllers.Implementation;
using Sources.Infrastructure.Implementation.Factories;
using Sources.Infrastructure.Implementation.Services;
using Sources.Presentation.Implementation.Views;
using Sources.Presentation.Implementation.Views.Forms;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private ContainerView _containerView;

    private void Awake()
    {
        var formService = new FormService(_containerView);
        var prefabFactory = new PrefabFactory();

        var mainMenuForm = new Form<MainMenuFormView, MainMenuPresenter>(
            view => new MainMenuPresenter(view, formService),
            prefabFactory
        );

        var optionsForm = new Form<OptionsFormView, OptionsPresenter>(
            view => new OptionsPresenter(view, formService),
            prefabFactory
        );

        var aboutForm = new Form<AboutFormView, AboutPresenter>(
            view => new AboutPresenter(view, formService),
            prefabFactory
        );

        formService.Add(mainMenuForm);
        formService.Add(optionsForm);
        formService.Add(aboutForm);

        formService.Show<MainMenuFormView>();
    }
}