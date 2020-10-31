namespace AbstractFactoryPattern_03_Phones
{
    class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: SamSung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}