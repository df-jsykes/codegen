using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Record {
    /* Array of DB table specific field name-value pairs. */
    public string _field_ { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Record {\n");
      sb.Append("  _field_: ").Append(_field_).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
