  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class SystemApi {
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
      /// getResources() - List resources available for system management. See listed operations for each resource available.
      /// </summary>
      /// <returns></returns>
      public Resources getResources () {
        // create path and map variables
        var path = "/system".Replace("{format}","json");

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
      /// getApps() - Retrieve one or more applications. Use the 'ids' or 'filter' parameter to limit records that are returned. By default, all records up to the maximum are returned. &lt;br&gt;Use the 'fields' and 'related' parameters to limit properties returned for each record. By default, all fields and no relations are returned for each record. &lt;br&gt;Alternatively, to retrieve by record, a large list of ids, or a complicated filter, use the POST request with X-HTTP-METHOD = GET header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the records to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of related names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results in returned metadata.</param>
      /// <param name="include_schema">Include the schema of the table queried in returned metadata.</param>
      /// <returns></returns>
      public AppsResponse getApps (string ids, string filter, integer limit, string order, integer offset, string fields, string related, bool include_count, bool include_schema) {
        // create path and map variables
        var path = "/system/app".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (limit != null){
          paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
          queryParams.Add("limit", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
		}
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (include_count != null){
          paramStr = (include_count != null && include_count is DateTime) ? ((DateTime)(object)include_count).ToString("u") : Convert.ToString(include_count);
          queryParams.Add("include_count", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (AppsResponse) ApiInvoker.deserialize(response, typeof(AppsResponse));
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
      /// createApps() - Create one or more applications. Post data should be a single record or an array of records (shown). By default, only the id property of the record affected is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public AppsResponse createApps (AppsRequest body, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/system/app".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (AppsResponse) ApiInvoker.deserialize(response, typeof(AppsResponse));
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
      /// updateApps() - Update one or more applications. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public AppsResponse updateApps (AppsRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/app".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (AppsResponse) ApiInvoker.deserialize(response, typeof(AppsResponse));
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
      /// deleteApps() - Delete one or more applications. By default, only the id property of the record deleted is returned on success. Use 'fields' and 'related' to return more properties of the deleted records. &lt;br&gt;Alternatively, to delete by record or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="delete_storage">If the app is hosted in a storage service, the storage will be deleted as well.</param>
      /// <returns></returns>
      public AppsResponse deleteApps (string ids, bool force, string fields, string related, bool delete_storage) {
        // create path and map variables
        var path = "/system/app".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (delete_storage != null){
          paramStr = (delete_storage != null && delete_storage is DateTime) ? ((DateTime)(object)delete_storage).ToString("u") : Convert.ToString(delete_storage);
          queryParams.Add("delete_storage", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (AppsResponse) ApiInvoker.deserialize(response, typeof(AppsResponse));
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
      /// getApp() - Retrieve one application. Use the 'fields' and/or 'related' parameter to limit properties that are returned. By default, all fields and no relations are returned.
      /// </summary>
      /// <param name="id">Identifier of the record to retrieve.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <param name="pkg">Download this app as a DreamFactory package file.</param>
      /// <param name="include_files">If 'pkg' is true, include hosted files in the package.</param>
      /// <param name="include_services">If 'pkg' is true, include associated services configuration in the package.</param>
      /// <param name="include_schema">If 'pkg' is true, include associated database schema in the package.</param>
      /// <param name="sdk">Download the DreamFactory Javascript SDK amended for this app.</param>
      /// <returns></returns>
      public AppResponse getApp (string id, string fields, string related, bool pkg, bool include_files, bool include_services, bool include_schema, bool sdk) {
        // create path and map variables
        var path = "/system/app/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (pkg != null){
          paramStr = (pkg != null && pkg is DateTime) ? ((DateTime)(object)pkg).ToString("u") : Convert.ToString(pkg);
          queryParams.Add("pkg", paramStr);
		}
        if (include_files != null){
          paramStr = (include_files != null && include_files is DateTime) ? ((DateTime)(object)include_files).ToString("u") : Convert.ToString(include_files);
          queryParams.Add("include_files", paramStr);
		}
        if (include_services != null){
          paramStr = (include_services != null && include_services is DateTime) ? ((DateTime)(object)include_services).ToString("u") : Convert.ToString(include_services);
          queryParams.Add("include_services", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        if (sdk != null){
          paramStr = (sdk != null && sdk is DateTime) ? ((DateTime)(object)sdk).ToString("u") : Convert.ToString(sdk);
          queryParams.Add("sdk", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (AppResponse) ApiInvoker.deserialize(response, typeof(AppResponse));
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
      /// updateApp() - Update one application. Post data should be an array of fields to update for a single record. &lt;br&gt;By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return more properties.
      /// </summary>
      /// <param name="id">Identifier of the record to update.</param>
      /// <param name="body">Data containing name-value pairs of fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public AppResponse updateApp (string id, AppRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/app/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (AppResponse) ApiInvoker.deserialize(response, typeof(AppResponse));
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
      /// deleteApp() - Delete one application.  By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return deleted properties.
      /// </summary>
      /// <param name="id">Identifier of the record to delete.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <param name="delete_storage">If the app is hosted in a storage service, the storage will be deleted as well.</param>
      /// <returns></returns>
      public AppResponse deleteApp (string id, string fields, string related, bool delete_storage) {
        // create path and map variables
        var path = "/system/app/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (delete_storage != null){
          paramStr = (delete_storage != null && delete_storage is DateTime) ? ((DateTime)(object)delete_storage).ToString("u") : Convert.ToString(delete_storage);
          queryParams.Add("delete_storage", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (AppResponse) ApiInvoker.deserialize(response, typeof(AppResponse));
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
      /// getAppGroups() - Retrieve one or more application groups. Use the 'ids' or 'filter' parameter to limit records that are returned. By default, all records up to the maximum are returned. &lt;br&gt;Use the 'fields' and 'related' parameters to limit properties returned for each record. By default, all fields and no relations are returned for each record. &lt;br&gt;Alternatively, to retrieve by record, a large list of ids, or a complicated filter, use the POST request with X-HTTP-METHOD = GET header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the records to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of related names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results in returned metadata.</param>
      /// <param name="include_schema">Include the schema of the table queried in returned metadata.</param>
      /// <returns></returns>
      public AppGroupsResponse getAppGroups (string ids, string filter, integer limit, string order, integer offset, string fields, string related, bool include_count, bool include_schema) {
        // create path and map variables
        var path = "/system/app_group".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (limit != null){
          paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
          queryParams.Add("limit", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
		}
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (include_count != null){
          paramStr = (include_count != null && include_count is DateTime) ? ((DateTime)(object)include_count).ToString("u") : Convert.ToString(include_count);
          queryParams.Add("include_count", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (AppGroupsResponse) ApiInvoker.deserialize(response, typeof(AppGroupsResponse));
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
      /// createAppGroups() - Create one or more application groups. Post data should be a single record or an array of records (shown). By default, only the id property of the record affected is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public AppGroupsResponse createAppGroups (AppGroupsRequest body, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/system/app_group".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (AppGroupsResponse) ApiInvoker.deserialize(response, typeof(AppGroupsResponse));
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
      /// updateAppGroups() - Update one or more application groups. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public AppGroupsResponse updateAppGroups (AppGroupsRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/app_group".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (AppGroupsResponse) ApiInvoker.deserialize(response, typeof(AppGroupsResponse));
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
      /// deleteAppGroups() - Delete one or more application groups. By default, only the id property of the record deleted is returned on success. Use 'fields' and 'related' to return more properties of the deleted records. &lt;br&gt;Alternatively, to delete by record or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public AppGroupsResponse deleteAppGroups (string ids, bool force, string fields, string related) {
        // create path and map variables
        var path = "/system/app_group".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (AppGroupsResponse) ApiInvoker.deserialize(response, typeof(AppGroupsResponse));
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
      /// getAppGroup() - Retrieve one application group. Use the 'fields' and/or 'related' parameter to limit properties that are returned. By default, all fields and no relations are returned.
      /// </summary>
      /// <param name="id">Identifier of the record to retrieve.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public AppGroup getAppGroup (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/app_group/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (AppGroup) ApiInvoker.deserialize(response, typeof(AppGroup));
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
      /// updateAppGroup() - Update one application group. Post data should be an array of fields to update for a single record. &lt;br&gt;By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return more properties.
      /// </summary>
      /// <param name="id">Identifier of the record to update.</param>
      /// <param name="body">Data containing name-value pairs of fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public AppGroupResponse updateAppGroup (string id, AppGroupRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/app_group/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (AppGroupResponse) ApiInvoker.deserialize(response, typeof(AppGroupResponse));
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
      /// deleteAppGroup() - Delete one application group. By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return deleted properties.
      /// </summary>
      /// <param name="id">Identifier of the record to delete.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public AppGroupResponse deleteAppGroup (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/app_group/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (AppGroupResponse) ApiInvoker.deserialize(response, typeof(AppGroupResponse));
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
      /// getConfig() - Retrieve system configuration properties. The retrieved properties control how the system behaves.
      /// </summary>
      /// <returns></returns>
      public ConfigResponse getConfig () {
        // create path and map variables
        var path = "/system/config".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ConfigResponse) ApiInvoker.deserialize(response, typeof(ConfigResponse));
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
      /// setConfig() - Update one or more system configuration properties. Post data should be an array of properties.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of properties to set.</param>
      /// <returns></returns>
      public ConfigResponse setConfig (ConfigRequest body) {
        // create path and map variables
        var path = "/system/config".Replace("{format}","json");

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
             return (ConfigResponse) ApiInvoker.deserialize(response, typeof(ConfigResponse));
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
      /// getConstants() - Retrieve all platform enumerated constants. Returns an object containing every enumerated type and its constant values
      /// </summary>
      /// <returns></returns>
      public Constants getConstants () {
        // create path and map variables
        var path = "/system/constant".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Constants) ApiInvoker.deserialize(response, typeof(Constants));
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
      /// getConstant() - Retrieve one constant type enumeration. Returns , all fields and no relations are returned.
      /// </summary>
      /// <param name="type">Identifier of the enumeration type to retrieve.</param>
      /// <returns></returns>
      public Constant getConstant (string type) {
        // create path and map variables
        var path = "/system/constant/{type}".Replace("{format}","json").Replace("{" + "type" + "}", apiInvoker.escapeString(type.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (type == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Constant) ApiInvoker.deserialize(response, typeof(Constant));
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
      /// getCustomSettings() - Retrieve all custom system settings. Returns an object containing name-value pairs for custom system settings
      /// </summary>
      /// <returns></returns>
      public CustomSettings getCustomSettings () {
        // create path and map variables
        var path = "/system/custom".Replace("{format}","json");

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
      /// setCustomSettings() - Update one or more custom system settings. A valid session and system configuration permissions is required to edit settings. Post body should be an array of name-value pairs.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of desired settings.</param>
      /// <returns></returns>
      public Success setCustomSettings (CustomSettings body) {
        // create path and map variables
        var path = "/system/custom".Replace("{format}","json");

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
      /// getCustomSetting() - Retrieve one custom system setting. Setting will be returned as an object containing name-value pair.
      /// </summary>
      /// <param name="setting">Name of the setting to retrieve.</param>
      /// <returns></returns>
      public CustomSetting getCustomSetting (string setting) {
        // create path and map variables
        var path = "/system/custom/{setting}".Replace("{format}","json").Replace("{" + "setting" + "}", apiInvoker.escapeString(setting.ToString()));

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
      /// deleteCustomSetting() - Delete one custom setting. A valid session with system configuration permissions is required to delete settings.
      /// </summary>
      /// <param name="setting">Name of the setting to delete.</param>
      /// <returns></returns>
      public Success deleteCustomSetting (string setting) {
        // create path and map variables
        var path = "/system/custom/{setting}".Replace("{format}","json").Replace("{" + "setting" + "}", apiInvoker.escapeString(setting.ToString()));

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
      /// getEmailTemplates() - Retrieve one or more email templates. Use the 'ids' or 'filter' parameter to limit records that are returned. By default, all records up to the maximum are returned. &lt;br&gt;Use the 'fields' and 'related' parameters to limit properties returned for each record. By default, all fields and no relations are returned for each record. &lt;br&gt;Alternatively, to retrieve by record, a large list of ids, or a complicated filter, use the POST request with X-HTTP-METHOD = GET header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the records to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of related names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results in returned metadata.</param>
      /// <param name="include_schema">Include the schema of the table queried in returned metadata.</param>
      /// <returns></returns>
      public EmailTemplatesResponse getEmailTemplates (string ids, string filter, integer limit, string order, integer offset, string fields, string related, bool include_count, bool include_schema) {
        // create path and map variables
        var path = "/system/email_template".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (limit != null){
          paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
          queryParams.Add("limit", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
		}
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (include_count != null){
          paramStr = (include_count != null && include_count is DateTime) ? ((DateTime)(object)include_count).ToString("u") : Convert.ToString(include_count);
          queryParams.Add("include_count", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (EmailTemplatesResponse) ApiInvoker.deserialize(response, typeof(EmailTemplatesResponse));
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
      /// createEmailTemplates() - Create one or more email templates. Post data should be a single record or an array of records (shown). By default, only the id property of the record affected is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public EmailTemplatesResponse createEmailTemplates (EmailTemplatesRequest body, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/system/email_template".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (EmailTemplatesResponse) ApiInvoker.deserialize(response, typeof(EmailTemplatesResponse));
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
      /// updateEmailTemplates() - Update one or more email templates. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public EmailTemplatesResponse updateEmailTemplates (EmailTemplatesRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/email_template".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (EmailTemplatesResponse) ApiInvoker.deserialize(response, typeof(EmailTemplatesResponse));
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
      /// deleteEmailTemplates() - Delete one or more email templates. By default, only the id property of the record deleted is returned on success. Use 'fields' and 'related' to return more properties of the deleted records. &lt;br&gt;Alternatively, to delete by record or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public EmailTemplatesResponse deleteEmailTemplates (string ids, bool force, string fields, string related) {
        // create path and map variables
        var path = "/system/email_template".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (EmailTemplatesResponse) ApiInvoker.deserialize(response, typeof(EmailTemplatesResponse));
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
      /// getEmailTemplate() - Retrieve one email template. Use the 'fields' and/or 'related' parameter to limit properties that are returned. By default, all fields and no relations are returned.
      /// </summary>
      /// <param name="id">Identifier of the record to retrieve.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public EmailTemplateResponse getEmailTemplate (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/email_template/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (EmailTemplateResponse) ApiInvoker.deserialize(response, typeof(EmailTemplateResponse));
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
      /// updateEmailTemplate() - Update one email template. Post data should be an array of fields to update for a single record. &lt;br&gt;By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return more properties.
      /// </summary>
      /// <param name="id">Identifier of the record to update.</param>
      /// <param name="body">Data containing name-value pairs of fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public EmailTemplateResponse updateEmailTemplate (string id, EmailTemplateRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/email_template/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (EmailTemplateResponse) ApiInvoker.deserialize(response, typeof(EmailTemplateResponse));
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
      /// deleteEmailTemplate() - Delete one email template. By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return deleted properties.
      /// </summary>
      /// <param name="id">Identifier of the record to delete.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public EmailTemplateResponse deleteEmailTemplate (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/email_template/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (EmailTemplateResponse) ApiInvoker.deserialize(response, typeof(EmailTemplateResponse));
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
      /// getRoles() - Retrieve one or more roles. Use the 'ids' or 'filter' parameter to limit records that are returned. By default, all records up to the maximum are returned. &lt;br&gt;Use the 'fields' and 'related' parameters to limit properties returned for each record. By default, all fields and no relations are returned for each record. &lt;br&gt;Alternatively, to retrieve by record, a large list of ids, or a complicated filter, use the POST request with X-HTTP-METHOD = GET header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the records to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of related names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results in returned metadata.</param>
      /// <param name="include_schema">Include the schema of the table queried in returned metadata.</param>
      /// <returns></returns>
      public RolesResponse getRoles (string ids, string filter, integer limit, string order, integer offset, string fields, string related, bool include_count, bool include_schema) {
        // create path and map variables
        var path = "/system/role".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (limit != null){
          paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
          queryParams.Add("limit", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
		}
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (include_count != null){
          paramStr = (include_count != null && include_count is DateTime) ? ((DateTime)(object)include_count).ToString("u") : Convert.ToString(include_count);
          queryParams.Add("include_count", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (RolesResponse) ApiInvoker.deserialize(response, typeof(RolesResponse));
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
      /// createRoles() - Create one or more roles. Post data should be a single record or an array of records (shown). By default, only the id property of the record affected is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public RolesResponse createRoles (RolesRequest body, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/system/role".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (RolesResponse) ApiInvoker.deserialize(response, typeof(RolesResponse));
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
      /// updateRoles() - Update one or more roles. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public RolesResponse updateRoles (RolesRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/role".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (RolesResponse) ApiInvoker.deserialize(response, typeof(RolesResponse));
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
      /// deleteRoles() - Delete one or more roles. By default, only the id property of the record deleted is returned on success. Use 'fields' and 'related' to return more properties of the deleted records. &lt;br&gt;Alternatively, to delete by record or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public RolesResponse deleteRoles (string ids, bool force, string fields, string related) {
        // create path and map variables
        var path = "/system/role".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (RolesResponse) ApiInvoker.deserialize(response, typeof(RolesResponse));
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
      /// getRole() - Retrieve one role. Use the 'fields' and/or 'related' parameter to limit properties that are returned. By default, all fields and no relations are returned.
      /// </summary>
      /// <param name="id">Identifier of the record to retrieve.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public RoleResponse getRole (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/role/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (RoleResponse) ApiInvoker.deserialize(response, typeof(RoleResponse));
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
      /// updateRole() - Update one role. Post data should be an array of fields to update for a single record. &lt;br&gt;By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return more properties.
      /// </summary>
      /// <param name="id">Identifier of the record to update.</param>
      /// <param name="body">Data containing name-value pairs of fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public RoleResponse updateRole (string id, RoleRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/role/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (RoleResponse) ApiInvoker.deserialize(response, typeof(RoleResponse));
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
      /// deleteRole() - Delete one role. By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return deleted properties.
      /// </summary>
      /// <param name="id">Identifier of the record to delete.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public RoleResponse deleteRole (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/role/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (RoleResponse) ApiInvoker.deserialize(response, typeof(RoleResponse));
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
      /// getServices() - Retrieve one or more services. Use the 'ids' or 'filter' parameter to limit records that are returned. By default, all records up to the maximum are returned. &lt;br&gt;Use the 'fields' and 'related' parameters to limit properties returned for each record. By default, all fields and no relations are returned for each record. &lt;br&gt;Alternatively, to retrieve by record, a large list of ids, or a complicated filter, use the POST request with X-HTTP-METHOD = GET header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the records to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of related names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results in returned metadata.</param>
      /// <param name="include_schema">Include the schema of the table queried in returned metadata.</param>
      /// <returns></returns>
      public ServicesResponse getServices (string ids, string filter, integer limit, string order, integer offset, string fields, string related, bool include_count, bool include_schema) {
        // create path and map variables
        var path = "/system/service".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (limit != null){
          paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
          queryParams.Add("limit", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
		}
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (include_count != null){
          paramStr = (include_count != null && include_count is DateTime) ? ((DateTime)(object)include_count).ToString("u") : Convert.ToString(include_count);
          queryParams.Add("include_count", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ServicesResponse) ApiInvoker.deserialize(response, typeof(ServicesResponse));
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
      /// createServices() - Create one or more services. Post data should be a single record or an array of records (shown). By default, only the id property of the record affected is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public ServicesResponse createServices (ServicesRequest body, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/system/service".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (ServicesResponse) ApiInvoker.deserialize(response, typeof(ServicesResponse));
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
      /// updateServices() - Update one or more services. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public ServicesResponse updateServices (ServicesRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/service".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (ServicesResponse) ApiInvoker.deserialize(response, typeof(ServicesResponse));
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
      /// deleteServices() - Delete one or more services. By default, only the id property of the record deleted is returned on success. Use 'fields' and 'related' to return more properties of the deleted records. &lt;br&gt;Alternatively, to delete by record or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public ServicesResponse deleteServices (string ids, bool force, string fields, string related) {
        // create path and map variables
        var path = "/system/service".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (ServicesResponse) ApiInvoker.deserialize(response, typeof(ServicesResponse));
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
      /// getService() - Retrieve one service. Use the 'fields' and/or 'related' parameter to limit properties that are returned. By default, all fields and no relations are returned.
      /// </summary>
      /// <param name="id">Identifier of the record to retrieve.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public ServiceResponse getService (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/service/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ServiceResponse) ApiInvoker.deserialize(response, typeof(ServiceResponse));
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
      /// updateService() - Update one service. Post data should be an array of fields to update for a single record. &lt;br&gt;By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return more properties.
      /// </summary>
      /// <param name="id">Identifier of the record to update.</param>
      /// <param name="body">Data containing name-value pairs of fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public ServiceResponse updateService (string id, ServiceRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/service/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (ServiceResponse) ApiInvoker.deserialize(response, typeof(ServiceResponse));
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
      /// deleteService() - Delete one service. By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return deleted properties.
      /// </summary>
      /// <param name="id">Identifier of the record to delete.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public ServiceResponse deleteService (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/service/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (ServiceResponse) ApiInvoker.deserialize(response, typeof(ServiceResponse));
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
      /// getUsers() - Retrieve one or more users. Use the 'ids' or 'filter' parameter to limit records that are returned. By default, all records up to the maximum are returned. &lt;br&gt;Use the 'fields' and 'related' parameters to limit properties returned for each record. By default, all fields and no relations are returned for each record. &lt;br&gt;Alternatively, to retrieve by record, a large list of ids, or a complicated filter, use the POST request with X-HTTP-METHOD = GET header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the records to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of related names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results in returned metadata.</param>
      /// <param name="include_schema">Include the schema of the table queried in returned metadata.</param>
      /// <param name="file">Download the results of the request as a file.</param>
      /// <returns></returns>
      public UsersResponse getUsers (string ids, string filter, integer limit, string order, integer offset, string fields, string related, bool include_count, bool include_schema, string file) {
        // create path and map variables
        var path = "/system/user".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (limit != null){
          paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
          queryParams.Add("limit", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
		}
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        if (include_count != null){
          paramStr = (include_count != null && include_count is DateTime) ? ((DateTime)(object)include_count).ToString("u") : Convert.ToString(include_count);
          queryParams.Add("include_count", paramStr);
		}
        if (include_schema != null){
          paramStr = (include_schema != null && include_schema is DateTime) ? ((DateTime)(object)include_schema).ToString("u") : Convert.ToString(include_schema);
          queryParams.Add("include_schema", paramStr);
		}
        if (file != null){
          paramStr = (file != null && file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
          queryParams.Add("file", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (UsersResponse) ApiInvoker.deserialize(response, typeof(UsersResponse));
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
      /// createUsers() - Create one or more users. Post data should be a single record or an array of records (shown). By default, only the id property of the record affected is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public UsersResponse createUsers (UsersRequest body, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/system/user".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (UsersResponse) ApiInvoker.deserialize(response, typeof(UsersResponse));
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
      /// updateUsers() - Update one or more users. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success, use 'fields' and 'related' to return more info.
      /// </summary>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public UsersResponse updateUsers (UsersRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/user".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (UsersResponse) ApiInvoker.deserialize(response, typeof(UsersResponse));
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
      /// deleteUsers() - Delete one or more users. By default, only the id property of the record deleted is returned on success. Use 'fields' and 'related' to return more properties of the deleted records. &lt;br&gt;Alternatively, to delete by record or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post records or ids.
      /// </summary>
      /// <param name="ids">Comma-delimited list of the identifiers of the records to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="fields">Comma-delimited list of field names to return for each record affected.</param>
      /// <param name="related">Comma-delimited list of related names to return for each record affected.</param>
      /// <returns></returns>
      public UsersResponse deleteUsers (string ids, bool force, string fields, string related) {
        // create path and map variables
        var path = "/system/user".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (UsersResponse) ApiInvoker.deserialize(response, typeof(UsersResponse));
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
      /// getUser() - Retrieve one user. Use the 'fields' and/or 'related' parameter to limit properties that are returned. By default, all fields and no relations are returned.
      /// </summary>
      /// <param name="id">Identifier of the record to retrieve.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public UserResponse getUser (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/user/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (UserResponse) ApiInvoker.deserialize(response, typeof(UserResponse));
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
      /// updateUser() - Update one user. Post data should be an array of fields to update for a single record. &lt;br&gt;By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return more properties.
      /// </summary>
      /// <param name="id">Identifier of the record to update.</param>
      /// <param name="body">Data containing name-value pairs of fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public UserResponse updateUser (string id, UserRequest body, string fields, string related) {
        // create path and map variables
        var path = "/system/user/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (UserResponse) ApiInvoker.deserialize(response, typeof(UserResponse));
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
      /// deleteUser() - Delete one user. By default, only the id is returned. Use the 'fields' and/or 'related' parameter to return deleted properties.
      /// </summary>
      /// <param name="id">Identifier of the record to delete.</param>
      /// <param name="fields">Comma-delimited list of field names to return.</param>
      /// <param name="related">Comma-delimited list of related records to return.</param>
      /// <returns></returns>
      public UserResponse deleteUser (string id, string fields, string related) {
        // create path and map variables
        var path = "/system/user/{id}".Replace("{format}","json").Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (fields != null){
          paramStr = (fields != null && fields is DateTime) ? ((DateTime)(object)fields).ToString("u") : Convert.ToString(fields);
          queryParams.Add("fields", paramStr);
		}
        if (related != null){
          paramStr = (related != null && related is DateTime) ? ((DateTime)(object)related).ToString("u") : Convert.ToString(related);
          queryParams.Add("related", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (UserResponse) ApiInvoker.deserialize(response, typeof(UserResponse));
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
