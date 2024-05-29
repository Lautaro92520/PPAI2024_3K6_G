namespace PPAIDSI.Dominio
{
    public class Reseña
    {
        private int es_premium;
        private DateTime fecha;

        public Reseña(string? comentario, int es_premium, DateTime fecha, int puntaje)
        {
            this.comentario = comentario;
            this.es_premium = es_premium;
            this.fecha = fecha;
            this.puntaje = puntaje;
        }

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