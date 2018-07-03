using NUnit.Framework;
using System;
using Zenject;

namespace HW.UnitTesting
{

    public class TesterInstaller : BindingInstaller 
    {
        public override void Bind()
        {
            
            Container.Bind<Iphone>().AsSingle();
            Container.Bind<Building>().AsSingle();
            Container.Bind<DPGen>().AsSingle();
            Container.Bind<DPTable>().AsSingle();
            Container.Bind<DPTable.DPTableFactory>().AsSingle();


            ContainerBindInterfaceTo<IIphoneCountable, Iphone>(true);
            ContainerBindInterfaceTo<IFloorCountable, Building>(true);
            ContainerBindInterfaceTo<IAlgoSettable, DPGen>(true);
            ContainerBindInterfaceTo<IDPTable, DPTable>(true);
            ContainerBindInterfaceTo<IDPTableFactory, DPTable.DPTableFactory>(true);



            Container.Bind<int>().FromInstance(3).WhenInjectedInto<Iphone>();
            Container.Bind<int>().FromInstance(100).WhenInjectedInto<Building>();

        }
    }
}
