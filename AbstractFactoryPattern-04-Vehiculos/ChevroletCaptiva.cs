namespace AbstractFactoryPattern_04_Vehiculos
{
    class ChevroletCaptiva : Vehiculo, IGamaMedia
    {
        public ChevroletCaptiva()
        {
            this.Gama = "Media";
            this.Nombre = "Chevrolet Captiva";
            this.Precio = "26999";
            this.Descripcion = $"Un muy buen rendimiento y la mejor calidad-precio";
        }
    }
}