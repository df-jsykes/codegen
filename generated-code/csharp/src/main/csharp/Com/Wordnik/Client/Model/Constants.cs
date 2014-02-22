using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Constants {
    public List<Constant> type_name { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Constants {\n");
      sb.Append("  type_name: ").Append(type_name).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
