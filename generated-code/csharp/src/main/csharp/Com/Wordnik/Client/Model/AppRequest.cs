using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class AppRequest {
    /* Identifier of this application. */
    public integer id { get; set; }

    /* Displayable name of this application. */
    public string name { get; set; }

    /* Name of the application to use in API transactions. */
    public string api_name { get; set; }

    /* Description of this application. */
    public string description { get; set; }

    /* Is this system application active for use. */
    public bool is_active { get; set; }

    /* URL for accessing this application. */
    public string url { get; set; }

    /* True when this application is hosted elsewhere, but available in Launchpad. */
    public bool is_url_external { get; set; }

    /* If hosted and imported, the url of zip or package file where the code originated. */
    public string import_url { get; set; }

    /* If hosted, the storage service identifier. */
    public string storage_service_id { get; set; }

    /* If hosted, the container of the storage service. */
    public string storage_container { get; set; }

    /* True when this app needs to hide launchpad. */
    public bool requires_fullscreen { get; set; }

    /* True to allow launchpad access via toggle. */
    public bool allow_fullscreen_toggle { get; set; }

    /* Screen location for toggle placement. */
    public string toggle_location { get; set; }

    /* True when the app relies on a browser plugin. */
    public bool requires_plugin { get; set; }

    /* Related roles by Role.default_app_id. */
    public List<string> roles_default_app { get; set; }

    /* Related users by User.default_app_id. */
    public List<string> users_default_app { get; set; }

    /* Related groups by app to group assignment. */
    public List<string> app_groups { get; set; }

    /* Related roles by app to role assignment. */
    public List<string> roles { get; set; }

    /* Related services by app to service assignment. */
    public List<string> services { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppRequest {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  api_name: ").Append(api_name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  is_active: ").Append(is_active).Append("\n");
      sb.Append("  url: ").Append(url).Append("\n");
      sb.Append("  is_url_external: ").Append(is_url_external).Append("\n");
      sb.Append("  import_url: ").Append(import_url).Append("\n");
      sb.Append("  storage_service_id: ").Append(storage_service_id).Append("\n");
      sb.Append("  storage_container: ").Append(storage_container).Append("\n");
      sb.Append("  requires_fullscreen: ").Append(requires_fullscreen).Append("\n");
      sb.Append("  allow_fullscreen_toggle: ").Append(allow_fullscreen_toggle).Append("\n");
      sb.Append("  toggle_location: ").Append(toggle_location).Append("\n");
      sb.Append("  requires_plugin: ").Append(requires_plugin).Append("\n");
      sb.Append("  roles_default_app: ").Append(roles_default_app).Append("\n");
      sb.Append("  users_default_app: ").Append(users_default_app).Append("\n");
      sb.Append("  app_groups: ").Append(app_groups).Append("\n");
      sb.Append("  roles: ").Append(roles).Append("\n");
      sb.Append("  services: ").Append(services).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
