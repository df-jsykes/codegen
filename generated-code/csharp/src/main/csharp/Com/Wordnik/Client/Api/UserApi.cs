  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class UserApi {
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
      /// getResources() - List resources available for user session management. See listed operations for each resource available.
      /// </summary>
      /// <returns></returns>
      public Resources getResources () {
        // create path and map variables
        var path = "/user".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Resources) ApiInvoker.deserialize(response, typeof(Resources));
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
      /// <summary>
      /// getCustomSettings() - Retrieve all custom user settings. Returns an object containing name-value pairs for custom user settings
      /// </summary>
      /// <returns></returns>
      public CustomSettings getCustomSettings () {
        // create path and map variables
        var path = "/user/custom".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (CustomSettings) ApiInvoker.deserialize(response, typeof(CustomSettings));
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
      /// <summary>
      /// setCustomSettings() - Set or update one or more custom user settings. A valid session is required to edit settings. Post body should be an array of name-value pairs.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of desired settings.</param>
      /// <returns></returns>
      public Success setCustomSettings (CustomSettings body) {
        // create path and map variables
        var path = "/user/custom".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Success) ApiInvoker.deserialize(response, typeof(Success));
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
      /// <summary>
      /// getCustomSetting() - Retrieve one custom user setting. Setting will be returned as an object containing name-value pair. A value of null is returned for settings that are not found.
      /// </summary>
      /// <param name="setting">Name of the setting to retrieve.</param>
      /// <returns></returns>
      public CustomSetting getCustomSetting (string setting) {
        // create path and map variables
        var path = "/user/custom/{setting}".Replace("{format}","json").Replace("{" + "setting" + "}", apiInvoker.escapeString(setting.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (setting == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (CustomSetting) ApiInvoker.deserialize(response, typeof(CustomSetting));
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
      /// <summary>
      /// deleteCustomSetting() - Delete one custom setting. A valid session is required to delete settings.
      /// </summary>
      /// <param name="setting">Name of the setting to delete.</param>
      /// <returns></returns>
      public Success deleteCustomSetting (string setting) {
        // create path and map variables
        var path = "/user/custom/{setting}".Replace("{format}","json").Replace("{" + "setting" + "}", apiInvoker.escapeString(setting.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (setting == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (Success) ApiInvoker.deserialize(response, typeof(Success));
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
      /// <summary>
      /// changePassword() - Change or reset the current user's password. A valid current session along with old and new password are required to change the password directly posting 'old_password' and 'new_password'. &lt;br/&gt;To request password reset, post 'email' and set 'reset' to true. &lt;br/&gt;To reset the password from an email confirmation, post 'email', 'code', and 'new_password'. &lt;br/&gt;To reset the password from a security question, post 'email', 'security_answer', and 'new_password'.
      /// </summary>
      /// <param name="reset">Set to true to perform password reset.</param>
      /// <param name="body">Data containing name-value pairs for password change.</param>
      /// <returns></returns>
      public PasswordResponse changePassword (bool reset, PasswordRequest body) {
        // create path and map variables
        var path = "/user/password".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (reset != null){
          paramStr = (reset != null && reset is DateTime) ? ((DateTime)(object)reset).ToString("u") : Convert.ToString(reset);
          queryParams.Add("reset", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (PasswordResponse) ApiInvoker.deserialize(response, typeof(PasswordResponse));
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
      /// <summary>
      /// getProfile() - Retrieve the current user's profile information. A valid current session is required to use this API. This profile, along with password, is the only things that the user can directly change.
      /// </summary>
      /// <returns></returns>
      public ProfileResponse getProfile () {
        // create path and map variables
        var path = "/user/profile".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ProfileResponse) ApiInvoker.deserialize(response, typeof(ProfileResponse));
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
      /// <summary>
      /// updateProfile() - Update the current user's profile information. Update the display name, phone, etc., as well as, security question and answer.
      /// </summary>
      /// <param name="body">Data containing name-value pairs for the user profile.</param>
      /// <returns></returns>
      public Success updateProfile (ProfileRequest body) {
        // create path and map variables
        var path = "/user/profile".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Success) ApiInvoker.deserialize(response, typeof(Success));
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
      /// <summary>
      /// register() - Register a new user in the system. The new user is created and, if required, sent an email for confirmation. This also handles the registration confirmation by posting email, confirmation code and new password.
      /// </summary>
      /// <param name="body">Data containing name-value pairs for new user registration.</param>
      /// <returns></returns>
      public Success register (Register body) {
        // create path and map variables
        var path = "/user/register".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Success) ApiInvoker.deserialize(response, typeof(Success));
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
      /// <summary>
      /// getSession() - Retrieve the current user session information. Calling this refreshes the current session, or returns an error for timed-out or invalid sessions.
      /// </summary>
      /// <returns></returns>
      public Session getSession () {
        // create path and map variables
        var path = "/user/session".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Session) ApiInvoker.deserialize(response, typeof(Session));
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
      /// <summary>
      /// login() - Login and create a new user session. Calling this creates a new session and logs in the user.
      /// </summary>
      /// <param name="body">Data containing name-value pairs used for logging into the system.</param>
      /// <returns></returns>
      public Session login (Login body) {
        // create path and map variables
        var path = "/user/session".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Session) ApiInvoker.deserialize(response, typeof(Session));
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
      /// <summary>
      /// logout() - Logout and destroy the current user session. Calling this deletes the current session and logs out the user.
      /// </summary>
      /// <returns></returns>
      public Success logout () {
        // create path and map variables
        var path = "/user/session".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (Success) ApiInvoker.deserialize(response, typeof(Success));
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
