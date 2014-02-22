  using System;
  using System.Collections.Generic;
  using com.wordnik.client.common;
  using com.wordnik.client.common.Model;
  namespace Com.Wordnik.Client.Api {
    public class GtatestApi {
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
      /// getContainers() - List all containers. List the names of the available containers in this storage. Use 'include_properties' to include any properties of the containers.
      /// </summary>
      /// <param name="include_properties">Return any properties of the container in the response.</param>
      /// <returns></returns>
      public ContainersResponse getContainers (bool include_properties) {
        // create path and map variables
        var path = "/gtatest".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (include_properties != null){
          paramStr = (include_properties != null && include_properties is DateTime) ? ((DateTime)(object)include_properties).ToString("u") : Convert.ToString(include_properties);
          queryParams.Add("include_properties", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ContainersResponse) ApiInvoker.deserialize(response, typeof(ContainersResponse));
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
      /// createContainers() - Create one or more containers. Post data should be a single container definition or an array of container definitions. Alternatively, override the HTTP Method to pass containers to other actions.
      /// </summary>
      /// <param name="body">Array of containers to create.</param>
      /// <param name="check_exist">If true, the request fails when the container to create already exists.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public ContainersResponse createContainers (ContainersRequest body, bool check_exist, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/gtatest".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (check_exist != null){
          paramStr = (check_exist != null && check_exist is DateTime) ? ((DateTime)(object)check_exist).ToString("u") : Convert.ToString(check_exist);
          queryParams.Add("check_exist", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (ContainersResponse) ApiInvoker.deserialize(response, typeof(ContainersResponse));
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
      /// deleteContainers() - Delete one or more containers. Pass a comma-delimited list of container names to delete. Set 'force' to true to delete all containers. Alternatively, to delete by container records or a large list of names, use the POST request with X-HTTP-METHOD = DELETE header and post containers.
      /// </summary>
      /// <param name="names">List of containers to delete.</param>
      /// <param name="force">Set force to true to delete all containers, otherwise 'names' parameter is required.</param>
      /// <returns></returns>
      public ContainersResponse deleteContainers (string names, bool force) {
        // create path and map variables
        var path = "/gtatest".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        string paramStr = null;
        if (names != null){
          paramStr = (names != null && names is DateTime) ? ((DateTime)(object)names).ToString("u") : Convert.ToString(names);
          queryParams.Add("names", paramStr);
		}
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (ContainersResponse) ApiInvoker.deserialize(response, typeof(ContainersResponse));
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
      /// getContainer() - List the container's content, including properties. Use 'include_properties' to get properties of the container. Use the 'include_folders' and/or 'include_files' to modify the listing.
      /// </summary>
      /// <param name="container">The name of the container from which you want to retrieve contents.</param>
      /// <param name="include_properties">Include any properties of the container in the response.</param>
      /// <param name="include_folders">Include folders in the returned listing.</param>
      /// <param name="include_files">Include files in the returned listing.</param>
      /// <param name="full_tree">List the contents of all sub-folders as well.</param>
      /// <param name="zip">Return the content of the folder as a zip file.</param>
      /// <returns></returns>
      public ContainerResponse getContainer (string container, bool include_properties, bool include_folders, bool include_files, bool full_tree, bool zip) {
        // create path and map variables
        var path = "/gtatest/{container}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (include_properties != null){
          paramStr = (include_properties != null && include_properties is DateTime) ? ((DateTime)(object)include_properties).ToString("u") : Convert.ToString(include_properties);
          queryParams.Add("include_properties", paramStr);
		}
        if (include_folders != null){
          paramStr = (include_folders != null && include_folders is DateTime) ? ((DateTime)(object)include_folders).ToString("u") : Convert.ToString(include_folders);
          queryParams.Add("include_folders", paramStr);
		}
        if (include_files != null){
          paramStr = (include_files != null && include_files is DateTime) ? ((DateTime)(object)include_files).ToString("u") : Convert.ToString(include_files);
          queryParams.Add("include_files", paramStr);
		}
        if (full_tree != null){
          paramStr = (full_tree != null && full_tree is DateTime) ? ((DateTime)(object)full_tree).ToString("u") : Convert.ToString(full_tree);
          queryParams.Add("full_tree", paramStr);
		}
        if (zip != null){
          paramStr = (zip != null && zip is DateTime) ? ((DateTime)(object)zip).ToString("u") : Convert.ToString(zip);
          queryParams.Add("zip", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (ContainerResponse) ApiInvoker.deserialize(response, typeof(ContainerResponse));
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
      /// createContainer() - Create container and/or add content. Post data as an array of folders and/or files.
      /// </summary>
      /// <param name="container">The name of the container you want to put the contents.</param>
      /// <param name="body">Array of folders and/or files.</param>
      /// <param name="url">The full URL of the file to upload.</param>
      /// <param name="extract">Extract an uploaded zip file into the container.</param>
      /// <param name="clean">Option when 'extract' is true, clean the current folder before extracting files and folders.</param>
      /// <param name="check_exist">If true, the request fails when the file or folder to create already exists.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public ContainerResponse createContainer (string container, ContainerRequest body, string url, bool extract, bool clean, bool check_exist, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/gtatest/{container}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (url != null){
          paramStr = (url != null && url is DateTime) ? ((DateTime)(object)url).ToString("u") : Convert.ToString(url);
          queryParams.Add("url", paramStr);
		}
        if (extract != null){
          paramStr = (extract != null && extract is DateTime) ? ((DateTime)(object)extract).ToString("u") : Convert.ToString(extract);
          queryParams.Add("extract", paramStr);
		}
        if (clean != null){
          paramStr = (clean != null && clean is DateTime) ? ((DateTime)(object)clean).ToString("u") : Convert.ToString(clean);
          queryParams.Add("clean", paramStr);
		}
        if (check_exist != null){
          paramStr = (check_exist != null && check_exist is DateTime) ? ((DateTime)(object)check_exist).ToString("u") : Convert.ToString(check_exist);
          queryParams.Add("check_exist", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (ContainerResponse) ApiInvoker.deserialize(response, typeof(ContainerResponse));
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
      /// updateContainerProperties() - Update properties of the container. Post data as an array of container properties.
      /// </summary>
      /// <param name="container">The name of the container you want to put the contents.</param>
      /// <param name="body">An array of container properties.</param>
      /// <returns></returns>
      public Container updateContainerProperties (string container, Container body) {
        // create path and map variables
        var path = "/gtatest/{container}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (Container) ApiInvoker.deserialize(response, typeof(Container));
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
      /// deleteContainer() - Delete one container and/or its contents. Set 'content_only' to true to delete the folders and files contained, but not the container. Set 'force' to true to delete a non-empty container. Alternatively, to delete by a listing of folders and files, use the POST request with X-HTTP-METHOD = DELETE header and post listing.
      /// </summary>
      /// <param name="container">The name of the container you want to delete from.</param>
      /// <param name="force">Set to true to force delete on a non-empty container.</param>
      /// <param name="content_only">Set to true to only delete the content of the container.</param>
      /// <returns></returns>
      public ContainerResponse deleteContainer (string container, bool force, bool content_only) {
        // create path and map variables
        var path = "/gtatest/{container}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (content_only != null){
          paramStr = (content_only != null && content_only is DateTime) ? ((DateTime)(object)content_only).ToString("u") : Convert.ToString(content_only);
          queryParams.Add("content_only", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (ContainerResponse) ApiInvoker.deserialize(response, typeof(ContainerResponse));
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
      /// getFolder() - List the folder's content, including properties. Use 'include_properties' to get properties of the folder. Use the 'include_folders' and/or 'include_files' to modify the listing.
      /// </summary>
      /// <param name="container">The name of the container from which you want to retrieve contents.</param>
      /// <param name="folder_path">The path of the folder you want to retrieve. This can be a sub-folder, with each level separated by a '/'</param>
      /// <param name="include_properties">Return any properties of the folder in the response.</param>
      /// <param name="include_folders">Include folders in the returned listing.</param>
      /// <param name="include_files">Include files in the returned listing.</param>
      /// <param name="full_tree">List the contents of all sub-folders as well.</param>
      /// <param name="zip">Return the content of the folder as a zip file.</param>
      /// <returns></returns>
      public FolderResponse getFolder (string container, string folder_path, bool include_properties, bool include_folders, bool include_files, bool full_tree, bool zip) {
        // create path and map variables
        var path = "/gtatest/{container}/{folder_path}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "folder_path" + "}", apiInvoker.escapeString(folder_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || folder_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (include_properties != null){
          paramStr = (include_properties != null && include_properties is DateTime) ? ((DateTime)(object)include_properties).ToString("u") : Convert.ToString(include_properties);
          queryParams.Add("include_properties", paramStr);
		}
        if (include_folders != null){
          paramStr = (include_folders != null && include_folders is DateTime) ? ((DateTime)(object)include_folders).ToString("u") : Convert.ToString(include_folders);
          queryParams.Add("include_folders", paramStr);
		}
        if (include_files != null){
          paramStr = (include_files != null && include_files is DateTime) ? ((DateTime)(object)include_files).ToString("u") : Convert.ToString(include_files);
          queryParams.Add("include_files", paramStr);
		}
        if (full_tree != null){
          paramStr = (full_tree != null && full_tree is DateTime) ? ((DateTime)(object)full_tree).ToString("u") : Convert.ToString(full_tree);
          queryParams.Add("full_tree", paramStr);
		}
        if (zip != null){
          paramStr = (zip != null && zip is DateTime) ? ((DateTime)(object)zip).ToString("u") : Convert.ToString(zip);
          queryParams.Add("zip", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (FolderResponse) ApiInvoker.deserialize(response, typeof(FolderResponse));
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
      /// createFolder() - Create a folder and/or add content. Post data as an array of folders and/or files. Folders are created if they do not exist
      /// </summary>
      /// <param name="container">The name of the container where you want to put the contents.</param>
      /// <param name="folder_path">The path of the folder where you want to put the contents. This can be a sub-folder, with each level separated by a '/'</param>
      /// <param name="body">Array of folders and/or files.</param>
      /// <param name="url">The full URL of the file to upload.</param>
      /// <param name="extract">Extract an uploaded zip file into the folder.</param>
      /// <param name="clean">Option when 'extract' is true, clean the current folder before extracting files and folders.</param>
      /// <param name="check_exist">If true, the request fails when the file or folder to create already exists.</param>
      /// <param name="X-HTTP-METHOD">Override request using POST to tunnel other http request, such as DELETE.</param>
      /// <returns></returns>
      public FolderResponse createFolder (string container, string folder_path, FolderRequest body, string url, bool extract, bool clean, bool check_exist, string X-HTTP-METHOD) {
        // create path and map variables
        var path = "/gtatest/{container}/{folder_path}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "folder_path" + "}", apiInvoker.escapeString(folder_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || folder_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (url != null){
          paramStr = (url != null && url is DateTime) ? ((DateTime)(object)url).ToString("u") : Convert.ToString(url);
          queryParams.Add("url", paramStr);
		}
        if (extract != null){
          paramStr = (extract != null && extract is DateTime) ? ((DateTime)(object)extract).ToString("u") : Convert.ToString(extract);
          queryParams.Add("extract", paramStr);
		}
        if (clean != null){
          paramStr = (clean != null && clean is DateTime) ? ((DateTime)(object)clean).ToString("u") : Convert.ToString(clean);
          queryParams.Add("clean", paramStr);
		}
        if (check_exist != null){
          paramStr = (check_exist != null && check_exist is DateTime) ? ((DateTime)(object)check_exist).ToString("u") : Convert.ToString(check_exist);
          queryParams.Add("check_exist", paramStr);
		}
        headerParams.Add("X-HTTP-METHOD", X-HTTP-METHOD);
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (FolderResponse) ApiInvoker.deserialize(response, typeof(FolderResponse));
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
      /// updateFolderProperties() - Update folder properties. Post body as an array of folder properties.
      /// </summary>
      /// <param name="container">The name of the container where you want to put the contents.</param>
      /// <param name="folder_path">The path of the folder you want to update. This can be a sub-folder, with each level separated by a '/'</param>
      /// <param name="body">Array of folder properties.</param>
      /// <returns></returns>
      public Folder updateFolderProperties (string container, string folder_path, Folder body) {
        // create path and map variables
        var path = "/gtatest/{container}/{folder_path}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "folder_path" + "}", apiInvoker.escapeString(folder_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || folder_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (Folder) ApiInvoker.deserialize(response, typeof(Folder));
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
      /// deleteFolder() - Delete one folder and/or its contents. Set 'content_only' to true to delete the sub-folders and files contained, but not the folder. Set 'force' to true to delete a non-empty folder. Alternatively, to delete by a listing of sub-folders and files, use the POST request with X-HTTP-METHOD = DELETE header and post listing.
      /// </summary>
      /// <param name="container">The name of the container where the folder exists.</param>
      /// <param name="folder_path">The path of the folder where you want to delete contents. This can be a sub-folder, with each level separated by a '/'</param>
      /// <param name="force">Set to true to force delete on a non-empty folder.</param>
      /// <param name="content_only">Set to true to only delete the content of the folder.</param>
      /// <returns></returns>
      public FolderResponse deleteFolder (string container, string folder_path, bool force, bool content_only) {
        // create path and map variables
        var path = "/gtatest/{container}/{folder_path}/".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "folder_path" + "}", apiInvoker.escapeString(folder_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || folder_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (force != null){
          paramStr = (force != null && force is DateTime) ? ((DateTime)(object)force).ToString("u") : Convert.ToString(force);
          queryParams.Add("force", paramStr);
		}
        if (content_only != null){
          paramStr = (content_only != null && content_only is DateTime) ? ((DateTime)(object)content_only).ToString("u") : Convert.ToString(content_only);
          queryParams.Add("content_only", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (FolderResponse) ApiInvoker.deserialize(response, typeof(FolderResponse));
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
      /// getFile() - Download the file contents and/or its properties. By default, the file is streamed to the browser. Use the 'download' parameter to prompt for download. Use the 'include_properties' parameter (optionally add 'content' to include base64 content) to list properties of the file.
      /// </summary>
      /// <param name="container">Name of the container where the file exists.</param>
      /// <param name="file_path">Path and name of the file to retrieve.</param>
      /// <param name="include_properties">Return properties of the file.</param>
      /// <param name="content">Return the content as base64 of the file, only applies when 'include_properties' is true.</param>
      /// <param name="download">Prompt the user to download the file from the browser.</param>
      /// <returns></returns>
      public FileResponse getFile (string container, string file_path, bool include_properties, bool content, bool download) {
        // create path and map variables
        var path = "/gtatest/{container}/{file_path}".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "file_path" + "}", apiInvoker.escapeString(file_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || file_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (include_properties != null){
          paramStr = (include_properties != null && include_properties is DateTime) ? ((DateTime)(object)include_properties).ToString("u") : Convert.ToString(include_properties);
          queryParams.Add("include_properties", paramStr);
		}
        if (content != null){
          paramStr = (content != null && content is DateTime) ? ((DateTime)(object)content).ToString("u") : Convert.ToString(content);
          queryParams.Add("content", paramStr);
		}
        if (download != null){
          paramStr = (download != null && download is DateTime) ? ((DateTime)(object)download).ToString("u") : Convert.ToString(download);
          queryParams.Add("download", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams);
          if(response != null){
             return (FileResponse) ApiInvoker.deserialize(response, typeof(FileResponse));
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
      /// createFile() - Create a new file. Post body should be the contents of the file or an object with file properties.
      /// </summary>
      /// <param name="container">Name of the container where the file exists.</param>
      /// <param name="file_path">Path and name of the file to create.</param>
      /// <param name="check_exist">If true, the request fails when the file to create already exists.</param>
      /// <param name="body">Content and/or properties of the file.</param>
      /// <returns></returns>
      public FileResponse createFile (string container, string file_path, bool check_exist, FileRequest body) {
        // create path and map variables
        var path = "/gtatest/{container}/{file_path}".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "file_path" + "}", apiInvoker.escapeString(file_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || file_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        if (check_exist != null){
          paramStr = (check_exist != null && check_exist is DateTime) ? ((DateTime)(object)check_exist).ToString("u") : Convert.ToString(check_exist);
          queryParams.Add("check_exist", paramStr);
		}
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams);
          if(response != null){
             return (FileResponse) ApiInvoker.deserialize(response, typeof(FileResponse));
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
      /// replaceFile() - Update content of the file. Post body should be the contents of the file.
      /// </summary>
      /// <param name="container">Name of the container where the file exists.</param>
      /// <param name="file_path">Path and name of the file to update.</param>
      /// <param name="body">The content of the file.</param>
      /// <returns></returns>
      public FileResponse replaceFile (string container, string file_path, FileRequest body) {
        // create path and map variables
        var path = "/gtatest/{container}/{file_path}".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "file_path" + "}", apiInvoker.escapeString(file_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || file_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, body, headerParams);
          if(response != null){
             return (FileResponse) ApiInvoker.deserialize(response, typeof(FileResponse));
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
      /// updateFileProperties() - Update properties of the file. Post body should be an array of file properties.
      /// </summary>
      /// <param name="container">Name of the container where the file exists.</param>
      /// <param name="file_path">Path and name of the file to update.</param>
      /// <param name="body">Properties of the file.</param>
      /// <returns></returns>
      public File updateFileProperties (string container, string file_path, File body) {
        // create path and map variables
        var path = "/gtatest/{container}/{file_path}".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "file_path" + "}", apiInvoker.escapeString(file_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || file_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "PATCH", queryParams, body, headerParams);
          if(response != null){
             return (File) ApiInvoker.deserialize(response, typeof(File));
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
      /// deleteFile() - Delete one file. Careful, this removes the given file from the storage.
      /// </summary>
      /// <param name="container">Name of the container where the file exists.</param>
      /// <param name="file_path">Path and name of the file to delete.</param>
      /// <returns></returns>
      public FileResponse deleteFile (string container, string file_path) {
        // create path and map variables
        var path = "/gtatest/{container}/{file_path}".Replace("{format}","json").Replace("{" + "container" + "}", apiInvoker.escapeString(container.ToString())).Replace("{" + "file_path" + "}", apiInvoker.escapeString(file_path.ToString()));

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();

        // verify required params are set
        if (container == null || file_path == null ) {
           throw new ApiException(400, "missing required params");
        }
        string paramStr = null;
        try {
          var response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, null, headerParams);
          if(response != null){
             return (FileResponse) ApiInvoker.deserialize(response, typeof(FileResponse));
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
