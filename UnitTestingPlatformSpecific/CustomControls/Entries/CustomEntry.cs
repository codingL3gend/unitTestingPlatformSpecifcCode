using System.Runtime.CompilerServices;

namespace UnitTestingPlatformSpecific.CustomControls.Entries;

public partial class CustomEntry : Entry
{
#if ANDROID || IOS
    protected override partial void OnPropertyChanged([CallerMemberName] string propertyName = null);
#endif
}
