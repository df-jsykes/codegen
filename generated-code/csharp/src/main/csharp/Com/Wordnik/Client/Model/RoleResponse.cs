using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class RoleResponse {
    /* Identifier of this role. */
    public integer id { get; set; }

    /* Displayable name of this role. */
    public string name { get; set; }

    /* Description of this role. */
    public string description { get; set; }

    /* Is this role active for use. */
    public bool is_active { get; set; }

    /* Default launched app for this role. */
    public integer default_app_id { get; set; }

    /* Related app by default_app_id. */
    public App default_app { get; set; }

    /* Related users by User.role_id. */
    public List<string> users { get; set; }

    /* Related apps by role assignment. */
    public List<string> apps { get; set; }

    /* Related services by role assignment. */
    public List<string> services { get; set; }

    /* Date this role was created. */
    public string created_date { get; set; }

    /* User Id of who created this role. */
    public integer created_by_id { get; set; }

    /* Date this role was last modified. */
    public string last_modified_date { get; set; }

    /* User Id of who last modified this role. */
    public integer last_modified_by_id { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RoleResponse {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  is_active: ").Append(is_active).Append("\n");
      sb.Append("  default_app_id: ").Append(default_app_id).Append("\n");
      sb.Append("  default_app: ").Append(default_app).Append("\n");
      sb.Append("  users: ").Append(users).Append("\n");
      sb.Append("  apps: ").Append(apps).Append("\n");
      sb.Append("  services: ").Append(services).Append("\n");
      sb.Append("  created_date: ").Append(created_date).Append("\n");
      sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
      sb.Append("  last_modified_date: ").Append(last_modified_date).Append("\n");
      sb.Append("  last_modified_by_id: ").Append(last_modified_by_id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
