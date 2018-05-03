namespace flydubai.DatabaseServices
{
    using System;
    using System.Linq;
    using System.Data.Entity;

    using flydubai.Common.Contracts.DatabaseServices;
    using flydubai.Model;
    using flydubai.Model.Profiles;

    /// <summary>
    /// Service to retrieve and save the sign up preferences into the database
    /// </summary>
    /// <remarks></remarks>
    public class SignUpPreferencesDatabaseService : ISignUpPreferencesDatabaseService
    {
        private readonly IRepository context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpPreferencesDatabaseService"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <remarks></remarks>
        public SignUpPreferencesDatabaseService(IRepository context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The preferences</returns>
        /// <remarks></remarks>
        public SignUpPreferences Get(int id)
        {
            return this.context.Find<SignUpPreferences>(id);
        }

        /// <summary>
        /// Gets the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>The preferences</returns>
        /// <remarks></remarks>
        public SignUpPreferences Get(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(email);
            }

            return this.context.AsQueryableWithTracking<SignUpPreferences>().Include(x => x.Country).SingleOrDefault(x => x.Email == email);
        }

        /// <summary>
        /// Saves the specified preferences.
        /// </summary>
        /// <param name="preferences">The preferences.</param>
        /// <remarks></remarks>
        public void Save(SignUpPreferences preferences)
        {
            if (this.context.Find<SignUpPreferences>(preferences.SignUpPreferencesId) == null)
            {
                this.context.Add(preferences);
            }

            this.context.SaveChanges();
        }

        /// <summary>
        /// Deletes the specified preferences.
        /// </summary>
        /// <param name="preferences">The preferences.</param>
        /// <remarks></remarks>
        public void Delete(SignUpPreferences preferences)
        {
            this.context.Delete(preferences);
        }
    }
}