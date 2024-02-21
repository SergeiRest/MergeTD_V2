using _Scripts.Grid;
using UnityEngine;
using Zenject;

namespace _Scripts.Installers
{
    public class GridInstaller : MonoInstaller
    {
        [SerializeField] private GridTemplate _gridTemplate;
        
        public override void InstallBindings()
        {
            Container.Bind<IGrid>().To<PlayerGrid>().FromNew().AsSingle().WithArguments(_gridTemplate).NonLazy();
        }
    }
}