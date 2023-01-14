namespace Geometry_Output;

public partial class Keys
{
    public static string ApiKey = SecretKeys.ApiKey is null ? "" : SecretKeys.ApiKey;
}