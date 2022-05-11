namespace SimpleSign.Models
{
    public class AssinaturaModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }

        public AssinaturaModel()
        {
        }

        public AssinaturaModel(int id, string usuario)
        {
            Id = id;
            Usuario = usuario;
        }
    }    
}
