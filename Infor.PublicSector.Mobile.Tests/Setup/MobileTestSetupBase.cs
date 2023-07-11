namespace Infor.PublicSector.Mobile.Tests.Setup;

/// <summary>
/// Class that does initial setup for all the tests
/// </summary>
public class MobileTestSetupBase
    : IDisposable
{
    #region Constructor

    /// <summary>
    /// Constructor to initialize the class
    /// </summary>
    public MobileTestSetupBase()
    {
        // One time setup for all tests
    }

    #endregion

    #region Cleanup

    public void Dispose()
    {
        // One time cleanup for all tests
    }

    #endregion
}
