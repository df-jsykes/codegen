using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Login {
    public string email { get; set; }

    public string password { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Login {\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  password: ").Append(password).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
