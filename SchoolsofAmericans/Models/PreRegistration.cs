﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolsofAmericans.Models
{
    /// <summary>
    /// Pre Regisrtation model
    /// </summary>
    /// <seealso cref="Object" />
    public class PreRegistration
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
          
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the name of the school.
        /// </summary>
        /// <value>
        /// The name of the school.
        /// </value>
        [Required]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }
        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        [Required]
        [Display(Name = "Email ID")]
        public string EmailId { get; set; }
    }
}
