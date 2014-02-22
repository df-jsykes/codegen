using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Session {
    /* Identifier for the current user. */
    public string id { get; set; }

    /* Email address of the current user. */
    public string email { get; set; }

    /* First name of the current user. */
    public string first_name { get; set; }

    /* Last name of the current user. */
    public string last_name { get; set; }

    /* Full display name of the current user. */
    public string display_name { get; set; }

    /* Is the current user a system administrator. */
    public bool is_sys_admin { get; set; }

    /* Name of the role to which the current user is assigned. */
    public string role { get; set; }

    /* Date timestamp of the last login for the current user. */
    public string last_login_date { get; set; }

    /* Extra user data, potentially from remote login provider. */
    public string user_data { get; set; }

    /* Where the user login originated, 0 = local, otherwise remote login provider_id. */
    public integer user_source { get; set; }

    /* App groups and the containing apps. */
    public List<App> app_groups { get; set; }

    /* Apps that are not in any app groups. */
    public List<App> no_group_apps { get; set; }

    /* Id for the current session, used in X-DreamFactory-Session-Token header for API requests. */
    public string session_id { get; set; }

    /* Timed ticket that can be used to start a separate session. */
    public string ticket { get; set; }

    /* Expiration time for the given ticket. */
    public string ticket_expiry { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Session {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  first_name: ").Append(first_name).Append("\n");
      sb.Append("  last_name: ").Append(last_name).Append("\n");
      sb.Append("  display_name: ").Append(display_name).Append("\n");
      sb.Append("  is_sys_admin: ").Append(is_sys_admin).Append("\n");
      sb.Append("  role: ").Append(role).Append("\n");
      sb.Append("  last_login_date: ").Append(last_login_date).Append("\n");
      sb.Append("  user_data: ").Append(user_data).Append("\n");
      sb.Append("  user_source: ").Append(user_source).Append("\n");
      sb.Append("  app_groups: ").Append(app_groups).Append("\n");
      sb.Append("  no_group_apps: ").Append(no_group_apps).Append("\n");
      sb.Append("  session_id: ").Append(session_id).Append("\n");
      sb.Append("  ticket: ").Append(ticket).Append("\n");
      sb.Append("  ticket_expiry: ").Append(ticket_expiry).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
