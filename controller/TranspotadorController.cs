using System.Collections.Generic;

using MPL.View;
using MPL.model;
using MPL.repository;
using System.Threading.Tasks;

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