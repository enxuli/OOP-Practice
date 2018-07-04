using System;
namespace HW2.NonDI
{
    public class House 
    {
        protected Door _door;

        public House()
        {
        }

        public Door InstallDoor()
        {
            _door = new Door();

            return _door;
        }

        public Door Door
        {
            get
            {
                return _door;
            }
        }
    }
}
