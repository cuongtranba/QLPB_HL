using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace _4.Helper
{
    public class ValidationModel
    {
        public bool IsValid { get; set; }
        public List<ValidationResult> ErrorMessages { get; set; }

        public string AllErrorMessage
        {
            get { return string.Join(Environment.NewLine, ErrorMessages.Select(c => c.ErrorMessage)); }
        }

        public ValidationModel()
        {
            ErrorMessages=new List<ValidationResult>();
        }
    }
}
