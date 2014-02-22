using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class AppsResponse {
    /* Array of system application records. */
    public List<AppResponse> record { get; set; }

    /* Array of metadata returned for GET requests. */
    public Metadata meta { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppsResponse {\n");
      sb.Append("  record: ").Append(record).Append("\n");
      sb.Append("  meta: ").Append(meta).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
