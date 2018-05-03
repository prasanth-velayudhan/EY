using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using flydubai.Model.Attributes;

namespace flydubai.Model
{
    /// <summary>
    /// Human
    /// </summary>
    [Serializable]
    public class Human
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        public Human()
        {
            this.Telephones = new List<Telephone>();
        }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Telephone> Telephones { get; set; }

        [Email(ErrorMessageResourceName = "Human.InvalidEmail")]
        public string Email { get; set; }
    }
}
