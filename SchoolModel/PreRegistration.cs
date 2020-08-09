using System;

namespace SchoolModel
{
    /// <summary>
    /// Pre Regisrtation model
    /// </summary>
    /// <seealso cref="Object" />
    public class PreRegistrationModel
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the name of the school.
        /// </summary>
        /// <value>
        /// The name of the school.
        /// </value>
  
        public string SchoolName { get; set; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
 
        public string EmailId { get; set; }
    }
}
