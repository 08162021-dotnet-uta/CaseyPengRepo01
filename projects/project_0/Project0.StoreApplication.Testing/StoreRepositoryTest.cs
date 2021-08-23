using Project0.StoreApplication.Storage.Repositories;
using Xunit;

namespace Project0.StoreApplication.Testing
{
  public class StoreRepositoryTests
  {
    [Fact]
    public void Test_StoreCollection()
    {
      var sut = new StoreRepository();
      var actual = sut.Stores;

      Assert.NotNull(actual);
    }
  }
}
