namespace flydubai.DatabaseServices
{
    using flydubai.Model.Profiles;

    /// <summary>
    /// Interface for SignUpPreferencesDatabaseService
    /// </summary>
    /// <remarks></remarks>
    public interface ISignUpPreferencesDatabaseService
    {
        SignUpPreferences Get(int id);

        SignUpPreferences Get(string email);

        void Save(SignUpPreferences preferences);

        void Delete(SignUpPreferences preferences);
    }
}
