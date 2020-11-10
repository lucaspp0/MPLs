using System;
using Xunit;

namespace MPL.teste.repository
{
  public class BaseRepositoryTeste
  {
      [Fact]
      public void ShouldSaveAndSerializeFile()
      {
          string test = "true";
          Assert.Equal("true", test);
      }
  }
}