namespace AbstractFactoryPattern_04_Vehiculos
{
    class HyundaiAccent : Vehiculo, IGamaBaja
    {
        public HyundaiAccent()
        {
            this.Gama = "Baja";
            this.Nombre = "Hyundai Accent";
            this.Precio = "12999";
            this.Descripcion = $"El mas básico del mercado, apenas lleva 4 personas.";
        }
    }
}