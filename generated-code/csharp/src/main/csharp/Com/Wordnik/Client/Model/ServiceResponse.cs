using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class ServiceResponse {
    /* Identifier of this service. */
    public integer id { get; set; }

    /* Displayable name of this service. */
    public string name { get; set; }

    /* Name of the service to use in API transactions. */
    public string api_name { get; set; }

    /* Description of this service. */
    public string description { get; set; }

    /* True if this service is active for use. */
    public bool is_active { get; set; }

    /* One of the supported service types. */
    public string type { get; set; }

    /* One of the supported enumerated service types. */
    public integer type_id { get; set; }

    /* The local or remote storage name (i.e. root folder). */
    public string storage_name { get; set; }

    /* They supported storage service type. */
    public string storage_type { get; set; }

    /* One of the supported enumerated storage service types. */
    public integer storage_type_id { get; set; }

    /* Any credentials data required by the service. */
    public string credentials { get; set; }

    /* The format of the returned data of the service. */
    public string native_format { get; set; }

    /* The base URL for remote web services. */
    public string base_url { get; set; }

    /* Additional URL parameters required by the service. */
    public string parameters { get; set; }

    /* Additional headers required by the service. */
    public string headers { get; set; }

    /* Related apps by app to service assignment. */
    public List<App> apps { get; set; }

    /* Related roles by service to role assignment. */
    public List<Role> roles { get; set; }

    /* True if this service is a default system service. */
    public bool is_system { get; set; }

    /* Date this service was created. */
    public string created_date { get; set; }

    /* User Id of who created this service. */
    public integer created_by_id { get; set; }

    /* Date this service was last modified. */
    public string last_modified_date { get; set; }

    /* User Id of who last modified this service. */
    public integer last_modified_by_id { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceResponse {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  api_name: ").Append(api_name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  is_active: ").Append(is_active).Append("\n");
      sb.Append("  type: ").Append(type).Append("\n");
      sb.Append("  type_id: ").Append(type_id).Append("\n");
      sb.Append("  storage_name: ").Append(storage_name).Append("\n");
      sb.Append("  storage_type: ").Append(storage_type).Append("\n");
      sb.Append("  storage_type_id: ").Append(storage_type_id).Append("\n");
      sb.Append("  credentials: ").Append(credentials).Append("\n");
      sb.Append("  native_format: ").Append(native_format).Append("\n");
      sb.Append("  base_url: ").Append(base_url).Append("\n");
      sb.Append("  parameters: ").Append(parameters).Append("\n");
      sb.Append("  headers: ").Append(headers).Append("\n");
      sb.Append("  apps: ").Append(apps).Append("\n");
      sb.Append("  roles: ").Append(roles).Append("\n");
      sb.Append("  is_system: ").Append(is_system).Append("\n");
      sb.Append("  created_date: ").Append(created_date).Append("\n");
      sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
      sb.Append("  last_modified_date: ").Append(last_modified_date).Append("\n");
      sb.Append("  last_modified_by_id: ").Append(last_modified_by_id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
