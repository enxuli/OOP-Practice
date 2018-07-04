using NUnit.Framework;
using System;
using Zenject;
using HW2.DI;

namespace HW2.UnitTesting
{

    public class TesterDIInstaller : BindingInstaller 
    {
        public override void Bind()
        {
            
            Container.Bind<KeyDI>().AsSingle();
            Container.Bind<HouseDI>().AsSingle();
            Container.Bind<DoorDI>().AsSingle();
            Container.Bind<KnobDI>().AsSingle();
            Container.Bind<KeyholdDI>().AsSingle();


            ContainerBindInterfaceTo<IKeyDI, KeyDI>(true);
            ContainerBindInterfaceTo<IHouseDI, HouseDI>(true);

            Container.Bind<IDoorDI>().WithId("newDoor").To<DoorDI>().AsTransient();
            Container.Bind<IKnobDI>().WithId("newKnob").To<KnobDI>().AsTransient();
            Container.Bind<IKeyholdDI>().WithId("newKeyhold").To<KeyholdDI>().AsTransient();

            Container.Bind<IDoorDI>().To<DoorDI>().AsSingle();
            Container.Bind<IKnobDI>().To<KnobDI>().AsSingle();
            Container.Bind<IKeyholdDI>().To<KeyholdDI>().AsSingle();   

            Container.Bind<int>().FromInstance(1).WhenInjectedInto<KeyDI>();
            Container.Bind<int>().FromInstance(1).WhenInjectedInto<KeyholdDI>();

        }
    }
}
