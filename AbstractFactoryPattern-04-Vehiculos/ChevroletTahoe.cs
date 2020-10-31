namespace AbstractFactoryPattern_04_Vehiculos
{
    class ChevroletTahoe : Vehiculo, IGamaAlta
    {
        public ChevroletTahoe()
        {
            this.Gama = "Alta";
            this.Nombre = "Chevrolet Tahoe";
            this.Precio = "89999";
            this.Descripcion = $"El mas potente del mercado, 400 caballos de fuerza.";
        }
    }
}