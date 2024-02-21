using _Scripts.Grid;
using _Scripts.Input;
using Zenject;

namespace _Scripts.Installers
{
    public class InputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerInput>().AsSingle().NonLazy();

            Container.BindInterfacesAndSelfTo<PointerListener>().AsSingle();
        }
    }
}