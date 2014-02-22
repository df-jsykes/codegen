using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Register {
    /* Email address of the new user. */
    public string email { get; set; }

    /* First name of the new user. */
    public string first_name { get; set; }

    /* Last name of the new user. */
    public string last_name { get; set; }

    /* Full display name of the new user. */
    public string display_name { get; set; }

    /* Password for the new user. */
    public string new_password { get; set; }

    /* Code required with new_password when using email confirmation. */
    public string code { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Register {\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  first_name: ").Append(first_name).Append("\n");
      sb.Append("  last_name: ").Append(last_name).Append("\n");
      sb.Append("  display_name: ").Append(display_name).Append("\n");
      sb.Append("  new_password: ").Append(new_password).Append("\n");
      sb.Append("  code: ").Append(code).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
