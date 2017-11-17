using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace XamarinApp.CoreClasses
{
	public class WebRequestMaker
	{
		public string Url { get; set; }
		public Object DataToSent { get; set; }
		public SupportedWebMethods WebMethod { get; set; }
		public SupportedDataTypes ResponseDataType { get; set; }
		public SupportedDataTypes RequestDataType { get; set; }
		public delegate void ResponseHandler(Object ResponseData);
		public event ResponseHandler OnResponseRecived;
		public WebRequestMaker()
		{
			Url = string.Empty;
			DataToSent = null;
			WebMethod = SupportedWebMethods.GET;
			ResponseDataType = SupportedDataTypes.String;
			RequestDataType = SupportedDataTypes.String;
		}
		public void MakeARequest()
		{
			try
			{
				if ((this.Url != null && this.Url.Trim().Length > 0))
				{
					WebClient _client = new WebClient();
					_client.BaseAddress = Url;
					if (this.WebMethod == SupportedWebMethods.GET)
					{
						_client.DownloadDataAsync(new Uri(this.Url));
						_client.DownloadDataCompleted += _client_DownloadDataCompleted;
					}
					else if (this.WebMethod == SupportedWebMethods.POST && DataToSent != null)
					{
						if (this.RequestDataType == SupportedDataTypes.String)
						{
							_client.UploadDataAsync(new Uri(this.Url), System.Text.Encoding.ASCII.GetBytes(DataToSent.ToString()));
							_client.UploadDataCompleted += _client_UploadDataCompleted;
						}
						else if (this.RequestDataType == SupportedDataTypes.DataBytes)
						{
							_client.UploadDataAsync(new Uri(this.Url), System.Text.Encoding.ASCII.GetBytes(DataToSent.ToString()));
							_client.UploadDataCompleted += _client_UploadDataCompleted;
						}
					}
				}
			}
			catch (Exception ex)
			{
				CommonFunctions.ReportError(ex);
			}
		}
		private void _client_UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
		{
			try
			{
				if (e.Error == null)
				{
					if (e.Result != null && e.Result.Length > 0)
					{
						if (this.ResponseDataType == SupportedDataTypes.String)
						{
							string Response = System.Text.Encoding.ASCII.GetString(e.Result);
							OnResponseRecived(Response);
						}
						if (this.ResponseDataType == SupportedDataTypes.DataBytes)
						{
							OnResponseRecived(e.Result);
						}
					}
				}
				else
					OnResponseRecived(e.Error);
			}
			catch (Exception ex)
			{
				CommonFunctions.ReportError(ex);
			}
		}
		private void _client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
		{
			try
			{
				if (e.Error == null)
				{
					if (e.Result != null && e.Result.Length > 0)
					{
						if (this.ResponseDataType == SupportedDataTypes.String)
						{
							string Response = System.Text.Encoding.ASCII.GetString(e.Result);
							OnResponseRecived(Response);
						}
						if (this.ResponseDataType == SupportedDataTypes.DataBytes)
						{
							OnResponseRecived(e.Result);
						}
					}
				}
				else
					OnResponseRecived(e.Error);
			}
			catch (Exception ex)
			{
				CommonFunctions.ReportError(ex);
			}
		}
	}
}
