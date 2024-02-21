using _Scripts.Data;
using _Scripts.Factories;
using UnityEngine;
using Zenject;

namespace _Scripts.Installers
{
    public class TowerFactoryInstaller : MonoInstaller
    {
        [SerializeField] private TowersData _towersData;
        
        public override void InstallBindings()
        {
            Container.Bind<TowersData>().FromInstance(_towersData);
            Container.Bind<ITowerFactory>().To<TowerFactory>().FromNew().AsSingle().NonLazy();
        }
    }
}