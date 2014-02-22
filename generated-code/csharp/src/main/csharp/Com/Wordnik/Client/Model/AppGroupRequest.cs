using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class AppGroupRequest {
    /* Identifier of this application group. */
    public integer id { get; set; }

    /* Displayable name of this application group. */
    public string name { get; set; }

    /* Description of this application group. */
    public string description { get; set; }

    /* Related apps by app to group assignment. */
    public List<App> apps { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppGroupRequest {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  apps: ").Append(apps).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
