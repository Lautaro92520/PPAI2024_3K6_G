namespace PPAIDSI.Dominio
{
    public class Reseña
    {
        private string comentario { get; set; }
        private string esPremium { get; set; }
        private DateTime fechaReseña { get; set; }
        private int puntaje { get; set; }
        private Vino vino { get; set; }
        private Enofilo enofilo { get; set; }
        private Sommelier sommelier { get; set; }

        public bool sosDePeriodo(DateTime desde, DateTime hasta)
        {
            return this.fechaReseña > desde && this.fechaReseña < hasta;
        }

        public bool sosDeSommelier()
        {
            return this.sommelier != null;
        }

        public int getPuntaje()
        {
            return this.puntaje;
        }
    }
}