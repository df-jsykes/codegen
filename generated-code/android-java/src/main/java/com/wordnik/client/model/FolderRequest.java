package com.wordnik.client.model;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.*;
import com.wordnik.client.model.FileRequest;
public class FolderRequest {
  /* Identifier/Name for the folder, localized to requested resource. */
  @JsonProperty("name")
  private String name = null;
  /* Full path of the folder, from the service including container. */
  @JsonProperty("path")
  private String path = null;
  /* Storage type specific properties. */
  @JsonProperty("_property_")
  private String _property_ = null;
  /* An array of name-value pairs. */
  @JsonProperty("metadata")
  private List<String> metadata = new ArrayList<String>();
  /* An array of sub-folders to create. */
  @JsonProperty("folder")
  private List<FolderRequest> folder = new ArrayList<FolderRequest>();
  /* An array of files to create. */
  @JsonProperty("file")
  private List<FileRequest> file = new ArrayList<FileRequest>();
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  public String getPath() {
    return path;
  }
  public void setPath(String path) {
    this.path = path;
  }

  public String get_property_() {
    return _property_;
  }
  public void set_property_(String _property_) {
    this._property_ = _property_;
  }

  public List<String> getMetadata() {
    return metadata;
  }
  public void setMetadata(List<String> metadata) {
    this.metadata = metadata;
  }

  public List<FolderRequest> getFolder() {
    return folder;
  }
  public void setFolder(List<FolderRequest> folder) {
    this.folder = folder;
  }

  public List<FileRequest> getFile() {
    return file;
  }
  public void setFile(List<FileRequest> file) {
    this.file = file;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class FolderRequest {\n");
    sb.append("  name: ").append(name).append("\n");
    sb.append("  path: ").append(path).append("\n");
    sb.append("  _property_: ").append(_property_).append("\n");
    sb.append("  metadata: ").append(metadata).append("\n");
    sb.append("  folder: ").append(folder).append("\n");
    sb.append("  file: ").append(file).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

