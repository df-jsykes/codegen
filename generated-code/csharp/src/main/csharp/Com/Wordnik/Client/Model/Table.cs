using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Table {
    /* Name of the table. */
    public string name { get; set; }

    /* DB type specific property name-value pairs. */
    public string _property_ { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Table {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  _property_: ").Append(_property_).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
