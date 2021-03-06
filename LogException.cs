﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 class LogException
 {


     private string GetExceptionTypeStack(Exception e)
     {
         if (e.InnerException != null)
         {
             string message = "";
             message = GetExceptionTypeStack(e.InnerException);
             message = message + "   " + e.GetType().ToString();
             return message;
         }
         else
         {
             return "   " + e.GetType().ToString();
         }
     }

     private string GetExceptionMessageStack(Exception e)
     {
         if (e.InnerException != null)
         {
             string message = "";
             message = GetExceptionMessageStack(e.InnerException);
             message = message + "   " + e.Message;
             return message;
         }
         else
         {
             return "   " + e.Message;
         }
     }

     private string GetExceptionCallStack(Exception e)
     {
         if (e.InnerException != null)
         {
             string message = "";
             message = GetExceptionCallStack(e.InnerException);
             message = message + "--- Next Call Stack: ";
             message = message + e.StackTrace;
             return message;
         }
         else
         {
             return e.StackTrace;
         }
     }


     public string LogOfException(Exception exception)
     {
         string error = "";

         error = "Exception classes:   ";
         error = error + GetExceptionTypeStack(exception);
         error = error + " ";
         error = error + " Exception messages: ";
         error = error + GetExceptionMessageStack(exception);

         error = error + " ";
         error = error + " Stack Traces: ";
         error = error + GetExceptionCallStack(exception);

         return error;
     }

 }
 
