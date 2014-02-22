using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class AppGroupResponse {
    /* Identifier of this application group. */
    public integer id { get; set; }

    /* Displayable name of this application group. */
    public string name { get; set; }

    /* Description of this application group. */
    public string description { get; set; }

    /* Related apps by app to group assignment. */
    public List<App> apps { get; set; }

    /* Date this application group was created. */
    public string created_date { get; set; }

    /* User Id of who created this application group. */
    public integer created_by_id { get; set; }

    /* Date this application group was last modified. */
    public string last_modified_date { get; set; }

    /* User Id of who last modified this application group. */
    public integer last_modified_by_id { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppGroupResponse {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  apps: ").Append(apps).Append("\n");
      sb.Append("  created_date: ").Append(created_date).Append("\n");
      sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
      sb.Append("  last_modified_date: ").Append(last_modified_date).Append("\n");
      sb.Append("  last_modified_by_id: ").Append(last_modified_by_id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
