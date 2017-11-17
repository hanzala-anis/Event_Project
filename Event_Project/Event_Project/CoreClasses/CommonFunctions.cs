using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace XamarinApp.CoreClasses
{
	public class CommonFunctions
	{
		private static void WriteLog(Exception ex)
		{
			string Content = string.Empty;
			Content += "Date And Time :" + DateTime.Now.ToString() + " \r\n";
			Content += "Error : " + ex.Message + "\r\n";
			Content += ex.StackTrace != null ? "StackTrace: " + ex.StackTrace + "\r\n" : "";
			if (ex.InnerException != null)
			{
				Content += "Inner Exception : " + ex.InnerException + "\r\n";
			}
			Content += "\r\n\r\n";
			Console.Write(Content);
		}
		public static void ReportError(Exception ex)
		{
			WriteLog(ex);
		}
		public static bool IsValidEmail(string strIn)
		{
			// Return true if strIn is in valid e-mail format. 
			return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
		}
		public static string ConvertFromBase64String(string data)
		{
			string result = "";
			try
			{
				byte[] decoded_byte = Convert.FromBase64String(data);
				result = ASCIIEncoding.ASCII.GetString(decoded_byte);
				return result;
			}
			catch (Exception e)
			{
				ReportError(e);
			}
			return result;
		}
		public static string ConvertToBase64String(string data)
		{
			string returnValue = "";
			try
			{
				byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(data);
				returnValue = Convert.ToBase64String(toEncodeAsBytes);
				return returnValue;
			}
			catch (Exception e)
			{
				ReportError(e);
			}
			return returnValue;
		}
		public static void WriteCustomLog(string Message, string CustomFileName = "")
		{
			try
			{
				string Content = string.Empty;
				Content = "Date And Time :" + DateTime.Now.ToString() + " \r\n" +
									"Message : " + Message + "\r\n";
				Content += "\r\n\r\n";
				Console.Write(Content);
			}
			catch (Exception ex)
			{
				ReportError(ex);
			}
		}
	}
}
