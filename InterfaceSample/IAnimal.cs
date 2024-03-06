namespace InterfaceSample
{
    public interface IAnimal : ILivingEntity
    {
        void MakeSound();
        AnimalType Type { get; }
        string Name { get; }
    }
}
