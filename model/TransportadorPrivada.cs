namespace MPL.model
{
    class TransportadoraPrivada : Envio
  {
      private bool prioridadeEspecializada;
      public bool PrioridadeEspecializada
      {
          get { return prioridadeEspecializada; }
          set { prioridadeEspecializada = value; }
      }
      public TransportadoraPrivada(bool prioridadeEspecializada, float valorFreteGratis):base(valorFreteGratis){
          this.prioridadeEspecializada = prioridadeEspecializada;
      }
  }
}