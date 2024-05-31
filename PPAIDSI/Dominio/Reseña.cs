namespace PPAIDSI.Dominio
{
    public class Reseña
    {
        private string comentario { get; set; }
        private bool esPremium { get; set; }
        private DateTime fechaReseña { get; set; }
        private int puntaje { get; set; }
        private Vino vino { get; set; }
        private Enofilo enofilo { get; set; }
        private Sommelier sommelier { get; set; }

        public Reseña(string comentario, bool esPremium, DateTime fecha, int puntaje, Sommelier sommelier)
        {
            this.comentario = comentario;
            this.esPremium = esPremium;
            this.fechaReseña = fecha;
            this.puntaje = puntaje;
            this.sommelier = sommelier;
        }


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