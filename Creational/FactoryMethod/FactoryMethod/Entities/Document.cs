namespace FactoryMethod.Entities
{
    public abstract class Document
    {
        public Document(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
