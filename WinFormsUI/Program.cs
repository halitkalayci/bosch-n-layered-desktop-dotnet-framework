using Core.Exceptions;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Helpers;

namespace WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Global Exception Handling
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            //
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // Gelen exceptiona göre davranışlar..
            // Backlog: switch yapısına çevirilecek.
            if (e.Exception is CustomValidationException)
            {
                HandleValidationException(e);
                return;
            }
            if (e.Exception is BusinessException)
            {
                HandleBusinessException(e);
                return;
            }
            MessageBox.Show("Bilinmedik hata", "Sistem");
        }

        private static void HandleBusinessException(ThreadExceptionEventArgs e)
        {
            var businessException = (BusinessException)e.Exception;
            // MessageHelper.ShowErrorMessage();
            //MessageBox.Show(businessException.ToString());
            ErrorForm errorForm = new ErrorForm(businessException.ToString());
            errorForm.ShowDialog();
        }

        // Custom Exception Class: İçindeki erroları mesaj olarak alt alta döndürsün.
        private static void HandleValidationException(ThreadExceptionEventArgs e)
        {
            var validationError = (CustomValidationException)e.Exception;
            ErrorForm errorForm = new ErrorForm(validationError.ToString());
            errorForm.ShowDialog();
        }
    }
}
