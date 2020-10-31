namespace AbstractFactoryPattern_04_Vehiculos
{
    class HyundaiVeracruz : Vehiculo, IGamaAlta
    {
        public HyundaiVeracruz()
        {
            this.Gama = "Alta";
            this.Nombre = "Hyundai Veracruz";
            this.Precio = "95000";
            this.Descripcion = $"6 filas de asientos y 330 caballos de fuerza.";
        }
    }
}