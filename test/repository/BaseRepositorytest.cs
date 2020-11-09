using System;
using Xunit;

namespace MPL.teste.repository
{
  public class BaseRepositoryTeste
  {
      [Fact]
      public void ShouldSaveFile()
      {
          bool test = true;
          Assert.Equal(true, test);
      }
  }
}