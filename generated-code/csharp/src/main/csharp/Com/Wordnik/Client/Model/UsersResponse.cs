using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class UsersResponse {
    /* Array of system user records. */
    public List<UserResponse> record { get; set; }

    /* Array of metadata returned for GET requests. */
    public Metadata meta { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersResponse {\n");
      sb.Append("  record: ").Append(record).Append("\n");
      sb.Append("  meta: ").Append(meta).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
