using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class RolesResponse {
    /* Array of system role records. */
    public List<Role> record { get; set; }

    /* Array of metadata returned for GET requests. */
    public Metadata meta { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RolesResponse {\n");
      sb.Append("  record: ").Append(record).Append("\n");
      sb.Append("  meta: ").Append(meta).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
