namespace AbstractFactoryPattern_04_Vehiculos
{
    class HyundaiSantaFe : Vehiculo, IGamaMedia
    {
        public HyundaiSantaFe()
        {
            this.Gama = "Media";
            this.Nombre = "Hyundai Santa Fe";
            this.Precio = "39000";
            this.Descripcion = $"3 filas de asientos y 220 caballos de fuerza.";
        }
    }
}