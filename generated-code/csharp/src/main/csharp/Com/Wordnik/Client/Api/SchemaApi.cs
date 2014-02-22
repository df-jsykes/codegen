  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class SchemaApi {
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
      /// getResources() - List resources available for database schema. See listed operations for each resource available.
      /// </summary>
      /// <returns></returns>
      public Resources getResources () {
        // create path and map variables
        var path = "/schema".Replace("{format}","json");

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
      /// createTables() - Create one or more tables. Post data should be a single table definition or an array of table definitions.
      /// </summary>
      /// <param name="body">Array of table definitions.</param>
      /// <returns></returns>
      public Resources createTables (Tables body) {
        // create path and map variables
        var path = "/schema".Replace("{format}","json");

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
      /// updateTables() - Update one or more tables. Post data should be a single table definition or an array of table definitions.
      /// </summary>
      /// <param name="body">Array of table definitions.</param>
      /// <returns></returns>
      public Resources updateTables (Tables body) {
        // create path and map variables
        var path = "/schema".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, body, headerParams);
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
      /// describeTable() - Retrieve table definition for the given table. This describes the table, its fields and relations to other tables.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <returns></returns>
      public TableSchema describeTable (string table_name) {
        // create path and map variables
        var path = "/schema/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (TableSchema) ApiInvoker.deserialize(response, typeof(TableSchema));
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
      /// createFields() - Create one or more fields in the given table. Post data should be an array of field properties for a single record or an array of fields.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="body">Array of field definitions.</param>
      /// <returns></returns>
      public Success createFields (string table_name, Fields body) {
        // create path and map variables
        var path = "/schema/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || body == null ) {
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
      /// updateFields() - Update one or more fields in the given table. Post data should be an array of field properties for a single record or an array of fields.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="body">Array of field definitions.</param>
      /// <returns></returns>
      public Success updateFields (string table_name, Fields body) {
        // create path and map variables
        var path = "/schema/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, body, headerParams);
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
      /// deleteTable() - Delete (aka drop) the given table. Careful, this drops the database table and all of its contents.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <returns></returns>
      public Success deleteTable (string table_name) {
        // create path and map variables
        var path = "/schema/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null ) {
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
      /// describeField() - Retrieve the definition of the given field for the given table. This describes the field and its properties.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="field_name">Name of the field to perform operations on.</param>
      /// <returns></returns>
      public FieldSchema describeField (string table_name, string field_name) {
        // create path and map variables
        var path = "/schema/{table_name}/{field_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "field_name" + "}", apiInvoker.escapeString(field_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || field_name == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (FieldSchema) ApiInvoker.deserialize(response, typeof(FieldSchema));
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
      /// updateField() - Update one record by identifier. Post data should be an array of field properties for the given field.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="field_name">Name of the field to perform operations on.</param>
      /// <param name="body">Array of field properties.</param>
      /// <returns></returns>
      public Success updateField (string table_name, string field_name, FieldSchema body) {
        // create path and map variables
        var path = "/schema/{table_name}/{field_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "field_name" + "}", apiInvoker.escapeString(field_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || field_name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, body, headerParams);
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
      /// deleteField() - Remove the given field from the given table. Careful, this drops the database table field/column and all of its contents.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="field_name">Name of the field to perform operations on.</param>
      /// <returns></returns>
      public Success deleteField (string table_name, string field_name) {
        // create path and map variables
        var path = "/schema/{table_name}/{field_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "field_name" + "}", apiInvoker.escapeString(field_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || field_name == null ) {
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
      }
    }
