namespace AbstractFactoryConsola.Classes
{
    //Clase abstracta pizza, en este punto no se conoce que tipo de pizza va a ser.
    public abstract class Pizzab
    {
        protected string _descripcion;
        //Objeto público que tomará una descripción dependiendo del tipo de pizza que se va a hacer.
        public object Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}
