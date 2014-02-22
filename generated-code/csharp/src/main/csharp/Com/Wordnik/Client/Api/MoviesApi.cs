  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class MoviesApi {
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
      /// Get a recordset of movies based on a query parameter Use a plus sign between words in titles with multiple words
      /// </summary>
      /// <param name="q">Movie name as a string</param>
      /// <returns></returns>
      public Movies getMovies (string q) {
        // create path and map variables
        var path = "/movies".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (q == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (q != null){
          paramStr = (q != null && q is DateTime) ? ((DateTime)(object)q).ToString("u") : Convert.ToString(q);
          queryParams.Add("q", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Movies) ApiInvoker.deserialize(response, typeof(Movies));
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
