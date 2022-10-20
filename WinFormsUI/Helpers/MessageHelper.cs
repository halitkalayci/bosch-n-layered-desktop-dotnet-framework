using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI.Helpers
{
    public class MessageHelper
    {
        public static void ShowSuccessMessage(string message)
        {
            SuccessForm successForm = new SuccessForm(message);
            successForm.ShowDialog();
        }

        public static void ShowErrorMessage(string message)
        {
            ErrorForm errorForm = new ErrorForm(message);
            errorForm.ShowDialog();
        }
    }
}
