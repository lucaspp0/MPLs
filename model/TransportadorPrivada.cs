namespace MPL.model
{
    class TransportadorPrivada : ABaseModel
  {
      private bool prioridadeEspecializada;
      public bool PrioridadeEspecializada
      {
          get { return prioridadeEspecializada; }
          set { prioridadeEspecializada = value; }
      }
         
  }
}