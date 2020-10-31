namespace AbstractFactoryPattern_04_Vehiculos
{
    class ChevroletSparkGT : Vehiculo, IGamaBaja
    {
        public ChevroletSparkGT()
        {
            this.Gama = "Baja";
            this.Nombre = "Chevrolet Spark GT";
            this.Precio = "15999";
            this.Descripcion = $"Lo mas básico del mercado pero es mejor que antar a pata.";
        }
    }
}