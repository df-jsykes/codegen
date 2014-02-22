  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class EmailApi {
      string basePath = "https://next.cloud.dreamfactory.com/rest";
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }
      
      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }
      
      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      /// sendEmail() - Send an email created from posted data and/or a template. If a template is not used with all required fields, then they must be included in the request. If the 'from' address is not provisioned in the service, then it must be included in the request.
      /// </summary>
      /// <param name="template">Optional template name to base email on.</param>
      /// <param name="template_id">Optional template id to base email on.</param>
      /// <param name="body">Data containing name-value pairs used for provisioning emails.</param>
      /// <returns></returns>
      public EmailResponse sendEmail (string template, integer template_id, EmailRequest body) {
        // create path and map variables
        var path = "/email".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (template != null){
          paramStr = (template != null && template is DateTime) ? ((DateTime)(object)template).ToString("u") : Convert.ToString(template);
          queryParams.Add("template", paramStr);
		}
        if (template_id != null){
          paramStr = (template_id != null && template_id is DateTime) ? ((DateTime)(object)template_id).ToString("u") : Convert.ToString(template_id);
          queryParams.Add("template_id", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (EmailResponse) ApiInvoker.deserialize(response, typeof(EmailResponse));
          }
          else {
            return null;
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
