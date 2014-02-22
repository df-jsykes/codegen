using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class UsersRequest {
    /* Array of system user records. */
    public List<UserRequest> record { get; set; }

    /* Array of system record identifiers, used for batch GET, PUT, PATCH, and DELETE. */
    public List<integer> ids { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersRequest {\n");
      sb.Append("  record: ").Append(record).Append("\n");
      sb.Append("  ids: ").Append(ids).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
