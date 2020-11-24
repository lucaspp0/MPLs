namespace MPL.model
{
    public class TransportadorPrivada : ABaseModel
  {
      private bool prioridadeEspecializada;
      public bool PrioridadeEspecializada
      {
          get { return prioridadeEspecializada; }
          set { prioridadeEspecializada = value; }
      }

      public TransportadorPrivada(){

      }

      public TransportadorPrivada(bool prioridadeEspecializada){
          this.PrioridadeEspecializada = prioridadeEspecializada;
      }
      
         
  }
}