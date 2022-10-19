namespace UnitTestingPlatformSpecific.CustomControls.Entries;

public partial class CustomEntry
{
    protected override partial void OnPropertyChanged(string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        //add custom code
    }
}
