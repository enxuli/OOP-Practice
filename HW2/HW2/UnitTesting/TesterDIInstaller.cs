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

            Container.Bind<IDoorDI>().To<DoorDI>().AsTransient().WhenInjectedInto<HouseDI>();

            ContainerBindInterfaceTo<IKeyDI, KeyDI>(true);
            ContainerBindInterfaceTo<IHouseDI, HouseDI>(false);
            ContainerBindInterfaceTo<IKeyholdDI, KeyholdDI>(true);
            ContainerBindInterfaceTo<IOpener, Opener>(true);

            Container.Bind<IKnobDI>().WithId("KnobWithKey").To<KnobKeyDI>().AsTransient();
            Container.Bind<IKnobDI>().WithId("KnobWithPwd").To<KnobPwdDI>().AsTransient();

            Container.Bind<int>().FromInstance(1).WhenInjectedInto<KeyDI>();
            Container.Bind<int>().FromInstance(1).WhenInjectedInto<KeyholdDI>();
            Container.Bind<string>().FromInstance("12345").WhenInjectedInto<KnobPwdDI>();
            Container.Bind<string>().FromInstance("12345").WhenInjectedInto<Opener>();
        }
    }
}
