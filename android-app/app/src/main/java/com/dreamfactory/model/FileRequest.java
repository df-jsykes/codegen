package com.dreamfactory.model;

import com.fasterxml.jackson.annotation.JsonProperty;

public class FileRequest {
  /* Identifier/Name for the file, localized to requested resource. */
  @JsonProperty("name")
  private String name = null;
  /* Full path of the file, from the service including container. */
  @JsonProperty("path")
  private String path = null;
  /* The media type of the content of the file. */
  @JsonProperty("content_type")
  private String content_type = null;
  /* Storage type specific properties. */
  @JsonProperty("_property_")
  private String _property_ = null;
  /* An array of name-value pairs. */
  @JsonProperty("metadata")
  private List<String> metadata = new ArrayList<String>();
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

  public String getContent_type() {
    return content_type;
  }
  public void setContent_type(String content_type) {
    this.content_type = content_type;
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

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class FileRequest {\n");
    sb.append("  name: ").append(name).append("\n");
    sb.append("  path: ").append(path).append("\n");
    sb.append("  content_type: ").append(content_type).append("\n");
    sb.append("  _property_: ").append(_property_).append("\n");
    sb.append("  metadata: ").append(metadata).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

