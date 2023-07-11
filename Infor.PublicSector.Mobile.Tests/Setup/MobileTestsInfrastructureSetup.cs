namespace Infor.PublicSector.Mobile.Tests.Setup;

/// <summary>
/// Base class for setting up infrastructure stuff for all the tests in the solution
/// </summary>
[CollectionDefinition("Field Works Tests")]
public class MobileTestsInfrastructureSetup
    : ICollectionFixture<MobileTestSetupBase>
{
}
