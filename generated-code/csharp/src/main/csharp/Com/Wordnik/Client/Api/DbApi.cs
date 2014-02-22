  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class DbApi {
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
      /// getTables() - List all tables. List the names of the available tables in this storage. By default, all tables are listed, use 'names' parameter to get specific tables. Use 'include_properties' to include any properties of the tables.
      /// </summary>
      /// <param name="include_properties">Return all properties of the tables, if any.</param>
      /// <param name="names">Comma-delimited list of the table names to retrieve.</param>
      /// <returns></returns>
      public Tables getTables (bool include_properties, string names) {
        // create path and map variables
        var path = "/db".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (include_properties != null){
          paramStr = (include_properties != null && include_properties is DateTime) ? ((DateTime)(object)include_properties).ToString("u") : Convert.ToString(include_properties);
          queryParams.Add("include_properties", paramStr);
		}
        if (names != null){
          paramStr = (names != null && names is DateTime) ? ((DateTime)(object)names).ToString("u") : Convert.ToString(names);
          queryParams.Add("names", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Tables) ApiInvoker.deserialize(response, typeof(Tables));
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
      /// getRecords() - Retrieve one or more records. Use the 'ids' or 'filter' parameter to limit resources that are returned. Use the 'fields' parameter to limit properties returned for each resource. By default, all fields are returned for all resources. Use the 'related' parameter to return related records for each resource. By default, no related records are returned. Alternatively, to send the 'ids' or 'filter' as posted data use the POST request with X-HTTP-METHOD = GET header and post array of ids or a filter.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="ids">Comma-delimited list of the identifiers of the resources to retrieve.</param>
      /// <param name="filter">SQL-like filter to limit the resources to retrieve.</param>
      /// <param name="limit">Set to limit the filter results.</param>
      /// <param name="offset">Set to offset the filter results to a particular record count.</param>
      /// <param name="order">SQL-like order containing field and direction for filter results.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <param name="include_count">Include the total number of filter results as meta data.</param>
      /// <param name="include_schema">Include the table schema as meta data.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <returns></returns>
      public Records getRecords (string table_name, string ids, string filter, int limit, int offset, string order, string fields, string related, bool include_count, bool include_schema, string id_field) {
        // create path and map variables
        var path = "/db/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null ) {
           throw new ApiException(400, "missing required params");
        }
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
        if (offset != null){
          paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
          queryParams.Add("offset", paramStr);
		}
        if (order != null){
          paramStr = (order != null && order is DateTime) ? ((DateTime)(object)order).ToString("u") : Convert.ToString(order);
          queryParams.Add("order", paramStr);
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
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Records) ApiInvoker.deserialize(response, typeof(Records));
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
      /// createRecords() - Create one or more records. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success. Use 'fields' parameter to return more info.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="body">Data containing name-value pairs of records to create.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public Records createRecords (string table_name, Records body, string id_field, string fields, string related, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/db/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
		}
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
             return (Records) ApiInvoker.deserialize(response, typeof(Records));
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
      /// updateRecords() - Update (patch) one or more records. Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success. Use 'fields' parameter to return more info.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="body">Data containing name-value pairs of records to update.</param>
      /// <param name="ids">Comma-delimited list of the identifiers of the resources to modify.</param>
      /// <param name="filter">SQL-like filter to limit the resources to modify.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <returns></returns>
      public Records updateRecords (string table_name, Records body, string ids, string filter, string id_field, string fields, string related) {
        // create path and map variables
        var path = "/db/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
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
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (Records) ApiInvoker.deserialize(response, typeof(Records));
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
      /// deleteRecords() - Delete one or more records. Use 'ids' or filter to delete specific records, otherwise set 'force' to true to clear the table. By default, only the id property of the record is returned on success, use 'fields' to return more info. Alternatively, to delete by records, a complicated filter, or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post array of records, filter, or ids.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="ids">Comma-delimited list of the identifiers of the resources to delete.</param>
      /// <param name="filter">SQL-like filter to limit the resources to delete.</param>
      /// <param name="force">Set force to true to delete all records in this table, otherwise 'ids' parameter is required.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <returns></returns>
      public Records deleteRecords (string table_name, string ids, string filter, bool force, string id_field, string fields, string related) {
        // create path and map variables
        var path = "/db/{table_name}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (ids != null){
          paramStr = (ids != null && ids is DateTime) ? ((DateTime)(object)ids).ToString("u") : Convert.ToString(ids);
          queryParams.Add("ids", paramStr);
		}
        if (filter != null){
          paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
          queryParams.Add("filter", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
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
             return (Records) ApiInvoker.deserialize(response, typeof(Records));
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
      /// getRecord() - Retrieve one record by identifier. Use the 'fields' parameter to limit properties that are returned. By default, all fields are returned. Use the 'related' parameter to return related records. By default, no related records are returned.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="id">Identifier of the resource to retrieve.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <returns></returns>
      public Record getRecord (string table_name, string id, string id_field, string fields, string related) {
        // create path and map variables
        var path = "/db/{table_name}/{id}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
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
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (Record) ApiInvoker.deserialize(response, typeof(Record));
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
      /// createRecord() - Create one record with given identifier. Post data should be an array of fields for a single record. Use the 'fields' parameter to return more properties. By default, the id is returned.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="id">Identifier of the resource to create.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="body">Data containing name-value pairs of the record to create.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <returns></returns>
      public Record createRecord (string table_name, string id, string id_field, Record body, string fields, string related) {
        // create path and map variables
        var path = "/db/{table_name}/{id}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
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
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (Record) ApiInvoker.deserialize(response, typeof(Record));
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
      /// updateRecord() - Update (patch) one record by identifier. Post data should be an array of fields for a single record. Use the 'fields' parameter to return more properties. By default, the id is returned.
      /// </summary>
      /// <param name="table_name">The name of the table you want to update.</param>
      /// <param name="id">Identifier of the resource to update.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="body">Data containing name-value pairs of the fields to update.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <returns></returns>
      public Record updateRecord (string table_name, string id, string id_field, Record body, string fields, string related) {
        // create path and map variables
        var path = "/db/{table_name}/{id}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || id == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
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
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (Record) ApiInvoker.deserialize(response, typeof(Record));
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
      /// deleteRecord() - Delete one record by identifier. Use the 'fields' parameter to return more deleted properties. By default, the id is returned.
      /// </summary>
      /// <param name="table_name">Name of the table to perform operations on.</param>
      /// <param name="id">Identifier of the resource to delete.</param>
      /// <param name="id_field">Comma-delimited list of the fields used as identifiers or primary keys for the table.</param>
      /// <param name="fields">Comma-delimited list of field names to retrieve for each record.</param>
      /// <param name="related">Comma-delimited list of relationship names to retrieve for each record.</param>
      /// <returns></returns>
      public Record deleteRecord (string table_name, string id, string id_field, string fields, string related) {
        // create path and map variables
        var path = "/db/{table_name}/{id}".Replace("{format}","json").Replace("{" + "table_name" + "}", apiInvoker.escapeString(table_name.ToString())).Replace("{" + "id" + "}", apiInvoker.escapeString(id.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (table_name == null || id == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (id_field != null){
          paramStr = (id_field != null && id_field is DateTime) ? ((DateTime)(object)id_field).ToString("u") : Convert.ToString(id_field);
          queryParams.Add("id_field", paramStr);
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
             return (Record) ApiInvoker.deserialize(response, typeof(Record));
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
