using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class AppsRequest {
    /* Array of system application records. */
    public List<AppRequest> record { get; set; }

    /* Array of system application record identifiers, used for batch GET, PUT, PATCH, and DELETE. */
    public List<integer> ids { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppsRequest {\n");
      sb.Append("  record: ").Append(record).Append("\n");
      sb.Append("  ids: ").Append(ids).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
