using System.Collections.Generic;

using MPL.View;
using MPL.model;
using MPL.repository;


namespace MPL.controller
{
  public class TranspotadorController
  {
      ITransportadorRepository _ITransportadorRepository;
      public TranspotadorController(ITransportadorRepository ITransportadorRepository ){
        _ITransportadorRepository = ITransportadorRepository;
      }

  }
}
