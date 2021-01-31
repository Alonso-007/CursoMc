using System.Collections.Generic;

namespace CursoMc.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public ICollection<Categoria> Categorias { get; set; }

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + Id.GetHashCode();
            return result;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;

            Produto other = (Produto)obj;
            if (Id == 0)
            {
                if (other.Id != 0)
                {
                    return false;
                }
                else if (!Id.Equals(other.Id))
                {
                    return false;
                }
            }
            return true;
        }
    }
}