using HouseModule.Prototype;

namespace HouseModule.Rooms
{
    public class Room : IHouseModule
    {
        public string Name { get; set; }
        public int Lenght { get; set; }
        public int Height { get; set; }
        public int Area { get => Lenght * Height; }

        public IHouseModule Clone()
        {
            // Apenas objetos de nivel superior são duplicados
            return (IHouseModule)MemberwiseClone();

            // Todos os objetos são duplicados
            // return (IHouseModule)this.Clone();
        }

        public string GetDetails()
        {
            return string.Format("Nome do cômodo: {0}\nComprimento: {1}\nAltura: {2}\nArea: {3}\n", Name, Lenght, Height, Area);
        }
    }
}
