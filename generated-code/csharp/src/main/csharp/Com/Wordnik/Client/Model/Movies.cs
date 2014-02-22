using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Movies {
    public List<Movie> resource { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Movies {\n");
      sb.Append("  resource: ").Append(resource).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
