using MPL.utils;
using Xunit;

namespace MPL.teste.util
{
  public class jsonUtilTest
  {
      public class UnitTestClass{
        public string Name { get; set; }
        public string Description { get; set; }

        public static UnitTestClass Build(){
          UnitTestClass obj = new UnitTestClass();
          obj.Name = "Test";
          obj.Description = "Test Description";
          return obj;
        }

        public bool Equals(UnitTestClass obj)
        {
          return obj.Name == this.Name && obj.Description == this.Description;
        }
      }

      [Fact]
      public  void ShouldBeSerializeObject()
      {
        string objSerialized = JsonUtil<UnitTestClass>.Serialize(UnitTestClass.Build());
        string expectedResult = "{\"Name\":\"Test\",\"Description\":\"Test Description\"}";
        Assert.Equal(expectedResult, objSerialized);
      }

      [Fact]
      public  void ShouldBeDeserializeObject()
      {
        UnitTestClass obj = UnitTestClass.Build();
        string objSerialized = JsonUtil<UnitTestClass>.Serialize(obj);
        UnitTestClass objDeserialized = JsonUtil<UnitTestClass>.Deserialize(objSerialized);

        Assert.True(obj.Equals(objDeserialized));
      }
  }
}