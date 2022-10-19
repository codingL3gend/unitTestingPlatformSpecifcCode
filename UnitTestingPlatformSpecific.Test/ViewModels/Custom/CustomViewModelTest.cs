using UnitTestingPlatformSpecific.ViewModels.Custom;

namespace UnitTestingPlatformSpecific.Test.ViewModels.Custom;

public class CustomViewModelTest
{
    CustomViewModel customViewModel;

    [Fact]
    [Trait("Category", "Unit")]
    public void TestMeTest()
    {
        customViewModel = new CustomViewModel();

        customViewModel.TestMe();
    }
}
